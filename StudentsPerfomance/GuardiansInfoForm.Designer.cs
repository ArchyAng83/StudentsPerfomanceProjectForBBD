
namespace StudentsPerfomance
{
    partial class GuardiansInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuardiansInfoForm));
            this.guardiansInfoDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.guardiansInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // guardiansInfoDataGridView
            // 
            this.guardiansInfoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guardiansInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guardiansInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guardiansInfoDataGridView.Location = new System.Drawing.Point(0, 2);
            this.guardiansInfoDataGridView.Name = "guardiansInfoDataGridView";
            this.guardiansInfoDataGridView.Size = new System.Drawing.Size(625, 241);
            this.guardiansInfoDataGridView.TabIndex = 0;
            // 
            // GuardiansInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 245);
            this.Controls.Add(this.guardiansInfoDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuardiansInfoForm";
            this.Text = "Информация об опекунах";
            this.Load += new System.EventHandler(this.GuardiansInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guardiansInfoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView guardiansInfoDataGridView;
    }
}