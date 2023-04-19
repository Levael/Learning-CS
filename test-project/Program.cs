namespace test_project { 
    public class Test {
        public static void Main () {
            //Converter();
            //PrintParamsInfo("str", -8, 3.14, true, 'c');
            
            // int[] test_array = {1,2,3,88,-9};
            //
            // PrintArrayLoop(test_array);
            // PrintArrayRecursion(test_array, 1);
            
            new Top().foo();    // should write "bottom, middle, top"
                
            Console.ReadKey();
        }
        
        static void Converter () {
            Console.WriteLine("Input one:");
            byte number_1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Input two:");
            byte number_2 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("The sum is: " + (number_1 + number_2));
        }
        
        static void PrintParamsInfo (params object[] parameters) {
            string output_msg = "Type: {0}, value: {1}";
            
            foreach (var parameter in parameters) {
                Console.WriteLine(output_msg, parameter.GetType(), parameter);
            }
        }

        static void PrintArrayLoop<T>(T[] array) {
            foreach (var item in array) {
                Console.WriteLine(item);
            }
        }
        
        static void PrintArrayRecursion<T>(T[] array, int index = 0) {
            if (index < array.Length) {
                Console.WriteLine(array[index]);
                PrintArrayRecursion(array, index + 1);
            }
        }
    }
}
