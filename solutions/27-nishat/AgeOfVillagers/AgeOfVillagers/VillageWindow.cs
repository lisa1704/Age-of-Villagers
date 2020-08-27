using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AgeOfVillagers
{
    public partial class Villagewindow : Form
    {
        List<INationFactory> nationlist = new List<INationFactory>();
        public Village village = null;
        public Graphics g;
        Pen p;

        public Villagewindow()
        {
            InitializeComponent();
            g = drawingpanel.CreateGraphics();
            p = new Pen(Color.Black);
        }

        private void Villagewindow_Load(object sender, EventArgs e)
        {
            nationlist.Add(new Nationfactory1());
            nationlist.Add(new Nationfactory2());
            nationlist.Add(new Nationfactory3());
        }

        private void btnnewvillage_Click(object sender, EventArgs e)
        {
            var selector = new NewVillageSelectorwindow(nationlist, this);
            selector.Show();
        }

        private void btnopenvillage_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsavevillage_Click(object sender, EventArgs e)
        {
            if (village != null)
            {
                IState state = village.GetState();
                //String villagename = "a";
                Savestate(state);
            }
        }

        private void Savestate(IState state)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "save village|*.aov";
            saveFileDialog1.Title = "Save village";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                var dataString = JsonConvert.SerializeObject(state, Formatting.Indented);
                System.IO.File.WriteAllText(saveFileDialog1.FileName, dataString);
            }
        }
    }
    
}

