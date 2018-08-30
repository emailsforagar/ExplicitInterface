using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---START---");
            IPrint print  = new DoSomething();
            IDuplicate duplicate = new DoSomething();
            Console.WriteLine($"Calling Copy through Print: {print.Copy()}");
            Console.WriteLine($"Calling Copy through Duplicate: {duplicate.Copy()}");
            Console.WriteLine("---END---");
            Console.ReadLine();
        }
    }
    public interface IPrint
    {
        string Copy();

    }
    public interface IDuplicate
    {
        string Copy();
    }
    class DoSomething : IPrint, IDuplicate
    {
        public DoSomething()
        {
            Console.WriteLine("Constructor is called");
        }
        string IDuplicate.Copy()
        {
            return "Duplicate";
        }

        string IPrint.Copy()
        {
            return "Print";
        }
    }
}
