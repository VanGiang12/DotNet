namespace GameCaRo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DrawChess();
        }

        private void DrawChess()
        {
            Button oldButton = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Const.CHESS_BORAD_HEIGHT; i++)
            {
                for (int j = 0; j < Const.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button();
                    btn.Width = Const.CHESS_WIDTH;
                    btn.Height = Const.CHESS_HEIGHT;
                    btn.Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y);
                    pnBanCo.Controls.Add(btn);
                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Const.CHESS_HEIGHT);
                oldButton.Width = oldButton.Height = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}