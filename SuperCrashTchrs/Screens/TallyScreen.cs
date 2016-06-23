using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SuperCrashTchrs.Screens
{
    public partial class TallyScreen : UserControl
    {
        public TallyScreen()
        {
            InitializeComponent();
        }

        private void TallyScreen_Load(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("");
        }
    }
}
