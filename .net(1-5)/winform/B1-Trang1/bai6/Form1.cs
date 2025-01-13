namespace bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtSo1.Text))
            {
                MessageBox.Show("Nhap so 1");
            }

            if (!int.TryParse(txtSo1.Text, out int val))
            {
                MessageBox.Show("Moi nhap so");
                txtSo1.Focus();
            }
            if (String.IsNullOrEmpty(txtSo2.Text))
            {
                MessageBox.Show("Nhap so 2");
            }

            if (!int.TryParse(txtSo2.Text, out int n))
            {
                MessageBox.Show("Moi nhap so");
                txtSo2.Focus();
            }
            txtKQ.Text = int.Parse(txtSo1.Text) + int.Parse(txtSo2.Text) + "";
        }

    }
}
