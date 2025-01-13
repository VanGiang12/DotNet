namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chklsLeft_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chklsLeft.Items.Add("Hưng Yên");
            chklsLeft.Items.Add("Hà Nội");
            chklsLeft.Items.Add("Thái Bình");
            chklsLeft.Items.Add("Đà Nẵng");

            chklsLeft.Items.AddRange(new string[] { "Bình Định", "Hải Dương" });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklsLeft.Items.Count; i++)
            {
                if (chklsLeft.GetItemChecked(i))//trả về true
                {
                    chklsRight.Items.Add(chklsLeft.Items[i]);
                    chklsLeft.Items.RemoveAt(i);
                }
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            chklsRight.Items.AddRange(chklsLeft.Items);
            chklsLeft.Items.Clear();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (var s in chklsRight.CheckedItems)
            {
                chklsLeft.Items.Add(s);
            }
            foreach (var s in chklsLeft.Items)
            {
                chklsRight.Items.Remove(s);
            }
        }

        private void btnremoveAll_Click(object sender, EventArgs e)
        {
            chklsLeft.Items.AddRange(chklsRight.Items);
            chklsRight.Items.Clear();
        }
    }
}