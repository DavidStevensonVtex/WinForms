namespace PaintEvent
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
            form.Text = "Paint Event";
            form.Paint += new PaintEventHandler(MyPaintHandler);

            Application.Run(form);
        }

        private static void MyPaintHandler(object? sender, PaintEventArgs pea)
        {
            Graphics grfx = pea.Graphics;
            grfx.Clear(Color.Chocolate);
        }
    }
}