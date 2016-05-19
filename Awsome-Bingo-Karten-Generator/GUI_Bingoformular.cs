using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Awsome_Bingo_Karten_Generator
{
    public partial class GUI_Bingoformular : Form
    {
        private int gridSize;
        public GUI_Bingoformular(int gridSize)
        {
            this.gridSize = gridSize;
            InitializeComponent();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (gridSize == 9)
            {
                this.Size = new Size(621, 631);
                Graphics graphic = e.Graphics;
                Size fixSize = new Size(200, 200);
                Rectangle r1 = new Rectangle(new Point(0, 0), fixSize);
                Rectangle r2 = new Rectangle(new Point(201, 0), fixSize);
                Rectangle r3 = new Rectangle(new Point(402, 0), fixSize);
                Rectangle r4 = new Rectangle(new Point(0, 201), fixSize);
                Rectangle r5 = new Rectangle(new Point(201, 201), fixSize);
                Rectangle r6 = new Rectangle(new Point(402, 201), fixSize);
                Rectangle r7 = new Rectangle(new Point(0, 402), fixSize);
                Rectangle r8 = new Rectangle(new Point(201, 402), fixSize);
                Rectangle r9 = new Rectangle(new Point(402, 402), fixSize);
                Image pic1 = Image.FromFile("Sushi.jpg");
                graphic.DrawImage(pic1, r1);
                graphic.DrawImage(pic1, r2);
                graphic.DrawImage(pic1, r3);
                graphic.DrawImage(pic1, r4);
                graphic.DrawImage(pic1, r5);
                graphic.DrawImage(pic1, r6);
                graphic.DrawImage(pic1, r7);
                graphic.DrawImage(pic1, r8);
                graphic.DrawImage(pic1, r9);
            }
            else if (gridSize == 16)
            {
                this.Size = new Size(821, 831);
                Graphics graphic = e.Graphics;
                Size fixSize = new Size(200, 200);
                Rectangle r1 = new Rectangle(new Point(0, 0), fixSize);
                Rectangle r2 = new Rectangle(new Point(201, 0), fixSize);
                Rectangle r3 = new Rectangle(new Point(402, 0), fixSize);
                Rectangle r4 = new Rectangle(new Point(603, 0), fixSize);
                Rectangle r5 = new Rectangle(new Point(0, 201), fixSize);
                Rectangle r6 = new Rectangle(new Point(201, 201), fixSize);
                Rectangle r7 = new Rectangle(new Point(402, 201), fixSize);
                Rectangle r8 = new Rectangle(new Point(603, 201), fixSize);
                Rectangle r9 = new Rectangle(new Point(0, 402), fixSize);
                Rectangle r10 = new Rectangle(new Point(201, 402), fixSize);
                Rectangle r11 = new Rectangle(new Point(402, 402), fixSize);
                Rectangle r12 = new Rectangle(new Point(603, 402), fixSize);
                Rectangle r13 = new Rectangle(new Point(0, 603), fixSize);
                Rectangle r14 = new Rectangle(new Point(201, 603), fixSize);
                Rectangle r15 = new Rectangle(new Point(402, 603), fixSize);
                Rectangle r16 = new Rectangle(new Point(603, 603), fixSize);
                Image pic1 = Image.FromFile("Sushi.jpg");
                graphic.DrawImage(pic1, r1);
                graphic.DrawImage(pic1, r2);
                graphic.DrawImage(pic1, r3);
                graphic.DrawImage(pic1, r4);
                graphic.DrawImage(pic1, r5);
                graphic.DrawImage(pic1, r6);
                graphic.DrawImage(pic1, r7);
                graphic.DrawImage(pic1, r8);
                graphic.DrawImage(pic1, r9);
                graphic.DrawImage(pic1, r10);
                graphic.DrawImage(pic1, r11);
                graphic.DrawImage(pic1, r12);
                graphic.DrawImage(pic1, r13);
                graphic.DrawImage(pic1, r14);
                graphic.DrawImage(pic1, r15);
                graphic.DrawImage(pic1, r16);
            }

            base.OnPaint(e);
        }

    }
}

