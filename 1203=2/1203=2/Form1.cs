namespace _1203_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        double p;
        string A = "0";

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = 
            textBox3.Text =
            textBox4.Text = 
            textBox5.Text = A.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            p = textBox1.Text.Length;
        }
        

        private void 兌換ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
              if (radioButton1.Checked) 
              {
                    if (p >= 25) 
                    {
                        p = p-25;
                        double A;

                        textBox2.Text = A.ToString();
                    }
                    else if (p >= 20)
                    { 
                        
                    }
              }
              else if(radioButton2.Checked)
              {

              }
            }
            catch
            {
                MessageBox.Show("請輸入正整數！");
            }
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}