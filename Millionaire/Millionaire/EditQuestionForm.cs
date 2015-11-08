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
    public partial class EditQuestionForm : Form, IEditView
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
        public int Current_Question 
        {
            get { return Convert.ToInt32(numericUpDown_Edit.Value); }
        }
        public int MaxQuestions
        {
            set { numericUpDown_Edit.Maximum = value; }
        }

        public event EventHandler<EventArgs> Edit;
        public event EventHandler<EventArgs> Update_v;
    
        public EditQuestionForm()
        {
            InitializeComponent();
        }

        private void numericUpDown_Edit_ValueChanged(object sender, EventArgs e)
        {
            int num = Current_Question;
            if (Update_v != null)
                Update_v(this, EventArgs.Empty);
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if(Edit!=null)
                Edit(this, EventArgs.Empty);
            DialogResult = DialogResult.OK;
        }
    }
}
