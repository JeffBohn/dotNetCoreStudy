using System;
using static System.Console;

namespace NullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Similar to traditional functionality:  Nullable reference types disabled.");
            #nullable disable
            string? annotatedNullableOld = "abc"; // GETS A CS8632 WARNING
            Console.WriteLine($"Annotated Nullable string set to abc:  [{annotatedNullableOld}]  WARNING CS8632 null annotation used outside of #nullable annotations context");
            annotatedNullableOld = null;
            Console.WriteLine($"Annotated Nullable string set to null:  [{annotatedNullableOld}]");
            string nonAnnotatedOld = "abc"; 
            Console.WriteLine($"Non-Annotated string set to abc:  [{nonAnnotatedOld}]");
            nonAnnotatedOld = null;
            Console.WriteLine($"Non-Annotated string set to null:  [{nonAnnotatedOld}]");
            
            Console.WriteLine("---New functionality:  Nullable reference types enabled.");
            #nullable enable
            string? annotatedNullable = "abc"; // No warning
            Console.WriteLine($"Annotated Nullable string set to abc:  [{annotatedNullable}]");
            annotatedNullable = null;
            Console.WriteLine($"Annotated Nullable string set to null:  [{annotatedNullable}]");
            string nonAnnotated = "abc"; 
            Console.WriteLine($"Non-Annotated string set to abc:  [{nonAnnotated}]");
            nonAnnotated = null; // WARNING
            Console.WriteLine($"Non-Annotated string set to null:  [{nonAnnotated}] WARNING CS8600 converting null to non-nullable type");
        }
    }
}
