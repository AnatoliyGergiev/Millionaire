namespace Millionaire
{
    partial class DeleteQuestionForm
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
            this.textBox_Question = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.numericUpDown_Delete = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Question
            // 
            this.textBox_Question.Location = new System.Drawing.Point(24, 95);
            this.textBox_Question.Name = "textBox_Question";
            this.textBox_Question.Size = new System.Drawing.Size(330, 22);
            this.textBox_Question.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер вопроса:";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(38, 134);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(118, 37);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_Delete
            // 
            this.numericUpDown_Delete.Location = new System.Drawing.Point(148, 22);
            this.numericUpDown_Delete.Name = "numericUpDown_Delete";
            this.numericUpDown_Delete.Size = new System.Drawing.Size(47, 22);
            this.numericUpDown_Delete.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вопрос для удаления:";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(214, 134);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(118, 37);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // DeleteQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 193);
            this.Controls.Add(this.numericUpDown_Delete);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Question);
            this.Name = "DeleteQuestionForm";
            this.Text = "DeleteQuestionForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.NumericUpDown numericUpDown_Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Cancel;
    }
}