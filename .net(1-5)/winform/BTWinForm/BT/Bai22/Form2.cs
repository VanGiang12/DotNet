using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai22
{
    public partial class Form2 : Form
    {
        public static ArrayList? arrayList; // ? có thể chứa gtri null
        public static bool flag = false;
        //public bool flag = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            Random rd=new Random();
            this.txtNhap.Text = rd.Next(-100, 101).ToString();
            if (arrayList == null)
                arrayList = new ArrayList();
            arrayList.Add(int.Parse(this.txtNhap.Text));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            this.Close();
            flag = true;
        }


    }
}
