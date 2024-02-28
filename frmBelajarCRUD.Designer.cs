namespace belajarCRUD
{
    partial class frmBelajarCRUD
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
            panel1 = new Panel();
            Materi = new Label();
            dgvCRUD = new DataGridView();
            pbGambar = new PictureBox();
            btnHapus = new Button();
            btnUbah = new Button();
            btnSimpan = new Button();
            btnCari = new Button();
            lbl_namabarang = new Label();
            txtDeskripsi = new TextBox();
            txtNamabarang = new TextBox();
            lbl_deskripsi = new Label();
            txtId = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCRUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGambar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(Materi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 59);
            panel1.TabIndex = 12;
            // 
            // Materi
            // 
            Materi.AutoSize = true;
            Materi.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Materi.ForeColor = Color.Black;
            Materi.Location = new Point(15, 12);
            Materi.Name = "Materi";
            Materi.Size = new Size(443, 30);
            Materi.TabIndex = 0;
            Materi.Text = "Belajar CRUD (Create, Read, Update, Delete)\r\n";
            // 
            // dgvCRUD
            // 
            dgvCRUD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCRUD.Location = new Point(443, 97);
            dgvCRUD.Name = "dgvCRUD";
            dgvCRUD.RowTemplate.Height = 25;
            dgvCRUD.Size = new Size(302, 336);
            dgvCRUD.TabIndex = 22;
            dgvCRUD.CellContentClick += dgvCRUD_CellContentClick;
            // 
            // pbGambar
            // 
            pbGambar.BackColor = SystemColors.ControlDark;
            pbGambar.Location = new Point(136, 155);
            pbGambar.Name = "pbGambar";
            pbGambar.Size = new Size(290, 219);
            pbGambar.TabIndex = 21;
            pbGambar.TabStop = false;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(370, 409);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(56, 23);
            btnHapus.TabIndex = 20;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnUbah
            // 
            btnUbah.Location = new Point(308, 409);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(56, 23);
            btnUbah.TabIndex = 19;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = true;
            btnUbah.Click += btnUbah_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(246, 409);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(56, 23);
            btnSimpan.TabIndex = 18;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(335, 380);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(91, 23);
            btnCari.TabIndex = 17;
            btnCari.Text = "Pilih Gambar";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // lbl_namabarang
            // 
            lbl_namabarang.AutoSize = true;
            lbl_namabarang.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_namabarang.Location = new Point(18, 97);
            lbl_namabarang.Name = "lbl_namabarang";
            lbl_namabarang.Size = new Size(100, 20);
            lbl_namabarang.TabIndex = 16;
            lbl_namabarang.Text = "Nama Barang\r\n";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(136, 126);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(290, 23);
            txtDeskripsi.TabIndex = 15;
            // 
            // txtNamabarang
            // 
            txtNamabarang.Location = new Point(136, 97);
            txtNamabarang.Name = "txtNamabarang";
            txtNamabarang.Size = new Size(290, 23);
            txtNamabarang.TabIndex = 14;
            // 
            // lbl_deskripsi
            // 
            lbl_deskripsi.AutoSize = true;
            lbl_deskripsi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_deskripsi.Location = new Point(18, 126);
            lbl_deskripsi.Name = "lbl_deskripsi";
            lbl_deskripsi.Size = new Size(69, 20);
            lbl_deskripsi.TabIndex = 13;
            lbl_deskripsi.Text = "Deskripsi";
            // 
            // txtId
            // 
            txtId.Location = new Point(18, 166);
            txtId.Name = "txtId";
            txtId.Size = new Size(49, 23);
            txtId.TabIndex = 23;
            // 
            // frmBelajarCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtId);
            Controls.Add(panel1);
            Controls.Add(dgvCRUD);
            Controls.Add(pbGambar);
            Controls.Add(btnHapus);
            Controls.Add(btnUbah);
            Controls.Add(btnSimpan);
            Controls.Add(btnCari);
            Controls.Add(lbl_namabarang);
            Controls.Add(txtDeskripsi);
            Controls.Add(txtNamabarang);
            Controls.Add(lbl_deskripsi);
            Name = "frmBelajarCRUD";
            Text = "frmBelajarCRUD";
            Load += FrmBelajarCRUD_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCRUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGambar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Materi;
        private DataGridView dgvCRUD;
        private PictureBox pbGambar;
        private Button btnHapus;
        private Button btnUbah;
        private Button btnSimpan;
        private Button btnCari;
        private Label lbl_namabarang;
        private TextBox txtDeskripsi;
        private TextBox txtNamabarang;
        private Label lbl_deskripsi;
        private TextBox txtId;
    }
}