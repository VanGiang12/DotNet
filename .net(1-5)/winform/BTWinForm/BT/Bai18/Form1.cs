namespace Bai18
{
    public partial class Form1 : Form
    {
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (radOK.Checked)
            {
               MessageBox.Show("Đây là một dạng của message Box", "Message Box",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                
            }
            else if (radOKCancel.Checked)
            {
                 MessageBox.Show("Đây là một dạng của message Box", "Message Box",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
               
            }
            else if (radAbortRetryIgnore.Checked)
            {
                MessageBox.Show("Đây là một dạng của message Box", "Message Box",
                    MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
                
            }
            else if (radYesNoCancel.Checked)
            {
                 MessageBox.Show("Đây là một dạng của message Box", "Message Box",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
               
            }
            else if (radYesNo.Checked)
            {
                MessageBox.Show("Đây là một dạng của message Box", "Message Box",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            }
            else if (radRetryCancel.Checked)
            {
                 MessageBox.Show("Đây là một dạng của message Box", "Message Box",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
                
            }
            radOK.Checked = false;
            radOKCancel.Checked = false;
            radRetryCancel.Checked = false;
            radAbortRetryIgnore.Checked = false;
            radYesNo.Checked = false;
            radYesNoCancel.Checked = false;
            if (radStop.Checked)
            {
                
                MessageBox.Show("Đây là một dạng của message Box", "Message Box",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                
            }
            else if (radQuestion.Checked)
            {
                MessageBox.Show("Đây là một dạng của message Box", "Message Box",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                
            }
            else if (radExclammation.Checked)
            {
                 MessageBox.Show("Đây là một dạng của message Box", "Message Box",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                
            }
            else if (radInformation.Checked)
            {
                 MessageBox.Show("Đây là một dạng của message Box", "Message Box",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
            }

            radStop.Checked = false;
            radQuestion.Checked = false;
            radExclammation.Checked = false;
            radInformation.Checked = false;
        }

        private void radOK_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Are you sure exit?", "Message Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}