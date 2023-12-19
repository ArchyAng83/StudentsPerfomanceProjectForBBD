
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
            this.studentFullNameLabel = new System.Windows.Forms.Label();
            this.classNameLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.subjectNameLabel = new System.Windows.Forms.Label();
            this.subjectNameComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.avgAllSubjectsLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.avgBySubjectLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentInfoDataGridView
            // 
            this.studentInfoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.studentInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentInfoDataGridView.Location = new System.Drawing.Point(16, 148);
            this.studentInfoDataGridView.Name = "studentInfoDataGridView";
            this.studentInfoDataGridView.Size = new System.Drawing.Size(375, 210);
            this.studentInfoDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Учащийся:";
            // 
            // studentFullNameLabel
            // 
            this.studentFullNameLabel.AutoSize = true;
            this.studentFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentFullNameLabel.Location = new System.Drawing.Point(120, 9);
            this.studentFullNameLabel.Name = "studentFullNameLabel";
            this.studentFullNameLabel.Size = new System.Drawing.Size(76, 24);
            this.studentFullNameLabel.TabIndex = 3;
            this.studentFullNameLabel.Text = "<none>";
            // 
            // classNameLbl
            // 
            this.classNameLbl.AutoSize = true;
            this.classNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classNameLbl.Location = new System.Drawing.Point(120, 37);
            this.classNameLbl.Name = "classNameLbl";
            this.classNameLbl.Size = new System.Drawing.Size(76, 24);
            this.classNameLbl.TabIndex = 5;
            this.classNameLbl.Text = "<none>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Класс:";
            // 
            // subjectNameLabel
            // 
            this.subjectNameLabel.AutoSize = true;
            this.subjectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectNameLabel.Location = new System.Drawing.Point(449, 152);
            this.subjectNameLabel.Name = "subjectNameLabel";
            this.subjectNameLabel.Size = new System.Drawing.Size(96, 24);
            this.subjectNameLabel.TabIndex = 6;
            this.subjectNameLabel.Text = "Предмет:";
            // 
            // subjectNameComboBox
            // 
            this.subjectNameComboBox.AllowDrop = true;
            this.subjectNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectNameComboBox.FormattingEnabled = true;
            this.subjectNameComboBox.Location = new System.Drawing.Point(551, 148);
            this.subjectNameComboBox.Name = "subjectNameComboBox";
            this.subjectNameComboBox.Size = new System.Drawing.Size(228, 32);
            this.subjectNameComboBox.TabIndex = 7;
            this.subjectNameComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectNameComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(450, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 16);
            this.label9.TabIndex = 92;
            this.label9.Text = "Общий средний балл:";
            // 
            // avgAllSubjectsLbl
            // 
            this.avgAllSubjectsLbl.AutoSize = true;
            this.avgAllSubjectsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgAllSubjectsLbl.Location = new System.Drawing.Point(665, 301);
            this.avgAllSubjectsLbl.Name = "avgAllSubjectsLbl";
            this.avgAllSubjectsLbl.Size = new System.Drawing.Size(51, 16);
            this.avgAllSubjectsLbl.TabIndex = 91;
            this.avgAllSubjectsLbl.Text = "<none>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(450, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 16);
            this.label8.TabIndex = 90;
            this.label8.Text = "Средний балл по предмету:";
            // 
            // avgBySubjectLbl
            // 
            this.avgBySubjectLbl.AutoSize = true;
            this.avgBySubjectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgBySubjectLbl.Location = new System.Drawing.Point(665, 335);
            this.avgBySubjectLbl.Name = "avgBySubjectLbl";
            this.avgBySubjectLbl.Size = new System.Drawing.Size(51, 16);
            this.avgBySubjectLbl.TabIndex = 89;
            this.avgBySubjectLbl.Text = "<none>";
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.avgAllSubjectsLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.avgBySubjectLbl);
            this.Controls.Add(this.subjectNameComboBox);
            this.Controls.Add(this.subjectNameLabel);
            this.Controls.Add(this.classNameLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentFullNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentInfoDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оценки учащегося";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentInfoForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentInfoDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label studentFullNameLabel;
        private System.Windows.Forms.Label classNameLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label subjectNameLabel;
        private System.Windows.Forms.ComboBox subjectNameComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label avgAllSubjectsLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label avgBySubjectLbl;
    }
}