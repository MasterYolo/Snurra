using Snurra.Enteties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Snurra
{
    /// <summary>
    /// The GUI class of the Snurra application
    /// </summary>
    public partial class Snurra : Form
    {
        public Snurra()
        {
            InitializeComponent();
            AssignmentOne.Checked = true;
        }

        /// <summary>
        /// When the button is pressed the operation can begin.
        /// </summary>
        /// <param name="sender">A sender object</param>
        /// <param name="e">arguments</param>
        private void button1_Click(object sender, EventArgs e)
        {
            Textbox.Text = "";
            Controller controller = new Controller();
            TransactionEntety[] transactions = controller.readFile();
            List<TransactionEntety> selectedTransactions = new List<TransactionEntety>();
            List<TransactionEntety> calculatedTransactionList = new List<TransactionEntety>();
            StringBuilder[] sb = new StringBuilder[transactions.Length];
            int i;

            if (AssignmentOne.Checked.Equals(true))
                {
                AssignmentTwo.Checked = false;
                dateTimePicker1.Value = DateTime.Parse("2007-07-31");
                for (i = 0; i < transactions.Length - 1; i++)
                {
                    if (transactions[i].Date < dateTimePicker1.Value)
                    {
                        selectedTransactions.Add(transactions[i]);
                    }
                }
                calculatedTransactionList = controller.calculateAqustitionValue(selectedTransactions);
                controller.writeAssignmentOneToFile(calculatedTransactionList);
                for (i = 0; i < calculatedTransactionList.Count; i++)
                {
                    sb[i] = new StringBuilder();
                    sb[i].AppendLine("Company name : " + calculatedTransactionList[i].CompanyName + ";"
                       + " Aqustition value : " + calculatedTransactionList[i].AqustitionValueByCalculation + ";"
                       + " Transaction date " + calculatedTransactionList[i].Date + ";"
                       + " Shares : " + calculatedTransactionList[i].Shares);
                    Textbox.AppendText(sb[i].ToString());
                } 
            }
            else
            {
                AssignmentOne.Checked = false;
                AssignmentTwo.Checked = true;
                dateTimePicker1.Value = DateTime.Parse("2008-02-28");
                for (i = 0; i < transactions.Length - 1; i++)
                {
                    if (transactions[i].Date < dateTimePicker1.Value)
                    {
                        selectedTransactions.Add(transactions[i]);
                    }
                }
                calculatedTransactionList = controller.calculateMarketValue(selectedTransactions);
                controller.writeAssignmentTwoToFile(calculatedTransactionList);
                for (i = 0; i < calculatedTransactionList.Count; i++)
                {
                    sb[i] = new StringBuilder();
                    sb[i].AppendLine("Company name : " + calculatedTransactionList[i].CompanyName + ";"
                       + " MarketValue : " + calculatedTransactionList[i].MarketValue + ";"
                       + " Transaction date " + calculatedTransactionList[i].Date + ";"
                       + " Shares : " + calculatedTransactionList[i].Shares);
                    Textbox.AppendText(sb[i].ToString());
                }

            }
        }
    }
}
