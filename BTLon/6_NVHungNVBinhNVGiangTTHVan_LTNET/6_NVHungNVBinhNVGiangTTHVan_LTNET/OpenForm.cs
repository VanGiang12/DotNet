using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_NVHungNVBinhNVGiangTTHVan_LTNET
{
    public static class OpenForm
    {
        public static Form currentForm = null;
        public static void openForm(Form form, Panel pn) 
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            currentForm = form;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.TopLevel = false;
            currentForm.Dock = DockStyle.Fill;
            pn.Controls.Add(currentForm);
            currentForm.Show();
        }
    }
}
