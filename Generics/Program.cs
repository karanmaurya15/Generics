namespace Generics
{
    internal class Program
    {
        public static void toPrint(int[] inputArray)
        {

            foreach (int element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------------------------------");
        }

        public static void toPrint(double[] inputArray)
        {

            foreach (double element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------------------------------");
        }

        public static void toPrint(string[] inputArray)
        {

            foreach (string element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------------------------------");
        }
    
       static void Main(string[] args)
       {
            Console.WriteLine("Wellcome to Generics program\n");

            int[] intArray = { 9, 8, 7, 6, 5, 3};
            double[] doubleArray = { 9.6, 7.5, 8.4, 5.33 };
            string[] stringArray = { "Generic", "OOPS", "Addressbook" };

            Program.toPrint(intArray);
            Program.toPrint(doubleArray);
            Program.toPrint(stringArray);

       }
    }
}