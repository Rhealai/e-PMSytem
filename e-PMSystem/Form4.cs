using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaterialManagement {
    public partial class Form4 : Form {
        public Form4(string frmStr) {
            InitializeComponent();

            this.Text = frmStr;

        }

        private void Form4_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                this.Dispose();
            }
        }
    }
}
