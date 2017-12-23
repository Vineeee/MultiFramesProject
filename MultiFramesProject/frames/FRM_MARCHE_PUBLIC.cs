using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFramesProject.frames
{
    public partial class FRM_MARCHE_PUBLIC : Form
    {
        public FRM_MARCHE_PUBLIC()
        {
            InitializeComponent();
        }

        public FRM_MARCHE_PUBLIC(int iID_MARCHE_PUBLIC)
        {
            InitializeComponent();
        }

        private void BTN_RECHERCHER_Click(object sender, EventArgs e)
        {
            DataTable dt_recherche = new DataTable();
            dt_recherche.Columns.Add("ID_MARCHE_PUBLIC", typeof(int));
            dt_recherche.Columns.Add("TITRE", typeof(string));
            dt_recherche.Columns.Add("TYPE_AVIS", typeof(string));
            dt_recherche.Columns.Add("SOURCE", typeof(string));

            dt_recherche.Rows.Add(1000, "Assistance à Maître d'ouvrage", "APOF", "BOAMP");
            dt_recherche.Rows.Add(1002, "Detection de Multimedia", "APOF", "BOAMP");
            dt_recherche.Rows.Add(1005, "Construction d'une école de petits", "APOF", "BOAMP");

            TABLE_RESULTAT_RECHERCHE.DataSource = dt_recherche;
        }
    }
}
