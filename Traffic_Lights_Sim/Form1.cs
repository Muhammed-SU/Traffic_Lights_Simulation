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
        private ctrlTraficLight[] _TrafficLights;
        private int _CurrentLight = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _TrafficLights = new ctrlTraficLight[]
            {
            ctrlTraficLight1,
            ctrlTraficLight2,
            ctrlTraficLight3,
            ctrlTraficLight4
            };

            foreach (ctrlTraficLight light in _TrafficLights)
            {
                light.GreenFinished += TrafficLight_GreenFinished;
            }

            StartTrafficLight();
        }

        private void TrafficLight_GreenFinished(object sender, EventArgs e)
        {
            _CurrentLight++;

            if (_CurrentLight >= _TrafficLights.Length)
            {
                _CurrentLight = 0;
            }

            StartTrafficLight();
        }

        private void StartTrafficLight()
        {
            // Stop all traffic light timers
            foreach (ctrlTraficLight light in _TrafficLights)
            {
                light.Stop();
            }

            // Make all RED
            foreach (ctrlTraficLight light in _TrafficLights)
            {
                light.CurrentLight = ctrlTraficLight.LightEnum.Red;
            }

            _TrafficLights[_CurrentLight].CurrentLight = ctrlTraficLight.LightEnum.Orange;

            // Make current traffic light GREEN
            _TrafficLights[_CurrentLight].CurrentLight =
                ctrlTraficLight.LightEnum.Green;

            // Start only current traffic light
            _TrafficLights[_CurrentLight].Start();
        }
    }
}
