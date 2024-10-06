namespace SeparateMain
{
    internal static class SeparateMain
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new AnotherHelloWorld());
        }
    }
}