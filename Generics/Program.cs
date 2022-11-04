namespace Generics
{
    internal class Program
    {
        public static void toPrint<T>(T[] inputArray)
        {
            Console.WriteLine(typeof(T) + " Array ");
            foreach (T element in inputArray)
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