using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gr374_Manin_Alekseev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g374_l10_Manin_AlekseevDataSet.pt' table. You can move, or remove it, as needed.
            this.ptTableAdapter.Fill(this.g374_l10_Manin_AlekseevDataSet.pt);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ptBindingSource.EndEdit();
            ptTableAdapter.Update(g374_l10_Manin_AlekseevDataSet);
        }
    }
}
