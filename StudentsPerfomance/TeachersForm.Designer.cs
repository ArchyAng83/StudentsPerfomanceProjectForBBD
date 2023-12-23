
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachersForm));
            this.teacherTabControl = new System.Windows.Forms.TabControl();
            this.lessonTabPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.markComboBox = new System.Windows.Forms.ComboBox();
            this.avgSubjectLbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lessonStudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.addMarkLessonBtn = new System.Windows.Forms.Button();
            this.deleteMarkLessonBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.classLessonCmbBox = new System.Windows.Forms.ComboBox();
            this.subjectNameLbl = new System.Windows.Forms.Label();
            this.teacherFullNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateMarkLessonBtn = new System.Windows.Forms.Button();
            this.lessonMarksDataGridView = new System.Windows.Forms.DataGridView();
            this.classJournalTabPage = new System.Windows.Forms.TabPage();
            this.subjectCmbBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.avgAllSubjectsText = new System.Windows.Forms.Label();
            this.avgAllSubjectsValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.avgBySubjectLbl = new System.Windows.Forms.Label();
            this.classJournalStudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.classJournalMarksDataGridView = new System.Windows.Forms.DataGridView();
            this.printStudentAVGBallBtn = new System.Windows.Forms.Button();
            this.classTeacherFullNameLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.classValueLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.teacherTabControl.SuspendLayout();
            this.lessonTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lessonStudentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonMarksDataGridView)).BeginInit();
            this.classJournalTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classJournalStudentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classJournalMarksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherTabControl
            // 
            this.teacherTabControl.Controls.Add(this.lessonTabPage);
            this.teacherTabControl.Controls.Add(this.classJournalTabPage);
            this.teacherTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherTabControl.Location = new System.Drawing.Point(0, 0);
            this.teacherTabControl.Name = "teacherTabControl";
            this.teacherTabControl.SelectedIndex = 0;
            this.teacherTabControl.Size = new System.Drawing.Size(726, 493);
            this.teacherTabControl.TabIndex = 0;
            // 
            // lessonTabPage
            // 
            this.lessonTabPage.Controls.Add(this.label4);
            this.lessonTabPage.Controls.Add(this.markComboBox);
            this.lessonTabPage.Controls.Add(this.avgSubjectLbl);
            this.lessonTabPage.Controls.Add(this.label16);
            this.lessonTabPage.Controls.Add(this.lessonStudentsDataGridView);
            this.lessonTabPage.Controls.Add(this.addMarkLessonBtn);
            this.lessonTabPage.Controls.Add(this.deleteMarkLessonBtn);
            this.lessonTabPage.Controls.Add(this.label5);
            this.lessonTabPage.Controls.Add(this.classLessonCmbBox);
            this.lessonTabPage.Controls.Add(this.subjectNameLbl);
            this.lessonTabPage.Controls.Add(this.teacherFullNameLabel);
            this.lessonTabPage.Controls.Add(this.label2);
            this.lessonTabPage.Controls.Add(this.label1);
            this.lessonTabPage.Controls.Add(this.updateMarkLessonBtn);
            this.lessonTabPage.Controls.Add(this.lessonMarksDataGridView);
            this.lessonTabPage.Location = new System.Drawing.Point(4, 22);
            this.lessonTabPage.Name = "lessonTabPage";
            this.lessonTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.lessonTabPage.Size = new System.Drawing.Size(718, 467);
            this.lessonTabPage.TabIndex = 0;
            this.lessonTabPage.Text = "Урок";
            this.lessonTabPage.UseVisualStyleBackColor = true;
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
            // lessonStudentsDataGridView
            // 
            this.lessonStudentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lessonStudentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lessonStudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lessonStudentsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.lessonStudentsDataGridView.Location = new System.Drawing.Point(12, 204);
            this.lessonStudentsDataGridView.Name = "lessonStudentsDataGridView";
            this.lessonStudentsDataGridView.Size = new System.Drawing.Size(263, 204);
            this.lessonStudentsDataGridView.TabIndex = 24;
            this.lessonStudentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lessonStudentsDataGridView_CellClick);
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
            // lessonMarksDataGridView
            // 
            this.lessonMarksDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lessonMarksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lessonMarksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lessonMarksDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.lessonMarksDataGridView.Location = new System.Drawing.Point(304, 204);
            this.lessonMarksDataGridView.Name = "lessonMarksDataGridView";
            this.lessonMarksDataGridView.Size = new System.Drawing.Size(263, 204);
            this.lessonMarksDataGridView.TabIndex = 13;
            // 
            // classJournalTabPage
            // 
            this.classJournalTabPage.Controls.Add(this.subjectCmbBox);
            this.classJournalTabPage.Controls.Add(this.label10);
            this.classJournalTabPage.Controls.Add(this.avgAllSubjectsText);
            this.classJournalTabPage.Controls.Add(this.avgAllSubjectsValue);
            this.classJournalTabPage.Controls.Add(this.label8);
            this.classJournalTabPage.Controls.Add(this.avgBySubjectLbl);
            this.classJournalTabPage.Controls.Add(this.classJournalStudentsDataGridView);
            this.classJournalTabPage.Controls.Add(this.classJournalMarksDataGridView);
            this.classJournalTabPage.Controls.Add(this.printStudentAVGBallBtn);
            this.classJournalTabPage.Controls.Add(this.classTeacherFullNameLbl);
            this.classJournalTabPage.Controls.Add(this.label6);
            this.classJournalTabPage.Controls.Add(this.classValueLabel);
            this.classJournalTabPage.Controls.Add(this.label3);
            this.classJournalTabPage.Location = new System.Drawing.Point(4, 22);
            this.classJournalTabPage.Name = "classJournalTabPage";
            this.classJournalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.classJournalTabPage.Size = new System.Drawing.Size(718, 467);
            this.classJournalTabPage.TabIndex = 1;
            this.classJournalTabPage.Text = "Журнал";
            this.classJournalTabPage.UseVisualStyleBackColor = true;
            // 
            // subjectCmbBox
            // 
            this.subjectCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectCmbBox.FormattingEnabled = true;
            this.subjectCmbBox.Location = new System.Drawing.Point(489, 139);
            this.subjectCmbBox.Name = "subjectCmbBox";
            this.subjectCmbBox.Size = new System.Drawing.Size(223, 32);
            this.subjectCmbBox.TabIndex = 90;
            this.subjectCmbBox.SelectedIndexChanged += new System.EventHandler(this.subjectCmbBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(386, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 24);
            this.label10.TabIndex = 89;
            this.label10.Text = "Предмет:";
            // 
            // avgAllSubjectsText
            // 
            this.avgAllSubjectsText.AutoSize = true;
            this.avgAllSubjectsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgAllSubjectsText.Location = new System.Drawing.Point(5, 413);
            this.avgAllSubjectsText.Name = "avgAllSubjectsText";
            this.avgAllSubjectsText.Size = new System.Drawing.Size(146, 16);
            this.avgAllSubjectsText.TabIndex = 88;
            this.avgAllSubjectsText.Text = "Общий средний балл:";
            // 
            // avgAllSubjectsValue
            // 
            this.avgAllSubjectsValue.AutoSize = true;
            this.avgAllSubjectsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgAllSubjectsValue.Location = new System.Drawing.Point(220, 413);
            this.avgAllSubjectsValue.Name = "avgAllSubjectsValue";
            this.avgAllSubjectsValue.Size = new System.Drawing.Size(51, 16);
            this.avgAllSubjectsValue.TabIndex = 87;
            this.avgAllSubjectsValue.Text = "<none>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(297, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 16);
            this.label8.TabIndex = 86;
            this.label8.Text = "Средний балл по предмету:";
            // 
            // avgBySubjectLbl
            // 
            this.avgBySubjectLbl.AutoSize = true;
            this.avgBySubjectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgBySubjectLbl.Location = new System.Drawing.Point(512, 413);
            this.avgBySubjectLbl.Name = "avgBySubjectLbl";
            this.avgBySubjectLbl.Size = new System.Drawing.Size(51, 16);
            this.avgBySubjectLbl.TabIndex = 85;
            this.avgBySubjectLbl.Text = "<none>";
            // 
            // classJournalStudentsDataGridView
            // 
            this.classJournalStudentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classJournalStudentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.classJournalStudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classJournalStudentsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.classJournalStudentsDataGridView.Location = new System.Drawing.Point(12, 195);
            this.classJournalStudentsDataGridView.Name = "classJournalStudentsDataGridView";
            this.classJournalStudentsDataGridView.Size = new System.Drawing.Size(263, 204);
            this.classJournalStudentsDataGridView.TabIndex = 84;
            this.classJournalStudentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classJournalStudentsDataGridView_CellClick);
            // 
            // classJournalMarksDataGridView
            // 
            this.classJournalMarksDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.classJournalMarksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classJournalMarksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classJournalMarksDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.classJournalMarksDataGridView.Location = new System.Drawing.Point(300, 195);
            this.classJournalMarksDataGridView.Name = "classJournalMarksDataGridView";
            this.classJournalMarksDataGridView.Size = new System.Drawing.Size(263, 204);
            this.classJournalMarksDataGridView.TabIndex = 83;
            // 
            // printStudentAVGBallBtn
            // 
            this.printStudentAVGBallBtn.Location = new System.Drawing.Point(618, 402);
            this.printStudentAVGBallBtn.Name = "printStudentAVGBallBtn";
            this.printStudentAVGBallBtn.Size = new System.Drawing.Size(94, 39);
            this.printStudentAVGBallBtn.TabIndex = 82;
            this.printStudentAVGBallBtn.Text = "Печать";
            this.printStudentAVGBallBtn.UseVisualStyleBackColor = true;
            this.printStudentAVGBallBtn.Click += new System.EventHandler(this.printStudentAVGBallBtn_Click);
            // 
            // classTeacherFullNameLbl
            // 
            this.classTeacherFullNameLbl.AutoSize = true;
            this.classTeacherFullNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classTeacherFullNameLbl.Location = new System.Drawing.Point(251, 46);
            this.classTeacherFullNameLbl.Name = "classTeacherFullNameLbl";
            this.classTeacherFullNameLbl.Size = new System.Drawing.Size(76, 24);
            this.classTeacherFullNameLbl.TabIndex = 26;
            this.classTeacherFullNameLbl.Text = "<none>";
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
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 493);
            this.Controls.Add(this.teacherTabControl);
            this.Name = "TeachersForm";
            this.Text = "Журнал учителя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeachersForm_FormClosing);
            this.teacherTabControl.ResumeLayout(false);
            this.lessonTabPage.ResumeLayout(false);
            this.lessonTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lessonStudentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonMarksDataGridView)).EndInit();
            this.classJournalTabPage.ResumeLayout(false);
            this.classJournalTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classJournalStudentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classJournalMarksDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl teacherTabControl;
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
        private System.Windows.Forms.DataGridView lessonMarksDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label classTeacherFullNameLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label classValueLabel;
        private System.Windows.Forms.Button printStudentAVGBallBtn;
        private System.Windows.Forms.DataGridView lessonStudentsDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox markComboBox;
        private System.Windows.Forms.Label avgSubjectLbl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label avgAllSubjectsText;
        private System.Windows.Forms.Label avgAllSubjectsValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label avgBySubjectLbl;
        private System.Windows.Forms.DataGridView classJournalStudentsDataGridView;
        private System.Windows.Forms.DataGridView classJournalMarksDataGridView;
        private System.Windows.Forms.ComboBox subjectCmbBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}