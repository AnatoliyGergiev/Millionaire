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
    public partial class DeleteQuestionForm : Form, IDeleteView
    {
        public string Question
        {
            get { return textBox_Question.Text.Trim(); }
            set { textBox_Question.Text = value; }
        }
        public int Current_Question
        {
            get { return Convert.ToInt32(numericUpDown_Delete.Value); }
        }
        public int MaxQuestions
        {
            set { numericUpDown_Delete.Maximum = value; }
        }
        public event EventHandler<EventArgs> Delete_q;
        public event EventHandler<EventArgs> Update_v;
        public DeleteQuestionForm()
        {
            InitializeComponent();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (Delete_q != null)
                Delete_q(this, EventArgs.Empty);
            DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown_Delete_ValueChanged(object sender, EventArgs e)
        {
            int num = Current_Question;
            if (Update_v != null)
                Update_v(this, EventArgs.Empty);
        }
    }
}
