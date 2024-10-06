namespace RunFormBadly
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form form = new Form();
            form.Text = "Not a Good Idea...";
            form.Visible = true;

            Application.Run();
        }
    }
}