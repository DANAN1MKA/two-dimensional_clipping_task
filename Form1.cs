using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_5_CG
{
    //Вариант 1. Общий алгоритм отсечения отрезка ортогональным окном


    public partial class Window : Form
    {
        private Point[] poligon = new Point[8];

        //Изображение преднозначеное для стирания изменений при отрисовке временных линий событием pB_Canv_MouseMove
        private Bitmap cls;


        public Window()
        {
            InitializeComponent();

            //задаем полигон
            poligon[0] = new Point(185, 199);
            poligon[1] = new Point(182, 96);
            poligon[2] = new Point(268, 91);
            poligon[3] = new Point(272, 144);
            poligon[4] = new Point(370, 143);
            poligon[5] = new Point(376, 69);
            poligon[6] = new Point(489, 120);
            poligon[7] = new Point(478, 234);

            //рисуем полигон
            Bitmap canv = new Bitmap(pB_Canv.Width, pB_Canv.Height);
            Graphics g = Graphics.FromImage(canv);
            Pen p = new Pen(Color.White, 2);
            g.Clear(Color.Black);
            for(int i = 1; i < 8; i++)
            {
                g.DrawLine(p, poligon[i - 1].X, poligon[i - 1].Y, poligon[i].X, poligon[i].Y);
            }
            g.DrawLine(p, poligon[0].X, poligon[0].Y, poligon[7].X, poligon[7].Y);
            pB_Canv.BackgroundImage = canv;

            //запоминаем исходное изображение
            cls = canv;
        }

        //Флаг сигналезирующий о необходимости рисовать линию
        private bool second_point_flag = false;
        //первая точка линии
        private Point point;

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap canv = new Bitmap(pB_Canv.BackgroundImage);
            Graphics g = Graphics.FromImage(canv);

            if(second_point_flag) { second_point_flag = false; }
            else
            {
                //запоминаем точку и начинаем рисовать линию
                point = new Point(e.X, e.Y);
                second_point_flag = true;
            }
            pB_Canv.BackgroundImage = canv;
        }

        private void pB_Canv_MouseMove(object sender, MouseEventArgs e)
        {
            if (second_point_flag)
            {
                //Стираем предыдущее изображение
                pB_Canv.BackgroundImage = cls;

                //рисуем новую линию
                Bitmap canv = new Bitmap(pB_Canv.BackgroundImage);
                Graphics g = Graphics.FromImage(canv);
                g.DrawLine(new Pen(Color.White), point.X, point.Y, e.X, e.Y);
                pB_Canv.BackgroundImage = canv;
            }
        }
    }
}
