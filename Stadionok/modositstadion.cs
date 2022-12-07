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
    public partial class modositstadion : Form
    {
        Database database = new Database();
        public modositstadion()
        {
            InitializeComponent();
        }

        private void modositstadion_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Program.stadionok.listBox_Stadionok.Text + " adatainak a módositása");
            stadion_adat ja = (stadion_adat)Program.stadionok.listBox_Stadionok.SelectedItem;
            textBox_id.Text = Convert.ToString(ja.Id);
            textBox_nev.Text = Convert.ToString(ja.Stadion);
            textBox_ferohely.Text = Convert.ToString(ja.Ferohely);
            textBox_varos.Text = Convert.ToString(ja.Varos);
            textBox_epult.Text = Convert.ToString(ja.Epult);
        }
        private bool HiagyzoAdat()
        {
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Adja meg a stadion nevét!");
                textBox_nev.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_ferohely.Text))
            {
                MessageBox.Show("Adja meg a ferőhelyet!");
                textBox_ferohely.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_varos.Text))
            {
                MessageBox.Show("Adja meg a város nevét!");
                textBox_varos.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_epult.Text))
            {
                MessageBox.Show("Adja meg mikor épült!");
                textBox_epult.Focus();
                return true;
            }
            return false;
        }
        private void button_modosit_Click(object sender, EventArgs e)
        {
            if (HiagyzoAdat())
            {
                return;
            }
            stadion_adat update_stadion = new stadion_adat(1, textBox_nev.Text, Convert.ToInt32(textBox_ferohely.Text), textBox_varos.Text, Convert.ToInt32(textBox_epult.Text));
            if (database.updateStadion(update_stadion))
            {
                MessageBox.Show("Sikeres rögzites!");
                textBox_id.Text = "";
                textBox_nev.Text = "";
                textBox_ferohely.Text = "";
                textBox_varos.Text = "";
                textBox_epult.Text = "";                
            }
            else
            {
                MessageBox.Show("Sikertelen rögzites!");
            }
            Program.stadionok.StadionokBetoltese();
            Close();
        }
    }
}
