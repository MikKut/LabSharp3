using Lb3_CSharp.Models;
using System;
using System.Windows.Forms;

namespace Lb2_Sharp
{
    public partial class UnitFactoriesForm : Form
    {
        public UnitFactoriesForm()
        {
            InitializeComponent();
        }
        public void InitializeNewFactoryInfo(IFactory factory)
        {
            NameBox.Text = factory.Name;
            QuantityOfWorkshops.Text = factory.QuantityOfWorkshops.ToString();
            QuantityOfEmployeesBox.Text = factory.FactoryHR.QuantityOfSlaves.ToString();
            IncomePerSlave.Text = factory.FactoryHR.IncomePerSlave.ToString();
            QuantityOfMasters.Text = factory.FactoryHR.QuantityOfMasters.ToString();
            IncomePerMasterBox.Text = factory.FactoryHR.IncomePerMaster.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IncomePerMaster_Click(object sender, EventArgs e)
        {

        }

        private void IncomePerSlave_Click(object sender, EventArgs e)
        {

        }

        private void QuantityOfWorkshops_Click(object sender, EventArgs e)
        {

        }

        private void UnitFactoriesForm_Load(object sender, EventArgs e)
        {

        }

        private void QuantityOfMasters_Click(object sender, EventArgs e)
        {

        }

        private void QuantityOfSlavesLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
