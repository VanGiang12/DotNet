using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeGiaoDienVaXuLyLucRuntime
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        Button[,] arrButton = null;
        Random rd = new Random();
        Button bandau = null;
        private void btnenter_Click(object sender, EventArgs e)
        {
            int dong = int.Parse(txtdong.Text);
            int cot = int.Parse(txtcot.Text);
            arrButton = new Button[dong, cot];
            pnButton.Controls.Clear();
            for(int i = 0; i < arrButton.GetLength(0); i++)
            {
                for(int j = 0; j < arrButton.GetLength(1); j++)
                {
                    Button btn = new Button();
                    btn.Text = rd.Next(101) + "";
                    btn.Width = btn.Height = 50;
                    btn.Location = new Point( j*btn.Height, i*btn.Width);  //mỗi một button sẽ vẽ theo 1 cột j hàng i
                    pnButton.Controls.Add(btn); //thêm vào panel
                    arrButton[i, j] = btn;  //thêm vào mảng
                    btn.BackColor = Color.WhiteSmoke;   //màu mặc định cho button
                    btn.Click += Btn_Click;     //tạo event cho button
                    btn.Tag = i + ";" + j;  //lưu lại để bt được thộc dòng cột nào(ng dùng k nhìn đc)
                }
            }

        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            if(bandau!=null)
            {
                //trước đó đã ấn cho button đổi màu rồi thì khi ấn nút ms thì nút cũ phải 
                //quay trở lại màu ban đầu
                DoiMau(bandau, Color.WhiteSmoke);
            }
            Button btn = sender as Button;
            bandau = btn;
            DoiMau(bandau, Color.Yellow);   //Đổi màu cả hàng và cột thẳng theo button chọn
            bandau.BackColor = Color.Red;   //đỏi màu lại button đã chọn
        }

        private void DoiMau(Button bandau, Color color)
        {
            string s = bandau.Tag.ToString();   //chuyển điểm i j thành string
            string[] arr = s.Split(';');    //tách i j ra
            int i = int.Parse(arr[0]);  //dòng
            int j = int.Parse(arr[1]);  //cột
            for (int c = 0; c < arrButton.GetLength(1)/*(cột)*/; c++)
                arrButton[i, c].BackColor = color;  //dòng cố định cột thay đổi
            for (int d = 0; d < arrButton.GetLength(0) /*(hàng)*/; d++)
                arrButton[d, j].BackColor = color;  //cột cố định dòng thay đổi
        }
    }
}
