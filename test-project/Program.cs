//using system

namespace Learning {
    class Test {
        static void Main (string[] args) {

            Console.WriteLine("Input one:");
            byte number_1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Input two:");
            byte number_2 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine(number_1 + number_2);
            
        }
    }
}