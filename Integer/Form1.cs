namespace Integer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int ukenar, kkenar, cevre, alan;
            ukenar = Convert.ToInt16(textBox1.Text);
            kkenar = Convert.ToInt16(textBox2.Text);

            cevre = (ukenar + kkenar) * 2;
            alan = ukenar * kkenar;

            label2.Text = cevre.ToString();
            label4.Text = alan.ToString();


        }
    }
}