
namespace StudentsPerformance
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.addTeacherBtn = new System.Windows.Forms.Button();
            this.updateTeacherBtn = new System.Windows.Forms.Button();
            this.deleteTeacherBtn = new System.Windows.Forms.Button();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.quantityOfStaffLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addTeacherBtn
            // 
            this.addTeacherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTeacherBtn.Location = new System.Drawing.Point(11, 12);
            this.addTeacherBtn.Name = "addTeacherBtn";
            this.addTeacherBtn.Size = new System.Drawing.Size(138, 44);
            this.addTeacherBtn.TabIndex = 0;
            this.addTeacherBtn.Text = "Добавить";
            this.addTeacherBtn.UseVisualStyleBackColor = true;
            this.addTeacherBtn.Click += new System.EventHandler(this.addTeacherBtn_Click);
            // 
            // updateTeacherBtn
            // 
            this.updateTeacherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateTeacherBtn.Location = new System.Drawing.Point(12, 62);
            this.updateTeacherBtn.Name = "updateTeacherBtn";
            this.updateTeacherBtn.Size = new System.Drawing.Size(138, 44);
            this.updateTeacherBtn.TabIndex = 1;
            this.updateTeacherBtn.Text = "Изменить";
            this.updateTeacherBtn.UseVisualStyleBackColor = true;
            this.updateTeacherBtn.Click += new System.EventHandler(this.updateTeacherBtn_Click);
            // 
            // deleteTeacherBtn
            // 
            this.deleteTeacherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteTeacherBtn.Location = new System.Drawing.Point(12, 112);
            this.deleteTeacherBtn.Name = "deleteTeacherBtn";
            this.deleteTeacherBtn.Size = new System.Drawing.Size(138, 44);
            this.deleteTeacherBtn.TabIndex = 2;
            this.deleteTeacherBtn.Text = "Удалить";
            this.deleteTeacherBtn.UseVisualStyleBackColor = true;
            this.deleteTeacherBtn.Click += new System.EventHandler(this.deleteTeacherBtn_Click);
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Location = new System.Drawing.Point(1, 189);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.Size = new System.Drawing.Size(753, 262);
            this.staffDataGridView.TabIndex = 3;
            // 
            // quantityOfStaffLbl
            // 
            this.quantityOfStaffLbl.AutoSize = true;
            this.quantityOfStaffLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityOfStaffLbl.Location = new System.Drawing.Point(641, 22);
            this.quantityOfStaffLbl.Name = "quantityOfStaffLbl";
            this.quantityOfStaffLbl.Size = new System.Drawing.Size(76, 24);
            this.quantityOfStaffLbl.TabIndex = 5;
            this.quantityOfStaffLbl.Text = "<none>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(388, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Колличество персонала:";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 454);
            this.Controls.Add(this.quantityOfStaffLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.staffDataGridView);
            this.Controls.Add(this.deleteTeacherBtn);
            this.Controls.Add(this.updateTeacherBtn);
            this.Controls.Add(this.addTeacherBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Персонал";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffForm_FormClosing);
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTeacherBtn;
        private System.Windows.Forms.Button updateTeacherBtn;
        private System.Windows.Forms.Button deleteTeacherBtn;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.Label quantityOfStaffLbl;
        private System.Windows.Forms.Label label4;
    }
}