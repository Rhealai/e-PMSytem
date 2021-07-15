using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Diagnostics;


namespace MaterialManagement {
    public partial class Form2 : Form {
        public Form2(string str) {
            InitializeComponent();
            label1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e) {
            dgv_update();
        }

        public void dgv_update() {
            //Step 1:清除Datagridview的資料
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            string productID = label1.Text;

            // Add File Folder
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID) == false)
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID);

            // Add Columns
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "檔案名稱";

            // Add Rows
            ArrayList row;
                        
            string filePath = AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID.ToString();
            int index_i=1;

            foreach (string fname in Directory.GetFileSystemEntries(filePath)) {
                //Debug.WriteLine(fname);
                row = new ArrayList();
                row.Add(index_i++);
                row.Add(Path.GetFileName(fname));
                dataGridView1.Rows.Add(row.ToArray());
            }


            //Add OpenFile Button Columns
            DataGridViewButtonColumn openfileColumns = new DataGridViewButtonColumn();

            openfileColumns.Name = "OpenFile";
            openfileColumns.HeaderText = "開啟檔案";
            openfileColumns.Text = "開啟";
            openfileColumns.UseColumnTextForButtonValue = true;
            openfileColumns.Width = 106;

            dataGridView1.Columns.Add(openfileColumns);


            //Add DeleteFile Button Columns
            DataGridViewButtonColumn deletefileColumns = new DataGridViewButtonColumn();

            deletefileColumns.Name = "DeleteFile";
            deletefileColumns.HeaderText = "刪除檔案";
            deletefileColumns.Text = "刪除";
            deletefileColumns.UseColumnTextForButtonValue = true;
            deletefileColumns.Width = 106;

            dataGridView1.Columns.Add(deletefileColumns);


        }

        private void btnUpload_Click(object sender, EventArgs e) {
            string pruductID = label1.Text;
            string filePath = AppDomain.CurrentDomain.BaseDirectory + @"data\" + pruductID;

            //MessageBox.Show(filePath);

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;

            //openFileDialog.ShowDialog();
            //openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                foreach (string fileName in openFileDialog.FileNames) {
                    File.Copy(fileName, filePath + "\\" + Path.GetFileName(fileName));
                }
            }

            dgv_update();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            string productID = label1.Text;
            string filePath = AppDomain.CurrentDomain.BaseDirectory + @"data\" + productID ;
            string productName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "開啟檔案") {

                ProcessStartInfo open = new ProcessStartInfo();
                open.FileName = productName;
                open.WorkingDirectory = filePath;
                Process.Start(open);
            }

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "刪除檔案") {
                DialogResult result = MessageBox.Show("Yes Or No", "確定刪除檔案", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == result) {
                    File.Delete(filePath + "\\" + productName);
                    MessageBox.Show(productName + " 檔案刪除");
                    dgv_update();
                }
                else if (DialogResult.No == result) {
                    //MessageBox.Show("你選擇了NO");
                }
            }
        }
    }
}
