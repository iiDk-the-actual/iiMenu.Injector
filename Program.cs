namespace iiMenu.Injector
{
    internal static class Program
    {
        private static Form1 mainForm = null;
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            mainForm = new Form1();
            Application.Run(mainForm);
        }
    }
}