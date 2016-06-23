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

namespace SuperCrashTchrs
{
    public partial class EndScreen : UserControl
    {
        public EndScreen()
        {
            InitializeComponent();

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("recentlyPlayed.xml");

                XmlNode parent;
                parent = doc.DocumentElement;

                //check each child of the parent element
                foreach (XmlNode child in parent.ChildNodes)
                {
                    
                }
             }

            catch
            {
                XmlTextWriter writer = new XmlTextWriter("recentlyPlayed.xml", null);

                writer.WriteStartElement("recency");

                writer.WriteElementString("winner", "");

                writer.WriteElementString("loser", "");
            }

        }
    }
}
