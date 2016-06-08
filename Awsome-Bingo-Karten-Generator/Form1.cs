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
    public partial class Form1 : Form
    {
        Bilderliste _Bilderliste = new Bilderliste();
        Controller _Controller = new Controller();

        public Form1()
        {
            InitializeComponent();
        }
         
          private void radioButton1_CheckedChanged(object sender, EventArgs e)
          {
              _Controller.setgridSize(9);
          }
  
          private void radioButton2_CheckedChanged(object sender, EventArgs e)
          {
              _Controller.setgridSize(16);
          }
  
          private void button3_Click(object sender, EventArgs e)
          {
              _Bilderliste.BingoCards.Clear();
              _Bilderliste.BingoPictures.Clear();
              _Controller.gridSize = 9;
          }
  
          private void checkBox1_CheckedChanged(object sender, EventArgs e)
          {
              _Controller.shouldCaptionsBeSet = Bilderunterschriften.Checked;
          }
  
          private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
          {
  
          }
    }
}
