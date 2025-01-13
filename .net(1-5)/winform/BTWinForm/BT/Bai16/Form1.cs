namespace Bai16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // dùng mảng
        private string[] ThienCan = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
        private string[] DiaChi = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };

        // dùng list
        List<string> Can = new List<string>();
        List<string> Chi = new List<string>();

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            int year;
            year = int.Parse(txtNamDuong.Text);
            string namAm = ThienCan[year % 10] + " " + DiaChi[year % 12];
            txtNamAm.Text = namAm;
        }

        // dùng list
        private void Form1_Load(object sender, EventArgs e)
        {
            Can.Add("Canh");
            Can.Add("Tân");
            Can.Add("Nhâm");
            Can.Add("Quý");
            Can.Add("Giáp");
            Can.Add("Ất");
            Can.Add("Bính");
            Can.Add("Đinh");
            Can.Add("Mậu");
            Can.Add("Kỷ");

            Chi.Add("Thân");
            Chi.Add("Dậu");
            Chi.Add("Tuất");
            Chi.Add("Hợi");
            Chi.Add("Tý");
            Chi.Add("Sửu");
            Chi.Add("Dần");
            Chi.Add("Mão");
            Chi.Add("Thìn");
            Chi.Add("Tỵ");
            Chi.Add("Ngọ");
            Chi.Add("Mùi");
        }

        // dùng với mảng
        private void btn2_Click(object sender, EventArgs e)
        {
            int year;
            year = int.Parse(txtNamDuong.Text);
            txtNamAm.Text = ThienCan[year % 10] + " " + DiaChi[year % 12];


        }
    }
}