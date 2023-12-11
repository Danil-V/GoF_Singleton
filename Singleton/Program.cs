using Singleton.Example_1;
using Singleton.Example_2;

namespace Singleton
{
    class Program {
        static void Main(string[] args) {
            // Example 1:
            (new Thread(() => {
                Computer comp2 = new Computer();
                comp2.OS = OS.getInstance("Windows 10");
                Console.WriteLine(comp2.OS.Name);

            })).Start();

            (new Thread(() => {
                Computer comp = new Computer();
                comp.Launch("Windows 8.1");
                Console.WriteLine(comp.OS.Name);
            })).Start();
            /*------------------------------------------------------*/

            // Example 2:
            (new Thread(() => {
                MySingleton singleton1 = MySingleton.GetInstance();
                Console.WriteLine(singleton1.Date);
            })).Start();

            MySingleton singleton2 = MySingleton.GetInstance();
            Console.WriteLine(singleton2.Date);
            /*------------------------------------------------------*/

            Console.ReadLine();
        }
    }
}