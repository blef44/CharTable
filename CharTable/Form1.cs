using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharTable
{
    public partial class Form1 : Form
    {
        private const int padding = 13, margin = 7, size = 38, colnum = 5;

        private string[] mainChars = { "À", "Ç", "ñ", "œ", "Œ", "ß" };
        private Button[] charButtons;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            //
            // Char Buttons
            //
            this.charButtons = new Button[mainChars.Length];
            for (int i = 0; i < mainChars.Length; i++)
            {
                charButtons[i] = new Button();
                Point logicLocation = new Point(i % colnum, i / colnum);
                charButtons[i].Location = new Point(padding + (margin + size) * logicLocation.X, padding + (margin + size) * logicLocation.Y);
                charButtons[i].Name = "charButton" + i;
                charButtons[i].Size = new Size(size, size);
                charButtons[i].TabIndex = 0;
                charButtons[i].Text = mainChars[i];
                charButtons[i].UseVisualStyleBackColor = true;
                charButtons[i].Click += new EventHandler(charButton_Click);

                Controls.Add(charButtons[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void charButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                Clipboard.SetText(button.Text);
                this.Close();
            }
        }
    }
}
