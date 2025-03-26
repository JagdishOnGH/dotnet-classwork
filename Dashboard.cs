using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginToDashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard(string message)
        {
            InitializeComponent();
            label1.Text = $"Welcome to Dashboard, Your Message {message}";
        }
    }
}
