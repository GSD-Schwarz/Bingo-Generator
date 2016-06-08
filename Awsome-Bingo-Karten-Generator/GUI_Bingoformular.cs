using System.Drawing;
using System.Windows.Forms;
using System.Windows.Controls;

namespace Awsome_Bingo_Karten_Generator
{
    public partial class GUI_Bingoformular : Form
    {
        private int gridSize;
        private bool showName;
        public GUI_Bingoformular(int gridSize, bool showName)
        {
            this.gridSize = gridSize;
            this.showName = showName;
            InitializeComponent();
        }

        

        protected override void OnPaint(PaintEventArgs e)
        {
            if (gridSize == 9 && showName == true)
            {
                // Bitmap wird initalisiert
                var bitmap1 = new Bitmap(621, 701);
                // Fenstergröße wird angepasst
                this.Size = new Size(621, 701);
                // Neue Grafik wird initalisiert
                Graphics graphic = e.Graphics;
                // feste Größe für alle Bildschirmrechtecke
                Size fixSize = new Size(200, 200);
                Size labelSize = new Size(150, 20);
                // 9 Rechtecke initalisieren
                Rectangle r1 = new Rectangle(new Point(0, 0), fixSize);
                Rectangle r2 = new Rectangle(new Point(201, 0), fixSize);
                Rectangle r3 = new Rectangle(new Point(402, 0), fixSize);
                Rectangle r4 = new Rectangle(new Point(50, 201), labelSize);
                Rectangle r5 = new Rectangle(new Point(251, 201), labelSize);
                Rectangle r6 = new Rectangle(new Point(452, 201), labelSize);
                Rectangle r7 = new Rectangle(new Point(0, 221), fixSize);
                Rectangle r8 = new Rectangle(new Point(201, 221), fixSize);
                Rectangle r9 = new Rectangle(new Point(402, 221), fixSize);
                Rectangle r10 = new Rectangle(new Point(0, 442), fixSize);
                Rectangle r11 = new Rectangle(new Point(201, 442), fixSize);
                Rectangle r12 = new Rectangle(new Point(402, 442), fixSize);

                // Bilder einlesen, über BilderArray laufen TEST @"C:\Sushi.jpg"
                System.Drawing.Image pic1 = System.Drawing.Image.FromFile(@"C:\Sushi.jpg");

                // Eingelesene Bilder anzeigen
                graphic.DrawImage(pic1, r1);
                graphic.DrawImage(pic1, r2);
                graphic.DrawImage(pic1, r3);
                graphic.DrawString("Hallo", new Font("Arial", 16), new SolidBrush(Color.Black), r4);
                graphic.DrawString("Hallo", new Font("Arial", 16), new SolidBrush(Color.Black), r5);
                graphic.DrawString("Hallo", new Font("Arial", 16), new SolidBrush(Color.Black), r6);
                graphic.DrawImage(pic1, r7);
                graphic.DrawImage(pic1, r8);
                graphic.DrawImage(pic1, r9);
                graphic.DrawImage(pic1, r10);
                graphic.DrawImage(pic1, r11);
                graphic.DrawImage(pic1, r12);



                // Canvas mit der Bitmap erzeugen
                var canvas1 = Graphics.FromImage(bitmap1);

                // Beste Komprimierung einschalten
                canvas1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Bilder in das Canvas laden
                canvas1.DrawImage(pic1, r1);
                canvas1.DrawImage(pic1, r2);
                canvas1.DrawImage(pic1, r3);
                canvas1.DrawString("Hallo", new Font("Arial", 16), new SolidBrush(Color.White), r4);
                canvas1.DrawString("Hallo", new Font("Arial", 16), new SolidBrush(Color.White), r5);
                canvas1.DrawString("Hallo", new Font("Arial", 16), new SolidBrush(Color.White), r6);
                canvas1.DrawImage(pic1, r7);
                canvas1.DrawImage(pic1, r8);
                canvas1.DrawImage(pic1, r9);
                canvas1.DrawImage(pic1, r10);
                canvas1.DrawImage(pic1, r11);
                canvas1.DrawImage(pic1, r12);
                // Canvas speichern
                canvas1.Save();

                try
                {
                    // Bitmap auf dem PC als "JPG" speichern
                    bitmap1.Save(@"C:\Users\de17166\Desktop\Image.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch (System.Exception ex)
                {
                    throw;
                }

            }
            else if (gridSize == 16 && showName == false)
            {   
                // Bitmap wird initalisiert
                var bitmap2 = new Bitmap(803, 803);
                // Fenstergröße wird angepasst
                this.Size = new Size(821, 831);
                // Neue Grafik wird initalisiert
                Graphics graphic = e.Graphics;
                // feste Größe für alle Bildschirmrechtecke
                Size fixSize = new Size(200, 200);

                // 16 Rechtecke initalisieren
                Rectangle r1  = new Rectangle(new Point(0, 0), fixSize);
                Rectangle r2  = new Rectangle(new Point(201, 0), fixSize);
                Rectangle r3  = new Rectangle(new Point(402, 0), fixSize);
                Rectangle r4  = new Rectangle(new Point(603, 0), fixSize);
                Rectangle r5  = new Rectangle(new Point(0, 201), fixSize);
                Rectangle r6  = new Rectangle(new Point(201, 201), fixSize);
                Rectangle r7  = new Rectangle(new Point(402, 201), fixSize);
                Rectangle r8  = new Rectangle(new Point(603, 201), fixSize);
                Rectangle r9  = new Rectangle(new Point(0, 402), fixSize);
                Rectangle r10 = new Rectangle(new Point(201, 402), fixSize);
                Rectangle r11 = new Rectangle(new Point(402, 402), fixSize);
                Rectangle r12 = new Rectangle(new Point(603, 402), fixSize);
                Rectangle r13 = new Rectangle(new Point(0, 603), fixSize);
                Rectangle r14 = new Rectangle(new Point(201, 603), fixSize);
                Rectangle r15 = new Rectangle(new Point(402, 603), fixSize);
                Rectangle r16 = new Rectangle(new Point(603, 603), fixSize);

                // Bilder einlesen, über BilderArray laufen TEST @"C:\Sushi.jpg"
                System.Drawing.Image pic1 = System.Drawing.Image.FromFile("Sushi.jpg");

                // Eingelesene Bilder anzeigen
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

                // Canvas mit der Bitmap erzeugen
                var canvas2 = Graphics.FromImage(bitmap2);

                // Beste Komprimierung einschalten
                canvas2.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Bilder in das Canvas laden
                canvas2.DrawImage(pic1, r1);
                canvas2.DrawImage(pic1, r2);
                canvas2.DrawImage(pic1, r3);
                canvas2.DrawImage(pic1, r4);
                canvas2.DrawImage(pic1, r5);
                canvas2.DrawImage(pic1, r6);
                canvas2.DrawImage(pic1, r7);
                canvas2.DrawImage(pic1, r8);
                canvas2.DrawImage(pic1, r9);
                canvas2.DrawImage(pic1, r10);
                canvas2.DrawImage(pic1, r11);
                canvas2.DrawImage(pic1, r12);
                canvas2.DrawImage(pic1, r13);
                canvas2.DrawImage(pic1, r14);
                canvas2.DrawImage(pic1, r15);
                canvas2.DrawImage(pic1, r16);
                // Canvas speichern
                canvas2.Save();

                try
                {   
                    // Bitmap auf dem PC als "JPG" speichern
                    bitmap2.Save(@"C:\Users\de17166\Desktop\Image.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch (System.Exception ex)
                {
                    throw;
                }
            }

            base.OnPaint(e);
        }

        private void toolStripMenuItem2_Click(object sender, System.EventArgs e)
        {

        }
    }
}

