namespace Millionaire
{
    partial class AddQuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_Answer1 = new System.Windows.Forms.TextBox();
            this.textBox_Answer2 = new System.Windows.Forms.TextBox();
            this.textBox_Answer3 = new System.Windows.Forms.TextBox();
            this.textBox_Answer4 = new System.Windows.Forms.TextBox();
            this.textBox_Question = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(62, 347);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(121, 40);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите вопрос:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите первый вариант ответа(правильный):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Введите второй вариант ответа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Введите третий вариант ответа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Введите четвёртый вариант ответа:";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(283, 347);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(121, 40);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // textBox_Answer1
            // 
            this.textBox_Answer1.Location = new System.Drawing.Point(28, 132);
            this.textBox_Answer1.Name = "textBox_Answer1";
            this.textBox_Answer1.Size = new System.Drawing.Size(407, 22);
            this.textBox_Answer1.TabIndex = 2;
            // 
            // textBox_Answer2
            // 
            this.textBox_Answer2.Location = new System.Drawing.Point(28, 188);
            this.textBox_Answer2.Name = "textBox_Answer2";
            this.textBox_Answer2.Size = new System.Drawing.Size(407, 22);
            this.textBox_Answer2.TabIndex = 2;
            // 
            // textBox_Answer3
            // 
            this.textBox_Answer3.Location = new System.Drawing.Point(28, 244);
            this.textBox_Answer3.Name = "textBox_Answer3";
            this.textBox_Answer3.Size = new System.Drawing.Size(407, 22);
            this.textBox_Answer3.TabIndex = 2;
            // 
            // textBox_Answer4
            // 
            this.textBox_Answer4.Location = new System.Drawing.Point(28, 301);
            this.textBox_Answer4.Name = "textBox_Answer4";
            this.textBox_Answer4.Size = new System.Drawing.Size(407, 22);
            this.textBox_Answer4.TabIndex = 2;
            // 
            // textBox_Question
            // 
            this.textBox_Question.Location = new System.Drawing.Point(28, 49);
            this.textBox_Question.Multiline = true;
            this.textBox_Question.Name = "textBox_Question";
            this.textBox_Question.Size = new System.Drawing.Size(407, 60);
            this.textBox_Question.TabIndex = 15;
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 400);
            this.Controls.Add(this.textBox_Question);
            this.Controls.Add(this.textBox_Answer4);
            this.Controls.Add(this.textBox_Answer3);
            this.Controls.Add(this.textBox_Answer2);
            this.Controls.Add(this.textBox_Answer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuestionForm";
            this.Text = "AddQuestionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_Answer1;
        private System.Windows.Forms.TextBox textBox_Answer2;
        private System.Windows.Forms.TextBox textBox_Answer3;
        private System.Windows.Forms.TextBox textBox_Answer4;
        private System.Windows.Forms.TextBox textBox_Question;
    }
}