using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Geçiş_Noktaları
{
    public partial class Form1 : Form
    {
        int x = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;

            if (progressBar1.Value!=29)
            {
                progressBar1.Value=progressBar1.Value+1;
            }



            if (x < 6)
            {
                switch (x)
                {
                    case 1: { label1.Visible = true; break; }

                    case 2: { label2.Visible = true; break; }

                    case 3: { label3.Visible = true; break; }

                    case 4: { label4.Visible = true; break; }

                    case 5: { label5.Visible = true; break; }



                }

            }

            else if (x<16)
            {
                timer1.Interval = 50;

                label5.Location = new Point(label5.Location.X + 35, 45);
                label4.Location = new Point(label4.Location.X + 35, 45);
                label3.Location = new Point(label3.Location.X + 35, 45);
                label2.Location = new Point(label2.Location.X + 35, 45);
                label1.Location = new Point(label1.Location.X + 35, 45);

            }

           

            else if (x<29)
            {
                label5.Location = new Point(label5.Location.X + 35, 45);
                label4.Location = new Point(label4.Location.X + 35, 45);
                label3.Location = new Point(label3.Location.X + 35, 45);
                label2.Location = new Point(label2.Location.X + 35, 45);
                label1.Location = new Point(label1.Location.X + 35, 45);
            }

            else if (x<35)
            {
                timer1.Interval = 250;
                 switch (x)
                {
                    case 30: { label1.Visible = false; break; }

                    case 31: { label2.Visible = false; break; }

                    case 32: { label3.Visible = false; break; }

                    case 33: { label4.Visible = false; break; }

                    case 34: 
                        
                        { 
                            label5.Visible = false; 
                            
                            x = 0;

                            label1.Location = new Point(10, 45);
                            label2.Location = new Point(45, 45);
                            label3.Location = new Point(80, 45);
                            label4.Location = new Point(115, 45);
                            label5.Location = new Point(140, 45);
                            progressBar1.Value = 0;
                            
                            break; 


                        }



                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Maximum = 29;
           

        }
    }
}
