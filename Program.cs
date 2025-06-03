namespace iiMenu.Injector
{
    internal static class Program
    {
        private static iisStupidMenu mainForm;
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            mainForm = new iisStupidMenu();
            Application.Run(mainForm);
        }
    }
}