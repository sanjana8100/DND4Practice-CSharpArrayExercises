namespace DNDPractice_CSharpArrayExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //P1- Store elements in an array and print them
            Program1 p1 = new Program1();
            p1.StoreAndPrintArray();

            //P2- Read n values in an array and display them in reverse order
            Program2 p2 = new Program2();
            p2.StoreAndPrintArrayInReverse();
        }
    }
}