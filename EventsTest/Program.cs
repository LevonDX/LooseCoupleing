namespace EventsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Switcher switcher = new Switcher(new Diod());
            switcher.SwitchOn();
            switcher.SwitchOff();
        }
    }
}