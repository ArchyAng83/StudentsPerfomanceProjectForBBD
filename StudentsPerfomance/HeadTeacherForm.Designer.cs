
namespace StudentsPerfomance
{
    partial class HeadTeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadTeacherForm));
            this.workWithStudentsBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workWithStudentsBtn
            // 
            this.workWithStudentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workWithStudentsBtn.Location = new System.Drawing.Point(193, 90);
            this.workWithStudentsBtn.Name = "workWithStudentsBtn";
            this.workWithStudentsBtn.Size = new System.Drawing.Size(188, 132);
            this.workWithStudentsBtn.TabIndex = 1;
            this.workWithStudentsBtn.Text = "Работа с учащимися";
            this.workWithStudentsBtn.UseVisualStyleBackColor = true;
            this.workWithStudentsBtn.Click += new System.EventHandler(this.workWithStudentsBtn_Click);
            // 
            // reportsBtn
            // 
            this.reportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportsBtn.Location = new System.Drawing.Point(213, 285);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(144, 47);
            this.reportsBtn.TabIndex = 2;
            this.reportsBtn.Text = "Отчеты";
            this.reportsBtn.UseVisualStyleBackColor = true;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // HeadTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 379);
            this.Controls.Add(this.reportsBtn);
            this.Controls.Add(this.workWithStudentsBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HeadTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Завуч";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HeadTeacherForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button workWithStudentsBtn;
        private System.Windows.Forms.Button reportsBtn;
    }
}