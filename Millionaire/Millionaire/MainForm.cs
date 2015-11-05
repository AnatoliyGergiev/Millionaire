using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionaire
{
    public partial class MainForm : Form
    {
        public string ListBox1 
        {
            set { listBox1.Text = value; }
        }
        public string Button_A
        {
            set { button_A.Text = value; }
        }
        public string Button_B
        {
            set { button_B.Text = value; }
        }
        public string Button_C
        {
            set { button_C.Text = value; }
        }
        public string Button_D
        {
            set { button_D.Text = value; }
        }
        public string TextBox_Question
        {
            set { textBox_question.Text = value; }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox_new_Click(object sender, EventArgs e)
        {
            button_stop.Visible = true;
            listBox1.Visible = true;
            button_A.Visible = true;
            button_B.Visible = true;
            button_C.Visible = true;
            button_D.Visible = true;
            textBox_question.Visible = true;
            groupBox1.Visible = true;
            Game game = new Game(this);
        }

        private void button_B_Click(object sender, EventArgs e)
        {
        }

        private void button_A_Click(object sender, EventArgs e)
        {
            
        }
    }
}
