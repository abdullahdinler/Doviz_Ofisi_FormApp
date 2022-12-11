
namespace Doviz_Ofisi_FormApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_İsim = new System.Windows.Forms.TextBox();
            this.Txt_TutarAlis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_DovizSatis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_DovizAlis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btn_AlisYap = new System.Windows.Forms.Button();
            this.Btn_SatişYap = new System.Windows.Forms.Button();
            this.Txt_TutarSatis = new System.Windows.Forms.TextBox();
            this.Txt_Miktar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOVIZGENUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARIHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alinanDovizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dovizOfisDBDataSet5 = new Doviz_Ofisi_FormApp.DovizOfisDBDataSet5();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.satilanDovizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dovizOfisDBDataSet6 = new Doviz_Ofisi_FormApp.DovizOfisDBDataSet6();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.alinanDovizTableAdapter = new Doviz_Ofisi_FormApp.DovizOfisDBDataSet5TableAdapters.AlinanDovizTableAdapter();
            this.satilanDovizTableAdapter = new Doviz_Ofisi_FormApp.DovizOfisDBDataSet6TableAdapters.SatilanDovizTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Lbl_dovizalınan = new System.Windows.Forms.Label();
            this.Lbl_dovizsatılan = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.nAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOVIZGENUSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kURDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARIHDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alinanDovizBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dovizOfisDBDataSet5)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satilanDovizBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dovizOfisDBDataSet6)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txt_İsim);
            this.panel1.Controls.Add(this.Txt_TutarAlis);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.Txt_DovizSatis);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Txt_DovizAlis);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.Btn_AlisYap);
            this.panel1.Controls.Add(this.Btn_SatişYap);
            this.panel1.Controls.Add(this.Txt_TutarSatis);
            this.panel1.Controls.Add(this.Txt_Miktar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 340);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(58, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "İsim:";
            // 
            // Txt_İsim
            // 
            this.Txt_İsim.Location = new System.Drawing.Point(125, 21);
            this.Txt_İsim.Name = "Txt_İsim";
            this.Txt_İsim.Size = new System.Drawing.Size(247, 26);
            this.Txt_İsim.TabIndex = 0;
            this.Txt_İsim.Tag = "Test";
            this.Txt_İsim.Text = "Müşteri Adı";
            // 
            // Txt_TutarAlis
            // 
            this.Txt_TutarAlis.Location = new System.Drawing.Point(268, 231);
            this.Txt_TutarAlis.Name = "Txt_TutarAlis";
            this.Txt_TutarAlis.ReadOnly = true;
            this.Txt_TutarAlis.Size = new System.Drawing.Size(104, 26);
            this.Txt_TutarAlis.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Beige;
            this.label11.Location = new System.Drawing.Point(-7, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "Doviz Satış:";
            // 
            // Txt_DovizSatis
            // 
            this.Txt_DovizSatis.Location = new System.Drawing.Point(125, 146);
            this.Txt_DovizSatis.Name = "Txt_DovizSatis";
            this.Txt_DovizSatis.ReadOnly = true;
            this.Txt_DovizSatis.Size = new System.Drawing.Size(247, 26);
            this.Txt_DovizSatis.TabIndex = 15;
            this.Txt_DovizSatis.TextChanged += new System.EventHandler(this.Txt_DovizSatis_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Beige;
            this.label10.Location = new System.Drawing.Point(3, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "Doviz Alış:";
            // 
            // Txt_DovizAlis
            // 
            this.Txt_DovizAlis.Location = new System.Drawing.Point(125, 104);
            this.Txt_DovizAlis.Name = "Txt_DovizAlis";
            this.Txt_DovizAlis.ReadOnly = true;
            this.Txt_DovizAlis.Size = new System.Drawing.Size(247, 26);
            this.Txt_DovizAlis.TabIndex = 13;
            this.Txt_DovizAlis.TextChanged += new System.EventHandler(this.Txt_DovizAlis_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Beige;
            this.label9.Location = new System.Drawing.Point(46, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Doviz:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "AUD"});
            this.comboBox1.Location = new System.Drawing.Point(125, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 26);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Doviz Seç";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Btn_AlisYap
            // 
            this.Btn_AlisYap.BackColor = System.Drawing.Color.Lime;
            this.Btn_AlisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AlisYap.ForeColor = System.Drawing.Color.Black;
            this.Btn_AlisYap.Location = new System.Drawing.Point(268, 276);
            this.Btn_AlisYap.Name = "Btn_AlisYap";
            this.Btn_AlisYap.Size = new System.Drawing.Size(104, 39);
            this.Btn_AlisYap.TabIndex = 10;
            this.Btn_AlisYap.Text = "Alış Yap";
            this.Btn_AlisYap.UseVisualStyleBackColor = false;
            this.Btn_AlisYap.Click += new System.EventHandler(this.Btn_AlisYap_Click);
            // 
            // Btn_SatişYap
            // 
            this.Btn_SatişYap.BackColor = System.Drawing.Color.Maroon;
            this.Btn_SatişYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_SatişYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SatişYap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_SatişYap.Location = new System.Drawing.Point(125, 276);
            this.Btn_SatişYap.Name = "Btn_SatişYap";
            this.Btn_SatişYap.Size = new System.Drawing.Size(104, 39);
            this.Btn_SatişYap.TabIndex = 9;
            this.Btn_SatişYap.Text = "Satış Yap";
            this.Btn_SatişYap.UseVisualStyleBackColor = false;
            this.Btn_SatişYap.Click += new System.EventHandler(this.Btn_SatişYap_Click);
            // 
            // Txt_TutarSatis
            // 
            this.Txt_TutarSatis.Location = new System.Drawing.Point(125, 231);
            this.Txt_TutarSatis.Name = "Txt_TutarSatis";
            this.Txt_TutarSatis.ReadOnly = true;
            this.Txt_TutarSatis.Size = new System.Drawing.Size(104, 26);
            this.Txt_TutarSatis.TabIndex = 7;
            // 
            // Txt_Miktar
            // 
            this.Txt_Miktar.Location = new System.Drawing.Point(125, 189);
            this.Txt_Miktar.Name = "Txt_Miktar";
            this.Txt_Miktar.Size = new System.Drawing.Size(247, 26);
            this.Txt_Miktar.TabIndex = 6;
            this.Txt_Miktar.TextChanged += new System.EventHandler(this.Txt_Miktar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Beige;
            this.label7.Location = new System.Drawing.Point(47, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tutar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Beige;
            this.label3.Location = new System.Drawing.Point(35, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Miktar:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(440, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 179);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alınan Doviz";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn,
            this.dOVIZGENUSDataGridViewTextBoxColumn,
            this.kURDataGridViewTextBoxColumn,
            this.aMOUNTDataGridViewTextBoxColumn,
            this.tARIHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alinanDovizBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 154);
            this.dataGridView1.TabIndex = 0;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "İism";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // dOVIZGENUSDataGridViewTextBoxColumn
            // 
            this.dOVIZGENUSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dOVIZGENUSDataGridViewTextBoxColumn.DataPropertyName = "DOVIZ_GENUS";
            this.dOVIZGENUSDataGridViewTextBoxColumn.HeaderText = "Doviz";
            this.dOVIZGENUSDataGridViewTextBoxColumn.Name = "dOVIZGENUSDataGridViewTextBoxColumn";
            this.dOVIZGENUSDataGridViewTextBoxColumn.Width = 72;
            // 
            // kURDataGridViewTextBoxColumn
            // 
            this.kURDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kURDataGridViewTextBoxColumn.DataPropertyName = "KUR";
            this.kURDataGridViewTextBoxColumn.HeaderText = "Kur";
            this.kURDataGridViewTextBoxColumn.Name = "kURDataGridViewTextBoxColumn";
            this.kURDataGridViewTextBoxColumn.Width = 60;
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "Miktar";
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            this.aMOUNTDataGridViewTextBoxColumn.Width = 82;
            // 
            // tARIHDataGridViewTextBoxColumn
            // 
            this.tARIHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tARIHDataGridViewTextBoxColumn.DataPropertyName = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tARIHDataGridViewTextBoxColumn.Name = "tARIHDataGridViewTextBoxColumn";
            // 
            // alinanDovizBindingSource
            // 
            this.alinanDovizBindingSource.DataMember = "AlinanDoviz";
            this.alinanDovizBindingSource.DataSource = this.dovizOfisDBDataSet5;
            // 
            // dovizOfisDBDataSet5
            // 
            this.dovizOfisDBDataSet5.DataSetName = "DovizOfisDBDataSet5";
            this.dovizOfisDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(440, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 167);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satılan Doviz";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn1,
            this.dOVIZGENUSDataGridViewTextBoxColumn1,
            this.kURDataGridViewTextBoxColumn1,
            this.aMOUNTDataGridViewTextBoxColumn1,
            this.tARIHDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.satilanDovizBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(3, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(688, 142);
            this.dataGridView2.TabIndex = 0;
            // 
            // satilanDovizBindingSource
            // 
            this.satilanDovizBindingSource.DataMember = "SatilanDoviz";
            this.satilanDovizBindingSource.DataSource = this.dovizOfisDBDataSet6;
            // 
            // dovizOfisDBDataSet6
            // 
            this.dovizOfisDBDataSet6.DataSetName = "DovizOfisDBDataSet6";
            this.dovizOfisDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.Lbl_dovizsatılan);
            this.groupBox3.Controls.Add(this.Lbl_dovizalınan);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(11, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1120, 106);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kasa ";
            // 
            // alinanDovizTableAdapter
            // 
            this.alinanDovizTableAdapter.ClearBeforeFill = true;
            // 
            // satilanDovizTableAdapter
            // 
            this.satilanDovizTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(286, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "TOPLAM SATILAN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(611, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "TOPLAM ALINAN";
            // 
            // Lbl_dovizalınan
            // 
            this.Lbl_dovizalınan.AutoSize = true;
            this.Lbl_dovizalınan.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_dovizalınan.Location = new System.Drawing.Point(650, 52);
            this.Lbl_dovizalınan.Name = "Lbl_dovizalınan";
            this.Lbl_dovizalınan.Size = new System.Drawing.Size(37, 18);
            this.Lbl_dovizalınan.TabIndex = 8;
            this.Lbl_dovizalınan.Text = "Null";
            // 
            // Lbl_dovizsatılan
            // 
            this.Lbl_dovizsatılan.AutoSize = true;
            this.Lbl_dovizsatılan.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_dovizsatılan.Location = new System.Drawing.Point(328, 52);
            this.Lbl_dovizsatılan.Name = "Lbl_dovizsatılan";
            this.Lbl_dovizsatılan.Size = new System.Drawing.Size(37, 18);
            this.Lbl_dovizsatılan.TabIndex = 9;
            this.Lbl_dovizsatılan.Text = "Null";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "AUD"});
            this.comboBox2.Location = new System.Drawing.Point(10, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(130, 26);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.Text = "Doviz Seç";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // nAMEDataGridViewTextBoxColumn1
            // 
            this.nAMEDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nAMEDataGridViewTextBoxColumn1.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn1.HeaderText = "İsim";
            this.nAMEDataGridViewTextBoxColumn1.Name = "nAMEDataGridViewTextBoxColumn1";
            this.nAMEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dOVIZGENUSDataGridViewTextBoxColumn1
            // 
            this.dOVIZGENUSDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dOVIZGENUSDataGridViewTextBoxColumn1.DataPropertyName = "DOVIZ_GENUS";
            this.dOVIZGENUSDataGridViewTextBoxColumn1.HeaderText = "Doviz";
            this.dOVIZGENUSDataGridViewTextBoxColumn1.Name = "dOVIZGENUSDataGridViewTextBoxColumn1";
            this.dOVIZGENUSDataGridViewTextBoxColumn1.Width = 72;
            // 
            // kURDataGridViewTextBoxColumn1
            // 
            this.kURDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kURDataGridViewTextBoxColumn1.DataPropertyName = "KUR";
            this.kURDataGridViewTextBoxColumn1.HeaderText = "Kur";
            this.kURDataGridViewTextBoxColumn1.Name = "kURDataGridViewTextBoxColumn1";
            this.kURDataGridViewTextBoxColumn1.Width = 60;
            // 
            // aMOUNTDataGridViewTextBoxColumn1
            // 
            this.aMOUNTDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aMOUNTDataGridViewTextBoxColumn1.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn1.HeaderText = "Miktar";
            this.aMOUNTDataGridViewTextBoxColumn1.Name = "aMOUNTDataGridViewTextBoxColumn1";
            this.aMOUNTDataGridViewTextBoxColumn1.Width = 82;
            // 
            // tARIHDataGridViewTextBoxColumn1
            // 
            this.tARIHDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tARIHDataGridViewTextBoxColumn1.DataPropertyName = "TARIH";
            this.tARIHDataGridViewTextBoxColumn1.HeaderText = "Tarih";
            this.tARIHDataGridViewTextBoxColumn1.Name = "tARIHDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 468);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Doviz Ofis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alinanDovizBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dovizOfisDBDataSet5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satilanDovizBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dovizOfisDBDataSet6)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_SatişYap;
        private System.Windows.Forms.TextBox Txt_TutarSatis;
        private System.Windows.Forms.TextBox Txt_Miktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_DovizSatis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_DovizAlis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btn_AlisYap;
        private System.Windows.Forms.TextBox Txt_TutarAlis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_İsim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DovizOfisDBDataSet5 dovizOfisDBDataSet5;
        private System.Windows.Forms.BindingSource alinanDovizBindingSource;
        private DovizOfisDBDataSet5TableAdapters.AlinanDovizTableAdapter alinanDovizTableAdapter;
        private DovizOfisDBDataSet6 dovizOfisDBDataSet6;
        private System.Windows.Forms.BindingSource satilanDovizBindingSource;
        private DovizOfisDBDataSet6TableAdapters.SatilanDovizTableAdapter satilanDovizTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOVIZGENUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARIHDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Lbl_dovizsatılan;
        private System.Windows.Forms.Label Lbl_dovizalınan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOVIZGENUSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kURDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARIHDataGridViewTextBoxColumn1;
    }
}

