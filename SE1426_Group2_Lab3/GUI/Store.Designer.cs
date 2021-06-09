
namespace SE1426_Group2_Lab3.GUI
{
    partial class Store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicStoreDataSet1 = new SE1426_Group2_Lab3.MusicStoreDataSet1();
            this.genresTableAdapter = new SE1426_Group2_Lab3.MusicStoreDataSet1TableAdapters.GenresTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.musicStoreDataSet2 = new SE1426_Group2_Lab3.MusicStoreDataSet2();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new SE1426_Group2_Lab3.MusicStoreDataSet2TableAdapters.AlbumsTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AlbumsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenresID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicStoreDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.genresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(374, 235);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // C1
            // 
            this.C1.DataPropertyName = "NameGenres";
            this.C1.HeaderText = "Name";
            this.C1.MinimumWidth = 6;
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            this.C1.Width = 323;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
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
            this.pictureBox1.Location = new System.Drawing.Point(392, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 235);
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
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detail,
            this.AlbumsID,
            this.GenresID,
            this.ArtistID,
            this.Title,
            this.Price,
            this.AlbumUrl});
            this.dataGridView3.Location = new System.Drawing.Point(12, 253);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(944, 198);
            this.dataGridView3.TabIndex = 4;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.MinimumWidth = 6;
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Detail.Width = 60;
            // 
            // AlbumsID
            // 
            this.AlbumsID.HeaderText = "AlbumsID";
            this.AlbumsID.MinimumWidth = 6;
            this.AlbumsID.Name = "AlbumsID";
            this.AlbumsID.ReadOnly = true;
            this.AlbumsID.Width = 125;
            // 
            // GenresID
            // 
            this.GenresID.HeaderText = "GenresID";
            this.GenresID.MinimumWidth = 6;
            this.GenresID.Name = "GenresID";
            this.GenresID.ReadOnly = true;
            this.GenresID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GenresID.Width = 125;
            // 
            // ArtistID
            // 
            this.ArtistID.HeaderText = "ArtistID";
            this.ArtistID.MinimumWidth = 6;
            this.ArtistID.Name = "ArtistID";
            this.ArtistID.ReadOnly = true;
            this.ArtistID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ArtistID.Width = 125;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Title.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.Width = 125;
            // 
            // AlbumUrl
            // 
            this.AlbumUrl.HeaderText = "AlbumUrl";
            this.AlbumUrl.MinimumWidth = 6;
            this.AlbumUrl.Name = "AlbumUrl";
            this.AlbumUrl.ReadOnly = true;
            this.AlbumUrl.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AlbumUrl.Width = 125;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(968, 472);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Store";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicStoreDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MusicStoreDataSet1 musicStoreDataSet1;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private MusicStoreDataSet1TableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MusicStoreDataSet2 musicStoreDataSet2;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private MusicStoreDataSet2TableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenresID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumUrl;
    }
}