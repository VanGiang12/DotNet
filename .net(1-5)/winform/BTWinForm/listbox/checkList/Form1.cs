namespace checkList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // đưa 1 phần tử
            cklstLeft.Items.Add("Ha Noi");
            cklstLeft.Items.Add("Nghe An");
            cklstLeft.Items.Add("Sai Gon");
            cklstLeft.Items.Add("Thai Binh");

            // đưa nhiều phần tử
            cklstLeft.Items.AddRange(new string[] { "Da Nang", "Can Tho", "Tay Ninh" });


        }

        private void btnMove1FromLeft_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cklstLeft.Items.Count; i++)
            {
                if (cklstLeft.GetItemChecked(i))
                {
                    cklstRight.Items.Add(cklstLeft.Items[i]);
                    cklstLeft.Items.RemoveAt(i);
                }
            }
        }

        private void btnMoveAllFromLeft_Click(object sender, EventArgs e)
        {
            cklstRight.Items.AddRange(cklstLeft.Items);
            cklstLeft.Items.Clear();
        }

        private void btnMove1FromRight_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection dsChecked = cklstRight.CheckedItems;
            foreach (var x in dsChecked)
            {
                cklstRight.Items.Add(x);

            }
            while (dsChecked.Count > 0)
            {
                cklstRight.Items.Remove(dsChecked[0]);
            }
        }

        private void btnMoveAllFromRight_Click(object sender, EventArgs e)
        {
            cklstLeft.Items.AddRange(cklstRight.Items);
            cklstRight.Items.Clear();
        }
    }
}
