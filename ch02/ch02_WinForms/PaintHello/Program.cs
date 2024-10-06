namespace PaintHello
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
            form.Text = "Paint Hello";
            form.BackColor = Color.White;
            form.Paint += MyPaintHandler;

            Application.Run(form);
        }

        private static void MyPaintHandler(object? sender, PaintEventArgs pea)
        {
            Form form = (Form) sender;
            Graphics grfx = pea.Graphics;

            grfx.DrawString("Hello, world!", form.Font, Brushes.Black, 0, 0);
        }
    }
}