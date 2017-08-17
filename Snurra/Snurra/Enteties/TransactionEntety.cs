using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snurra.Enteties
{
    /// <summary>
    /// Entety class for the transaction used in this application.
    /// </summary>
    public class TransactionEntety
    {
        private String companyName;
        private DateTime date;
        private int shares;
        private int aqustitionValueByLine;
        private int numberOfTransactions;
        private int marketValue;
        private int aqustitionValueByCalculation;

        public string CompanyName { get => companyName; set => companyName = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Shares { get => shares; set => shares = value; }
        public int NumberOfTransactions { get => numberOfTransactions; set => numberOfTransactions = value; }
        public int MarketValue { get => marketValue; set => marketValue = value; }
        public int AqustitionValueByCalculation { get => aqustitionValueByCalculation; set => aqustitionValueByCalculation = value; }
        public int AqustitionValueByLine { get => aqustitionValueByLine; set => aqustitionValueByLine = value; }
    }
}
