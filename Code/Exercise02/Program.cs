using System;
using System.Reflection;
using System.Diagnostics;

namespace Exercise02
{
    class Program
    {
     #region Properties

        private static string dashes = new string('-', Console.WindowWidth - 1);
        private static int[] columnWidth = {0, -10, -5, 35, 35};
        private static string template = 
                string.Format(
                    "{0}0,{1}{2}{3}1,{4}{5}{6}2,{7}{8}{9}3,{10}{11}",
                    "{",GetColumnWidth(1),"}",
                    "{",GetColumnWidth(2),"}",
                    "{",GetColumnWidth(3),"}",
                    "{",GetColumnWidth(4),"}");

        public static string Dashes { get => dashes; }
        public static string Template { get => template;  }
#endregion
        /// <summary>
        /// Get the width of a column.
        /// </summary>
        /// <param name="columnNumber">The one based column number to get.</param>
        /// <returns>An int value indicating the width of the column.</returns>
        public static int GetColumnWidth(int columnNumber) {
            return columnWidth[columnNumber];
        }
        /// <summary>
        /// Outputs a formatted line of information about the type of the passed value.
        /// </summary>
        /// <param name="o">The value for which to display information.</param>
        static void OutputDetailLine(dynamic o)
        {
            FieldInfo min;
            FieldInfo max;
            Type objectType;

            objectType = o.GetType();
            if (objectType==null)
            {
                Debug.Write("objectType is null");
            }
            Debug.Write(objectType.FullName);
            min = o.GetType().GetField("MinValue", BindingFlags.Public | BindingFlags.Static);
            if (min==null)
            {
                Debug.Write("min is null");
            }          
            max = o.GetType().GetField("MaxValue", BindingFlags.Public | BindingFlags.Static);
            Console.WriteLine(Template,objectType.Name, System.Runtime.InteropServices.Marshal.SizeOf(o), (min?.GetValue(null)?? null)?.ToString()??string.Empty, (max?.GetValue(null)?? null)?.ToString()?? string.Empty);
        }
        /// <summary>
        /// Standard Main function
        /// </summary>
        /// <param name="args">The arguments passed to the program upon startup.</param>
        static void Main(string[] args)
        {
            // Display heading
            Console.WriteLine(Dashes);
            Console.WriteLine(Template, "Type","Bytes","Min","Max");
            Console.WriteLine(Dashes);
            
            // Display one row for each of these values of various data types.
            sbyte a = 0;
            OutputDetailLine(a);
            byte b = 0;
            OutputDetailLine(b);
            short c = 0;
            OutputDetailLine(c);
            ushort d = 0;
            OutputDetailLine(d);
            int e = 0;
            OutputDetailLine(e);
            uint f = 0;
            OutputDetailLine(f);
            long g = 0L;
            OutputDetailLine(g);
            ulong h = 0UL;
            OutputDetailLine(h);
            float i = 0.0F;
            OutputDetailLine(i);
            double j = 0.0;
            OutputDetailLine(j);
            decimal k = 0.0M;
            OutputDetailLine(k);
        }
    }
}
