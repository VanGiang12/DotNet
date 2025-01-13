namespace VeGiaoDienVaXuLyLucRuntime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button bandau = null;
        private void btnThem_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Random rd = new Random();
            btn.Text = rd.Next(101) + "";
            btn.Width = 100;
            btn.Height = 30;
            btn.BackColor = Color.Yellow;
            pnButton.Controls.Add(btn);
            //tạo sự kiện với button
            btn.Click += Btn_Click;     //+= xong ấn tab
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            if (bandau != null)     //trước đó đã chọn rồi
            {
                bandau.BackColor = Color.Yellow;
            }
            Button btn = sender as Button;  //as chuyển đổi dữ liệu của đối tượng về đúng kdl của nó
            btn.BackColor = Color.Red;
            bandau = btn;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bandau != null)
                pnButton.Controls.Remove(bandau);
        }
    }
}