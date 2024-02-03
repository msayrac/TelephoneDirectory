namespace TelephoneDirectory
{
	partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.BtnTemizle = new System.Windows.Forms.Button();
			this.BtnGuncelle = new System.Windows.Forms.Button();
			this.BtnSil = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TxtEmail = new System.Windows.Forms.TextBox();
			this.MasketTelefon = new System.Windows.Forms.MaskedTextBox();
			this.TxtSoyad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.BtnEkle = new System.Windows.Forms.Button();
			this.TxtID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(681, 403);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rehber";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 26);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(675, 374);
			this.dataGridView1.TabIndex = 25;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.BtnTemizle);
			this.groupBox2.Controls.Add(this.BtnGuncelle);
			this.groupBox2.Controls.Add(this.BtnSil);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.TxtEmail);
			this.groupBox2.Controls.Add(this.MasketTelefon);
			this.groupBox2.Controls.Add(this.TxtSoyad);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.TxtAd);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.BtnEkle);
			this.groupBox2.Controls.Add(this.TxtID);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(699, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(500, 403);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Yeni Kişi";
			// 
			// BtnTemizle
			// 
			this.BtnTemizle.Location = new System.Drawing.Point(256, 342);
			this.BtnTemizle.Name = "BtnTemizle";
			this.BtnTemizle.Size = new System.Drawing.Size(142, 39);
			this.BtnTemizle.TabIndex = 8;
			this.BtnTemizle.Text = "Temizle";
			this.BtnTemizle.UseVisualStyleBackColor = true;
			this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.Location = new System.Drawing.Point(115, 342);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(135, 39);
			this.BtnGuncelle.TabIndex = 7;
			this.BtnGuncelle.Text = "Güncelle";
			this.BtnGuncelle.UseVisualStyleBackColor = true;
			this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
			// 
			// BtnSil
			// 
			this.BtnSil.Location = new System.Drawing.Point(256, 297);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(142, 39);
			this.BtnSil.TabIndex = 6;
			this.BtnSil.Text = "Sil";
			this.BtnSil.UseVisualStyleBackColor = true;
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(35, 264);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 24);
			this.label5.TabIndex = 11;
			this.label5.Text = "Email :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 216);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 24);
			this.label4.TabIndex = 10;
			this.label4.Text = "Telefon :";
			// 
			// TxtEmail
			// 
			this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.TxtEmail.Location = new System.Drawing.Point(115, 261);
			this.TxtEmail.Name = "TxtEmail";
			this.TxtEmail.Size = new System.Drawing.Size(283, 30);
			this.TxtEmail.TabIndex = 4;
			// 
			// MasketTelefon
			// 
			this.MasketTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.MasketTelefon.Location = new System.Drawing.Point(115, 210);
			this.MasketTelefon.Mask = "(999) 000-0000";
			this.MasketTelefon.Name = "MasketTelefon";
			this.MasketTelefon.Size = new System.Drawing.Size(283, 30);
			this.MasketTelefon.TabIndex = 3;
			// 
			// TxtSoyad
			// 
			this.TxtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.TxtSoyad.Location = new System.Drawing.Point(115, 163);
			this.TxtSoyad.Name = "TxtSoyad";
			this.TxtSoyad.Size = new System.Drawing.Size(283, 30);
			this.TxtSoyad.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 166);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "Soyad :";
			// 
			// TxtAd
			// 
			this.TxtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.TxtAd.Location = new System.Drawing.Point(115, 108);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new System.Drawing.Size(283, 30);
			this.TxtAd.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(65, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ad :";
			// 
			// BtnEkle
			// 
			this.BtnEkle.Location = new System.Drawing.Point(115, 297);
			this.BtnEkle.Name = "BtnEkle";
			this.BtnEkle.Size = new System.Drawing.Size(135, 39);
			this.BtnEkle.TabIndex = 5;
			this.BtnEkle.Text = "Ekle";
			this.BtnEkle.UseVisualStyleBackColor = true;
			this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
			// 
			// TxtID
			// 
			this.TxtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.TxtID.Location = new System.Drawing.Point(115, 54);
			this.TxtID.Name = "TxtID";
			this.TxtID.Size = new System.Drawing.Size(283, 30);
			this.TxtID.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(65, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(386, 490);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 24);
			this.label6.TabIndex = 27;
			this.label6.Text = "label6";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Green;
			this.ClientSize = new System.Drawing.Size(1755, 910);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button BtnGuncelle;
		private System.Windows.Forms.Button BtnSil;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TxtEmail;
		private System.Windows.Forms.MaskedTextBox MasketTelefon;
		private System.Windows.Forms.TextBox TxtSoyad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtAd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BtnEkle;
		private System.Windows.Forms.TextBox TxtID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnTemizle;
		private System.Windows.Forms.Label label6;
	}
}

