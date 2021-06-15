
namespace SE1426_Group2_Lab3.GUI
{
    partial class ReportGUI
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.OrderGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderDetailGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textFrom = new System.Windows.Forms.TextBox();
            this.textTo = new System.Windows.Forms.TextBox();
            this.textFname = new System.Windows.Forms.TextBox();
            this.textCountry = new System.Windows.Forms.TextBox();
            this.btFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 9);
            this.monthCalendar1.MaxSelectionCount = 31;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // OrderGridView1
            // 
            this.OrderGridView1.AllowUserToAddRows = false;
            this.OrderGridView1.AllowUserToDeleteRows = false;
            this.OrderGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView1.Location = new System.Drawing.Point(335, 29);
            this.OrderGridView1.Name = "OrderGridView1";
            this.OrderGridView1.ReadOnly = true;
            this.OrderGridView1.RowHeadersWidth = 51;
            this.OrderGridView1.RowTemplate.Height = 24;
            this.OrderGridView1.Size = new System.Drawing.Size(564, 235);
            this.OrderGridView1.TabIndex = 1;
            this.OrderGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Order_CellClick);
            // 
            // OrderDetailGridView2
            // 
            this.OrderDetailGridView2.AllowUserToAddRows = false;
            this.OrderDetailGridView2.AllowUserToDeleteRows = false;
            this.OrderDetailGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDetailGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetailGridView2.Location = new System.Drawing.Point(335, 300);
            this.OrderDetailGridView2.Name = "OrderDetailGridView2";
            this.OrderDetailGridView2.ReadOnly = true;
            this.OrderDetailGridView2.RowHeadersWidth = 51;
            this.OrderDetailGridView2.RowTemplate.Height = 24;
            this.OrderDetailGridView2.Size = new System.Drawing.Size(446, 150);
            this.OrderDetailGridView2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "First name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Country:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Order:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Order detail:";
            // 
            // textFrom
            // 
            this.textFrom.Location = new System.Drawing.Point(142, 242);
            this.textFrom.Name = "textFrom";
            this.textFrom.ReadOnly = true;
            this.textFrom.Size = new System.Drawing.Size(113, 22);
            this.textFrom.TabIndex = 9;
            // 
            // textTo
            // 
            this.textTo.Location = new System.Drawing.Point(142, 277);
            this.textTo.Name = "textTo";
            this.textTo.ReadOnly = true;
            this.textTo.Size = new System.Drawing.Size(113, 22);
            this.textTo.TabIndex = 10;
            // 
            // textFname
            // 
            this.textFname.Location = new System.Drawing.Point(142, 314);
            this.textFname.Name = "textFname";
            this.textFname.Size = new System.Drawing.Size(113, 22);
            this.textFname.TabIndex = 11;
            this.textFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFname_KeyPress);
            // 
            // textCountry
            // 
            this.textCountry.Location = new System.Drawing.Point(142, 350);
            this.textCountry.Name = "textCountry";
            this.textCountry.Size = new System.Drawing.Size(113, 22);
            this.textCountry.TabIndex = 12;
            this.textCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCountry_KeyPress);
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(142, 394);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(75, 23);
            this.btFilter.TabIndex = 13;
            this.btFilter.Text = "Filter";
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 472);
            this.Controls.Add(this.btFilter);
            this.Controls.Add(this.textCountry);
            this.Controls.Add(this.textFname);
            this.Controls.Add(this.textTo);
            this.Controls.Add(this.textFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderDetailGridView2);
            this.Controls.Add(this.OrderGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportGUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ReportGUI";
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView OrderGridView1;
        private System.Windows.Forms.DataGridView OrderDetailGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textFrom;
        private System.Windows.Forms.TextBox textTo;
        private System.Windows.Forms.TextBox textFname;
        private System.Windows.Forms.TextBox textCountry;
        private System.Windows.Forms.Button btFilter;
    }
}