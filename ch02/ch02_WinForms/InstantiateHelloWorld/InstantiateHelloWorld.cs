namespace InstantiateHelloWorld
{
    class InstantiateHelloWorld
    {
        [STAThread]
        static void Main() {
            Form form = new HelloWorld();
            form.Text = "Instantiate " + form.Text;
            form.Paint += MyPaintHandler;

            Application.Run(form);
        }

        private static void MyPaintHandler(object? sender, PaintEventArgs e)
        {
            Form form = (Form)sender;
            Graphics grfx = e.Graphics;

            grfx.DrawString("Hello from InstantiateHelloWorld!", form.Font, Brushes.Black, 0, 100);
        }
    }
}