using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinforms
{
    public partial class frmArticulos : Form
    {
        public string Texto { get; set; }

        public frmArticulos()
        {

            InitializeComponent();
           
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            if (Texto == "" ) 
            { 
                lblUno.Visible = false;
                lblMDFArt.Visible = false;
            }
            else 
            { 
                lblUno.Visible = true;
                lblMDFArt.Visible = true;
                lblUno.Text = Texto;
            }
        }
    }
    
}
