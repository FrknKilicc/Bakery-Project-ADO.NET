namespace Bakery
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GirisYap = new System.Windows.Forms.Button();
            this.sifreYonetici = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KadiYonetici = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelGiris = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sifreMusteri = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.kadiMusteri = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ytkyt = new System.Windows.Forms.MaskedTextBox();
            this.MsKytButton1 = new System.Windows.Forms.RadioButton();
            this.ykkyt = new System.Windows.Forms.TextBox();
            this.yskyt = new System.Windows.Forms.TextBox();
            this.YonKytButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.mtKYT = new System.Windows.Forms.MaskedTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mkKYT = new System.Windows.Forms.TextBox();
            this.msKYT = new System.Windows.Forms.TextBox();
            this.KayitOl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.YoneticiGirisRadio = new System.Windows.Forms.RadioButton();
            this.MusteriGirisRadio = new System.Windows.Forms.RadioButton();
            this.KaıytOlRadio = new System.Windows.Forms.RadioButton();
            this.PanelGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GirisYap
            // 
            this.GirisYap.BackColor = System.Drawing.Color.Transparent;
            this.GirisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GirisYap.BackgroundImage")));
            this.GirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GirisYap.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GirisYap.FlatAppearance.BorderSize = 0;
            this.GirisYap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.GirisYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.GirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisYap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GirisYap.Location = new System.Drawing.Point(10, 552);
            this.GirisYap.Name = "GirisYap";
            this.GirisYap.Size = new System.Drawing.Size(174, 41);
            this.GirisYap.TabIndex = 5;
            this.GirisYap.Text = "Giriş Yap";
            this.GirisYap.UseVisualStyleBackColor = false;
            this.GirisYap.Click += new System.EventHandler(this.GirisYap_Click);
            // 
            // sifreYonetici
            // 
            this.sifreYonetici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sifreYonetici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifreYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.sifreYonetici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.sifreYonetici.Location = new System.Drawing.Point(10, 491);
            this.sifreYonetici.Name = "sifreYonetici";
            this.sifreYonetici.PasswordChar = '*';
            this.sifreYonetici.Size = new System.Drawing.Size(167, 22);
            this.sifreYonetici.TabIndex = 3;
            this.sifreYonetici.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(10, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // KadiYonetici
            // 
            this.KadiYonetici.AccessibleDescription = "";
            this.KadiYonetici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KadiYonetici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KadiYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KadiYonetici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.KadiYonetici.Location = new System.Drawing.Point(10, 434);
            this.KadiYonetici.Name = "KadiYonetici";
            this.KadiYonetici.Size = new System.Drawing.Size(167, 22);
            this.KadiYonetici.TabIndex = 1;
            this.KadiYonetici.Visible = false;
            this.KadiYonetici.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(10, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // PanelGiris
            // 
            this.PanelGiris.BackColor = System.Drawing.Color.Transparent;
            this.PanelGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelGiris.BackgroundImage")));
            this.PanelGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelGiris.Controls.Add(this.pictureBox3);
            this.PanelGiris.Controls.Add(this.pictureBox1);
            this.PanelGiris.Controls.Add(this.sifreMusteri);
            this.PanelGiris.Controls.Add(this.flowLayoutPanel1);
            this.PanelGiris.Controls.Add(this.label1);
            this.PanelGiris.Controls.Add(this.kadiMusteri);
            this.PanelGiris.Controls.Add(this.KadiYonetici);
            this.PanelGiris.Controls.Add(this.sifreYonetici);
            this.PanelGiris.Controls.Add(this.GirisYap);
            this.PanelGiris.Controls.Add(this.label2);
            this.PanelGiris.Location = new System.Drawing.Point(2, 1);
            this.PanelGiris.Name = "PanelGiris";
            this.PanelGiris.Size = new System.Drawing.Size(209, 631);
            this.PanelGiris.TabIndex = 6;
            this.PanelGiris.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 170);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(209, 190);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // sifreMusteri
            // 
            this.sifreMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sifreMusteri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifreMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.sifreMusteri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.sifreMusteri.Location = new System.Drawing.Point(10, 491);
            this.sifreMusteri.Name = "sifreMusteri";
            this.sifreMusteri.PasswordChar = '*';
            this.sifreMusteri.Size = new System.Drawing.Size(167, 22);
            this.sifreMusteri.TabIndex = 12;
            this.sifreMusteri.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(209, 171);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // kadiMusteri
            // 
            this.kadiMusteri.AccessibleDescription = "";
            this.kadiMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kadiMusteri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kadiMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.kadiMusteri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.kadiMusteri.Location = new System.Drawing.Point(10, 434);
            this.kadiMusteri.Name = "kadiMusteri";
            this.kadiMusteri.Size = new System.Drawing.Size(167, 22);
            this.kadiMusteri.TabIndex = 11;
            this.kadiMusteri.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.ytkyt);
            this.panel2.Controls.Add(this.MsKytButton1);
            this.panel2.Controls.Add(this.ykkyt);
            this.panel2.Controls.Add(this.yskyt);
            this.panel2.Controls.Add(this.YonKytButton2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.mtKYT);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.mkKYT);
            this.panel2.Controls.Add(this.msKYT);
            this.panel2.Controls.Add(this.KayitOl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(1026, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 631);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // ytkyt
            // 
            this.ytkyt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ytkyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ytkyt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.ytkyt.Location = new System.Drawing.Point(29, 477);
            this.ytkyt.Mask = "(999) 000-0000";
            this.ytkyt.Name = "ytkyt";
            this.ytkyt.Size = new System.Drawing.Size(176, 20);
            this.ytkyt.TabIndex = 13;
            this.ytkyt.Visible = false;
            // 
            // MsKytButton1
            // 
            this.MsKytButton1.BackColor = System.Drawing.Color.Transparent;
            this.MsKytButton1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MsKytButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.MsKytButton1.Location = new System.Drawing.Point(110, 520);
            this.MsKytButton1.Name = "MsKytButton1";
            this.MsKytButton1.Size = new System.Drawing.Size(95, 27);
            this.MsKytButton1.TabIndex = 12;
            this.MsKytButton1.Text = "Müşteri ";
            this.MsKytButton1.UseVisualStyleBackColor = false;
            this.MsKytButton1.CheckedChanged += new System.EventHandler(this.MsKytButton1_CheckedChanged);
            // 
            // ykkyt
            // 
            this.ykkyt.AccessibleDescription = "";
            this.ykkyt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ykkyt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ykkyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ykkyt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.ykkyt.Location = new System.Drawing.Point(26, 387);
            this.ykkyt.Name = "ykkyt";
            this.ykkyt.Size = new System.Drawing.Size(179, 20);
            this.ykkyt.TabIndex = 11;
            this.ykkyt.Visible = false;
            // 
            // yskyt
            // 
            this.yskyt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.yskyt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yskyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yskyt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.yskyt.Location = new System.Drawing.Point(29, 434);
            this.yskyt.Name = "yskyt";
            this.yskyt.PasswordChar = '*';
            this.yskyt.Size = new System.Drawing.Size(179, 20);
            this.yskyt.TabIndex = 12;
            this.yskyt.Visible = false;
            // 
            // YonKytButton2
            // 
            this.YonKytButton2.BackColor = System.Drawing.Color.Transparent;
            this.YonKytButton2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YonKytButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.YonKytButton2.Location = new System.Drawing.Point(26, 521);
            this.YonKytButton2.Name = "YonKytButton2";
            this.YonKytButton2.Size = new System.Drawing.Size(98, 26);
            this.YonKytButton2.TabIndex = 11;
            this.YonKytButton2.Text = "Yönetici";
            this.YonKytButton2.UseVisualStyleBackColor = false;
            this.YonKytButton2.CheckedChanged += new System.EventHandler(this.YonKytButton2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(25, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefon No:";
            // 
            // mtKYT
            // 
            this.mtKYT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtKYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtKYT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.mtKYT.Location = new System.Drawing.Point(29, 477);
            this.mtKYT.Mask = "(999) 000-0000";
            this.mtKYT.Name = "mtKYT";
            this.mtKYT.Size = new System.Drawing.Size(176, 20);
            this.mtKYT.TabIndex = 9;
            this.mtKYT.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel2.BackgroundImage")));
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(225, 171);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 190);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(25, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // mkKYT
            // 
            this.mkKYT.AccessibleDescription = "";
            this.mkKYT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mkKYT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkKYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mkKYT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.mkKYT.Location = new System.Drawing.Point(29, 387);
            this.mkKYT.Name = "mkKYT";
            this.mkKYT.Size = new System.Drawing.Size(179, 20);
            this.mkKYT.TabIndex = 1;
            this.mkKYT.Visible = false;
            // 
            // msKYT
            // 
            this.msKYT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.msKYT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msKYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msKYT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.msKYT.Location = new System.Drawing.Point(29, 432);
            this.msKYT.Name = "msKYT";
            this.msKYT.PasswordChar = '*';
            this.msKYT.Size = new System.Drawing.Size(179, 20);
            this.msKYT.TabIndex = 3;
            this.msKYT.Visible = false;
            // 
            // KayitOl
            // 
            this.KayitOl.BackColor = System.Drawing.Color.Transparent;
            this.KayitOl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KayitOl.BackgroundImage")));
            this.KayitOl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KayitOl.FlatAppearance.BorderSize = 0;
            this.KayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayitOl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.KayitOl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KayitOl.Location = new System.Drawing.Point(29, 553);
            this.KayitOl.Name = "KayitOl";
            this.KayitOl.Size = new System.Drawing.Size(179, 41);
            this.KayitOl.TabIndex = 5;
            this.KayitOl.Text = "Kayıt Ol";
            this.KayitOl.UseVisualStyleBackColor = false;
            this.KayitOl.Visible = false;
            this.KayitOl.Click += new System.EventHandler(this.KayitOl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(25, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Şifre:";
            // 
            // YoneticiGirisRadio
            // 
            this.YoneticiGirisRadio.BackColor = System.Drawing.Color.Transparent;
            this.YoneticiGirisRadio.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YoneticiGirisRadio.Location = new System.Drawing.Point(399, 489);
            this.YoneticiGirisRadio.Name = "YoneticiGirisRadio";
            this.YoneticiGirisRadio.Size = new System.Drawing.Size(192, 50);
            this.YoneticiGirisRadio.TabIndex = 8;
            this.YoneticiGirisRadio.Text = "Yönetici Girişi";
            this.YoneticiGirisRadio.UseVisualStyleBackColor = false;
            this.YoneticiGirisRadio.CheckedChanged += new System.EventHandler(this.YoneticiGirisRadio_CheckedChanged);
            // 
            // MusteriGirisRadio
            // 
            this.MusteriGirisRadio.BackColor = System.Drawing.Color.Transparent;
            this.MusteriGirisRadio.Checked = true;
            this.MusteriGirisRadio.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriGirisRadio.Location = new System.Drawing.Point(597, 489);
            this.MusteriGirisRadio.Name = "MusteriGirisRadio";
            this.MusteriGirisRadio.Size = new System.Drawing.Size(192, 50);
            this.MusteriGirisRadio.TabIndex = 9;
            this.MusteriGirisRadio.TabStop = true;
            this.MusteriGirisRadio.Text = "Müşteri Girişi";
            this.MusteriGirisRadio.UseVisualStyleBackColor = false;
            this.MusteriGirisRadio.CheckedChanged += new System.EventHandler(this.MusteriGirisRadio_CheckedChanged);
            // 
            // KaıytOlRadio
            // 
            this.KaıytOlRadio.BackColor = System.Drawing.Color.Transparent;
            this.KaıytOlRadio.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KaıytOlRadio.Location = new System.Drawing.Point(522, 545);
            this.KaıytOlRadio.Name = "KaıytOlRadio";
            this.KaıytOlRadio.Size = new System.Drawing.Size(192, 50);
            this.KaıytOlRadio.TabIndex = 10;
            this.KaıytOlRadio.Text = "Kayıt Ol";
            this.KaıytOlRadio.UseVisualStyleBackColor = false;
            this.KaıytOlRadio.CheckedChanged += new System.EventHandler(this.KaıytOlRadio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1246, 630);
            this.Controls.Add(this.KaıytOlRadio);
            this.Controls.Add(this.MusteriGirisRadio);
            this.Controls.Add(this.YoneticiGirisRadio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelGiris);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelGiris.ResumeLayout(false);
            this.PanelGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GirisYap;
        private System.Windows.Forms.TextBox sifreYonetici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KadiYonetici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelGiris;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mkKYT;
        private System.Windows.Forms.TextBox msKYT;
        private System.Windows.Forms.Button KayitOl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton YoneticiGirisRadio;
        private System.Windows.Forms.RadioButton MusteriGirisRadio;
        private System.Windows.Forms.RadioButton KaıytOlRadio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtKYT;
        private System.Windows.Forms.RadioButton MsKytButton1;
        private System.Windows.Forms.RadioButton YonKytButton2;
        private System.Windows.Forms.MaskedTextBox ytkyt;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.TextBox kadiMusteri;
        public System.Windows.Forms.TextBox sifreMusteri;
        public System.Windows.Forms.TextBox ykkyt;
        public System.Windows.Forms.TextBox yskyt;
    }
}

