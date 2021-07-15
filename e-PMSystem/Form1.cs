using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DealCamera;
using System.Diagnostics;



namespace MaterialManagement
{
    public partial class Form1 : Form
    {
        DataBaseClass db = new DataBaseClass();

        public Form1()
        {
            InitializeComponent();            
            InitialItem();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //顯示類別項目
            //Step 1:清除Datagridview的資料
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();            

            cbQueryType.Items.Clear();
            cbQueryStor.Items.Clear();

            //填入DataGridView1
            //String sqlString = "select * from electrical where 類別 like '" + cbQueryType.Text.ToString() + "';";
            String sqlString = "SELECT ID,名稱,數量,類別,建檔日期,儲存盒號 FROM electrical;";
            if (cbQueryType.Text != "")
            {
                sqlString = "select ID,名稱,數量,類別,建檔日期,儲存盒號 from electrical where 類別 like '" + cbQueryType.Text.ToString() + "';";
            }

            if (cbQueryStor.Text != "")
            {
                sqlString = "select ID,名稱,數量,類別,建檔日期,儲存盒號 from electrical where 儲存盒號 like '" + cbQueryStor.Text.ToString() + "';";
            }

            if (cbQueryType.Text != "" && cbQueryStor.Text != "")
            {
                sqlString = "select ID,名稱,數量,類別,建檔日期,儲存盒號 from electrical where 儲存盒號 like '" + cbQueryStor.Text.ToString() + "' and 類別 like '" + cbQueryType.Text.ToString() + "';";
            }

            InitialItem();

            DataTable tb = db.DBGirdView(sqlString);
            bindingSource1.DataSource = tb;

            dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            //bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            
            //Add Button Columns
            DataGridViewButtonColumn btColumn = new DataGridViewButtonColumn();

            btColumn.Name = "proSpec";
            btColumn.HeaderText = "其他資料";
            btColumn.Text = "Data.";
            btColumn.UseColumnTextForButtonValue = true;
            btColumn.Width = 106;
            dataGridView1.Columns.Add(btColumn);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt_fromDGV = new DataTable();
            dt_fromDGV = (DataTable)bindingSource1.DataSource;

        }


        public DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // 列强制转换
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }

            // 循环行
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //刪除品項紀錄
            string DelLog = "刪除品項," + tbDelName.Text + "," + tbDelAmount.Text + "," + tbDelType.Text + "," + tbDelStor.Text;

            //"增加品項," + il.itemName + "," + il.amount.ToString() + "," + il.type + "," + il.dt + "," + il.storage;

            db.DBLogInset(DelLog);

            //執行刪除指令
            db.DBGridDelete(int.Parse(cbDelSerial.Text.ToString()));

            dataGridView1.Show();
        }

        private void cbDelSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlString = "select * from electrical where ID like " + cbDelSerial.Text.ToString() + ";";
            DataTable tb = db.DBGirdView(sqlString);
            tb = db.DBGirdView(sqlString);

            //ID
            //= tb.Rows[0][1].ToString();
            //名稱
            tbDelName.Text = tb.Rows[0][1].ToString();
            //數量
            tbDelAmount.Text = tb.Rows[0][2].ToString();
            //類別
            tbDelType.Text = tb.Rows[0][3].ToString();
            //建檔日期
            dTmDel.Value = Convert.ToDateTime(tb.Rows[0][4]);

