using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFramesProject
{
    public partial class FRM_MDI : Form
    {

        frames.FRM_MARCHE_PUBLIC frm_marche_public;

        public FRM_MDI()
        {
            InitializeComponent();
        }

        private void marchéPublicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_marche_public == null)
            {
                frm_marche_public = new frames.FRM_MARCHE_PUBLIC();
                frm_marche_public.MdiParent = this;
                frm_marche_public.FormClosed += new FormClosedEventHandler(frm_marche_public_FormClosed);
                frm_marche_public.Show();
            }
            else
            {
                frm_marche_public.Activate();
            }
        }

        private void frm_marche_public_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_marche_public = null;
        }
    }
}
