namespace Personel_Kayit
{
    partial class Form_Ana
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ana));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Meslek = new System.Windows.Forms.TextBox();
            this.Rb_Bekar = new System.Windows.Forms.RadioButton();
            this.Msk_Maas = new System.Windows.Forms.MaskedTextBox();
            this.Rb_Evli = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.Cmb_Sehir = new System.Windows.Forms.ComboBox();
            this.Txt_soyad = new System.Windows.Forms.TextBox();
            this.Txt_ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_Grafik = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_İstatislik = new System.Windows.Forms.Button();
            this.Btn_Temizle = new System.Windows.Forms.Button();
            this.Btn_Güncelle = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Btn_Kaydet = new System.Windows.Forms.Button();
            this.Btn_Listele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_Veri_TabaniDataSet3 = new Personel_Kayit.Personel_Veri_TabaniDataSet3();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbl_PersonelTableAdapter = new Personel_Kayit.Personel_Veri_TabaniDataSet3TableAdapters.Tbl_PersonelTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabaniDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_Meslek);
            this.groupBox1.Controls.Add(this.Rb_Bekar);
            this.groupBox1.Controls.Add(this.Msk_Maas);
            this.groupBox1.Controls.Add(this.Rb_Evli);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Cmb_Sehir);
            this.groupBox1.Controls.Add(this.Txt_soyad);
            this.groupBox1.Controls.Add(this.Txt_ad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Txt_id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 531);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // Txt_Meslek
            // 
            this.Txt_Meslek.Location = new System.Drawing.Point(182, 358);
            this.Txt_Meslek.Name = "Txt_Meslek";
            this.Txt_Meslek.Size = new System.Drawing.Size(310, 36);
            this.Txt_Meslek.TabIndex = 5;
            // 
            // Rb_Bekar
            // 
            this.Rb_Bekar.AutoSize = true;
            this.Rb_Bekar.Location = new System.Drawing.Point(290, 315);
            this.Rb_Bekar.Name = "Rb_Bekar";
            this.Rb_Bekar.Size = new System.Drawing.Size(91, 32);
            this.Rb_Bekar.TabIndex = 66;
            this.Rb_Bekar.TabStop = true;
            this.Rb_Bekar.Text = "Bekar";
            this.Rb_Bekar.UseVisualStyleBackColor = true;
            this.Rb_Bekar.CheckedChanged += new System.EventHandler(this.Rb_Bekar_CheckedChanged);
            // 
            // Msk_Maas
            // 
            this.Msk_Maas.Location = new System.Drawing.Point(182, 260);
            this.Msk_Maas.Mask = "0000";
            this.Msk_Maas.Name = "Msk_Maas";
            this.Msk_Maas.Size = new System.Drawing.Size(310, 36);
            this.Msk_Maas.TabIndex = 4;
            this.Msk_Maas.ValidatingType = typeof(int);
            // 
            // Rb_Evli
            // 
            this.Rb_Evli.AutoSize = true;
            this.Rb_Evli.Location = new System.Drawing.Point(195, 315);
            this.Rb_Evli.Name = "Rb_Evli";
            this.Rb_Evli.Size = new System.Drawing.Size(69, 32);
            this.Rb_Evli.TabIndex = 55;
            this.Rb_Evli.TabStop = true;
            this.Rb_Evli.Text = "Evli";
            this.Rb_Evli.UseVisualStyleBackColor = true;
            this.Rb_Evli.CheckedChanged += new System.EventHandler(this.Rb_Evli_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Maaş:";
            // 
            // Cmb_Sehir
            // 
            this.Cmb_Sehir.FormattingEnabled = true;
            this.Cmb_Sehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.Cmb_Sehir.Location = new System.Drawing.Point(182, 211);
            this.Cmb_Sehir.Name = "Cmb_Sehir";
            this.Cmb_Sehir.Size = new System.Drawing.Size(310, 36);
            this.Cmb_Sehir.TabIndex = 3;
            // 
            // Txt_soyad
            // 
            this.Txt_soyad.Location = new System.Drawing.Point(182, 162);
            this.Txt_soyad.Name = "Txt_soyad";
            this.Txt_soyad.Size = new System.Drawing.Size(310, 36);
            this.Txt_soyad.TabIndex = 2;
            // 
            // Txt_ad
            // 
            this.Txt_ad.Location = new System.Drawing.Point(183, 113);
            this.Txt_ad.Name = "Txt_ad";
            this.Txt_ad.Size = new System.Drawing.Size(310, 36);
            this.Txt_ad.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Meslek:";
            // 
            // Txt_id
            // 
            this.Txt_id.Location = new System.Drawing.Point(182, 66);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(310, 36);
            this.Txt_id.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Durum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Persnel ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şehir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Btn_Grafik);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Btn_İstatislik);
            this.groupBox2.Controls.Add(this.Btn_Temizle);
            this.groupBox2.Controls.Add(this.Btn_Güncelle);
            this.groupBox2.Controls.Add(this.Btn_Sil);
            this.groupBox2.Controls.Add(this.Btn_Kaydet);
            this.groupBox2.Controls.Add(this.Btn_Listele);
            this.groupBox2.Location = new System.Drawing.Point(591, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 531);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 28);
            this.label8.TabIndex = 5;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // Btn_Grafik
            // 
            this.Btn_Grafik.Location = new System.Drawing.Point(79, 385);
            this.Btn_Grafik.Name = "Btn_Grafik";
            this.Btn_Grafik.Size = new System.Drawing.Size(189, 50);
            this.Btn_Grafik.TabIndex = 7;
            this.Btn_Grafik.Text = "Grafikler";
            this.Btn_Grafik.UseVisualStyleBackColor = true;
            this.Btn_Grafik.Click += new System.EventHandler(this.Btn_Grafik_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_İstatislik
            // 
            this.Btn_İstatislik.Location = new System.Drawing.Point(79, 329);
            this.Btn_İstatislik.Name = "Btn_İstatislik";
            this.Btn_İstatislik.Size = new System.Drawing.Size(189, 50);
            this.Btn_İstatislik.TabIndex = 3;
            this.Btn_İstatislik.Text = "İstatislik";
            this.Btn_İstatislik.UseVisualStyleBackColor = true;
            this.Btn_İstatislik.Click += new System.EventHandler(this.Btn_İstatislik_Click);
            // 
            // Btn_Temizle
            // 
            this.Btn_Temizle.Location = new System.Drawing.Point(79, 273);
            this.Btn_Temizle.Name = "Btn_Temizle";
            this.Btn_Temizle.Size = new System.Drawing.Size(189, 50);
            this.Btn_Temizle.TabIndex = 6;
            this.Btn_Temizle.Text = "Temizle";
            this.Btn_Temizle.UseVisualStyleBackColor = true;
            this.Btn_Temizle.Click += new System.EventHandler(this.Btn_Temizle_Click);
            // 
            // Btn_Güncelle
            // 
            this.Btn_Güncelle.Location = new System.Drawing.Point(79, 217);
            this.Btn_Güncelle.Name = "Btn_Güncelle";
            this.Btn_Güncelle.Size = new System.Drawing.Size(189, 50);
            this.Btn_Güncelle.TabIndex = 5;
            this.Btn_Güncelle.Text = "Güncelle";
            this.Btn_Güncelle.UseVisualStyleBackColor = true;
            this.Btn_Güncelle.Click += new System.EventHandler(this.Btn_Güncelle_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Location = new System.Drawing.Point(79, 161);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(189, 50);
            this.Btn_Sil.TabIndex = 4;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Location = new System.Drawing.Point(79, 105);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(189, 50);
            this.Btn_Kaydet.TabIndex = 3;
            this.Btn_Kaydet.Text = "Kaydet";
            this.Btn_Kaydet.UseVisualStyleBackColor = true;
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // Btn_Listele
            // 
            this.Btn_Listele.Location = new System.Drawing.Point(79, 49);
            this.Btn_Listele.Name = "Btn_Listele";
            this.Btn_Listele.Size = new System.Drawing.Size(189, 50);
            this.Btn_Listele.TabIndex = 2;
            this.Btn_Listele.Text = "Listele";
            this.Btn_Listele.UseVisualStyleBackColor = true;
            this.Btn_Listele.Click += new System.EventHandler(this.Btn_Listele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 549);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(946, 459);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(940, 424);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            this.perSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            this.perDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personel_Veri_TabaniDataSet3;
            // 
            // personel_Veri_TabaniDataSet3
            // 
            this.personel_Veri_TabaniDataSet3.DataSetName = "Personel_Veri_TabaniDataSet3";
            this.personel_Veri_TabaniDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(983, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(983, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1230, 1037);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Ana";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabaniDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Meslek;
        private System.Windows.Forms.RadioButton Rb_Bekar;
        private System.Windows.Forms.MaskedTextBox Msk_Maas;
        private System.Windows.Forms.RadioButton Rb_Evli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Cmb_Sehir;
        private System.Windows.Forms.TextBox Txt_soyad;
        private System.Windows.Forms.TextBox Txt_ad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Grafik;
        private System.Windows.Forms.Button Btn_İstatislik;
        private System.Windows.Forms.Button Btn_Temizle;
        private System.Windows.Forms.Button Btn_Güncelle;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button Btn_Kaydet;
        private System.Windows.Forms.Button Btn_Listele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Personel_Veri_TabaniDataSet3 personel_Veri_TabaniDataSet3;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private Personel_Veri_TabaniDataSet3TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

