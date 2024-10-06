namespace FormProperties
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

            form.Text = "Form Properties";
            form.BackColor = Color.BlanchedAlmond;
            form.Width *= 2;
            form.Height /= 2;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.Cursor = Cursors.Hand;
            form.StartPosition = FormStartPosition.CenterScreen;

            Application.Run(form);
        }
    }
}