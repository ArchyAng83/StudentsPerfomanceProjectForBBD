
namespace StudentsPerformance
{
    partial class StudentInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInfoForm));
            this.studentInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.studentInfoLabel = new System.Windows.Forms.Label();
            this.classStudentInfoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.subjectNameLabel = new System.Windows.Forms.Label();
            this.subjectNameComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentInfoDataGridView
            // 
            this.studentInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentInfoDataGridView.Location = new System.Drawing.Point(1, 124);
            this.studentInfoDataGridView.Name = "studentInfoDataGridView";
            this.studentInfoDataGridView.Size = new System.Drawing.Size(798, 327);
            this.studentInfoDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Учащийся:";
            // 
            // studentInfoLabel
            // 
            this.studentInfoLabel.AutoSize = true;
            this.studentInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentInfoLabel.Location = new System.Drawing.Point(90, 9);
            this.studentInfoLabel.Name = "studentInfoLabel";
            this.studentInfoLabel.Size = new System.Drawing.Size(57, 16);
            this.studentInfoLabel.TabIndex = 3;
            this.studentInfoLabel.Text = "<none>";
            // 
            // classStudentInfoLabel
            // 
            this.classStudentInfoLabel.AutoSize = true;
            this.classStudentInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classStudentInfoLabel.Location = new System.Drawing.Point(90, 37);
            this.classStudentInfoLabel.Name = "classStudentInfoLabel";
            this.classStudentInfoLabel.Size = new System.Drawing.Size(57, 16);
            this.classStudentInfoLabel.TabIndex = 5;
            this.classStudentInfoLabel.Text = "<none>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Класс:";
            // 
            // subjectNameLabel
            // 
            this.subjectNameLabel.AutoSize = true;
            this.subjectNameLabel.Location = new System.Drawing.Point(315, 13);
            this.subjectNameLabel.Name = "subjectNameLabel";
            this.subjectNameLabel.Size = new System.Drawing.Size(55, 13);
            this.subjectNameLabel.TabIndex = 6;
            this.subjectNameLabel.Text = "Предмет:";
            // 
            // subjectNameComboBox
            // 
            this.subjectNameComboBox.AllowDrop = true;
            this.subjectNameComboBox.FormattingEnabled = true;
            this.subjectNameComboBox.Location = new System.Drawing.Point(388, 11);
            this.subjectNameComboBox.Name = "subjectNameComboBox";
            this.subjectNameComboBox.Size = new System.Drawing.Size(228, 21);
            this.subjectNameComboBox.TabIndex = 7;
            this.subjectNameComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectNameComboBox_SelectedIndexChanged);
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subjectNameComboBox);
            this.Controls.Add(this.subjectNameLabel);
            this.Controls.Add(this.classStudentInfoLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentInfoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentInfoDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оценки учащегося";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentInfoDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label studentInfoLabel;
        private System.Windows.Forms.Label classStudentInfoLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label subjectNameLabel;
        private System.Windows.Forms.ComboBox subjectNameComboBox;
    }
}