namespace TwoForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form form1 = new Form();
            Form form2 = new Form();

            form1.Text = "Form passed to Run()";
            form2.Text = "Second Form";
            form2.Show();

            Application.Run(form1);

            MessageBox.Show("Application.Run() has returned control back to Main. Bye, bye!", "TwoForms");
        }
    }
}