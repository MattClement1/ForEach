/*
*Created by: Matthew Clement
*Created on: 19-Oct-2015
*Created for: Unit #3-12
*This program makes all the control objects invisible
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEach
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            foreach (Control aControl in this.Controls) 
            {
                aControl.Visible = false; 
            }
        }
    }
}
