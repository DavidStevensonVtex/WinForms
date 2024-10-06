namespace PaintTwoForms
{
    internal static class Program
    {
        static Form form1, form2;

        [STAThread]
        static void Main()
        {
            form1 = new Form();
            form2 = new Form();

            form1.Text = "First Form";
            form1.BackColor = Color.White;
            form1.Paint += MyPaintHandler;
            form2.Text = "Second Form";
            form2.BackColor = Color.White;
            form2.Paint += MyPaintHandler;
            form2.Show();

            Application.Run(form1);
        }

        private static void MyPaintHandler(object? sender, PaintEventArgs pea)
        {
            Form form = (Form)sender;
            Graphics grfx = pea.Graphics;
            string str;

            if (form == form1)
            {
                str = "Hello from the first form";
            } else
            {
                str = "Hello from the second form";
            }

            grfx.DrawString(str, form.Font, Brushes.Black, 0, 0);
        }
    }
}