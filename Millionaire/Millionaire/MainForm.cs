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
        public int Current_Question { get; set; }
        public string User_Answer { get; set; }
        public string Right_Answer { get; set; }

        public event EventHandler<EventArgs> Next_q;
        public event EventHandler<EventArgs> Select_button;
        SoundPlayer player;
        public MainForm()
        {
            InitializeComponent();
            player = new SoundPlayer("../../resources/sound/begin.wav");
            player.Play();
            BackgroundImage = new Bitmap("../../resources/image/423.jpg");
            button_stop.Visible = true;
            pictureBox_exit.Visible = true;
            pictureBox_new.Visible = true;

            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstBox_DrawItem);  
        }

        private void pictureBox_new_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible != true)
            {
                pictureBox1.Visible = true;
                MainPresenter pr = new MainPresenter(this);
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
                player.SoundLocation = "../../resources/sound/gong.wav";
                player.Play();
                listBox1.SelectedIndex = 14 - Number_Question;
                /*Button[] bn = { button_A, button_B, button_C, button_D };
                picture_True.Visible = false;
                text_True.Visible = false;
                button_Next.Visible = false;
                picture_tel_hint.Visible = false;
                text_tel_hint.Visible = false;
                Number_Question = 0;
                foreach (Button b in bn)
                {
                    b.BackColor = Color.Black;
                    b.Enabled = true;
                }

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
                hint_50.BackgroundImage = new Bitmap("../../Resources/Image/1.jpg");
                hint_tel.BackgroundImage = new Bitmap("../../Resources/Image/2.jpg");
                hint_hall.BackgroundImage = new Bitmap("../../Resources/Image/3.jpg");
                hint_50.Enabled = true;
                hint_tel.Enabled = true;
                hint_hall.Enabled = true;

                player.SoundLocation = "../../resources/sound/gong.wav";
                player.Play();
                listBox1.SelectedIndex = 14 - Number_Question;*/
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

            listBox1.SelectedIndex = 14 - Number_Question;

            foreach (Button b in bn)
            {
                b.BackColor = Color.Black;
                b.Enabled = true;
            }
        }



        private void lstBox_DrawItem(object sender,   
                      System.Windows.Forms.DrawItemEventArgs e)  
                {  
                    // Перерисовываем фон всех элементов ListBox.  
                    e.DrawBackground();  
              
                    // Создаем объект Brush.  
                    Brush myBrush = Brushes.Black;  
  
                    // Определяем номер текущего элемента  
                    switch (e.Index)  
                    {  
                        case 0:  
                            myBrush = Brushes.Orange;  
                            break;  
                        case 5:  
                            myBrush = Brushes.Orange;  
                            break;  
                        case 10:  
                            myBrush = Brushes.Orange;  
                            break;  
                    }  
  
                    //Если необходимо, закрашиваем фон   
                    //активного элемента в новый цвет  
                    //e.Graphics.FillRectangle(myBrush, e.Bounds);  
              
                    // Перерисовываем текст текущего элемента  
                    e.Graphics.DrawString(  
                        ((ListBox)sender).Items[e.Index].ToString(),   
                        e.Font, myBrush, e.Bounds,   
                        StringFormat.GenericDefault);  
  
                    // Если ListBox в фокусе, рисуем прямоугольник   
                    //вокруг активного элемента.  
                    e.DrawFocusRectangle();  
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


                //switch (r)
                //{
                //    case 0:
                //        progressBar1.Value = rnd.Next(40, 90);
                //        break;
                //    case 1:
                //        progressBar2.Value = rnd.Next(40, 90);
                //        break;
                //    case 2:
                //        progressBar3.Value = rnd.Next(40, 90);
                //        break;
                //    case 3:
                //        progressBar4.Value = rnd.Next(40, 90);
                //        break;
                //}
                hint_hall.BackgroundImage = new Bitmap("../../Resources/Image/6.jpg");
                hint_hall.Enabled = false;
            }
        }

        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQuestionForm addQuestionForm = new AddQuestionForm();
            AddPresenter addPresenter = new AddPresenter(addQuestionForm);
            if (addQuestionForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Вопрос успешно добавлен!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void удалитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteQuestionForm deleteQuestionForm = new DeleteQuestionForm();
            DeletePresenter deletePresenter = new DeletePresenter(deleteQuestionForm);
            if (deleteQuestionForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Вопрос успешно удален!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void изменитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditQuestionForm editQuestionForm = new EditQuestionForm();
            EditPresenter editPresenter = new EditPresenter(editQuestionForm);
            if (editQuestionForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Вопрос успешно изменён!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }  
}  
