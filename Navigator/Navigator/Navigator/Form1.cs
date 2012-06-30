using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Navigator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string route;

            string destination = textBox1.Text;
            Navigator navigator1 = new Navigator();
            navigator1.SetDestination(destination);
            route = navigator1.GetRoute();

            string avoidRoute = textBox2.Text;
            Navigator navigator2 = new Navigator();
            navigator2.SetDestination(destination);
            navigator2.ModifyRouteToAvoid(avoidRoute);

            string includeRoute = textBox3.Text;
            Navigator navigator3 = new Navigator();
            navigator3.SetDestination(destination);
            navigator3.ModifyRouteToInclude(includeRoute);

            string message = "Total Distance: " + navigator1.TotalDistance() + "\n Total distance with avoided street: " +
                             navigator2.TotalDistance() + "\n Total distance with added street: " +
                             navigator3.TotalDistance();
            MessageBox.Show(message);

        }
    }
}
