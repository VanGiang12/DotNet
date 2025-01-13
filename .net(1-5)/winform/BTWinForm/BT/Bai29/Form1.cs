using System.IO;

namespace Bai29
{
    public partial class Form1 : Form
    {
        string path = @"D:\myfile\SinhVien.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(path, false);
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                ListViewItem item = (ListViewItem)listView1.Items[i];
                string s1 = item.SubItems[0].Text;
                string s2 = item.SubItems[1].Text;
                string s3 = item.SubItems[2].Text;
                writer.WriteLine($"{s1}\t\t{s2}\t\t{s3}");
            }
            writer.Close();
            MessageBox.Show("Lưu thành công");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHoTen.Text) &&
               !string.IsNullOrEmpty(txtMaSo.Text) && !string.IsNullOrEmpty(txtNgaySinh.Text))
            {
                string ma = txtMaSo.Text;
                string ten = txtHoTen.Text;
                string ngaysinh = txtNgaySinh.Text;
                DateTime date;
                string ns;
                if (DateTime.TryParse(ngaysinh, out date))
                {
                    ns = date.ToShortDateString();
                    ListViewItem item = new ListViewItem(ma);
                    item.SubItems.Add(ten);
                    item.SubItems.Add(ns);
                    listView1.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("Ngày không đúng định dạng(mm/dd/yyyy");
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            StreamReader reader = new StreamReader(path);
            string line;
            while ((line = (reader.ReadLine())) != null && !string.IsNullOrEmpty(line))
            {
                string[] tach = line.Split("\t\t");
                if (tach.Length >= 3)
                {
                    ListViewItem item = new ListViewItem(tach[0]);
                    item.SubItems.Add(tach[1]);
                    item.SubItems.Add(tach[2]);

                    listView1.Items.Add(item);
                }
            }
            reader.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("chưa chọn");
            }
        }

        
    }
}