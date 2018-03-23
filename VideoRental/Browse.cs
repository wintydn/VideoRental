using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental
{
    public partial class Browse : Form
    {
        public Browse()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Confirm f = new Confirm();
            f.ShowDialog();
        }

        private void Browse_Load(object sender, EventArgs e)
        {
            this.Height = 600;
            this.Width = 600;
        }
    }
}
