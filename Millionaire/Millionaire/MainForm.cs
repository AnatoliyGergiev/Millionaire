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
        public int Current_Question { get; set; }
        public string User_Answer { get; set; }
        public string Right_Answer { get; set; }

        public event EventHandler<EventArgs> Next_q;
        public event EventHandler<EventArgs> Select_button;
        private SoundPlayer player;
        private Label[] list;// = new Label[15];
        private bool allow_new;

        public MainForm()
        {
            InitializeComponent();
            player = new SoundPlayer("../../resources/sound/begin.wav");
            player.Play();
            BackgroundImage = new Bitmap("../../resources/image/423.jpg");
            button_stop.Visible = true;
            pictureBox_exit.Visible = true;
            pictureBox_new.Visible = true;
            list=new Label[]{label_1, label_2, label_3, label_4, label_5, label_6, label_7,
                label_8, label_9, label_10, label_11, label_12, label_13, label_14, label_15};
            allow_new = true;
        }

        private void pictureBox_new_Click(object sender, EventArgs e)
        {
            if (allow_new)
            {
                pictureBox1.Visible = true;
                pictureBox1.BackgroundImage = new Bitmap("../../resources/Image/mil.jpg");
                MainPresenter pr = new MainPresenter(this);
                player.Stop();
                groupBox2.Visible = true;
                foreach (Label l in list)
                    l.BackColor = Color.Black;
                button_A.Visible = true;
                button_A.BackColor = Color.Black;
                button_B.Visible = true;
                button_B.BackColor = Color.Black;
                button_C.Visible = true;
                button_C.BackColor = Color.Black;
                button_D.Visible = true;
                button_D.BackColor = Color.Black;
                textBox_question.Visible = true;
                groupBox1.Visible = true;
                hint_50.BackgroundImage = new Bitmap("../../resources/Image/1.jpg");
                hint_tel.BackgroundImage = new Bitmap("../../resources/Image/2.jpg");
                hint_hall.BackgroundImage = new Bitmap("../../resources/Image/3.jpg");
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                player.SoundLocation = "../../resources/sound/gong.wav";
                player.Play();
                list[0].BackColor = Color.Green;
                groupBox_hall.Visible = false;
                allow_new = false;
            }
        }

        private void button_B_Click(object sender, EventArgs e)
        {
            if (button_Next.Visible == false)
            {
                User_Answer = button_B.Text.Trim();
                if (Select_button != null)
                {
                    Select_button(button_B, EventArgs.Empty);
                }
            }
        }

        private void button_A_Click(object sender, EventArgs e)
        {
            if (button_Next.Visible == false)
            {
                User_Answer = button_A.Text.Trim();
                if (Select_button != null)
                {
                    Select_button(button_A, EventArgs.Empty);
                }
            }
        }
        public void NextQuestion()
        {
            if (Next_q != null)
                Next_q(this, EventArgs.Empty);
        }
        public void GameOver(object sender)
        {
            Button x = new Button();
            if (button_A.Text == Right_Answer)
                x = button_A;
            else if (button_B.Text == Right_Answer)
                x = button_B;
            else if (button_C.Text == Right_Answer)
                x = button_C;
            else if (button_D.Text == Right_Answer)
                x = button_D;
            x.BackColor = Color.Green;
            Button a = sender as Button;
            a.BackColor = Color.Red;
            Win(Number_Question-1);
        }
        public void Win(int number_question)
        {
            if (number_question == 14)
            {
                player.SoundLocation = "../../resources/sound/winner.wav";
                player.Play();
                pictureBox1.BackgroundImage = new Bitmap("../../resources/Image/Vifrash.jpg");
                MessageBox.Show(this, "Поздравляем, Вы выиграли 1 000 000!");
            }
            else if (number_question >= 4 && number_question <9)
            {
                player.SoundLocation = "../../resources/sound/summa.wav";
                player.Play();
                pictureBox1.BackgroundImage = new Bitmap("../../resources/Image/vig.jpg");
                MessageBox.Show(this, "Вы выиграли 1 000!");
            }
            else if (number_question == 0)
            {
                player.SoundLocation = "../../resources/sound/false.wav";
                player.Play();
                pictureBox1.BackgroundImage = new Bitmap("../../resources/Image/vig.jpg");
                MessageBox.Show(this, "Вы выиграли 0!");
            }
            else if (number_question >= 9)
            {
                player.SoundLocation = "../../resources/sound/summa.wav";
                player.Play();
                pictureBox1.BackgroundImage = new Bitmap("../../resources/Image/vig.jpg");
                MessageBox.Show(this, "Вы выиграли 32 000!");
            }
            allow_new = true;
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            if (button_Next.Visible == false)
            {
                User_Answer = button_C.Text.Trim();
                if (Select_button != null)
                {
                    Select_button(button_C, EventArgs.Empty);
                }
            }
        }

        private void button_D_Click(object sender, EventArgs e)
        {
            if (button_Next.Visible == false)
            {
                User_Answer = button_D.Text.Trim();
                if (Select_button != null)
                {
                    Select_button(button_D, EventArgs.Empty);
                }
            }
        }
        public void TrueAnswer(object sender)
        {
            player.SoundLocation = "../../resources/sound/true.wav";
            player.Play();
            picture_True.Visible = true;
            text_True.Visible = true;
            button_Next.Visible = true;
            Button a = sender as Button;
            a.BackColor = Color.Green;
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            Button[] bn = { button_A, button_B, button_C, button_D };
            picture_True.Visible = false;
            text_True.Visible = false;
            button_Next.Visible = false;

            picture_tel_hint.Visible = false;
            text_tel_hint.Visible = false;

            groupBox_hall.Visible = false;

            player.SoundLocation = "../../resources/sound/gong.wav";
            player.Play();
            NextQuestion();
            list[Number_Question - 1].BackColor = Color.Black;
            list[Number_Question].BackColor = Color.Green;

            foreach (Button b in bn)
            {
                b.BackColor = Color.Black;
                b.Enabled = true;
            }
        }
        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hint_50_Click(object sender, EventArgs e)
        {
            if (button_Next.Visible == false)
            {
                Button[] bn = { button_A, button_B, button_C, button_D };
                Random rnd = new Random();
                int r = -1;
                for (int i = 0; i < 4; i++)
                {
                    bn[i].Enabled = false;
                    if (bn[i].Text == Right_Answer)
                        r = i;
                }
                int n;
                do
                {
                    n = rnd.Next(0, 3);
                } while (n == r);
                bn[r].Enabled = true;
                bn[n].Enabled = true;
                hint_50.BackgroundImage = new Bitmap("../../Resources/Image/4.jpg");
                hint_50.Enabled = false;
            }
        }

        private void hint_tel_Click(object sender, EventArgs e)
        {
            if (button_Next.Visible == false)
            {
                player.SoundLocation = "../../Resources/sound/zvonok.wav";
                player.Play();
                text_tel_hint.Visible = true;
                picture_tel_hint.Visible = true;

                text_tel_hint.Text = "Я думаю это " + Right_Answer;

                hint_tel.BackgroundImage = new Bitmap("../../Resources/Image/5.jpg");
                hint_tel.Enabled = false;
            }
        }

        private void hint_hall_Click(object sender, EventArgs e)
        {
            if (button_Next.Visible == false)
            {
                player.SoundLocation = "../../Resources/sound/zal.wav";
                player.Play();
                groupBox_hall.Visible = true;
                ProgressBar[] pb = { progressBar1, progressBar2, progressBar3, progressBar4 };
                Label[] lb = { label2, label3, label4, label5 };
                foreach (ProgressBar p in pb)
                    p.ForeColor = Color.Red;
                Random rnd = new Random();
                Button[] bn = { button_A, button_B, button_C, button_D };
                int r = -1;
                for (int i = 0; i < 4; i++)
                {
                    if (bn[i].Text == Right_Answer)
                        r = i;
                }
                pb[r].Value = rnd.Next(40, 90);
                lb[r].Text = pb[r].Value + "%";
                for (int i = 0; i < r; i++)
                {
                    pb[i].Value = (100 - pb[r].Value) / 3;
                    lb[i].Text = pb[i].Value + "%";
                }
                for (int i = r + 1; i < 4; i++)
                {
                    pb[i].Value = (100 - pb[r].Value) / 3;
                    lb[i].Text = pb[i].Value + "%";
                }

                hint_hall.BackgroundImage = new Bitmap("../../Resources/Image/6.jpg");
                hint_hall.Enabled = false;
            }
        }

        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            AddQuestionForm addQuestionForm = new AddQuestionForm();
            AddPresenter addPresenter = new AddPresenter(addQuestionForm);
            if (addQuestionForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Вопрос успешно добавлен!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void удалитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            DeleteQuestionForm deleteQuestionForm = new DeleteQuestionForm();
            DeletePresenter deletePresenter = new DeletePresenter(deleteQuestionForm);
            if (deleteQuestionForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Вопрос успешно удален!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void изменитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            EditQuestionForm editQuestionForm = new EditQuestionForm();
            EditPresenter editPresenter = new EditPresenter(editQuestionForm);
            if (editQuestionForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Вопрос успешно изменён!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            if (button_Next.Visible == true)
                Win(Number_Question);
            else
                Win(Number_Question - 1);
        }
    }  
}  
