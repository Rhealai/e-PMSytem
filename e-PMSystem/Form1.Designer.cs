namespace MaterialManagement
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbQueryType = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addPBox = new System.Windows.Forms.PictureBox();
            this.funcAddItem = new System.Windows.Forms.Button();
            this.dTmAdd = new System.Windows.Forms.DateTimePicker();
            this.cbAddAmount = new System.Windows.Forms.ComboBox();
            this.cbAddStor = new System.Windows.Forms.ComboBox();
            this.cbAddType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.tbDelName = new System.Windows.Forms.TextBox();
            this.funcDeltem = new System.Windows.Forms.Button();
            this.tbDelStor = new System.Windows.Forms.TextBox();
            this.tbDelType = new System.Windows.Forms.TextBox();
            this.dTmDel = new System.Windows.Forms.DateTimePicker();
            this.cbDelSerial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDelAmount = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.funcAddPicture = new System.Windows.Forms.Button();
            this.btnModPic = new System.Windows.Forms.Button();
            this.modPBox = new System.Windows.Forms.PictureBox();
            this.funcMod = new System.Windows.Forms.Button();
            this.cbModSerial = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dTmMod = new System.Windows.Forms.DateTimePicker();
            this.cbModAmount = new System.Windows.Forms.ComboBox();
            this.cbModStor = new System.Windows.Forms.ComboBox();
            this.cbModType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbModName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnOpenCamera = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbQueryStor = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label20 = new System.Windows.Forms.Label();
            this.tbQueryName = new System.Windows.Forms.TextBox();
            this.btQuery = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modPBox)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(911, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "查詢項目";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 255);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1093, 279);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbQueryType
            // 
            this.cbQueryType.FormattingEnabled = true;
            this.cbQueryType.Location = new System.Drawing.Point(911, 124);
            this.cbQueryType.Margin = new System.Windows.Forms.Padding(4);
            this.cbQueryType.Name = "cbQueryType";
            this.cbQueryType.Size = new System.Drawing.Size(176, 23);
            this.cbQueryType.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 232);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addPBox);
            this.tabPage1.Controls.Add(this.funcAddItem);
            this.tabPage1.Controls.Add(this.dTmAdd);
            this.tabPage1.Controls.Add(this.cbAddAmount);
            this.tabPage1.Controls.Add(this.cbAddStor);
            this.tabPage1.Controls.Add(this.cbAddType);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbAddName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(879, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "新增頁面";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addPBox
            // 
            this.addPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPBox.Location = new System.Drawing.Point(625, 21);
            this.addPBox.Margin = new System.Windows.Forms.Padding(4);
            this.addPBox.Name = "addPBox";
            this.addPBox.Size = new System.Drawing.Size(242, 174);
            this.addPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addPBox.TabIndex = 14;
            this.addPBox.TabStop = false;
            this.addPBox.Click += new System.EventHandler(this.addPBox_Click);
            this.addPBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.addPBox_DragDrop);
            this.addPBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.addPBox_DragEnter);
            // 
            // funcAddItem
            // 
            this.funcAddItem.Location = new System.Drawing.Point(416, 124);
            this.funcAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.funcAddItem.Name = "funcAddItem";
            this.funcAddItem.Size = new System.Drawing.Size(177, 48);
            this.funcAddItem.TabIndex = 13;
            this.funcAddItem.Text = "增加項目";
            this.funcAddItem.UseVisualStyleBackColor = true;
            this.funcAddItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // dTmAdd
            // 
            this.dTmAdd.Location = new System.Drawing.Point(416, 75);
            this.dTmAdd.Margin = new System.Windows.Forms.Padding(4);
            this.dTmAdd.Name = "dTmAdd";
            this.dTmAdd.Size = new System.Drawing.Size(155, 25);
            this.dTmAdd.TabIndex = 12;
            // 
            // cbAddAmount
            // 
            this.cbAddAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddAmount.FormattingEnabled = true;
            this.cbAddAmount.Location = new System.Drawing.Point(417, 22);
            this.cbAddAmount.Margin = new System.Windows.Forms.Padding(4);
            this.cbAddAmount.Name = "cbAddAmount";
            this.cbAddAmount.Size = new System.Drawing.Size(56, 23);
            this.cbAddAmount.TabIndex = 11;
            // 
            // cbAddStor
            // 
            this.cbAddStor.FormattingEnabled = true;
            this.cbAddStor.Location = new System.Drawing.Point(117, 132);
            this.cbAddStor.Margin = new System.Windows.Forms.Padding(4);
            this.cbAddStor.Name = "cbAddStor";
            this.cbAddStor.Size = new System.Drawing.Size(180, 23);
            this.cbAddStor.TabIndex = 10;
            // 
            // cbAddType
            // 
            this.cbAddType.FormattingEnabled = true;
            this.cbAddType.Location = new System.Drawing.Point(117, 78);
            this.cbAddType.Margin = new System.Windows.Forms.Padding(4);
            this.cbAddType.Name = "cbAddType";
            this.cbAddType.Size = new System.Drawing.Size(180, 23);
            this.cbAddType.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "儲存位置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "建檔日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "類別";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "數量";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "名稱";
            // 
            // tbAddName
            // 
            this.tbAddName.Location = new System.Drawing.Point(117, 26);
            this.tbAddName.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(180, 25);
            this.tbAddName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.tbDelName);
            this.tabPage2.Controls.Add(this.funcDeltem);
            this.tabPage2.Controls.Add(this.tbDelStor);
            this.tabPage2.Controls.Add(this.tbDelType);
            this.tabPage2.Controls.Add(this.dTmDel);
            this.tabPage2.Controls.Add(this.cbDelSerial);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbDelAmount);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(879, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "刪除頁面";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(333, 29);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 15);
            this.label18.TabIndex = 27;
            this.label18.Text = "名稱";
            // 
            // tbDelName
            // 
            this.tbDelName.Location = new System.Drawing.Point(424, 22);
            this.tbDelName.Margin = new System.Windows.Forms.Padding(4);
            this.tbDelName.Name = "tbDelName";
            this.tbDelName.ReadOnly = true;
            this.tbDelName.Size = new System.Drawing.Size(155, 25);
            this.tbDelName.TabIndex = 26;
            // 
            // funcDeltem
            // 
            this.funcDeltem.Location = new System.Drawing.Point(620, 89);
            this.funcDeltem.Margin = new System.Windows.Forms.Padding(4);
            this.funcDeltem.Name = "funcDeltem";
            this.funcDeltem.Size = new System.Drawing.Size(144, 72);
            this.funcDeltem.TabIndex = 25;
            this.funcDeltem.Text = "刪除項目";
            this.funcDeltem.UseVisualStyleBackColor = true;
            this.funcDeltem.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tbDelStor
            // 
            this.tbDelStor.Location = new System.Drawing.Point(117, 129);
            this.tbDelStor.Margin = new System.Windows.Forms.Padding(4);
            this.tbDelStor.Name = "tbDelStor";
            this.tbDelStor.ReadOnly = true;
            this.tbDelStor.Size = new System.Drawing.Size(180, 25);
            this.tbDelStor.TabIndex = 24;
            // 
            // tbDelType
            // 
            this.tbDelType.Location = new System.Drawing.Point(117, 74);
            this.tbDelType.Margin = new System.Windows.Forms.Padding(4);
            this.tbDelType.Name = "tbDelType";
            this.tbDelType.ReadOnly = true;
            this.tbDelType.Size = new System.Drawing.Size(180, 25);
            this.tbDelType.TabIndex = 23;
            // 
            // dTmDel
            // 
            this.dTmDel.Location = new System.Drawing.Point(424, 129);
            this.dTmDel.Margin = new System.Windows.Forms.Padding(4);
            this.dTmDel.Name = "dTmDel";
            this.dTmDel.Size = new System.Drawing.Size(155, 25);
            this.dTmDel.TabIndex = 22;
            // 
            // cbDelSerial
            // 
            this.cbDelSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDelSerial.FormattingEnabled = true;
            this.cbDelSerial.Location = new System.Drawing.Point(117, 22);
            this.cbDelSerial.Margin = new System.Windows.Forms.Padding(4);
            this.cbDelSerial.Name = "cbDelSerial";
            this.cbDelSerial.Size = new System.Drawing.Size(180, 23);
            this.cbDelSerial.TabIndex = 21;
            this.cbDelSerial.SelectedIndexChanged += new System.EventHandler(this.cbDelSerial_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "儲存位置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "建檔日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "類別";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "數量";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "編號";
            // 
            // tbDelAmount
            // 
            this.tbDelAmount.Location = new System.Drawing.Point(424, 74);
            this.tbDelAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbDelAmount.Name = "tbDelAmount";
            this.tbDelAmount.ReadOnly = true;
            this.tbDelAmount.Size = new System.Drawing.Size(155, 25);
            this.tbDelAmount.TabIndex = 13;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.funcAddPicture);
            this.tabPage3.Controls.Add(this.btnModPic);
            this.tabPage3.Controls.Add(this.modPBox);
            this.tabPage3.Controls.Add(this.funcMod);
            this.tabPage3.Controls.Add(this.cbModSerial);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.dTmMod);
            this.tabPage3.Controls.Add(this.cbModAmount);
            this.tabPage3.Controls.Add(this.cbModStor);
            this.tabPage3.Controls.Add(this.cbModType);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.tbModName);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(879, 203);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "修改頁面";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // funcAddPicture
            // 
            this.funcAddPicture.Location = new System.Drawing.Point(353, 165);
            this.funcAddPicture.Margin = new System.Windows.Forms.Padding(4);
            this.funcAddPicture.Name = "funcAddPicture";
            this.funcAddPicture.Size = new System.Drawing.Size(161, 31);
            this.funcAddPicture.TabIndex = 28;
            this.funcAddPicture.Text = "新增圖片";
            this.funcAddPicture.UseVisualStyleBackColor = true;
            this.funcAddPicture.Click += new System.EventHandler(this.funcAddPicture_Click);
            // 
            // btnModPic
            // 
            this.btnModPic.BackColor = System.Drawing.Color.Black;
            this.btnModPic.Location = new System.Drawing.Point(607, 178);
            this.btnModPic.Margin = new System.Windows.Forms.Padding(4);
            this.btnModPic.Name = "btnModPic";
            this.btnModPic.Size = new System.Drawing.Size(17, 16);
            this.btnModPic.TabIndex = 27;
            this.btnModPic.Text = ".";
            this.btnModPic.UseVisualStyleBackColor = false;
            this.btnModPic.Click += new System.EventHandler(this.btnModPic_Click);
            // 
            // modPBox
            // 
            this.modPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPBox.Location = new System.Drawing.Point(632, 22);
            this.modPBox.Margin = new System.Windows.Forms.Padding(4);
            this.modPBox.Name = "modPBox";
            this.modPBox.Size = new System.Drawing.Size(227, 173);
            this.modPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.modPBox.TabIndex = 26;
            this.modPBox.TabStop = false;
            this.modPBox.Click += new System.EventHandler(this.modPBox_Click);
            this.modPBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.modPBox_DragDrop);
            this.modPBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.modPBox_DragEnter);
            // 
            // funcMod
            // 
            this.funcMod.Location = new System.Drawing.Point(117, 165);
            this.funcMod.Margin = new System.Windows.Forms.Padding(4);
            this.funcMod.Name = "funcMod";
            this.funcMod.Size = new System.Drawing.Size(181, 31);
            this.funcMod.TabIndex = 25;
            this.funcMod.Text = "修改項目";
            this.funcMod.UseVisualStyleBackColor = true;
            this.funcMod.Click += new System.EventHandler(this.funcMod_Click);
            // 
            // cbModSerial
            // 
            this.cbModSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModSerial.FormattingEnabled = true;
            this.cbModSerial.Location = new System.Drawing.Point(117, 22);
            this.cbModSerial.Margin = new System.Windows.Forms.Padding(4);
            this.cbModSerial.Name = "cbModSerial";
            this.cbModSerial.Size = new System.Drawing.Size(180, 23);
            this.cbModSerial.TabIndex = 24;
            this.cbModSerial.SelectedIndexChanged += new System.EventHandler(this.cbModSerial_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 26);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 15);
            this.label19.TabIndex = 23;
            this.label19.Text = "編號";
            // 
            // dTmMod
            // 
            this.dTmMod.Location = new System.Drawing.Point(441, 126);
            this.dTmMod.Margin = new System.Windows.Forms.Padding(4);
            this.dTmMod.Name = "dTmMod";
            this.dTmMod.Size = new System.Drawing.Size(155, 25);
            this.dTmMod.TabIndex = 22;
            // 
            // cbModAmount
            // 
            this.cbModAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModAmount.FormattingEnabled = true;
            this.cbModAmount.Location = new System.Drawing.Point(443, 74);
            this.cbModAmount.Margin = new System.Windows.Forms.Padding(4);
            this.cbModAmount.Name = "cbModAmount";
            this.cbModAmount.Size = new System.Drawing.Size(56, 23);
            this.cbModAmount.TabIndex = 21;
            // 
            // cbModStor
            // 
            this.cbModStor.FormattingEnabled = true;
            this.cbModStor.Location = new System.Drawing.Point(117, 132);
            this.cbModStor.Margin = new System.Windows.Forms.Padding(4);
            this.cbModStor.Name = "cbModStor";
            this.cbModStor.Size = new System.Drawing.Size(180, 23);
            this.cbModStor.TabIndex = 19;
            // 
            // cbModType
            // 
            this.cbModType.FormattingEnabled = true;
            this.cbModType.Location = new System.Drawing.Point(117, 78);
            this.cbModType.Margin = new System.Windows.Forms.Padding(4);
            this.cbModType.Name = "cbModType";
            this.cbModType.Size = new System.Drawing.Size(180, 23);
            this.cbModType.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 132);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "儲存位置";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(351, 129);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "建檔日期";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 78);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "類別";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(351, 78);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 15;
            this.label14.Text = "數量";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(351, 26);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "名稱";
            // 
            // tbModName
            // 
            this.tbModName.Location = new System.Drawing.Point(443, 26);
            this.tbModName.Margin = new System.Windows.Forms.Padding(4);
            this.tbModName.Name = "tbModName";
            this.tbModName.Size = new System.Drawing.Size(180, 25);
            this.tbModName.TabIndex = 13;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnOpenCamera);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(879, 203);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "其他功能";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnOpenCamera
            // 
            this.btnOpenCamera.Location = new System.Drawing.Point(24, 25);
            this.btnOpenCamera.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenCamera.Name = "btnOpenCamera";
            this.btnOpenCamera.Size = new System.Drawing.Size(155, 40);
            this.btnOpenCamera.TabIndex = 0;
            this.btnOpenCamera.Text = "開啟攝影機";
            this.btnOpenCamera.UseVisualStyleBackColor = true;
            this.btnOpenCamera.Click += new System.EventHandler(this.btnOpenCamera_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(911, 104);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 4;
            this.label16.Text = "根據類別";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(911, 155);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "根據儲存位置";
            // 
            // cbQueryStor
            // 
            this.cbQueryStor.FormattingEnabled = true;
            this.cbQueryStor.Location = new System.Drawing.Point(911, 174);
            this.cbQueryStor.Margin = new System.Windows.Forms.Padding(4);
            this.cbQueryStor.Name = "cbQueryStor";
            this.cbQueryStor.Size = new System.Drawing.Size(175, 23);
            this.cbQueryStor.TabIndex = 11;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1133, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(911, 202);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 15);
            this.label20.TabIndex = 13;
            this.label20.Text = "名稱搜索";
            // 
            // tbQueryName
            // 
            this.tbQueryName.Location = new System.Drawing.Point(911, 221);
            this.tbQueryName.Margin = new System.Windows.Forms.Padding(4);
            this.tbQueryName.Name = "tbQueryName";
            this.tbQueryName.Size = new System.Drawing.Size(129, 25);
            this.tbQueryName.TabIndex = 14;
            // 
            // btQuery
            // 
            this.btQuery.Location = new System.Drawing.Point(1051, 220);
            this.btQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(35, 28);
            this.btQuery.TabIndex = 15;
            this.btQuery.Text = "...";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(MaterialManagement.ItemList);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 575);
            this.Controls.Add(this.btQuery);
            this.Controls.Add(this.tbQueryName);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbQueryStor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbQueryType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "電子料件管理(SQLite3) - Ver.1.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modPBox)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox cbQueryType;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.ComboBox cbAddAmount;
        private System.Windows.Forms.ComboBox cbAddStor;
        private System.Windows.Forms.ComboBox cbAddType;
        private System.Windows.Forms.DateTimePicker dTmAdd;
        private System.Windows.Forms.DateTimePicker dTmDel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDelAmount;
        private System.Windows.Forms.DateTimePicker dTmMod;
        private System.Windows.Forms.ComboBox cbModAmount;
        private System.Windows.Forms.ComboBox cbModStor;
        private System.Windows.Forms.ComboBox cbModType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbModName;
        private System.Windows.Forms.ComboBox cbDelSerial;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbQueryStor;
        private System.Windows.Forms.TextBox tbDelStor;
        private System.Windows.Forms.TextBox tbDelType;
        private System.Windows.Forms.Button funcDeltem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbDelName;
        private System.Windows.Forms.Button funcAddItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox cbModSerial;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button funcMod;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbQueryName;
        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.PictureBox addPBox;
        private System.Windows.Forms.PictureBox modPBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnOpenCamera;
        private System.Windows.Forms.Button btnModPic;
        private System.Windows.Forms.Button funcAddPicture;
    }
}

