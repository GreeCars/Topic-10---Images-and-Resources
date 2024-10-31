using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_10___Images_and_Resources
{
    public partial class FormAddResources : Form
    {
        public FormAddResources()
        {
            InitializeComponent();
        }

        private void imgMario_Click(object sender, EventArgs e)
        {
            imgMario.Image = Properties.Resources.MarioAwake;
            imgSleep.Visible = true;
        }

        private void imgSleep_Click(object sender, EventArgs e)
        {
            imgMario.Image = Properties.Resources.MarioSleep;
            imgSleep.Visible = false;
        }
    }
}
