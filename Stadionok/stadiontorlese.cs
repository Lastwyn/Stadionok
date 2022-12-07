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
    public partial class stadiontorlese : Form
    {
        Database database = new Database();
        public stadiontorlese()
        {
            InitializeComponent();
        }

        private void button_torles_Click(object sender, EventArgs e)
        {
            stadion_adat deletestadion = new stadion_adat(1, textBox_nev.Text, Convert.ToInt32(textBox_ferohely.Text), textBox_varos.Text, Convert.ToInt32(textBox_epult.Text));
            if (database.deleteStadion(deletestadion))
            {
                MessageBox.Show("Sikeres törlés!");
                textBox_id.Text = "";
                textBox_nev.Text = "";
                textBox_ferohely.Text = "";
                textBox_varos.Text = "";
                textBox_epult.Text = "";
            }
            else
            {
                MessageBox.Show("Sikertelen törlés!");
            }
            Program.stadionok.StadionokBetoltese();
            Close();

        }

        private void stadiontorlese_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Program.stadionok.listBox_Stadionok.Text + " adatainak a törlése");
            stadion_adat ja = (stadion_adat)Program.stadionok.listBox_Stadionok.SelectedItem;
            textBox_id.Text = Convert.ToString(ja.Id);
            textBox_nev.Text = Convert.ToString(ja.Stadion);
            textBox_ferohely.Text = Convert.ToString(ja.Ferohely);
            textBox_varos.Text = Convert.ToString(ja.Varos);
            textBox_epult.Text = Convert.ToString(ja.Epult);

        }
    }
}
