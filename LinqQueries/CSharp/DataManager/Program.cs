namespace CSharp.DataManager
{
    internal static class Program
    {
        public static MainForm MainFormInstance { get; private set; }

       
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            MainFormInstance = new MainForm();
            Application.Run(MainFormInstance);
        }
    }
}