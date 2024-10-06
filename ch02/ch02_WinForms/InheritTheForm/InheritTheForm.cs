namespace InheritTheForm
{
    public partial class InheritTheForm : Form
    {
        public static void Main()
        {
            InheritTheForm form = new InheritTheForm();
            form.Text = "Inherit the Form";
            form.BackColor = Color.White;

            Application.Run(form);
        }
    }
}
