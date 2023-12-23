namespace StudentsPerformance
{
    partial class AddNewClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewClassForm));
            this.newClassTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveNewClassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newClassTextBox
            // 
            this.newClassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newClassTextBox.Location = new System.Drawing.Point(163, 34);
            this.newClassTextBox.Name = "newClassTextBox";
            this.newClassTextBox.Size = new System.Drawing.Size(309, 26);
            this.newClassTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Новый класс:";
            // 
            // saveNewClassBtn
            // 
            this.saveNewClassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveNewClassBtn.Location = new System.Drawing.Point(184, 96);
            this.saveNewClassBtn.Name = "saveNewClassBtn";
            this.saveNewClassBtn.Size = new System.Drawing.Size(132, 31);
            this.saveNewClassBtn.TabIndex = 3;
            this.saveNewClassBtn.Text = "Сохранить";
            this.saveNewClassBtn.UseVisualStyleBackColor = true;
            this.saveNewClassBtn.Click += new System.EventHandler(this.saveNewClassBtn_Click);
            // 
            // AddNewClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 160);
            this.Controls.Add(this.newClassTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveNewClassBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewClassForm";
            this.Text = "Добавление нового класса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newClassTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveNewClassBtn;
    }
}