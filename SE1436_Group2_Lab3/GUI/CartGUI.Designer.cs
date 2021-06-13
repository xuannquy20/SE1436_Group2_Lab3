
namespace SE1426_Group2_Lab3.GUI
{
    partial class CartGUI
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
            this.btnCheckout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.CartTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CartTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Black;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(26, 47);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(139, 33);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Checkout >>";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(599, 53);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(127, 22);
            this.TotalTextBox.TabIndex = 2;
            // 
            // CartTable
            // 
            this.CartTable.AllowUserToAddRows = false;
            this.CartTable.AllowUserToDeleteRows = false;
            this.CartTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartTable.Location = new System.Drawing.Point(26, 116);
            this.CartTable.Name = "CartTable";
            this.CartTable.RowHeadersWidth = 51;
            this.CartTable.RowTemplate.Height = 24;
            this.CartTable.Size = new System.Drawing.Size(700, 193);
            this.CartTable.TabIndex = 3;
            this.CartTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartTable_CellClick);
            // 
            // CartGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(748, 321);
            this.Controls.Add(this.CartTable);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CartGUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.Activated += new System.EventHandler(this.CartGUI_Activated);
            this.Load += new System.EventHandler(this.CartGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CartTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalTextBox;
        public System.Windows.Forms.DataGridView CartTable;
    }
}