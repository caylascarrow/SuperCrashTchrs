using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperCrashTchrs.Screens;

namespace SuperCrashTchrs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

                 // display the main menu
            Screens.MainScreen mm = new Screens.MainScreen();

            // set the menu to display centre screen based on screen size defaults
            mm.Size = new Size(ScreenControl.controlWidth, ScreenControl.controlHeight);
            mm.Location = ScreenControl.startCentre;

            // add main menu screen to form
            this.Controls.Add(mm);
        }
    }
}
