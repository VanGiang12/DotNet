namespace Bai23
{
    public partial class Form1 : Form
    {
        List<int> lst = new List<int>();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPhatSinh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int n = b - a + 1;
            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(a, (b + 1));
                lst.Add(x);
            }
            foreach (var item in lst)
            {
                txtAB.Text += item + "  ";
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int s = 0;
            foreach (var item in lst)
            {
                s += item;
            }
            txtTong.Text = s + "";
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            lst.Sort();
            foreach (var item in lst)
            {
                txtSapXep.Text += item + "  ";
            }
        }
    }
}