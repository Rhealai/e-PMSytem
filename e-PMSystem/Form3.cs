using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DealCamera;

namespace MaterialManagement {

    public partial class Form3 : Form {

        capCamera capC = new capCamera();
        long Video_Handle;

        public Form3() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            capC.Disconnect(Video_Handle);
            this.Dispose();
        }

        private void Form3_Load(object sender, EventArgs e) {
            //Video_Handle = CreateCaptureWindow(PicCapture.Handle, , , PicCapture.Width, PicCapture.Height, 0)
            Video_Handle = capC.CreateCaptureWindow((int)pictureBox1.Handle, 0,0, pictureBox1.Width, pictureBox1.Height, 0);
        }
    }
}
