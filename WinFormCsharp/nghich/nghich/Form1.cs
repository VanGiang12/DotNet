namespace nghich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[,] arrButton = new Button[10, 10];
        Button bandau = null;
        private void Form1_Load(object sender, EventArgs e)
        {

            pnButton.Controls.Clear();
            for (int i = 0; i < arrButton.GetLength(0); i++)
            {
                for (int j = 0; j < arrButton.GetLength(1); j++)
                {
                    Button btn = new Button();
                    btn.Text = "";
                    btn.Height = btn.Width = 50;
                    btn.Location = new Point(j * btn.Height, i * btn.Width);
                    pnButton.Controls.Add(btn);
                    arrButton[i, j] = btn;
                    btn.BackColor = Color.WhiteSmoke;
                    btn.Click += Btn_Click;
                    btn.Tag = i + ";" + j;
                }
            }
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (bandau != null)
            {
                if (btn.Text == "X")
                {
                    btn.Text = "O";
                    //bandau = btn;
                }
                else if (btn.Text == "O")
                {
                    btn.Text = "X";
                   // bandau = btn;
                }
                   
            }
            
            btn.Text = "X";
            bandau = btn;
            
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}