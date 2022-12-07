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
    public partial class ujstadion : Form
    {
        Database database = new Database();
        public ujstadion()
        {
            InitializeComponent();
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
        private void ujstadion_Load(object sender, EventArgs e)
        {
          
        }

        private void button_uj_Click(object sender, EventArgs e)
        {
            if (HiagyzoAdat())
            {
                return;
            }
            stadion_adat insertstadion = new stadion_adat(1, textBox_nev.Text, Convert.ToInt32(textBox_ferohely.Text), textBox_varos.Text, Convert.ToInt32(textBox_epult.Text));
            if (database.insertStadion(insertstadion))
            {
                MessageBox.Show("Sikeres adatbevitel!");
                textBox_id.Text = "";
                textBox_nev.Text = "";
                textBox_ferohely.Text = "";
                textBox_varos.Text = "";
                textBox_epult.Text = "";
            }
            else
            {
                MessageBox.Show("Sikertelen adatbevitel!");
            }
            Program.stadionok.StadionokBetoltese();
            Close();
        }
    }
    
}
