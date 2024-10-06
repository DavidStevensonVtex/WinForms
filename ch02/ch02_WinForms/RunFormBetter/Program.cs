namespace RunFormBetter
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
            form.Text = "My Veriy Own Form";

            Application.Run(form);
        }
    }
}