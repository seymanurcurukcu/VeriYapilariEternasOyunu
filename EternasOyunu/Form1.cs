using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EternasOyunu
{
    public partial class frmEternas : Form
    {
        public ArrayTypedStack ats;
        public frmEternas()
        {
            InitializeComponent();
            ats = new ArrayTypedStack();
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            ats.Push();
            for (int i = 1; i < 9; i++)
            {
                var cubukDeger = ats.items.FindAll(x => x.cubuk == i);
                string renkler = "";
                int w = 0;
                int g = 0;
                for (int j = 0; j < cubukDeger.Count; j++)
                {
                    renkler = renkler + cubukDeger[j].wg;
                    if (cubukDeger[j].wg == "w")
                    {
                        w++;
                    }
                    else
                    {
                        g++;
                    }
                }
                lstListele.Items.Add("S" + i + ":" + renkler);

                if (w == 4)
                {
                    MessageBox.Show("Kazanan beyaz takım");
                    btnOyna.Enabled = false;
                }
                else if (g == 4)
                {
                    MessageBox.Show("Kazanan yeşil takım");
                    btnOyna.Enabled = false;
                }
                else if (ats.items.Count == 32 && w != 4 && g != 4)
                {
                    MessageBox.Show("Berabere");
                    btnOyna.Enabled = false;
                }

            }
            lstListele.Items.Add(" ");
        }
    }
}
