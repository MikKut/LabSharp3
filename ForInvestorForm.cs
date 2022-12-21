using System;
using Lb3_CSharp.Extensions;
using System.Windows.Forms;

namespace Lb2_Sharp
{
    public partial class ForInvestorForm : Form
    {
        private bool mock = false;
        private FactoriesDirection.FactoriesDirection _direction;
        public ForInvestorForm()
        {
            _direction = FactoriesDirection.FactoriesDirection.GetInstance();
            InitializeComponent();
        }

        public void RenovateListOfFactories()
        {
            ListOfInvestmentResults.Clear();
            ListOfFactories.Clear();
            foreach (var factory in _direction.GetAllFactories())
            {
                ListOfFactories.Items.Add(factory.Key);
            }
        }
        private void AddMOneyToTheMoneyList(string factoryName)
        {
            ListOfInvestmentResults.Items.Add(_direction.GetFactory(factoryName).ValueIncomeFromInvestition(InvestitionNumeric.Value).ToString());
        }
        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void ListOfFactories_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (mock)
            {
                if (ListOfFactories.Focused)
                {
                    AddMOneyToTheMoneyList(ListOfFactories.FocusedItem.Text);
                }
                mock = false;
                return;
            }
            mock = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
