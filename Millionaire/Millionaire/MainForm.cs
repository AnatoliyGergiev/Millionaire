using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
        SoundPlayer player;
        public MainForm()
        {
            InitializeComponent();
            Game game = new Game();
            player = new SoundPlayer("../../resources/sound/begin.wav");
            player.Play();
            BackgroundImage = new Bitmap("../../resources/image/423.jpg");
            button_stop.Visible = true;
            pictureBox_exit.Visible = true;
            pictureBox_new.Visible = true;
        }

        private void pictureBox_new_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            Presenter pr = new Presenter(this);
            player.Stop();
            listBox1.Visible = true;
            button_A.Visible = true;
            button_B.Visible = true;
            button_C.Visible = true;
            button_D.Visible = true;
            textBox_question.Visible = true;
            groupBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
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
            picture_True.Visible = false;
            text_True.Visible = false;
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
            player.SoundLocation = "../../resources/sound/winner.wav";
            player.Play();
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
        public void TrueAnswer()
        {
            player.SoundLocation = "../../resources/sound/true.wav";
            player.Play();
            picture_True.Visible = true;
            text_True.Visible = true;
            button_Next.Visible = true;
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            button_Next.Visible = false;
            player.SoundLocation = "../../resources/sound/gong.wav";
            player.Play();
            NextQuestion();
        }
    }
}
