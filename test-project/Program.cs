using System;

namespace Learning {
    public class Test {
        public static void Main (string[] args) {
            PrintParamsInfo("str", -8, 3.14, true, 'c');
        }
        
        // static void Converter () {
        //     Console.WriteLine("Input one:");
        //     byte number_1 = Convert.ToByte(Console.ReadLine());

        //     Console.WriteLine("Input two:");
        //     byte number_2 = Convert.ToByte(Console.ReadLine());

        //     Console.WriteLine("The sum is: " + (number_1 + number_2));
        //     Console.ReadKey();
        // }
        
        static void PrintParamsInfo (params object[] parameters) {
            string output_msg = "Type: {0}, value: {1}";
            
            foreach (var parameter in parameters) {
                Console.WriteLine(output_msg, parameter.GetType(), parameter);
            }
        }
    }
}
