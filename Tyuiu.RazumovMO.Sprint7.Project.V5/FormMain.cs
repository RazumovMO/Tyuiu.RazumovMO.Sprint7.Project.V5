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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonNamedInfo_RMO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение с информацией о кодах товаров, названиях товаров, количестве на складе, стоимости единицы товара, примечания - описание товара, номере и ФИО поставщика товара.");
        }

        private void ButtonNamedProducts_rmo_Click(object sender, EventArgs e)
        {
            FormProducts newForm = new FormProducts();
            newForm.ShowDialog();
        }


        private void ButtonNamedProviders_rmo_Click(object sender, EventArgs e)
        {
            FormProviders newForm = new FormProviders();
            newForm.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProducts newForm = new FormProducts();
            newForm.ShowDialog();
        }

        private void ButtonNamedAddProviders_rmo_Click(object sender, EventArgs e)
        {
            FormProviders newForm = new FormProviders();
            newForm.ShowDialog();
        }

        private void ButtonNamedDeleteProviderOrProduct_rmo_Click(object sender, EventArgs e)
        {
            FormProvOrProd newForm = new FormProvOrProd();
            newForm.ShowDialog();
            
        }

        private void ButtonNamedChangeTime_rmo_Click(object sender, EventArgs e)
        {
            FormTimeTable newForm = new FormTimeTable();
            newForm.ShowDialog();
        }
    }
}
