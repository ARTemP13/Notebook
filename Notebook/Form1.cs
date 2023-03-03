using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Notebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string file = "Безымяный";
        private float SizeText = 10.0f;

        private void времяИДатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "all (*.*) |*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(dialog.FileName, UTF8Encoding.UTF8);
                file = dialog.FileName;
            } 

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа Блокнот является текстовым редактором. Это значит, что Данная программа предназначена для работы с текстом. Блокнот – одна из самых простых программ по работе с текстом. В ней мы можем только вводить текст и редактировать его. Изменять шрифт или размер отдельных символов, т.е. производить форматирование текста, в этой программе мы не можем.");

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(file, richTextBox1.Text, UTF8Encoding.UTF8);
            } 
            catch
            {
                MessageBox.Show("Ошибка сохранения");
            }
        }
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Font font = new Font("Times New Roman", 2.0f);
            richTextBox1.SelectionFont = font;
            SizeText = 2.0f;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Font font = new Font("Times New Roman", 4.0f);
            richTextBox1.SelectionFont = font;
            SizeText = 4.0f;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Font font = new Font("Times New Roman", 8.0f);
            richTextBox1.SelectionFont = font;
            SizeText = 8.0f;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Font font = new Font("Times New Roman", 12.0f);
            richTextBox1.SelectionFont = font;
            SizeText = 12.0f;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Font font = new Font("Times New Roman", 16.0f);
            richTextBox1.SelectionFont = font;
            SizeText = 16.0f;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Font font = new Font("Times New Roman", 24.0f);
            richTextBox1.SelectionFont = font;
            SizeText = 24.0f;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Font font = new Font("Times New Roman", 32.0f);
            richTextBox1.SelectionFont = font;
            SizeText = 32.0f;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Font font = new Font("Times New Roman", 48.0f);
            richTextBox1.SelectionFont = font;
            SizeText = 48.0f;
        }

        private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            richTextBox1.SelectionColor = Color.White;
        }

        private void черныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Black;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void желтыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Yellow;
        }

        private void розовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Pink;
        }

        private void жирнымToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Times New Roman",SizeText, FontStyle.Bold);
        }

        private void курсивомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Times New Roman", SizeText, FontStyle.Italic);
        }
    }
}
