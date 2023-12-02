
namespace StudentsPerformance
{
    partial class AddSubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubjectForm));
            this.saveSubjectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newSubjectTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveSubjectBtn
            // 
            this.saveSubjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveSubjectBtn.Location = new System.Drawing.Point(182, 96);
            this.saveSubjectBtn.Name = "saveSubjectBtn";
            this.saveSubjectBtn.Size = new System.Drawing.Size(132, 31);
            this.saveSubjectBtn.TabIndex = 0;
            this.saveSubjectBtn.Text = "Сохранить";
            this.saveSubjectBtn.UseVisualStyleBackColor = true;
            this.saveSubjectBtn.Click += new System.EventHandler(this.saveSubjectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Новый предмет:";
            // 
            // newSubjectTextBox
            // 
            this.newSubjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newSubjectTextBox.Location = new System.Drawing.Point(161, 34);
            this.newSubjectTextBox.Name = "newSubjectTextBox";
            this.newSubjectTextBox.Size = new System.Drawing.Size(309, 26);
            this.newSubjectTextBox.TabIndex = 2;
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 169);
            this.Controls.Add(this.newSubjectTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveSubjectBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSubjectForm";
            this.Text = "Добавить новый предмет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveSubjectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newSubjectTextBox;
    }
}