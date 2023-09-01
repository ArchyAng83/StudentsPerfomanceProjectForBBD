
namespace StudentsPerfomance
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
            this.addLessonBtn = new System.Windows.Forms.Button();
            this.deleteLessonBtn = new System.Windows.Forms.Button();
            this.updateLessonBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.classLessonCmbBox = new System.Windows.Forms.ComboBox();
            this.subjectNameLabel = new System.Windows.Forms.Label();
            this.teacherFullNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveLessonBtn = new System.Windows.Forms.Button();
            this.lessonDataGridView = new System.Windows.Forms.DataGridView();
            this.classJournalTabPage = new System.Windows.Forms.TabPage();
            this.classJournalBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.classJournalCmbBox = new System.Windows.Forms.ComboBox();
            this.classJournalDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.lessonTabPage.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(800, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // lessonTabPage
            // 
            this.lessonTabPage.Controls.Add(this.addLessonBtn);
            this.lessonTabPage.Controls.Add(this.deleteLessonBtn);
            this.lessonTabPage.Controls.Add(this.updateLessonBtn);
            this.lessonTabPage.Controls.Add(this.label5);
            this.lessonTabPage.Controls.Add(this.classLessonCmbBox);
            this.lessonTabPage.Controls.Add(this.subjectNameLabel);
            this.lessonTabPage.Controls.Add(this.teacherFullNameLabel);
            this.lessonTabPage.Controls.Add(this.label2);
            this.lessonTabPage.Controls.Add(this.label1);
            this.lessonTabPage.Controls.Add(this.saveLessonBtn);
            this.lessonTabPage.Controls.Add(this.lessonDataGridView);
            this.lessonTabPage.Location = new System.Drawing.Point(4, 22);
            this.lessonTabPage.Name = "lessonTabPage";
            this.lessonTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.lessonTabPage.Size = new System.Drawing.Size(792, 460);
            this.lessonTabPage.TabIndex = 0;
            this.lessonTabPage.Text = "Урок";
            this.lessonTabPage.UseVisualStyleBackColor = true;
            // 
            // addLessonBtn
            // 
            this.addLessonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addLessonBtn.Location = new System.Drawing.Point(8, 15);
            this.addLessonBtn.Name = "addLessonBtn";
            this.addLessonBtn.Size = new System.Drawing.Size(181, 34);
            this.addLessonBtn.TabIndex = 23;
            this.addLessonBtn.Text = "Добавить";
            this.addLessonBtn.UseVisualStyleBackColor = true;
            this.addLessonBtn.Click += new System.EventHandler(this.addLessonBtn_Click);
            // 
            // deleteLessonBtn
            // 
            this.deleteLessonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteLessonBtn.Location = new System.Drawing.Point(8, 98);
            this.deleteLessonBtn.Name = "deleteLessonBtn";
            this.deleteLessonBtn.Size = new System.Drawing.Size(181, 34);
            this.deleteLessonBtn.TabIndex = 22;
            this.deleteLessonBtn.Text = "Удалить";
            this.deleteLessonBtn.UseVisualStyleBackColor = true;
            this.deleteLessonBtn.Click += new System.EventHandler(this.deleteLessonBtn_Click);
            // 
            // updateLessonBtn
            // 
            this.updateLessonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateLessonBtn.Location = new System.Drawing.Point(650, 98);
            this.updateLessonBtn.Name = "updateLessonBtn";
            this.updateLessonBtn.Size = new System.Drawing.Size(109, 23);
            this.updateLessonBtn.TabIndex = 21;
            this.updateLessonBtn.Text = "Обновить";
            this.updateLessonBtn.UseVisualStyleBackColor = true;
            this.updateLessonBtn.Click += new System.EventHandler(this.updateLessonBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(628, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Класс:";
            // 
            // classLessonCmbBox
            // 
            this.classLessonCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classLessonCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classLessonCmbBox.FormattingEnabled = true;
            this.classLessonCmbBox.Location = new System.Drawing.Point(703, 42);
            this.classLessonCmbBox.Name = "classLessonCmbBox";
            this.classLessonCmbBox.Size = new System.Drawing.Size(56, 28);
            this.classLessonCmbBox.TabIndex = 19;
            // 
            // subjectNameLabel
            // 
            this.subjectNameLabel.AutoSize = true;
            this.subjectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectNameLabel.Location = new System.Drawing.Point(386, 43);
            this.subjectNameLabel.Name = "subjectNameLabel";
            this.subjectNameLabel.Size = new System.Drawing.Size(58, 16);
            this.subjectNameLabel.TabIndex = 18;
            this.subjectNameLabel.Text = "<none>";
            // 
            // teacherFullNameLabel
            // 
            this.teacherFullNameLabel.AutoSize = true;
            this.teacherFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherFullNameLabel.Location = new System.Drawing.Point(386, 15);
            this.teacherFullNameLabel.Name = "teacherFullNameLabel";
            this.teacherFullNameLabel.Size = new System.Drawing.Size(58, 16);
            this.teacherFullNameLabel.TabIndex = 17;
            this.teacherFullNameLabel.Text = "<none>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(246, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Предмет:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(246, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Преподаватель:";
            // 
            // saveLessonBtn
            // 
            this.saveLessonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveLessonBtn.Location = new System.Drawing.Point(8, 55);
            this.saveLessonBtn.Name = "saveLessonBtn";
            this.saveLessonBtn.Size = new System.Drawing.Size(181, 34);
            this.saveLessonBtn.TabIndex = 14;
            this.saveLessonBtn.Text = "Сохранить";
            this.saveLessonBtn.UseVisualStyleBackColor = true;
            this.saveLessonBtn.Click += new System.EventHandler(this.saveLessonBtn_Click);
            // 
            // lessonDataGridView
            // 
            this.lessonDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lessonDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lessonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lessonDataGridView.Location = new System.Drawing.Point(-4, 161);
            this.lessonDataGridView.Name = "lessonDataGridView";
            this.lessonDataGridView.Size = new System.Drawing.Size(800, 307);
            this.lessonDataGridView.TabIndex = 13;
            // 
            // classJournalTabPage
            // 
            this.classJournalTabPage.Controls.Add(this.classJournalBtn);
            this.classJournalTabPage.Controls.Add(this.label3);
            this.classJournalTabPage.Controls.Add(this.classJournalCmbBox);
            this.classJournalTabPage.Controls.Add(this.classJournalDataGridView);
            this.classJournalTabPage.Location = new System.Drawing.Point(4, 22);
            this.classJournalTabPage.Name = "classJournalTabPage";
            this.classJournalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.classJournalTabPage.Size = new System.Drawing.Size(792, 460);
            this.classJournalTabPage.TabIndex = 1;
            this.classJournalTabPage.Text = "Журнал";
            this.classJournalTabPage.UseVisualStyleBackColor = true;
            // 
            // classJournalBtn
            // 
            this.classJournalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classJournalBtn.Location = new System.Drawing.Point(669, 67);
            this.classJournalBtn.Name = "classJournalBtn";
            this.classJournalBtn.Size = new System.Drawing.Size(109, 23);
            this.classJournalBtn.TabIndex = 24;
            this.classJournalBtn.Text = "Обновить";
            this.classJournalBtn.UseVisualStyleBackColor = true;
            this.classJournalBtn.Click += new System.EventHandler(this.classJournalBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(647, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Класс:";
            // 
            // classJournalCmbBox
            // 
            this.classJournalCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classJournalCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classJournalCmbBox.FormattingEnabled = true;
            this.classJournalCmbBox.Location = new System.Drawing.Point(722, 11);
            this.classJournalCmbBox.Name = "classJournalCmbBox";
            this.classJournalCmbBox.Size = new System.Drawing.Size(56, 28);
            this.classJournalCmbBox.TabIndex = 22;
            // 
            // classJournalDataGridView
            // 
            this.classJournalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classJournalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classJournalDataGridView.Location = new System.Drawing.Point(0, 108);
            this.classJournalDataGridView.Name = "classJournalDataGridView";
            this.classJournalDataGridView.Size = new System.Drawing.Size(792, 349);
            this.classJournalDataGridView.TabIndex = 0;
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.tabControl1);
            this.Name = "TeachersForm";
            this.Text = "Журнал учителя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeachersForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.lessonTabPage.ResumeLayout(false);
            this.lessonTabPage.PerformLayout();
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
        private System.Windows.Forms.Button addLessonBtn;
        private System.Windows.Forms.Button deleteLessonBtn;
        private System.Windows.Forms.Button updateLessonBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox classLessonCmbBox;
        private System.Windows.Forms.Label subjectNameLabel;
        private System.Windows.Forms.Label teacherFullNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveLessonBtn;
        private System.Windows.Forms.DataGridView lessonDataGridView;
        private System.Windows.Forms.DataGridView classJournalDataGridView;
        private System.Windows.Forms.Button classJournalBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox classJournalCmbBox;
    }
}