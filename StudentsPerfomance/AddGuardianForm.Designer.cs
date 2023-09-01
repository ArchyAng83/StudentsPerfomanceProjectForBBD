
namespace StudentsPerfomance
{
    partial class AddGuardianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGuardianForm));
            this.saveGuardianDataBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fullNameGuardianTextBox = new System.Windows.Forms.TextBox();
            this.phoneGuardianTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveGuardianDataBtn
            // 
            this.saveGuardianDataBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveGuardianDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveGuardianDataBtn.Location = new System.Drawing.Point(138, 266);
            this.saveGuardianDataBtn.Name = "saveGuardianDataBtn";
            this.saveGuardianDataBtn.Size = new System.Drawing.Size(231, 47);
            this.saveGuardianDataBtn.TabIndex = 3;
            this.saveGuardianDataBtn.Text = "Сохранить";
            this.saveGuardianDataBtn.UseVisualStyleBackColor = true;
            this.saveGuardianDataBtn.Click += new System.EventHandler(this.saveGuardianDataBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // fullNameGuardianTextBox
            // 
            this.fullNameGuardianTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameGuardianTextBox.Location = new System.Drawing.Point(138, 48);
            this.fullNameGuardianTextBox.Name = "fullNameGuardianTextBox";
            this.fullNameGuardianTextBox.Size = new System.Drawing.Size(329, 29);
            this.fullNameGuardianTextBox.TabIndex = 5;
            // 
            // phoneGuardianTextBox
            // 
            this.phoneGuardianTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneGuardianTextBox.Location = new System.Drawing.Point(138, 113);
            this.phoneGuardianTextBox.Name = "phoneGuardianTextBox";
            this.phoneGuardianTextBox.Size = new System.Drawing.Size(329, 29);
            this.phoneGuardianTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Телефон";
            // 
            // AddGuardianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 363);
            this.Controls.Add(this.phoneGuardianTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullNameGuardianTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveGuardianDataBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddGuardianForm";
            this.Text = "Добавить опекуна";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveGuardianDataBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fullNameGuardianTextBox;
        private System.Windows.Forms.TextBox phoneGuardianTextBox;
        private System.Windows.Forms.Label label2;
    }
}