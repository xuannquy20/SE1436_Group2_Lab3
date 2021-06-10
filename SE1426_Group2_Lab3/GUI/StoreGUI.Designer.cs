
namespace SE1426_Group2_Lab3.GUI
{
    partial class StoreGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreGUI));
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicStoreDataSet1 = new SE1426_Group2_Lab3.MusicStoreDataSet1();
            this.genresTableAdapter = new SE1426_Group2_Lab3.MusicStoreDataSet1TableAdapters.GenresTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.musicStoreDataSet2 = new SE1426_Group2_Lab3.MusicStoreDataSet2();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new SE1426_Group2_Lab3.MusicStoreDataSet2TableAdapters.AlbumsTableAdapter();
            this.NameGenres = new System.Windows.Forms.DataGridView();
            this.Albums = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicStoreDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Albums)).BeginInit();
            this.SuspendLayout();
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.musicStoreDataSet1;
            // 
            // musicStoreDataSet1
            // 
            this.musicStoreDataSet1.DataSetName = "MusicStoreDataSet1";
            this.musicStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(696, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // musicStoreDataSet2
            // 
            this.musicStoreDataSet2.DataSetName = "MusicStoreDataSet2";
            this.musicStoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.musicStoreDataSet2;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // NameGenres
            // 
            this.NameGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NameGenres.Location = new System.Drawing.Point(12, 12);
            this.NameGenres.Name = "NameGenres";
            this.NameGenres.ReadOnly = true;
            this.NameGenres.RowHeadersWidth = 51;
            this.NameGenres.RowTemplate.Height = 24;
            this.NameGenres.Size = new System.Drawing.Size(242, 235);
            this.NameGenres.TabIndex = 5;
            this.NameGenres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NameGenres_CellClick);
            this.NameGenres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NameGenres_CellContentClick);
            // 
            // Albums
            // 
            this.Albums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Albums.Location = new System.Drawing.Point(13, 254);
            this.Albums.Name = "Albums";
            this.Albums.RowHeadersWidth = 51;
            this.Albums.RowTemplate.Height = 24;
            this.Albums.Size = new System.Drawing.Size(943, 206);
            this.Albums.TabIndex = 6;
            this.Albums.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Albums_CellClick);
            this.Albums.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // StoreGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(968, 472);
            this.Controls.Add(this.Albums);
            this.Controls.Add(this.NameGenres);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoreGUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicStoreDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Albums)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MusicStoreDataSet1 musicStoreDataSet1;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private MusicStoreDataSet1TableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MusicStoreDataSet2 musicStoreDataSet2;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private MusicStoreDataSet2TableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.DataGridView NameGenres;
        private System.Windows.Forms.DataGridView Albums;
    }
}