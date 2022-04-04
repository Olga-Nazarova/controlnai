using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Мой", "папа", "никогда", "не", "был", "в", "Египте", "но", "всегда", "мечтал", "там", "побывать" };
            var arrayOne = new string[array.Length];
            var size = 0;

            foreach (var value in array)
            {
                if (value.Length <= 3)
                {
                    arrayOne[size] = value;
                    size++;
                }
            }
            Console.Write(string.Join(Environment.NewLine, arrayOne, 0, size));
        }
    }
}
