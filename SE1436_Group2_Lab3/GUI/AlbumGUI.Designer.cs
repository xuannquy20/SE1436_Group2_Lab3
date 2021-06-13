
namespace SE1426_Group2_Lab3.GUI
{
    partial class AlbumGUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.albumsData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.albumsData)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create a new album";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // albumsData
            // 
            this.albumsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.albumsData.Location = new System.Drawing.Point(12, 61);
            this.albumsData.Name = "albumsData";
            this.albumsData.RowHeadersWidth = 51;
            this.albumsData.RowTemplate.Height = 24;
            this.albumsData.Size = new System.Drawing.Size(944, 386);
            this.albumsData.TabIndex = 1;
            this.albumsData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.albumsData_CellClick);
            // 
            // AlbumGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 459);
            this.Controls.Add(this.albumsData);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlbumGUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AlbumGUI";
            this.Load += new System.EventHandler(this.AlbumGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.albumsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView albumsData;
    }
}