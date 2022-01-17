using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio.View
{
    public partial class frmPB : Form
    {
        private int userId;
        public frmPB(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
    }
}
