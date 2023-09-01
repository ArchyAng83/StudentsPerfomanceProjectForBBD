
namespace StudentsPerfomance
{
    partial class AddStudentToClassJournal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentToClassJournal));
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.addStudentDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudentBtn.Location = new System.Drawing.Point(201, 281);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(163, 39);
            this.addStudentBtn.TabIndex = 9;
            this.addStudentBtn.Text = "Добавить учащегося";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // addStudentDataGridView
            // 
            this.addStudentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addStudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addStudentDataGridView.Location = new System.Drawing.Point(12, 12);
            this.addStudentDataGridView.Name = "addStudentDataGridView";
            this.addStudentDataGridView.Size = new System.Drawing.Size(526, 246);
            this.addStudentDataGridView.TabIndex = 10;
            // 
            // AddStudentToClassJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 353);
            this.Controls.Add(this.addStudentDataGridView);
            this.Controls.Add(this.addStudentBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStudentToClassJournal";
            this.Text = "Добавить учащегося в журнал оценок";
            this.Load += new System.EventHandler(this.AddStudentToClassJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addStudentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.DataGridView addStudentDataGridView;
    }
}