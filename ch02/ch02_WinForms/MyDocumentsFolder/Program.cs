namespace MyDocumentsFolder
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MessageBox.Show(
                Environment.GetFolderPath(Environment.SpecialFolder.Personal), 
                "My Documents Folder");
        }
    }
}