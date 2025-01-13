namespace Bai22
{
    public partial class Form1 : Form
    {
        //Form2 frm2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //frm2=new Form2();
        }

        private void btnNhapMang_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            if (Form2.flag)
            {
                foreach (var item in Form2.arrayList)
                {
                    //this.txtNhap.Text = item + "     ";  // ghi đè giá trị
                    this.txtNhap.AppendText(item + "     ");//ghi tiếp vào phía sau
                }
            }
        }

        private void btnTongMang_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in Form2.arrayList)
            {
                sum += int.Parse(item.ToString());
            }
            txtKetQua.Text = sum.ToString();

        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            txtKetQua.Clear();
            int min = 0, max = 0;
            if (Form2.arrayList != null && Form2.arrayList.Count > 0)
            {
                Form2.arrayList.Sort();
                min = (int)Form2.arrayList[0];
                max = (int)Form2.arrayList[Form2.arrayList.Count - 1];
            }
            txtKetQua.Text = $"Số lớn nhất: {max}" + $" Số bé nhất: {min}";
        }

        private void btnDemChan_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (Form2.arrayList != null && Form2.arrayList.Count > 0)
            {
                foreach (var item in Form2.arrayList)
                {
                    if (int.Parse(item.ToString()) % 2 == 0)
                        count++;
                }
            }
            txtKetQua.Text = $"Có {count} phần tử chẵn";
        }

        private void btnXuatViTriChan_Click(object sender, EventArgs e)
        {
            string s = "";
            if (Form2.arrayList != null && Form2.arrayList.Count > 0)
            {
                for (int i = 0; i < Form2.arrayList.Count; i++)
                {
                    if (int.Parse(Form2.arrayList[i].ToString()) % 2 == 0)
                    {
                        s += i + "   ";
                    }
                }
            }
            txtKetQua.Text = "Vị trí các số chẵn: " + s;
        }

        private void btnXuatVitriLe_Click(object sender, EventArgs e)
        {
            string s = "";
            if (Form2.arrayList != null && Form2.arrayList.Count > 0)
            {
                for (int i = 0; i < Form2.arrayList.Count; i++)
                {
                    if (int.Parse(Form2.arrayList[i].ToString()) % 2 != 0)
                    {
                        s += i + "   ";
                    }
                }
            }
            txtKetQua.Text = "Vị trí các số lẻ: " + s;
        }

        private void btnDemLe_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (Form2.arrayList != null && Form2.arrayList.Count > 0)
            {
                foreach (var item in Form2.arrayList)
                {
                    if (int.Parse(item.ToString()) % 2 != 0)
                        count++;
                }
            }
            txtKetQua.Text = $"Có {count} phần tử lẻ";
        }
    }
}