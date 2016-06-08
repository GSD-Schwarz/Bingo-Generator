namespace Awsome_Bingo_Karten_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this._3mal3Radio = new System.Windows.Forms.RadioButton();
            this._4malmRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Bilderunterschriften = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
                         // 
                         // _3mal3Radio
                         // 
            this._3mal3Radio.AutoSize = true;
            this._3mal3Radio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._3mal3Radio.Location = new System.Drawing.Point(6, 30);
            this._3mal3Radio.Name = "_3mal3Radio";
            this._3mal3Radio.Size = new System.Drawing.Size(50, 23);
            this._3mal3Radio.TabIndex = 1;
            this._3mal3Radio.TabStop = true;
            this._3mal3Radio.Text = "3x3";
            this._3mal3Radio.UseVisualStyleBackColor = true;
            this._3mal3Radio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
                         // 
                         // _4malmRadio
                         // 
            this._4malmRadio.AutoSize = true;
            this._4malmRadio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._4malmRadio.Location = new System.Drawing.Point(103, 30);
            this._4malmRadio.Name = "_4malmRadio";
            this._4malmRadio.Size = new System.Drawing.Size(50, 23);
            this._4malmRadio.TabIndex = 2;
            this._4malmRadio.TabStop = true;
            this._4malmRadio.Text = "4x4";
            this._4malmRadio.UseVisualStyleBackColor = true;
            this._4malmRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
                         // 
                         // groupBox1
                         // 
            this.groupBox1.Controls.Add(this._3mal3Radio);
            this.groupBox1.Controls.Add(this._4malmRadio);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Größe";
                         // 
                         // groupBox2
                         // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 264);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilderauswahl";
                         // 
                         // button4
                         // 
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(442, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 34);
            this.button4.TabIndex = 1;
            this.button4.Text = "Bild +";
            this.button4.UseVisualStyleBackColor = true;
                         // 
                         // button1
                         // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(559, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ordner öffnen";
            this.button1.UseVisualStyleBackColor = true;
                         // 
                         // groupBox3
                         // 
            this.groupBox3.Controls.Add(this.Bilderunterschriften);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(675, 87);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bingo-Formular";
                         // 
                         // button3
                         // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(122, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "leeren";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
                         // 
                         // button2
                         // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "generieren";
            this.button2.UseVisualStyleBackColor = true;
                         // 
                         // statusStrip1
                         // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
              this.statuslabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(700, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
                         // 
                         // statuslabel1
                         // 
            this.statuslabel1.Name = "statuslabel1";
            this.statuslabel1.Size = new System.Drawing.Size(118, 17);
            this.statuslabel1.Text = "toolStripStatusLabel1";
                         // 
                         // openFileDialog1
                         // 
            this.openFileDialog1.FileName = "openFileDialog1";
                         // 
                         // Bilderunterschriften
                         // 
            this.Bilderunterschriften.AutoSize = true;
            this.Bilderunterschriften.Location = new System.Drawing.Point(238, 34);
            this.Bilderunterschriften.Name = "Bilderunterschriften";
            this.Bilderunterschriften.Size = new System.Drawing.Size(183, 27);
            this.Bilderunterschriften.TabIndex = 9;
            this.Bilderunterschriften.Text = "Bilderunterschriften";
            this.Bilderunterschriften.UseVisualStyleBackColor = true;
            this.Bilderunterschriften.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
                         // 
                         // Form1
                         // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 505);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bingo-Generator | Einstellungen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton _3mal3Radio;
        private System.Windows.Forms.RadioButton _4malmRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox Bilderunterschriften;
    }
}