//            dTmDel.Value = DateTime.Parse(tb.Rows[0][4].ToString("yyyy-mm-dd"));
            //儲存盒號
            tbDelStor.Text = tb.Rows[0][5].ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String sqlString = "select *  from electrical";
            DataTable tb = db.DBGirdView(sqlString);
            bindingSource1.DataSource = tb;

            bindingSource1.MoveLast();
            //MessageBox.Show(bindingSource1.Position.ToString());

            
            ItemList il = new ItemList(tbAddName.Text, int.Parse(cbAddAmount.Text), cbAddType.Text, DateTime.Now.ToString("yyyy-MM-dd").ToString(), cbAddStor.Text);
            db.DBGridInsert(il, bindingSource1.Count + 1);

            //新增品項紀錄
            string AddLog = "增加品項," + il.itemName + "," + il.amount.ToString() + "," + il.type + "," + il.dt + "," + il.storage;
            db.DBLogInset(AddLog);

            dataGridView1.Show();

            //新增產品圖片
            string productID = (bindingSource1.Count + 1).ToString();
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID)) {
                //MessageBox.Show("DIR EXISTS.");
            }
            else {
                //MessageBox.Show("NEED Create DIR.");
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID);
            }

            if (addPBox.Image == null) {
                //MessageBox.Show("No Image.");
            }
            else {
                //MessageBox.Show("Image here.");
                Bitmap bmp = new Bitmap(addPBox.Image, 320, 240);
                bmp.Save(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID + @"\cover.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }

        }

        private void funcMod_Click(object sender, EventArgs e)
        {
            string sqlString = "select * from electrical where ID like " + cbModSerial.Text.ToString() + ";";
            DataTable tb = db.DBGirdView(sqlString);
            //tb = db.DBGirdView(sqlString);

            string[] oldData = new string[6];

            oldData[0] = cbModSerial.Text;
            oldData[1] = tb.Rows[0][1].ToString();
            oldData[2] = tb.Rows[0][2].ToString();
            oldData[3] = tb.Rows[0][3].ToString();
            oldData[4] = tb.Rows[0][4].ToString();
            oldData[5] = tb.Rows[0][5].ToString();



            string[] newData = new string[6];
            newData[0] = cbModSerial.Text;
            newData[1] = tbModName.Text;
            newData[2] = cbModAmount.Text;
            newData[3] = cbModType.Text;
            newData[4] = dTmMod.Value.ToString("yyyy-MM-dd HH:mm:ss");
            newData[5] = cbModStor.Text;

            ItemList item = new ItemList(tbModName.Text, int.Parse(cbModAmount.Text), cbModType.Text,
                                         dTmMod.Value.ToString("yyyy-MM-dd HH:mm:ss"), cbModStor.Text);


            string ModString = "[";

            for (int i = 0; i < 6; i++)
            {
                if (i != 5)
                    ModString += oldData[i] + ',';
                if (i == 5)
                    ModString += oldData[i];
            }

            ModString += "]->[";

            for (int i = 0; i < 6; i++)
            {
                if (i != 5)
                    ModString += newData[i] + ',';
                if (i == 5)
                    ModString += newData[i];
            }
            ModString += "]";

            db.DBGidUpdate(cbModSerial.Text,item);

            //修改品項紀錄
            string ModLog = "修改品項," + ModString;
            db.DBLogInset(ModLog);


            //新增產品圖片
            //string productID = cbModSerial.Text.ToString();

            //if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID) == false)
            //    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID);            

            //if (modPBox.Image == null) {
            //    //MessageBox.Show("No Image.");
            //}
            //else {
            //    Bitmap bmp = new Bitmap(modPBox.Image, 320, 240);
            //    try {
            //        if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID + @"\cover.jpg") == false)
            //            bmp.Save(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID + @"\cover.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //        else
            //            MessageBox.Show("產品圖片已存在，無法更換，請刪除原圖檔後再更新","圖檔無法更換");
            //    }
            //        catch(Exception ex) {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}            
        }

        private void cbModSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlString = "select * from electrical where ID like " + cbModSerial.Text.ToString() + ";";
            DataTable tb = db.DBGirdView(sqlString);
            tb = db.DBGirdView(sqlString);

            //ID
            //= tb.Rows[0][1].ToString();
            //名稱
            tbModName.Text = tb.Rows[0][1].ToString();
            //數量
            cbModAmount.Text = tb.Rows[0][2].ToString();
            //類別
            cbModType.Text = tb.Rows[0][3].ToString();
            //建檔日期
            //dTmMod.Value = (DateTime)tb.Rows[0][4];
            dTmMod.Value = Convert.ToDateTime(tb.Rows[0][4]);
            //儲存盒號
            cbModStor.Text = tb.Rows[0][5].ToString();

            string productID = cbModSerial.Text;
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID + @"\cover.jpg")) {
                //modPBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID + @"\cover.jpg");
                //Bitmap bmpCover = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID + @"\cover.jpg");
                FileStream imgfs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID + @"\cover.jpg", FileMode.Open, FileAccess.Read);

                modPBox.Image = Image.FromStream(imgfs);
                imgfs.Close();                
            }
            else{
                modPBox.Image = null;
            }
            
            
            
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            //顯示類別項目
            //Step 1:清除Datagridview的資料
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            //填入DataGridView1
            //String sqlString = "select * from electrical where 類別 like '" + cbQueryType.Text.ToString() + "';";
            String sqlString = "select ID,名稱,數量,類別,建檔日期,儲存盒號 from electrical";
            if (tbQueryName.Text != "")
            {
                sqlString = "select ID,名稱,數量,類別,建檔日期,儲存盒號 from electrical where 名稱 like '%" + tbQueryName.Text + "%';";
            }

            DataTable tb = db.DBGirdView(sqlString);
            bindingSource1.DataSource = tb;

            dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            //bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;

            //Add Button Columns
            DataGridViewButtonColumn btColumn = new DataGridViewButtonColumn();

            btColumn.Name = "proSpec";
            btColumn.HeaderText = "其他資料";
            btColumn.Text = "Data.";
            btColumn.UseColumnTextForButtonValue = true;
            btColumn.Width = 106;
            dataGridView1.Columns.Add(btColumn);
        }

        private void InitialItem() {

            String sqlString = @"select ID,名稱,數量,類別,建檔日期,儲存盒號 from electrical";
            // String sqlString = @"select * from electrical";
            DataTable tb = db.DBGirdView(sqlString);
            bindingSource1.DataSource = tb;

            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            //bindingNavigator1.BindingSource = bindingSource1;
            //dataGridView1.DataSource = bindingSource1;

            //------------------------------------
            sqlString = "select distinct 類別 from electrical;";
            tb = db.DBGirdView(sqlString);

            //------------------------------------
            cbQueryType.Items.Clear();
            cbAddType.Items.Clear();
            cbModType.Items.Clear();
            cbAddAmount.Items.Clear();
            cbModAmount.Items.Clear();
            cbAddStor.Items.Clear();
            cbModStor.Items.Clear();
            cbQueryStor.Items.Clear();
            cbDelSerial.Items.Clear();
            cbModSerial.Items.Clear();

            //------------------------------------

            foreach (DataRow row in tb.Rows)
            {
                cbQueryType.Items.Add(row.ItemArray.First());
                cbAddType.Items.Add(row.ItemArray.First());
                cbModType.Items.Add(row.ItemArray.First());
            }


            for (int i = 0; i < 26; i++)
            {
                cbAddAmount.Items.Add(i);
                cbModAmount.Items.Add(i);
            }

            sqlString = "select distinct 儲存盒號 from electrical order by cast(儲存盒號 as integer);";
            tb = db.DBGirdView(sqlString);
            foreach (DataRow row in tb.Rows)
            {
                cbAddStor.Items.Add(row.ItemArray.First());
                cbModStor.Items.Add(row.ItemArray.First());
                cbQueryStor.Items.Add(row.ItemArray.First());
            }


            sqlString = "select distinct ID from electrical;";
            tb = db.DBGirdView(sqlString);
            foreach (DataRow row in tb.Rows)
            {
                cbDelSerial.Items.Add(row.ItemArray.First());
                cbModSerial.Items.Add(row.ItemArray.First());
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            addPBox.AllowDrop = true;
            modPBox.AllowDrop = true;

        }
        

        private void addPBox_DragDrop(object sender, DragEventArgs e) {
            string path = "";
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                string str = ((string[])e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();

                addPBox.Image = Image.FromFile(str);
                path = ((string[])e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            }
        }

        private void addPBox_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.All;
            }
            else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void modPBox_DragDrop(object sender, DragEventArgs e) {
            string path = "";
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                string str = ((string[])e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();

                modPBox.Image = Image.FromFile(str);
                path = ((string[])e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            }
        }

        private void modPBox_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.All;
            }
            else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void modPBox_Click(object sender, EventArgs e) {
            if(Clipboard.ContainsImage())
                 modPBox.Image = Clipboard.GetImage();
        }

        private void addPBox_Click(object sender, EventArgs e) {
            addPBox.Image = Clipboard.GetImage();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            string frmString;
          
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "其他資料") {
                string productName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmString = db.DBReturnID(productName);

                //Method 1
                Form2 frm = new Form2(frmString);
                frm.ShowDialog();
            }

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "ID") {
                string productName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmString = db.DBReturnID(productName);
                //MessageBox.Show(frmString);

                tabControl1.SelectedIndex = 2;
                cbModSerial.SelectedIndex = Int32.Parse(frmString)-1;

            }
        }

        private void btnOpenCamera_Click(object sender, EventArgs e) {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void btnModPic_Click(object sender, EventArgs e) {
            if(modPBox.Image != null) {
                string frmStr = tbModName.Text;
                Form4 frm = new Form4(frmStr);
                frm.pictureBox1.Image = modPBox.Image;
                frm.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                frm.ShowDialog();
            }

        }

        private void funcAddPicture_Click(object sender, EventArgs e)
        {
            //新增產品圖片
            string productID = cbModSerial.Text.ToString();

            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID) == false)
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID);

            if (modPBox.Image == null)
            {
                //MessageBox.Show("No Image.");
            }
            else
            {
                Bitmap bmp = new Bitmap(modPBox.Image, 320, 240);
                try
                {
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID + @"\cover.jpg") == false)
                        bmp.Save(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID + @"\cover.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    else
                        MessageBox.Show("產品圖片已存在，無法更新，請刪除原圖檔後再更新", "圖檔無法更新");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            dataGridView1.Height = this.Height - 265;
            this.Width = 858;

        }
    }
}
