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
    public partial class AddQuestionForm : Form, IAddView
    {
        public string Question 
        { 
            get { return textBox_Question.Text.Trim(); } 
            set { textBox_Question.Text = value; } 
        }
        public string Answer_A 
        { 
            get { return textBox_Answer1.Text.Trim(); }
            set { textBox_Answer1.Text = value; } 
        }
        public string Answer_B 
        { 
            get { return textBox_Answer2.Text.Trim(); }
            set { textBox_Answer2.Text = value; }
        }
        public string Answer_C 
        { 
            get { return textBox_Answer3.Text.Trim(); }
            set { textBox_Answer3.Text = value; }
        }
        public string Answer_D 
        { 
            get { return textBox_Answer4.Text.Trim(); }
            set { textBox_Answer4.Text = value; }
        }

        public event EventHandler<EventArgs> Add;
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (Add != null)
                Add(this, EventArgs.Empty);
            DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
