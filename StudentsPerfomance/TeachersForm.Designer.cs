
namespace StudentsPerformance
{
    partial class TeachersForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lessonTabPage = new System.Windows.Forms.TabPage();
            this.classStudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.addMarkLessonBtn = new System.Windows.Forms.Button();
            this.deleteMarkLessonBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.classLessonCmbBox = new System.Windows.Forms.ComboBox();
            this.subjectNameLbl = new System.Windows.Forms.Label();
            this.teacherFullNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateMarkLessonBtn = new System.Windows.Forms.Button();
            this.lessonDataGridView = new System.Windows.Forms.DataGridView();
            this.classJournalTabPage = new System.Windows.Forms.TabPage();
            this.printStudentAVGBallBtn = new System.Windows.Forms.Button();
            this.classTeacherFullNameValueLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.classValueLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.classJournalDataGridView = new System.Windows.Forms.DataGridView();
            this.avgSubjectLbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.markComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.lessonTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classStudentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonDataGridView)).BeginInit();
            this.classJournalTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classJournalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.lessonTabPage);
            this.tabControl1.Controls.Add(this.classJournalTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(726, 493);
            this.tabControl1.TabIndex = 0;
            // 
            // lessonTabPage
            // 
            this.lessonTabPage.Controls.Add(this.label4);
            this.lessonTabPage.Controls.Add(this.markComboBox);
            this.lessonTabPage.Controls.Add(this.avgSubjectLbl);
            this.lessonTabPage.Controls.Add(this.label16);
            this.lessonTabPage.Controls.Add(this.classStudentsDataGridView);
            this.lessonTabPage.Controls.Add(this.addMarkLessonBtn);
            this.lessonTabPage.Controls.Add(this.deleteMarkLessonBtn);
            this.lessonTabPage.Controls.Add(this.label5);
            this.lessonTabPage.Controls.Add(this.classLessonCmbBox);
            this.lessonTabPage.Controls.Add(this.subjectNameLbl);
            this.lessonTabPage.Controls.Add(this.teacherFullNameLabel);
            this.lessonTabPage.Controls.Add(this.label2);
            this.lessonTabPage.Controls.Add(this.label1);
            this.lessonTabPage.Controls.Add(this.updateMarkLessonBtn);
            this.lessonTabPage.Controls.Add(this.lessonDataGridView);
            this.lessonTabPage.Location = new System.Drawing.Point(4, 22);
            this.lessonTabPage.Name = "lessonTabPage";
            this.lessonTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.lessonTabPage.Size = new System.Drawing.Size(718, 467);
            this.lessonTabPage.TabIndex = 0;
            this.lessonTabPage.Text = "Урок";
            this.lessonTabPage.UseVisualStyleBackColor = true;
            // 
            // classStudentsDataGridView
            // 
            this.classStudentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classStudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classStudentsDataGridView.Location = new System.Drawing.Point(12, 204);
            this.classStudentsDataGridView.Name = "classStudentsDataGridView";
            this.classStudentsDataGridView.Size = new System.Drawing.Size(263, 204);
            this.classStudentsDataGridView.TabIndex = 24;
            this.classStudentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classStudentsDataGridView_CellClick);
            // 
            // addMarkLessonBtn
            // 
            this.addMarkLessonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMarkLessonBtn.Location = new System.Drawing.Point(588, 204);
            this.addMarkLessonBtn.Name = "addMarkLessonBtn";
            this.addMarkLessonBtn.Size = new System.Drawing.Size(118, 34);
            this.addMarkLessonBtn.TabIndex = 23;
            this.addMarkLessonBtn.Text = "Добавить";
            this.addMarkLessonBtn.UseVisualStyleBackColor = true;
            this.addMarkLessonBtn.Click += new System.EventHandler(this.addLessonBtn_Click);
            // 
            // deleteMarkLessonBtn
            // 
            this.deleteMarkLessonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteMarkLessonBtn.Location = new System.Drawing.Point(588, 315);
            this.deleteMarkLessonBtn.Name = "deleteMarkLessonBtn";
            this.deleteMarkLessonBtn.Size = new System.Drawing.Size(118, 34);
            this.deleteMarkLessonBtn.TabIndex = 22;
            this.deleteMarkLessonBtn.Text = "Удалить";
            this.deleteMarkLessonBtn.UseVisualStyleBackColor = true;
            this.deleteMarkLessonBtn.Click += new System.EventHandler(this.deleteMarkLessonBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(569, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Класс:";
            // 
            // classLessonCmbBox
            // 
            this.classLessonCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classLessonCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classLessonCmbBox.FormattingEnabled = true;
            this.classLessonCmbBox.Location = new System.Drawing.Point(644, 13);
            this.classLessonCmbBox.Name = "classLessonCmbBox";
            this.classLessonCmbBox.Size = new System.Drawing.Size(56, 28);
            this.classLessonCmbBox.TabIndex = 19;
            this.classLessonCmbBox.SelectedIndexChanged += new System.EventHandler(this.classLessonCmbBox_SelectedIndexChanged);
            // 
            // subjectNameLbl
            // 
            this.subjectNameLbl.AutoSize = true;
            this.subjectNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectNameLbl.Location = new System.Drawing.Point(110, 46);
            this.subjectNameLbl.Name = "subjectNameLbl";
            this.subjectNameLbl.Size = new System.Drawing.Size(76, 24);
            this.subjectNameLbl.TabIndex = 18;
            this.subjectNameLbl.Text = "<none>";
            // 
            // teacherFullNameLabel
            // 
            this.teacherFullNameLabel.AutoSize = true;
            this.teacherFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherFullNameLabel.Location = new System.Drawing.Point(170, 13);
            this.teacherFullNameLabel.Name = "teacherFullNameLabel";
            this.teacherFullNameLabel.Size = new System.Drawing.Size(76, 24);
            this.teacherFullNameLabel.TabIndex = 17;
            this.teacherFullNameLabel.Text = "<none>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Предмет:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Преподаватель:";
            // 
            // updateMarkLessonBtn
            // 
            this.updateMarkLessonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateMarkLessonBtn.Location = new System.Drawing.Point(588, 258);
            this.updateMarkLessonBtn.Name = "updateMarkLessonBtn";
            this.updateMarkLessonBtn.Size = new System.Drawing.Size(118, 34);
            this.updateMarkLessonBtn.TabIndex = 14;
            this.updateMarkLessonBtn.Text = "Изменить";
            this.updateMarkLessonBtn.UseVisualStyleBackColor = true;
            this.updateMarkLessonBtn.Click += new System.EventHandler(this.updateMarkLessonBtn_Click);
            // 
            // lessonDataGridView
            // 
            this.lessonDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lessonDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lessonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lessonDataGridView.Location = new System.Drawing.Point(304, 204);
            this.lessonDataGridView.Name = "lessonDataGridView";
            this.lessonDataGridView.Size = new System.Drawing.Size(263, 204);
            this.lessonDataGridView.TabIndex = 13;
            // 
            // classJournalTabPage
            // 
            this.classJournalTabPage.Controls.Add(this.printStudentAVGBallBtn);
            this.classJournalTabPage.Controls.Add(this.classTeacherFullNameValueLabel);
            this.classJournalTabPage.Controls.Add(this.label6);
            this.classJournalTabPage.Controls.Add(this.classValueLabel);
            this.classJournalTabPage.Controls.Add(this.label3);
            this.classJournalTabPage.Controls.Add(this.classJournalDataGridView);
            this.classJournalTabPage.Location = new System.Drawing.Point(4, 22);
            this.classJournalTabPage.Name = "classJournalTabPage";
            this.classJournalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.classJournalTabPage.Size = new System.Drawing.Size(718, 467);
            this.classJournalTabPage.TabIndex = 1;
            this.classJournalTabPage.Text = "Журнал";
            this.classJournalTabPage.UseVisualStyleBackColor = true;
            // 
            // printStudentAVGBallBtn
            // 
            this.printStudentAVGBallBtn.Location = new System.Drawing.Point(6, 79);
            this.printStudentAVGBallBtn.Name = "printStudentAVGBallBtn";
            this.printStudentAVGBallBtn.Size = new System.Drawing.Size(75, 23);
            this.printStudentAVGBallBtn.TabIndex = 82;
            this.printStudentAVGBallBtn.Text = "Печать";
            this.printStudentAVGBallBtn.UseVisualStyleBackColor = true;
            // 
            // classTeacherFullNameValueLabel
            // 
            this.classTeacherFullNameValueLabel.AutoSize = true;
            this.classTeacherFullNameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classTeacherFullNameValueLabel.Location = new System.Drawing.Point(251, 46);
            this.classTeacherFullNameValueLabel.Name = "classTeacherFullNameValueLabel";
            this.classTeacherFullNameValueLabel.Size = new System.Drawing.Size(76, 24);
            this.classTeacherFullNameValueLabel.TabIndex = 26;
            this.classTeacherFullNameValueLabel.Text = "<none>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Классный руководитель:";
            // 
            // classValueLabel
            // 
            this.classValueLabel.AutoSize = true;
            this.classValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classValueLabel.Location = new System.Drawing.Point(81, 14);
            this.classValueLabel.Name = "classValueLabel";
            this.classValueLabel.Size = new System.Drawing.Size(76, 24);
            this.classValueLabel.TabIndex = 24;
            this.classValueLabel.Text = "<none>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Класс:";
            // 
            // classJournalDataGridView
            // 
            this.classJournalDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classJournalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classJournalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classJournalDataGridView.Location = new System.Drawing.Point(0, 108);
            this.classJournalDataGridView.Name = "classJournalDataGridView";
            this.classJournalDataGridView.Size = new System.Drawing.Size(858, 349);
            this.classJournalDataGridView.TabIndex = 0;
            // 
            // avgSubjectLbl
            // 
            this.avgSubjectLbl.AutoSize = true;
            this.avgSubjectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgSubjectLbl.Location = new System.Drawing.Point(516, 422);
            this.avgSubjectLbl.Name = "avgSubjectLbl";
            this.avgSubjectLbl.Size = new System.Drawing.Size(51, 16);
            this.avgSubjectLbl.TabIndex = 26;
            this.avgSubjectLbl.Text = "<none>";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(301, 422);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(188, 16);
            this.label16.TabIndex = 25;
            this.label16.Text = "Средний балл по предмету:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(423, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Оценка:";
            // 
            // markComboBox
            // 
            this.markComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.markComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markComboBox.FormattingEnabled = true;
            this.markComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.markComboBox.Location = new System.Drawing.Point(511, 147);
            this.markComboBox.Name = "markComboBox";
            this.markComboBox.Size = new System.Drawing.Size(56, 28);
            this.markComboBox.TabIndex = 27;
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 493);
            this.Controls.Add(this.tabControl1);
            this.Name = "TeachersForm";
            this.Text = "Журнал учителя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeachersForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.lessonTabPage.ResumeLayout(false);
            this.lessonTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classStudentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonDataGridView)).EndInit();
            this.classJournalTabPage.ResumeLayout(false);
            this.classJournalTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classJournalDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage lessonTabPage;
        private System.Windows.Forms.TabPage classJournalTabPage;
        private System.Windows.Forms.Button addMarkLessonBtn;
        private System.Windows.Forms.Button deleteMarkLessonBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox classLessonCmbBox;
        private System.Windows.Forms.Label subjectNameLbl;
        private System.Windows.Forms.Label teacherFullNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateMarkLessonBtn;
        private System.Windows.Forms.DataGridView lessonDataGridView;
        private System.Windows.Forms.DataGridView classJournalDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label classTeacherFullNameValueLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label classValueLabel;
        private System.Windows.Forms.Button printStudentAVGBallBtn;
        private System.Windows.Forms.DataGridView classStudentsDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox markComboBox;
        private System.Windows.Forms.Label avgSubjectLbl;
        private System.Windows.Forms.Label label16;
    }
}