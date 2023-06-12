namespace DNDPractice_CSharpArrayExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("P1- Store elements in an array and print them");
            //Console.WriteLine("----------------------------------------------------------");
            //Program1 p1 = new Program1();
            //p1.StoreAndPrintArray();

            //Console.WriteLine("P2- Read n values in an array and display them in reverse order");
            //Console.WriteLine("----------------------------------------------------------");
            //Program2 p2 = new Program2();
            //p2.StoreAndPrintArrayInReverse();

            Console.WriteLine("P3- Find the sum of all array elements");
            Console.WriteLine("----------------------------------------------------------");
            Program3 p3 = new Program3();
            p3.SumOfElementsInArray();
        }
    }
}