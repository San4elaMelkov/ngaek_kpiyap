using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kpyp_WF
{
    public partial class laba22_child : Form
    {
        public laba22_child(kpyp_WF.frmContainer parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }
    }
}
