namespace SeparateMain
{
    public class AnotherHelloWorld : Form
    {
        public AnotherHelloWorld()
        {
            Text = "Another Hello World";
            BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs pea)
        {
            Graphics grfx = pea.Graphics;

            grfx.DrawString("Hello, Windows Forms1", Font, Brushes.Black, 0, 0);
        }
    }
}
