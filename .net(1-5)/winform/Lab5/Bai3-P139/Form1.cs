using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai3_P139
{
    public partial class Form1 : Form
    {
        private Color selectedColor = Color.FromArgb(255, 0, 0, 0);
        private bool isDrawingCircle = true;// Cho mặc định là vẽ hình tròn
        private bool isDrawingSquare, isDrawingRectangle, isDrawingEllipse;
        private int redValue, greenValue,blueValue;

        public Form1()
        {
            InitializeComponent();
        }/*
        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            redValue = hScrollBar1.Value; // Sử dụng giá trị của HScrollBar làm thành phần Red của màu
            UpdateColor(); // Cập nhật màu sắc mới
        }

        private void hScrollBarGreen_ValueChanged(object sender, EventArgs e)
        {
            greenValue = hScrollBarGreen.Value;
            UpdateColor();
        }

        private void hScrollBarBlue_ValueChanged(object sender, EventArgs e)
        {
            blueValue = hScrollBarBlue.Value;
            UpdateColor();
        }

        private void UpdateColor()
        {
            redValue = Math.Min(redValue, 255);
            greenValue = Math.Min(greenValue, 255);
            blueValue = Math.Min(blueValue, 255);

            redValue = Math.Max(redValue, 0);
            greenValue = Math.Max(greenValue, 0);
            blueValue = Math.Max(blueValue, 0);

            selectedColor = Color.FromArgb(255, redValue, greenValue, blueValue);
            DrawShape();
        }*/
        #region 
        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            // Cập nhật màu sắc khi giá trị của HScrollBar thay đổi
            redValue = hScrollBar1.Value; // Sử dụng giá trị của HScrollBar làm thành phần Red của màu
            selectedColor = Color.FromArgb(255, redValue, 0, 0); // Cập nhật màu sắc mới
            DrawShape(); // Vẽ lại hình với màu sắc mới
        }
        private void hScrollBarGreen_ValueChanged(object sender, EventArgs e)
        {
            greenValue = hScrollBar1.Value;
            redValue = hScrollBar1.Value - hScrollBarBlue.Value;
            blueValue = hScrollBarBlue.Value - hScrollBarGreen.Value;
            if(redValue < 0)
                redValue = 0;
            if(blueValue < 0)
                blueValue = 0;
            selectedColor = Color.FromArgb(255, redValue, greenValue, blueValue); 
            DrawShape();
        }

        private void hScrollBarBlue_ValueChanged(object sender, EventArgs e)
        {
            blueValue = hScrollBarBlue.Value;
            redValue = hScrollBar1.Value - hScrollBarBlue.Value;
            greenValue = hScrollBarGreen.Value - hScrollBarBlue.Value;
            if (redValue < 0)
            {
                redValue = 0;
            }
            if (greenValue < 0)
            {
                greenValue = 0;
            }
            selectedColor = Color.FromArgb(255, redValue, greenValue, blueValue); 
            DrawShape();
        }
        #endregion*/
        private void btnDraw_Click(object sender, EventArgs e)
        {
            // Tô màu cho hình vẽ trên vùng vẽ
            DrawShape();
        }

        private void DrawShape()
        {
            Graphics g = panelDrawing.CreateGraphics();
            g.Clear(panelDrawing.BackColor); // Xóa hình trước khi vẽ

            SolidBrush pen = new SolidBrush(selectedColor);

            int width = 100; // Chiều rộng của hình
            int height = 100; // Chiều cao của hình
            int x = (panelDrawing.Width - width) / 2; // Tính toán tọa độ x để hình được đặt chính giữa
            int y = (panelDrawing.Height - height) / 2; // Tính toán tọa độ y để hình được đặt chính giữa

            //chứ ý. tọa độ viền kp tâm
            if (isDrawingCircle)
            {
                g.FillEllipse(pen, x, y, width, height); // Vẽ hình tròn
            }
            else if (isDrawingSquare)
            {
                g.FillRectangle(pen, x, y, width, height); // Vẽ hình vuông
            }
            else if (isDrawingRectangle)
            {
                g.FillRectangle(pen, x, (panelDrawing.Height - 50) / 2, width, 50);
            }
            else if (isDrawingEllipse)
            {
                g.FillEllipse(pen, x, (panelDrawing.Height - 70) / 2, width, 70);
            }
        }

        private void radioButtonCircle_CheckedChanged(object sender, EventArgs e)
        {
            // Xác định hình vẽ là hình tròn
            isDrawingCircle = radioButtonCircle.Checked;
        }

        private void radioButtonSquare_CheckedChanged(object sender, EventArgs e)
        {
            // Xác định hình vẽ là hình vuông
            isDrawingSquare = radioButtonSquare.Checked;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Xác định hình vẽ là hình vuông
            isDrawingRectangle = radioButtonRectangle.Checked;
        }


        private void radioButtonEllipse_CheckedChanged(object sender, EventArgs e)
        {
            isDrawingEllipse = radioButtonEllipse.Checked;
        }


    }
}
