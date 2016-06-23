using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCrashTchrs.Screens
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void playButton_Click_1(object sender, EventArgs e)
        {
            //go to character select screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CharacterSelection cs = new CharacterSelection();


            // set the character select to display centre screen
            cs.Location = new Point((f.Width - cs.Width) / 2, (f.Height - cs.Height) / 2);

            f.Controls.Add(cs);
        }

        private void recentBoard_Click(object sender, EventArgs e)
        {
            //go to recently played matches screen 
            Form f = this.FindForm();
            f.Controls.Remove(this);

            TallyScreen ts = new TallyScreen();

            // set the tally screen to display centre screen
            ts.Location = new Point((f.Width - ts.Width) / 2, (f.Height - ts.Height) / 2);

            f.Controls.Add(ts);
        }
    }
}

