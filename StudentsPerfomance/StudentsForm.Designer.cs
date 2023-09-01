
namespace StudentsPerfomance
{
    partial class StudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteStudentBtn = new System.Windows.Forms.Button();
            this.updateStudentBtn = new System.Windows.Forms.Button();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.addGuardianBtn = new System.Windows.Forms.Button();
            this.addFromListLinkLabel = new System.Windows.Forms.LinkLabel();
            this.guardiansInfoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Location = new System.Drawing.Point(-1, 218);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.Size = new System.Drawing.Size(803, 327);
            this.studentsDataGridView.TabIndex = 11;
            // 
            // deleteStudentBtn
            // 
            this.deleteStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteStudentBtn.Location = new System.Drawing.Point(12, 127);
            this.deleteStudentBtn.Name = "deleteStudentBtn";
            this.deleteStudentBtn.Size = new System.Drawing.Size(140, 43);
            this.deleteStudentBtn.TabIndex = 10;
            this.deleteStudentBtn.Text = "Удалить";
            this.deleteStudentBtn.UseVisualStyleBackColor = true;
            this.deleteStudentBtn.Click += new System.EventHandler(this.deleteStudentBtn_Click);
            // 
            // updateStudentBtn
            // 
            this.updateStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateStudentBtn.Location = new System.Drawing.Point(12, 70);
            this.updateStudentBtn.Name = "updateStudentBtn";
            this.updateStudentBtn.Size = new System.Drawing.Size(140, 43);
            this.updateStudentBtn.TabIndex = 9;
            this.updateStudentBtn.Text = "Изменить";
            this.updateStudentBtn.UseVisualStyleBackColor = true;
            this.updateStudentBtn.Click += new System.EventHandler(this.updateStudentBtn_Click);
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudentBtn.Location = new System.Drawing.Point(12, 12);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(140, 43);
            this.addStudentBtn.TabIndex = 8;
            this.addStudentBtn.Text = "Добавить";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // addGuardianBtn
            // 
            this.addGuardianBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addGuardianBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addGuardianBtn.Location = new System.Drawing.Point(592, 80);
            this.addGuardianBtn.Name = "addGuardianBtn";
            this.addGuardianBtn.Size = new System.Drawing.Size(196, 33);
            this.addGuardianBtn.TabIndex = 12;
            this.addGuardianBtn.Text = "Добавить опекунов";
            this.addGuardianBtn.UseVisualStyleBackColor = true;
            this.addGuardianBtn.Click += new System.EventHandler(this.addGuardianBtn_Click);
            // 
            // addFromListLinkLabel
            // 
            this.addFromListLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFromListLinkLabel.AutoSize = true;
            this.addFromListLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFromListLinkLabel.Location = new System.Drawing.Point(589, 127);
            this.addFromListLinkLabel.Name = "addFromListLinkLabel";
            this.addFromListLinkLabel.Size = new System.Drawing.Size(131, 16);
            this.addFromListLinkLabel.TabIndex = 13;
            this.addFromListLinkLabel.TabStop = true;
            this.addFromListLinkLabel.Text = "Выбрать из списка";
            this.addFromListLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addFromListLinkLabel_LinkClicked);
            // 
            // guardiansInfoBtn
            // 
            this.guardiansInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guardiansInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guardiansInfoBtn.Location = new System.Drawing.Point(592, 22);
            this.guardiansInfoBtn.Name = "guardiansInfoBtn";
            this.guardiansInfoBtn.Size = new System.Drawing.Size(196, 33);
            this.guardiansInfoBtn.TabIndex = 14;
            this.guardiansInfoBtn.Text = "Информация об опекунах";
            this.guardiansInfoBtn.UseVisualStyleBackColor = true;
            this.guardiansInfoBtn.Click += new System.EventHandler(this.guardiansInfoBtn_Click);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.guardiansInfoBtn);
            this.Controls.Add(this.addFromListLinkLabel);
            this.Controls.Add(this.addGuardianBtn);
            this.Controls.Add(this.studentsDataGridView);
            this.Controls.Add(this.deleteStudentBtn);
            this.Controls.Add(this.updateStudentBtn);
            this.Controls.Add(this.addStudentBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учащиеся";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentsForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.Button deleteStudentBtn;
        private System.Windows.Forms.Button updateStudentBtn;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button addGuardianBtn;
        private System.Windows.Forms.LinkLabel addFromListLinkLabel;
        private System.Windows.Forms.Button guardiansInfoBtn;
    }
}