
namespace StudentsPerfomance
{
    partial class AddGuardianFromListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGuardianFromListForm));
            this.addGuardianFromListBtn = new System.Windows.Forms.Button();
            this.guardiansDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.guardiansDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addGuardianFromListBtn
            // 
            this.addGuardianFromListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addGuardianFromListBtn.Location = new System.Drawing.Point(25, 31);
            this.addGuardianFromListBtn.Name = "addGuardianFromListBtn";
            this.addGuardianFromListBtn.Size = new System.Drawing.Size(196, 43);
            this.addGuardianFromListBtn.TabIndex = 3;
            this.addGuardianFromListBtn.Text = "Добавить опекуна";
            this.addGuardianFromListBtn.UseVisualStyleBackColor = true;
            this.addGuardianFromListBtn.Click += new System.EventHandler(this.addGuardianFromListBtn_Click);
            // 
            // guardiansDataGridView
            // 
            this.guardiansDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guardiansDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guardiansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guardiansDataGridView.Location = new System.Drawing.Point(0, 109);
            this.guardiansDataGridView.Name = "guardiansDataGridView";
            this.guardiansDataGridView.Size = new System.Drawing.Size(801, 340);
            this.guardiansDataGridView.TabIndex = 2;
            // 
            // AddGuardianFromListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addGuardianFromListBtn);
            this.Controls.Add(this.guardiansDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddGuardianFromListForm";
            this.Text = "Список опекунов";
            this.Load += new System.EventHandler(this.AddGuardianFromListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guardiansDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addGuardianFromListBtn;
        private System.Windows.Forms.DataGridView guardiansDataGridView;
    }
}