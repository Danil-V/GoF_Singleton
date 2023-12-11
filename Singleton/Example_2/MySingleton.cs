namespace Singleton.Example_2
{
    // Потокобезопасная реализация без lock:
    public class MySingleton {
        private static readonly MySingleton instance = new();
        public string Date { get; private set; }

        private MySingleton() {
            Date = System.DateTime.Now.TimeOfDay.ToString();
        }

        public static MySingleton GetInstance() {
            return instance;
        }
    }
}
