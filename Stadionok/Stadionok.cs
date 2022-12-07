using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadionok
{
    public partial class Stadionok : Form
    {
        Database database = new Database();
        public Stadionok()
        {
            InitializeComponent();
        }

        private void Stadionok_Load(object sender, EventArgs e)
        {
            StadionokBetoltese();
        }
        public void StadionokBetoltese()
        {

            listBox_Stadionok.Items.Clear();
            foreach (stadion_adat item in database.getAllStadion())
            {
                listBox_Stadionok.Items.Add(item);
            }
        }

        private void újStadionBeviteleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Ujstadion.ShowDialog();
            StadionokBetoltese();

        }

        private void stadionMódosításaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Modositstadion.ShowDialog();
            StadionokBetoltese();
        }

        private void stadionTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Stadiontorlese.ShowDialog();
            StadionokBetoltese();
        }
    }
}
