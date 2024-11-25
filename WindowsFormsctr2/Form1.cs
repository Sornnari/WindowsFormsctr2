namespace WindowsFormsctr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("สวัสดี ชาวโลก", "First Message");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ต้องการปิดจริงหรือไม่", "แน่ใจนะ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);
            this.BackColor = Color.FromArgb(r, g, b);
            this.Text = r.ToString() + "," + g.ToString() + "," + b.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightBlue;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightGreen;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightPink;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "มหาวิทยาลัยราชภัฎอุดรธานี")
            {
                label1.Text = "Udonthani Rajabhat Universsity";
            }
            else
            {
                label1.Text = "มหาวิทยาลัยราขภัฎอุดรธานี";
            }

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightGreen;
            label1.ForeColor = Color.LightPink;

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightGray;
            label1.ForeColor = Color.LightBlue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            Random rn = new Random();
            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);
            label1.ForeColor = Color.FromArgb(r, g, b);

        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            textBox1.Text = string.Empty;
            //textBox1.Text = null;

        }
    }
}
