namespace TwoPaintHandlers
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
            form.Text = "Two Paint Handlers";
            form.BackColor = Color.White;
            form.Paint += PaintHandler1;
            form.Paint += PaintHandler2;
            Application.Run(form);
        }

        private static void PaintHandler1(object? sender, PaintEventArgs e)
        {
            Form form = (Form)sender;
            Graphics grfx = e.Graphics;

            grfx.DrawString("First Paint Event Handler", form.Font, Brushes.Black, 0, 0);
        }

        private static void PaintHandler2(object? sender, PaintEventArgs e)
        {
            Form form = (Form)sender;
            Graphics grfx = e.Graphics;

            grfx.DrawString("Second Paint Event Handler", form.Font, Brushes.Black, 0, 100);
        }
    }
}