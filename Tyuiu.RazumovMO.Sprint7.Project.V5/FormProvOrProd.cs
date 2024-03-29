using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.RazumovMO.Sprint7.Project.V5
{
    public partial class FormProvOrProd : Form    
    {
        public FormProvOrProd()
        {
            InitializeComponent();
            
        }

        private void FormProvOrProd_Load(object sender, EventArgs e)
        {

        }

        private void ButtonNamedDeleteProd_rmo_Click(object sender, EventArgs e)
        {
            FormProducts newForm = new FormProducts();
            this.Close();
            this.Hide();
            newForm.ShowDialog();            
        }

        private void ButtonNamedDeleteProv_rmo_Click(object sender, EventArgs e)
        {
            FormProviders newForm = new FormProviders();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
