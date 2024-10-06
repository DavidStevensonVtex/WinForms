namespace InheritWithConstructor
{
    public partial class InheritWithConstructor : Form
    {
        public static void Main()
        {
            Application.Run(new InheritWithConstructor());
        }
        public InheritWithConstructor()
        {
            Text = "Inherit with Constructor";
            BackColor = Color.White;
        }
    }
}
