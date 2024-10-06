
class InheritHelloWorld : HelloWorld
{
    [STAThread]
    static void Main()
    {
        Application.Run(new InheritHelloWorld());
    }

    public InheritHelloWorld()
    {
        Text = "Inherit " + Text;
    }

    protected override void OnPaint(PaintEventArgs pea)
    {
        Graphics grfx = pea.Graphics;

        grfx.DrawString("Hello from InheritHelloWorld!", Font, Brushes.Black, 0, 100);
    }
}