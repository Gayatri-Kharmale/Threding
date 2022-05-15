using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threding
{
    public class Threading
    {
        public void Run()
        {


            Thread t = Thread.CurrentThread;
            for (int i = 1; i <= 10; i++ )
            {
                Console.WriteLine(t.Name);
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        public void Run2()
        {
            Thread t= Thread.CurrentThread;
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(t.Name);
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            Threading myThread = new Threading();
            Threading myThread2 = new Threading();
            Thread first  = new Thread(new ThreadStart(myThread.Run));
            Thread second = new Thread(new ThreadStart(myThread.Run));
            Thread third = new Thread(new ThreadStart(myThread.Run2));
            first.Name = "First Thread";
            second.Name = "Second Thread";
            first.Start();
            first.Join();
            second.Start();


        }
    }
}
