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
    public partial class MainForm : Form, IGameView
    {
        public string Table 
        {
            set { listBox1.Text = value; }
        }
        public string Answer_A
        {
            set { button_A.Text = value; }
        }
        public string Answer_B
        {
            set { button_B.Text = value; }
        }
        public string Answer_C
        {
            set { button_C.Text = value; }
        }
        public string Answer_D
        {
            set { button_D.Text = value; }
        }
        public string Question
        {
            set { textBox_question.Text = (Number_Question+1) + ". " + value; }
        }
        public int Number_Question { get; set; }
        public string User_Answer { get; set; }
        public string Right_Answer { get; set; }

        public event EventHandler<EventArgs> Next_q;
        public event EventHandler<EventArgs> Select_button;
        public MainForm()
        {
            InitializeComponent();
            Presenter pr = new Presenter(this);
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
            Game game = new Game();
        }

        private void button_B_Click(object sender, EventArgs e)
        {
            User_Answer = button_B.Text.Trim();
            if (Select_button != null)
            {
                Select_button(this, EventArgs.Empty);
            }
        }

        private void button_A_Click(object sender, EventArgs e)
        {
            User_Answer = button_A.Text.Trim();
            if (Select_button != null)
            {
                Select_button(this, EventArgs.Empty);
            }
        }
        public void NextQuestion()
        {
            if (Next_q != null)
                Next_q(this, EventArgs.Empty);
        }
        public void GameOver()
        {
            MessageBox.Show("Game Over!!!");
            Close();
        }
        public void Win()
        {

        }

        private void button_C_Click(object sender, EventArgs e)
        {
            User_Answer = button_C.Text.Trim();
            if (Select_button != null)
            {
                Select_button(this, EventArgs.Empty);
            }
        }

        private void button_D_Click(object sender, EventArgs e)
        {
            User_Answer = button_D.Text.Trim();
            if (Select_button != null)
            {
                Select_button(this, EventArgs.Empty);
            }
        }
    }
}
