
namespace StudentsPerfomance
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.quantityOfStudentsLbl = new System.Windows.Forms.Label();
            this.avgSchoolLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.avgMarkSubjectBtn = new System.Windows.Forms.Button();
            this.avgMarkClassBtn = new System.Windows.Forms.Button();
            this.resultReportDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultReportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество учащихся:";
            // 
            // quantityOfStudentsLbl
            // 
            this.quantityOfStudentsLbl.AutoSize = true;
            this.quantityOfStudentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityOfStudentsLbl.Location = new System.Drawing.Point(284, 26);
            this.quantityOfStudentsLbl.Name = "quantityOfStudentsLbl";
            this.quantityOfStudentsLbl.Size = new System.Drawing.Size(76, 24);
            this.quantityOfStudentsLbl.TabIndex = 1;
            this.quantityOfStudentsLbl.Text = "<none>";
            // 
            // avgSchoolLbl
            // 
            this.avgSchoolLbl.AutoSize = true;
            this.avgSchoolLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgSchoolLbl.Location = new System.Drawing.Point(284, 115);
            this.avgSchoolLbl.Name = "avgSchoolLbl";
            this.avgSchoolLbl.Size = new System.Drawing.Size(76, 24);
            this.avgSchoolLbl.TabIndex = 5;
            this.avgSchoolLbl.Text = "<none>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(31, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Средний балл по школе:";
            // 
            // avgMarkSubjectBtn
            // 
            this.avgMarkSubjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgMarkSubjectBtn.Location = new System.Drawing.Point(35, 193);
            this.avgMarkSubjectBtn.Name = "avgMarkSubjectBtn";
            this.avgMarkSubjectBtn.Size = new System.Drawing.Size(155, 52);
            this.avgMarkSubjectBtn.TabIndex = 6;
            this.avgMarkSubjectBtn.Text = "Средний балл \r\nпо предметам";
            this.avgMarkSubjectBtn.UseVisualStyleBackColor = true;
            this.avgMarkSubjectBtn.Click += new System.EventHandler(this.avgMarkSubjectBtn_Click);
            // 
            // avgMarkClassBtn
            // 
            this.avgMarkClassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgMarkClassBtn.Location = new System.Drawing.Point(35, 280);
            this.avgMarkClassBtn.Name = "avgMarkClassBtn";
            this.avgMarkClassBtn.Size = new System.Drawing.Size(155, 55);
            this.avgMarkClassBtn.TabIndex = 7;
            this.avgMarkClassBtn.Text = "Средний балл\r\nпо классам";
            this.avgMarkClassBtn.UseVisualStyleBackColor = true;
            this.avgMarkClassBtn.Click += new System.EventHandler(this.avgMarkClassBtn_Click);
            // 
            // resultReportDataGridView
            // 
            this.resultReportDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resultReportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultReportDataGridView.Location = new System.Drawing.Point(236, 193);
            this.resultReportDataGridView.Name = "resultReportDataGridView";
            this.resultReportDataGridView.Size = new System.Drawing.Size(348, 245);
            this.resultReportDataGridView.TabIndex = 8;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.resultReportDataGridView);
            this.Controls.Add(this.avgMarkClassBtn);
            this.Controls.Add(this.avgMarkSubjectBtn);
            this.Controls.Add(this.avgSchoolLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantityOfStudentsLbl);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчеты";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultReportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quantityOfStudentsLbl;
        private System.Windows.Forms.Label avgSchoolLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button avgMarkSubjectBtn;
        private System.Windows.Forms.Button avgMarkClassBtn;
        private System.Windows.Forms.DataGridView resultReportDataGridView;
    }
}