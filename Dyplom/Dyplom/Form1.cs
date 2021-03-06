﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PrzepisanyDyplom
{
    public partial class Form1 : Form
    {
        int q, a, z, n, k, m, i, b, uciec, nrekranu, cr1;
        char ch;
        byte starynr, n1;

        public Form1()
        {
            InitializeComponent();
        }

        private Graphics m_graphics;
        private Pen m_pen = new Pen(Color.Blue, 2F);
        private Font m_font;
        private Brush m_brush;

        //private void DrawPoint(int x, int y)
        //{
        //    m_graphics.DrawRectangle(Pens.Red, x, y, 1, 1);
        //}

        private void Button1Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            pictureBox1.Refresh();
            m_graphics = pictureBox1.CreateGraphics();
            MainRoutine();
            //m_graphics.DrawLine(m_pen, 10, 10, 100, 100);
            button1.Enabled = true;
        }

        private void MainRoutine()
        {
            starynr = 0; cr1 = 14;
            try
            {
                do { NAPIS(); } while (true);
            }
            catch (ExternalException ex)
            {
                //TODO: Obsługa w kodzie
            }
        }

        private void ry()
        {
            setfillstyle(1,11);
             bar(130,100,400,170);
             setcolor(0);
             PISZ(140,110,"PROGRAM SYMULUJAaCY PRACEa NASTAWNI EL. 110kV");
             PISZ(140,130,"DEMONSTRACJA ELEMENTOqW POqL POMIAROWYCH");
             PISZ(140,141,"SYMULACJA  STANOqW  AWARYJNYCH");
             PISZ(140,152,"KROqTKA INFORMACJA O PROGRAMIE");
        }

        private void NAPIS()
        {
            char q = (char) 0;
            int n, m;
            pictureBox1.Refresh();
            settextstyle(2,0,4);
            n=1;
            setfillstyle(1,11);
            bar(130,100,400,170);
            setfillstyle(1,15);
            bar(130,170,400,180);
            setcolor(0);
            PISZ(140,170,"WYBIERZ ODPOWIEDNIE POLE I NACISqNIJ ENTER");
            obwodka1(130,130,400,141,3);
            do
            {
                

            setcolor(0);
             PISZ(140,110,"PROGRAM SYMULUJAaCY PRACEa NASTAWNI EL. 110kV");
             PISZ(140,130,"DEMONSTRACJA ELEMENTOqW POqL POMIAROWYCH");
             PISZ(140,141,"SYMULACJA  STANOqW  AWARYJNYCH");
             PISZ(140,152,"KROqTKA INFORMACJA O PROGRAMIE");
             q=ReadKey();
                //Esc
             if (q == KeyEscape) pytanie();
                setfillstyle(1,7);
                if (q != 0)
                {

                    if (q == KeyCursorDown)
                        n++;
                    else if (q ==KeyCursorUp)
                        n--;
                    else if (q != KeyEnter && q != KeyEscape)
                        beep();
                    if (n==4) n=1;
                    if (n==0) n=3;
                    if (n==1) {ry();obwodka1(130,130,400,141,3);}
                    if (n==2) {ry();obwodka1(130,142,400,152,3);}
                    if (n==3) {ry();obwodka1(130,151,400,163,3);}
                    // }; setfillstyle(1,11);
                }
            } while (q!=13);
            
            // case n of
            // 1:pokaz;
            // 2:begin n1=1;wybor_awarii;end;
            // 3:informacja;
        }

        private void beep()
        {
            AlertDing ding = new AlertDing(250, 8);
            ding.Play();

        }

        private void pytanie()
        {
            setcolor(15);
            PISZ(30, 300, "JESTESq PEWNY ZzE CHCESZ WYJSqCq Z PROGRAMU? TAK(ENTER/Esc/T)  NIE(INNE KLAWISZE)");
            Thread.Sleep(200);//Żeby użytkownik zdążył puścić Esc
            char klawis = ReadKey();
            if (klawis == 27 || klawis == 13 || klawis == 'T' || klawis == 't')
            {
                //TODO: clearviewport;
                // closegraph;
                Application.Exit();
            }
            else
            {
                setfillstyle(0, 0);
                bar(20, 300, 532, 320);
            }
        }

        [DllImport("user32.dll")] static extern short GetAsyncKeyState(int vKey); 

        private static char ReadKey()
        {
            bool search = false;
            var pressed = 0;
            do
            {

                for (int i = 0; i < 255; i++)
                {
                    short keyState = GetAsyncKeyState(i);
                    if (0 != (keyState & 0x8000))
                    {
                        pressed = i;
                        search = true; 
                        break;
                    }
                }
                Application.DoEvents();
            } while (!search);
            return (char) pressed;
        }

        private void obwodka1(int prx1,int pry1, int prx2, int pry2, int color)
        {
            // TODO: var  p:pointer;
            // size:word;
            // {
            // size=imagesize(prx1,pry1,prx2,pry2);
            // getmem(p,size);
            // getimage(prx1,pry1,prx2,pry2,p^);
            // setfillstyle(1,color);
            // bar(prx1,pry1,prx2,pry2);
            // setcolor(15);
            // putimage(prx1,pry1,p^,andput);
            // freemem(p,size);
            // };
            m_graphics.DrawRectangle(m_pen, prx1, pry1*2, (prx2-prx1)*2, (pry2-pry1)*2);
        }

        private void PISZ(int wsx, int wsy, string napis)
        {
            int c;
            int yMultiplied = wsy*2;
            string znakp;
            c = napis.Length;
            for (int i = 0; i < c; i++)
            {
                znakp=napis.Substring(i,1);
                if (znakp=="q") PolishLetterCoz(wsx - 3, yMultiplied + 1);
                else if (znakp=="l") PolishLetterL(wsx - 7, yMultiplied + 8); 
                else if (znakp=="z") PolishLetterZ(wsx - 3, yMultiplied + 0);
                else if (znakp == "a") PolishLetterAe(wsx - 2, yMultiplied + 10);
                else {outtextxy(wsx,yMultiplied,znakp);wsx=wsx+12;}

            }
        }

        //TODO: Poniższe funkcje do usunięcia
        private void PolishLetterAe(int wsx, int wsy)
        {
            line(wsx, wsy, wsx + 3, wsy - 3);
        }

        private void PolishLetterZ(int wsx, int wsy)
        {
            circle(wsx, wsy, 1);
        }

        private void PolishLetterL(int wsx, int wsy)
        {
            line(wsx, wsy, wsx + 3, wsy - 3);
        }

        private void PolishLetterCoz(int wsx, int wsy)
        {
            line(wsx, wsy, wsx + 1, wsy - 1);
        }

        private void setcolor (int color) 
        {
            m_pen = new Pen(Color.Black, 2F);
            //TODO: przekodowanie kolorów
        }

        private void bar (int left, int top, int right, int bottom)
        {
            m_graphics.DrawRectangle(m_pen, left, top, right, bottom);
            //TODO: wyjaśnić, czy to były wypełnione czy puste prostokąty
        }

        private void setfillstyle(int pattern, int color)
        {
            m_brush = new SolidBrush(Color.Black);
            //TODO: color, pattern switch, może też m_Pen
        }
        
        private void settextstyle(int font, int direction, int charsize)
        {
            m_font = new Font(FontFamily.GenericSerif, charsize*3, FontStyle.Regular);
            m_brush = Brushes.Black;
            //TODO: if na font, sprawdzić direction, może też m_Pen
        }

        private void outtextxy(int wsx, int wsy, string znakp)
        {
            m_graphics.DrawString(znakp, m_font, m_brush, wsx, wsy);
        }

        private void line(int x1, int y1, int x2, int y2)
        {
            m_graphics.DrawLine(m_pen, x1, y1, x2, y2);
        }

        private void circle(int wsx, int wsy, int radius)
        {
            m_graphics.DrawEllipse(m_pen, wsx, wsy, radius, radius);
        }
        const int KeyEscape = 27;
        const int KeyCursorDown = 40;
        const int KeyCursorUp = 38;
        const int KeyEnter = 13;

    }
}
