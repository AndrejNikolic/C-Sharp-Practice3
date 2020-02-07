using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomaciZadatak12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start = startTime.Value.Hour * 60 + startTime.Value.Minute;
            int end = endTime.Value.Hour * 60 + endTime.Value.Minute;

            int resultMins, resultHours;

            if (start == end) {
                MessageBox.Show("Leave and arrival time can't be the same", "Warning!", MessageBoxButtons.OK);
            }
            else if (start < end)
            {
                resultMins = (end - start) % 60;
                resultHours = ((end - start) - resultMins) / 60;
                String strHour = "";
                if (resultHours < 2)
                {
                    strHour = " hour";
                }else
                {
                    strHour = " hours";
                }

                result.Text = "Plane will land in: " + resultHours.ToString() + strHour + " and " + resultMins.ToString() + " minutes";
            }
            else {
                resultMins = 60 + (end - start) % 60;
                resultHours = 24 + ((end - start) - resultMins) / 60;

                result.Text = "Plane will land in: " + resultHours.ToString() + " hours and " + resultMins.ToString() + " minutes";
            }
            
        }
    }
}
