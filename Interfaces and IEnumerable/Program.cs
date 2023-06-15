namespace Interfaces_and_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Classroster cr = new Classroster ();
           foreach (string arg in cr)
            {
                Console.WriteLine (arg);
            }
        }
    }
}