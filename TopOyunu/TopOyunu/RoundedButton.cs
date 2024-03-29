﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;


namespace TopOyunu
{

    class RoundedButton : Button
    {

        private int borderSize = 0;
        private int borderRadius = 30;
        private Color borderColor = Color.Transparent;

        public float hareket_acisi = 0;
        public int top_durumu = 0; // 0:oyunda -1: asagidan cikti 1:yukarıdan cikti

        puan_hesaplayici puan_Hesaplayici;

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }


        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        public RoundedButton(Color renk, int x, int y, float hareket_acisi, ref puan_hesaplayici puan_hesaplayici_referansi)
        {
            puan_Hesaplayici = puan_hesaplayici_referansi;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(60, 60);
            this.BackColor = renk;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
            this.Text = "";

            this.Location = new Point(x, y);
            this.hareket_acisi = hareket_acisi;
            this.Show();
        }
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);


            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    this.Region = new Region(pathSurface);

                    pevent.Graphics.DrawPath(penSurface, pathSurface);


                    if (borderSize >= 1)

                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }

        }


        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        public void hareketlendir(int form_height, int form_width, int oyuncu_x)
        {
            float hareket_hizi = 10;
            int yeni_x = (int)(hareket_hizi * Math.Cos(hareket_acisi / 180 * 3.14)) + this.Location.X;
            int yeni_y = (int)(hareket_hizi * Math.Sin(hareket_acisi / 180 * 3.14)) + this.Location.Y;

            if (yeni_y < 1 + 20)//yukarı
            {
                if (yeni_x > 300 && yeni_x < 480)
                {
                    top_durumu = 1;

                }
                else
                {
                    hareket_acisi = hareket_acisi * -1;
                    if (hareket_acisi < 0)
                    {

                        hareket_acisi += 360;
                    }
                }

            }

            if (yeni_y > form_height - 120)//asagi
            {
                if (yeni_x > oyuncu_x && yeni_x < (oyuncu_x + 170))
                {
                    hareket_acisi = hareket_acisi * -1;
                    puan_Hesaplayici.top_oyuncuya_carpti();
                    if (hareket_acisi < 0)
                    {

                        hareket_acisi += 360;
                    }

                }
                else
                {

                    top_durumu = -1;
                }



            }


            //sag ve sol
            if (yeni_x < -1 + 20)
            {
                hareket_acisi = 180 - hareket_acisi;
                if (hareket_acisi < 0)
                {
                    hareket_acisi += 360;
                }
            }
            if (yeni_x > form_width - 80 - 20)
            {
                hareket_acisi = 180 - hareket_acisi;
                if (hareket_acisi < 0)
                {
                    hareket_acisi += 360;
                }
            }

            this.Location = new Point(yeni_x, yeni_y);
        }


    }




}


