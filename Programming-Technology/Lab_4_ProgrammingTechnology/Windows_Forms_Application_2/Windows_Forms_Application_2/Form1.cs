using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Application_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Scheme_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Wheat);
            Pen pen = new Pen(Brushes.Black, 2);

            SolidBrush bruh = new SolidBrush(Color.White);

            g.FillEllipse(bruh, 110, 270, 70, 70);
            g.DrawEllipse(pen, 110, 270, 70, 70);
            g.DrawLine(pen, 140, 330, 140, 280);
            g.DrawLine(pen, 140, 320, 160, 335);
            g.DrawLine(pen, 140, 290, 160, 275);


            g.DrawEllipse(pen, 20, 300, 10, 10);
            g.DrawLine(pen, 34, 300, 16, 310);
            g.DrawLine(pen, 30, 306, 140, 306);

            SolidBrush bruh_w = new SolidBrush(Color.Black);
            g.FillEllipse(bruh_w, 89, 301, 10, 10);

            g.DrawLine(pen, 95, 140, 95, 400);


            g.DrawLine(pen, 70, 400, 120, 400);
            g.DrawLine(pen, 70, 410, 120, 410);

            g.DrawLine(pen, 95, 410, 95, 500);

            g.DrawLine(pen, 70, 500, 120, 500);

            g.DrawLine(pen, 95, 140, 450, 140);

           
            g.FillPolygon(bruh, new Point[4] { new Point(270, 130), new Point(320, 130), new Point(320, 150), new Point(270, 150) });
            g.DrawPolygon(pen, new Point[4] { new Point(270, 130), new Point(320, 130), new Point(320, 150), new Point(270, 150) });

            g.DrawLine(pen, 450, 140, 450, 260);

           

            g.DrawLine(pen, 160, 275, 160, 30);
            g.DrawLine(pen, 160, 335, 160, 450);

            g.DrawLine(pen, 450, 260, 500, 260);

            g.DrawLine(pen, 500, 30, 500, 340);

            g.DrawLine(pen, 160, 30, 900, 30);

            g.DrawLine(pen, 160, 450, 500, 450);

            g.FillEllipse(bruh, 450, 335, 70, 70);
            g.DrawEllipse(pen, 450, 335, 70, 70);
            g.DrawLine(pen, 480, 345, 480, 395);
            g.DrawLine(pen, 500, 340, 480, 355);
            g.DrawLine(pen, 500, 400, 480, 385);

            g.DrawLine(pen, 500, 400, 500, 520);

            g.DrawLine(pen, 160, 200, 290, 200);

            g.DrawLine(pen, 290, 180, 290, 220);
            g.DrawLine(pen, 300, 180, 300, 220);

            g.DrawLine(pen, 300, 200, 390, 200);

            g.DrawLine(pen, 480, 370, 390, 370);

            g.DrawLine(pen, 390, 370, 390, 30);

            g.DrawLine(pen, 850, 520, 500, 520);

            g.DrawLine(pen, 620, 520, 620, 180);

            g.FillEllipse(bruh, 570, 115, 70, 70);
            g.DrawEllipse(pen, 570, 115, 70, 70);
            g.DrawLine(pen, 600, 125, 600, 175);
            g.DrawLine(pen, 620, 180, 600, 165);
            g.DrawLine(pen, 620, 120, 600, 135);


            g.DrawLine(pen, 620, 120, 620, 30);

            g.DrawLine(pen, 620, 100, 700, 100);

            g.DrawLine(pen, 700, 100, 700, 520);

            g.DrawLine(pen, 600, 150, 500, 150);

            g.DrawLine(pen, 850, 520, 850, 370);


            g.FillEllipse(bruh, 800, 305, 70, 70);
            g.DrawEllipse(pen, 800, 305, 70, 70);
            g.DrawLine(pen, 830, 370, 830, 315);
            g.DrawLine(pen, 850 ,310, 830, 325);
            g.DrawLine(pen, 850, 370, 830, 355);

            g.DrawLine(pen, 620, 343, 830, 343);

            g.DrawLine(pen, 850, 310, 850, 290);

            g.DrawLine(pen, 850, 290, 870, 290);

            g.DrawEllipse(pen, 870, 285, 10, 10);
            g.DrawLine(pen, 887, 295, 863, 285);

            g.DrawEllipse(pen, 900, 25, 10, 10);
            g.DrawLine(pen, 917, 35, 893, 25);

            g.FillEllipse(bruh_w, 615, 25, 10, 10);
            g.FillEllipse(bruh_w, 495, 25, 10, 10);
            g.FillEllipse(bruh_w, 385, 25, 10, 10);

            g.FillEllipse(bruh_w, 615, 514, 10, 10);
            g.FillEllipse(bruh_w, 695, 514, 10, 10);

            g.FillEllipse(bruh_w, 615, 337, 10, 10);
            g.FillEllipse(bruh_w, 615, 94, 10, 10);

            g.FillEllipse(bruh_w, 495, 445, 10, 10);
            g.FillEllipse(bruh_w, 495, 255, 10, 10);
            g.FillEllipse(bruh_w, 495, 145, 10, 10);

            g.FillEllipse(bruh_w, 230, 135, 10, 10);
            g.FillEllipse(bruh_w, 345, 135, 10, 10);

            g.DrawLine(pen, 235, 136, 235, 70);
            g.DrawLine(pen, 350, 136, 350, 70);

            g.DrawLine(pen, 350, 70, 300, 70);
            g.DrawLine(pen, 235, 70, 290, 70);

            g.DrawLine(pen, 300, 50, 300, 90);
            g.DrawLine(pen, 290, 50, 290, 90);

            g.FillPolygon(bruh, new Point[4] { new Point(490, 60), new Point(510, 60), new Point(510, 110), new Point(490, 110) });
            g.DrawPolygon(pen, new Point[4] { new Point(490, 60), new Point(510, 60), new Point(510, 110), new Point(490, 110) });

            g.FillPolygon(bruh, new Point[4] { new Point(490, 190), new Point(510, 190), new Point(510, 240), new Point(490, 240) });
            g.DrawPolygon(pen, new Point[4] { new Point(490, 190), new Point(510, 190), new Point(510, 240), new Point(490, 240) });


            g.FillPolygon(bruh, new Point[4] { new Point(490, 460), new Point(510, 460), new Point(510, 510), new Point(490, 510) });
            g.DrawPolygon(pen, new Point[4] { new Point(490, 460), new Point(510, 460), new Point(510, 510), new Point(490, 510) });

            g.FillPolygon(bruh, new Point[4] { new Point(150, 60), new Point(170, 60), new Point(170, 110), new Point(150, 110) });
            g.DrawPolygon(pen, new Point[4] { new Point(150, 60), new Point(170, 60), new Point(170, 110), new Point(150, 110) });

            g.FillPolygon(bruh, new Point[4] { new Point(380, 60), new Point(400, 60), new Point(400, 110), new Point(380, 110) });
            g.DrawPolygon(pen, new Point[4] { new Point(380, 60), new Point(400, 60), new Point(400, 110), new Point(380, 110) });

            g.FillPolygon(bruh, new Point[4] { new Point(610, 460), new Point(630, 460), new Point(630, 510), new Point(610, 510) });
            g.DrawPolygon(pen, new Point[4] { new Point(610, 460), new Point(630, 460), new Point(630, 510), new Point(610, 510) });

            g.FillPolygon(bruh, new Point[4] { new Point(610, 190), new Point(630, 190), new Point(630, 240), new Point(610, 240) });
            g.DrawPolygon(pen, new Point[4] { new Point(610, 190), new Point(630, 190), new Point(630, 240), new Point(610, 240) });

            g.FillPolygon(bruh, new Point[4] { new Point(690, 190), new Point(710, 190), new Point(710, 240), new Point(690, 240) });
            g.DrawPolygon(pen, new Point[4] { new Point(690, 190), new Point(710, 190), new Point(710, 240), new Point(690, 240) });

            g.DrawLine(pen, 620, 50, 640, 80);
            g.DrawLine(pen, 620, 50, 600, 80);
            g.DrawLine(pen, 640, 80, 600, 80);

            g.DrawLine(pen, 600, 50, 640, 50);

            SolidBrush bruh_b = new SolidBrush(Color.Black);

            g.DrawString("X1", new Font("Arial", 12, FontStyle.Italic), bruh_b, 30, 280);
            g.DrawString("+ C1", new Font("Arial", 12, FontStyle.Italic), bruh_b, 100, 410);
            g.DrawString("VT1", new Font("Arial", 12, FontStyle.Italic), bruh_b, 160, 340);
            g.DrawString("C3", new Font("Arial", 12, FontStyle.Italic), bruh_b, 300, 160);
            g.DrawString("+", new Font("Arial", 12, FontStyle.Italic), bruh_b, 300, 180);
            g.DrawString("R2", new Font("Arial", 12, FontStyle.Italic), bruh_b, 280, 110);
            g.DrawString("C2", new Font("Arial", 12, FontStyle.Italic), bruh_b, 280, 30);
            g.DrawString("+", new Font("Arial", 12, FontStyle.Italic), bruh_b, 270, 50);
            g.DrawString("R1", new Font("Arial", 12, FontStyle.Italic), bruh_b, 170, 70);
            g.DrawString("R3", new Font("Arial", 12, FontStyle.Italic), bruh_b, 400, 70);
            g.DrawString("R4", new Font("Arial", 12, FontStyle.Italic), bruh_b, 510, 70);
            g.DrawString("VD1", new Font("Arial", 12, FontStyle.Italic), bruh_b, 640, 40);
            g.DrawString("X2", new Font("Arial", 12, FontStyle.Italic), bruh_b, 860, 10);
            g.DrawString("VT1", new Font("Arial", 12, FontStyle.Italic), bruh_b, 640, 120);
            g.DrawString("R7", new Font("Arial", 12, FontStyle.Italic), bruh_b, 640, 200);
            g.DrawString("R8", new Font("Arial", 12, FontStyle.Italic), bruh_b, 640, 470);
            g.DrawString("R5", new Font("Arial", 12, FontStyle.Italic), bruh_b, 510, 200);
            g.DrawString("VT2", new Font("Arial", 12, FontStyle.Italic), bruh_b, 510, 330);
            g.DrawString("R6", new Font("Arial", 12, FontStyle.Italic), bruh_b, 510, 470);
            g.DrawString("R9", new Font("Arial", 12, FontStyle.Italic), bruh_b, 720, 200);
            g.DrawString("VT4", new Font("Arial", 12, FontStyle.Italic), bruh_b, 850, 380);
            g.DrawString("X3", new Font("Arial", 12, FontStyle.Italic), bruh_b, 840, 265);


        }
    }
}
