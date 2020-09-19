using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        Pen myPen = new Pen(Color.Green,2);

        public Form1()
        {
            InitializeComponent();
            //this.Width = 600;
            //this.Height = 400;
         
        }
        private void button10_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Save Village");

            /*SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Files(*.txt)|*.txt|All Files (*.*)|*.*";
            if (save.ShowDialog()==DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                write.Write(Text);
                write.Dispose();                
            }

            else
            {
                throw new Exception();
            }*/

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("New Village");
            Refresh();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Open Village");
            /*OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files(*.txt)|*.txt| All Files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(open.FileName));
                Text = read.ReadToEnd();
                read.Dispose();
            }
            */
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            

            x =e.X;
            y = e.Y;
            //h = 100;
            //w = 200;
            Graphics g = this.CreateGraphics();

            string nation = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

            if (nation == "Bangladeshi Farmers")
            {
                panel1.BackColor = Color.White;
                BackColor = Color.Green;

                if (radioButton1.Checked)
                {
                    BangladeshiFarmers bdh = new BangladeshiFarmers(g);
                    bdh.DrawHouse(e);



                }

                if (radioButton2.Checked)
                {
                    BangladeshiFarmers bdt = new BangladeshiFarmers(g);
                    bdt.DrawTree(e);

                }
                if (radioButton3.Checked)
                {
                    //g.DrawLine(myPen, x, y, h, w);

                    BangladeshiFarmers bds = new BangladeshiFarmers(g);
                    bds.DrawWaterSource(e);

                }
            }

            else if (nation == "Egypt Kings")
            {

                panel1.BackColor = Color.White;
                BackColor = Color.Yellow;

                if (radioButton1.Checked)
                {

                    EgyptianKing ekh = new EgyptianKing(g);
                    ekh.DrawHouse(e);

                }

                if (radioButton2.Checked)
                {
                    EgyptianKing ekt = new EgyptianKing(g);
                    ekt.DrawTree(e);

                }
                if (radioButton3.Checked)
                {


                    EgyptianKing eks = new EgyptianKing(g);
                    eks.DrawWaterSource(e);

                }
            }

            else if (nation == "Inuit Hunters")
            {
                BackColor = Color.White;

                if (radioButton1.Checked)
                {

                    InuitHunters iht = new InuitHunters(g);
                    iht.DrawHouse(e);

                }

                if (radioButton2.Checked)
                {
                    InuitHunters iht = new InuitHunters(g);
                    iht.DrawTree(e);

                }
                if (radioButton3.Checked)
                {


                    InuitHunters iht = new InuitHunters(g);
                    iht.DrawWaterSource(e);

                }
                
            }

            else if (nation == "Arab Bedouin")
            {
                panel1.BackColor = Color.White;
                BackColor = Color.YellowGreen; 
                if (radioButton1.Checked)
                {

                    ArabBedouin abt = new ArabBedouin(g);
                    abt.DrawHouse(e);

                }

                if (radioButton2.Checked)
                {
                    ArabBedouin abt = new ArabBedouin(g);
                    abt.DrawTree(e);

                }
                if (radioButton3.Checked)
                {


                    ArabBedouin abt = new ArabBedouin(g);
                    abt.DrawWaterSource(e);

                }
                
            }


        }


        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             //x = e.X;
             //y = e.Y;
        }




    }
}
