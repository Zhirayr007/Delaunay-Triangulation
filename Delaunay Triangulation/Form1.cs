using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delaunay_Triangulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        Graphics g;
        Dots[] mas_dots;
        double width, height;
        int dots_count;
        double Radius;
        Dots center= new Dots();
        public class Dots
        {
            public double x;
            public double y;
        }
         public void DrawTriangle(Dots point1, Dots point2, Dots point3, double w, double h)
         {
             Pen vertex = new Pen(Color.Red, 1);
            // Используя середину w/2 и h/2
            //g.DrawLine(vertex, (float)(w / 2 + point1.x), (float)(h / 2 + point1.y), (float)(w / 2 + point2.x), (float)(h / 2 + point2.y));
            //g.DrawLine(vertex, (float)(w / 2 + point2.x), (float)(h / 2 + point2.y), (float)(w / 2 + point3.x), (float)(h / 2 + point3.y));
            //g.DrawLine(vertex, (float)(w / 2 + point3.x), (float)(h / 2 + point3.y), (float)(w / 2 + point1.x), (float)(h / 2 + point1.y));
            g.DrawLine(vertex, (float)(point1.x), (float)(point1.y), (float)(point2.x), (float)(point2.y));
            g.DrawLine(vertex, (float)(point2.x), (float)(point2.y), (float)(point3.x), (float)(point3.y));
            g.DrawLine(vertex, (float)(point3.x), (float)(point3.y), (float)(point1.x), (float)(point1.y));
        }

         public void DrawOutCircle(Dots point1, Dots point2, Dots point3, double w, double h)
          {
              Pen vertexPen = new Pen(Color.Green, 3);

              double w1 = ((point2.x * point2.x - point1.x * point1.x + point2.y * point2.y - point1.y * point1.y) * (point3.y - point1.y) - (point3.x * point3.x - point1.x * point1.x + point3.y * point3.y - point1.y * point1.y) * (point2.y - point1.y)) / ((point2.x - point1.x) * (point3.y - point1.y) - (point3.x - point1.x) * (point2.y - point1.y)) / 2.0;
              double w2 = ((point3.x * point3.x - point1.x * point1.x + point3.y * point3.y - point1.y * point1.y) * (point2.x - point1.x) - (point2.x * point2.x - point1.x * point1.x + point2.y * point2.y - point1.y * point1.y) * (point3.x - point1.x)) / ((point2.x - point1.x) * (point3.y - point1.y) - (point3.x - point1.x) * (point2.y - point1.y)) / 2.0;
              double Rad = Math.Sqrt((w1 - point1.x) * (w1 - point1.x) + (w2 - point1.y) * (w2 - point1.y));
              //сохраняем центр и радиус
              center.x = w1;
              center.y = w2;
              Radius = Rad;
             
          }
         public void DrawOutCircle1(Dots point1, Dots point2, Dots point3, double w, double h)
         {
             Pen vertexPen = new Pen(Color.Green, 1);

             double w1 = ((point2.x * point2.x - point1.x * point1.x + point2.y * point2.y - point1.y * point1.y) * (point3.y - point1.y) - (point3.x * point3.x - point1.x * point1.x + point3.y * point3.y - point1.y * point1.y) * (point2.y - point1.y)) / ((point2.x - point1.x) * (point3.y - point1.y) - (point3.x - point1.x) * (point2.y - point1.y)) / 2.0;
             double w2 = ((point3.x * point3.x - point1.x * point1.x + point3.y * point3.y - point1.y * point1.y) * (point2.x - point1.x) - (point2.x * point2.x - point1.x * point1.x + point2.y * point2.y - point1.y * point1.y) * (point3.x - point1.x)) / ((point2.x - point1.x) * (point3.y - point1.y) - (point3.x - point1.x) * (point2.y - point1.y)) / 2.0;
             double Rad = Math.Sqrt((w1 - point1.x) * (w1 - point1.x) + (w2 - point1.y) * (w2 - point1.y));
             if (checkBox1.Checked)
             {
                 g.DrawEllipse(vertexPen, (float)(w / 2 + (w1 - Rad)), (float)(h / 2 + (w2 - Rad)), (float)(2.0 * Rad), (float)(2.0 * Rad));
             }
         }
        private void gennods_Click(object sender, EventArgs e)
        {
            dots_count = Convert.ToInt32(Count.Text); 
            //Рисование 
            bmp = new Bitmap(picture.Width, picture.Height);
            g = Graphics.FromImage(bmp);
            SolidBrush brush_back = new SolidBrush(Color.White);

            g.FillRectangle(brush_back, 0, 0, picture.Width, picture.Height);
            width = picture.Width;
            height = picture.Height;

            mas_dots = new Dots[dots_count];

            //Создание объекта для генерации чисел
            Random rnd = new Random();

            //Получить случайное число
            for (int i=0;i<dots_count;i++)
            {
                mas_dots[i] = new Dots();
                mas_dots[i].x= rnd.NextDouble()* width;
                mas_dots[i].y = rnd.NextDouble() * height;
            }
            //ручка для пружины
            SolidBrush dots = new SolidBrush(Color.Black);
            for (int i = 0; i < dots_count; i++)
            {
                //Rectangle rect = new Rectangle((int)(width / 2+ mas_dots[i].x), (int)(height / 2+ mas_dots[i].y), 3, 3);
                Rectangle rect = new Rectangle((int)( mas_dots[i].x), (int)( mas_dots[i].y), 3, 3);
                g.FillRectangle(dots, rect);
            }
           
            //DrawTriangle(mas_dots[0], mas_dots[1], mas_dots[2], width, height);
            //g.DrawLine(pruzhin, (float)(10), (float)(height / 2 + 10), (float)(width / 2 + X), (float)(height / 2 + 10));

            picture.Image = bmp;
        }

        private void Joindots_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < dots_count ; k++)
            {
                for (int j = 0; j < dots_count; j++)
                {
                    if (j == k) continue;
                    for (int i =0; i < dots_count; i++)
                    {
                        if (i == j || i == k) continue;
                        bool a = false;
                        DrawOutCircle(mas_dots[k], mas_dots[j], mas_dots[i], width, height);
                        for (int m = 0; m < dots_count; m++)
                        {
                            //радиус каждой точки от центра конкретного треугольника 
                            double R = Math.Sqrt((center.x - mas_dots[m].x) * (center.x - mas_dots[m].x) + (center.y - mas_dots[m].y) * (center.y - mas_dots[m].y));

                            if (R < Radius)
                            {
                                a = true;
                                //DrawTriangle(mas_dots[i], mas_dots[i + 1], mas_dots[i + 2], width, height);
                            }
                        }
                        if (false == a)
                        {
                            DrawTriangle(mas_dots[k], mas_dots[j], mas_dots[i], width, height);
                            DrawOutCircle1(mas_dots[k], mas_dots[j], mas_dots[i], width, height);
                        }
                    }
                }
            }

            picture.Image = bmp;
        }
    }


  
}
