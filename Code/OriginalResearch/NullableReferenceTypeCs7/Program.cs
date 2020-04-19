using System;

namespace NullableReferenceTypeCs7
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# version 7 forced by the contents of file: Directory.Build.props
            Console.WriteLine("---C# version 7 does not allow nullable reference types.");
            string? annotatedNullableOld = "abc"; // Error that says:  This needs C# 8.0 or greater.
        }
    }
}
