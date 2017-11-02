using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccess;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataCommander dc = new DataCommander();
        List<string> containers = new List<string>();

        public Form1()
        {
            InitializeComponent();

            this.GetData.Click += getContainers;
            dc.ContainersReady += showContainers;
        }

        private void showContainers()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string item in containers)
            {
                sb.AppendLine(item);
            }
            ContainerTextBox.Text = sb.ToString();
        }

        private void getContainers(object sender, EventArgs e)
        {
            containers = dc.GetAllContainers();
        }
    }
}
