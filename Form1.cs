namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buf = textBox1.Text;
            buf = buf.Replace("-", "");
            while (buf.StartsWith(" "))
            {
                buf = buf.Remove(0, 1);
            }
            while (buf.EndsWith(" "))
            {
                buf = buf.Remove(buf.Length - 1);
            }
            buf = buf.Replace("   ", " ");
            buf = buf.Replace("  ", " ");
            label1.Text = System.Convert.ToString(buf.Count(s => s == ' ') + 1);
        }
    }
}