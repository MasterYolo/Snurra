using Snurra.Operation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snurra.Enteties
{
    /// <summary>
    /// IdentifyEntety - Takes the strings that were passed from the newly written file
    /// and identify it as a transaction.
    /// </summary>
    public class IdentifyEntety
    {
        private String[] lines;
        private TransactionEntety[] transactionEntety;

        public IdentifyEntety(String[] lines)
        {
            this.lines = lines;
            TransactionEntety = new TransactionEntety[lines.Length];
        }

        public TransactionEntety[] TransactionEntety { get => transactionEntety; set => transactionEntety = value; }

        public TransactionEntety[] identify()
        {
            TransactionEntety = new TransactionEntety[lines.Length];
            for (int i = 0; i < lines.Length-1; i++)
            {
                TransactionEntety[i] = new TransactionEntety();
                //Company name.
                TransactionEntety[i].CompanyName = lines[i].Substring(0, 7);
                //Aqustition value
                TransactionEntety[i].AqustitionValueByLine = Convert.ToInt32(lines[i].Substring(7, 6));
                //Transaction date
                TransactionEntety[i].Date = DateTime.Parse(lines[i].Substring(13, 8).Insert(4, "-").Insert(7, "-"));
                //Shares
                TransactionEntety[i].Shares = Convert.ToInt16(lines[i].Substring(lines[i].Length - 4, 4));
            }
            return TransactionEntety;
        }
    }
}
