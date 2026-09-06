using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Lights_Sim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ctrlTraficLight1.CountDownStartValue = 10;
            ctrlTraficLight1.Start();
            ctrlTraficLight2.Start();
            ctrlTraficLight3.Start();
            ctrlTraficLight4.Start();

        }

    }
}
