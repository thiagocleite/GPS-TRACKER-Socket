using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GPS1Visual
{
    public partial class FormMapa : Form
    {
        public FormMapa(string url)
        {
            InitializeComponent();
            webBrowserGoogleEarth.Navigate(url);
        }
    }
}
