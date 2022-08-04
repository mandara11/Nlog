using NlogDemo;

namespace Nlog
{
    class Program
    {
        public static void Main(string[] args)
        {
            Sum sum = new Sum();

            sum.Addition(0, 0);
            Console.WriteLine("This is a Logger Demo");
            Console.ReadKey();
        }
    }
}