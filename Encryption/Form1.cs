using System.IO;
using System.Text;
using System.Windows.Forms;
using Encryption;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ColorDialog colorDialog1 = new ColorDialog();
            FontDialog fontDialog2 = new FontDialog();
            InitializeComponent();
            colorDialog1.FullOpen = true;
            colorDialog1.Color = this.BackColor;
            fontDialog2.Font = fontDialog2.Font;



        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Caesar caesar = new Caesar();
            int r = Convert.ToInt32(textBox2.Text); ;
            string buf = textBox1.Text;
            textBox1.Text = caesar.Decrypt(buf.ToString(), r);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Caesar caesar = new Caesar();
            int r = Convert.ToInt32(textBox2.Text); ;
            string buf = textBox1.Text;
            textBox1.Text = caesar.Encrypt(buf.ToString(), r);



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "��������� �������� (*.txt)|*.txt|��� ����� (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(textBox1.Text);
                streamWriter.Close();
            }
        }

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true; //������������
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true; //������������
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dir = @"C:\Users\aleks\source\repos\Interface\Encryption\text"; //���������� ���� ��������� �����
                                                                                       //������
                string[] filenames = openFileDialog.FileNames;
                //�������� ���� � ���������� ������
                FileInfo fi = new FileInfo(openFileDialog.FileName);
                string dirSource = fi.DirectoryName;
                //���������� ����� � ��������� ����������
                foreach (String file in filenames)
                {
                    string fname = file.Substring(dirSource.Length + 1);
                    System.IO.File.Copy(Path.Combine(dirSource, fname), Path.Combine(dir, fname), true);
                }
            }
        }

        private void �olorToolStripMenuItem_Click(object sender, EventArgs e)
        {


            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            this.BackColor = colorDialog1.Color;

        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog2 = new FontDialog();
            if (fontDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            this.Font = fontDialog2.Font;
            // ��������� ����� ������
            this.ForeColor = fontDialog2.Color;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Convert.ToInt32(textBox2.Text);


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
