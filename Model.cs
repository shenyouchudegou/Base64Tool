using System;
using System.Text;

namespace Base64Tool
{
    public partial class Model : Form
    {

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public Model()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = richTextBox1.Text;
            var encode_type = comboBox1.Text;
            var encode = Base64Encode(a);
            richTextBox2.Text = encode;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = richTextBox1.Text;
            richTextBox2.Text = Base64Decode(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var a = richTextBox2.Text;
            richTextBox2.Text = richTextBox1.Text;
            richTextBox1.Text = a;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
