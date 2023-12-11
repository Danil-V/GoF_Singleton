namespace Singleton.Example_1
{
    public class Computer {
        public OS OS { get; set; }
        public void Launch(string osName) {
            OS = OS.getInstance(osName);
        }
    }
}
