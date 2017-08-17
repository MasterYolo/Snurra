using Snurra.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snurra.Operation
{
    /// <summary>
    /// Calculate class handles the calculations in the application which are once done passed to the controller.
    /// </summary>
    public class Calculate
    {
        //Hard coded values for assignment two.
        double ABB_LTD = 159.50;
        double SSAB_B = 160.50;
        double VOLVO_B = 93.75;
        int i;

        /// <summary>
        /// calculateAqustitionValue - 
        /// Calculates the aqustitionvalue by grouping up the different companies then uses the previous element's 
        /// shares and aqustitionvalue to determinate the new value.
        /// It uses Math.Abs() to remove all the negative values from.
        /// </summary>
        /// <param name="transaction">List of selected transaction</param>
        /// <returns>List of transaction with calculated Aqustition value.</returns>
        public List<TransactionEntety> calculateAqustitionValue(List<TransactionEntety> transaction)
        {
            List<TransactionEntety> volvoTransactions = new List<TransactionEntety>();
            List<TransactionEntety> ABB_LTDTransactions = new List<TransactionEntety>();
            List<TransactionEntety> SSAB_BTransactions = new List<TransactionEntety>();
            List<TransactionEntety> calculatedResult = new List<TransactionEntety>();
            


            for (i = 0; i < transaction.Count; i++)
            {
                if (transaction[i].CompanyName.Contains("VOLVO B"))
                {
                    volvoTransactions.Add(transaction[i]);

                }

                else if (transaction[i].CompanyName.Contains("ABB LTD"))
                {
                    ABB_LTDTransactions.Add(transaction[i]);


                }
                else if (transaction[i].CompanyName.Contains("SSAB B"))
                {
                    SSAB_BTransactions.Add(transaction[i]);
                }

            }

            for (i = 0; i < volvoTransactions.Count; i++)
            {
                if (i == 0)
                {
                    volvoTransactions[i].AqustitionValueByCalculation = volvoTransactions[i].AqustitionValueByLine;
                }
                else if (volvoTransactions[i].Shares < 0)
                {
                    volvoTransactions[i].AqustitionValueByCalculation = volvoTransactions[i - 1].AqustitionValueByCalculation -
                        ((Math.Abs(volvoTransactions[i - 1].AqustitionValueByCalculation) / Math.Abs(volvoTransactions[i - 1].Shares)) * Math.Abs(volvoTransactions[i].Shares));
                    volvoTransactions[i].Shares = volvoTransactions[i - 1].Shares + volvoTransactions[i].Shares;
                }
                else
                {
                    volvoTransactions[i].AqustitionValueByCalculation += volvoTransactions[i - 1].AqustitionValueByCalculation + volvoTransactions[i].AqustitionValueByLine;
                    volvoTransactions[i].Shares = volvoTransactions[i - 1].Shares + volvoTransactions[i].Shares;
                }
            }
            for (i = 0; i < ABB_LTDTransactions.Count; i++)
            {
                if (i == 0)
                {
                    ABB_LTDTransactions[i].AqustitionValueByCalculation = ABB_LTDTransactions[i].AqustitionValueByLine;
                }
                else if (ABB_LTDTransactions[i].Shares < 0)
                {
                    ABB_LTDTransactions[i].AqustitionValueByCalculation = ABB_LTDTransactions[i - 1].AqustitionValueByCalculation -
                        ((Math.Abs(ABB_LTDTransactions[i - 1].AqustitionValueByCalculation) / Math.Abs(ABB_LTDTransactions[i - 1].Shares)) * Math.Abs(ABB_LTDTransactions[i].Shares));
                    ABB_LTDTransactions[i].Shares = ABB_LTDTransactions[i - 1].Shares + ABB_LTDTransactions[i].Shares;
                }
                else
                {
                    ABB_LTDTransactions[i].AqustitionValueByCalculation += ABB_LTDTransactions[i - 1].AqustitionValueByCalculation
                        + ABB_LTDTransactions[i].AqustitionValueByLine;
                    ABB_LTDTransactions[i].Shares = ABB_LTDTransactions[i - 1].Shares + ABB_LTDTransactions[i].Shares;

                }
            }

            for (i = 0; i < SSAB_BTransactions.Count; i++)
            {
                if (i == 0)
                {
                    SSAB_BTransactions[i].AqustitionValueByCalculation = SSAB_BTransactions[i].AqustitionValueByLine;
                }
                else if (SSAB_BTransactions[i].Shares < 0)
                {
                    SSAB_BTransactions[i].Shares = SSAB_BTransactions[i - 1].Shares + SSAB_BTransactions[i].Shares;
                    SSAB_BTransactions[i].AqustitionValueByCalculation = SSAB_BTransactions[i - 1].AqustitionValueByCalculation -
                        ((Math.Abs(SSAB_BTransactions[i - 1].AqustitionValueByCalculation) / Math.Abs(SSAB_BTransactions[i - 1].Shares)) * Math.Abs(SSAB_BTransactions[i].Shares));
                }
                else
                {
                    SSAB_BTransactions[i].AqustitionValueByCalculation += SSAB_BTransactions[i - 1].AqustitionValueByCalculation
                        + SSAB_BTransactions[i].AqustitionValueByLine;
                    SSAB_BTransactions[i].Shares = SSAB_BTransactions[i - 1].Shares + SSAB_BTransactions[i].Shares;
                }
            }
            return calculatedResult = volvoTransactions.Concat(ABB_LTDTransactions).Concat(SSAB_BTransactions).ToList();
        }

        /// <summary>
        /// Calculates the Marketvalue by multiplying the shares of each transaction
        /// with the
        /// </summary>
        /// <param name="selectedTransactions"></param>
        /// <returns></returns>
        public List<TransactionEntety> calculateMarketValue(List<TransactionEntety> selectedTransactions)
        {
            for (i = 0; i < selectedTransactions.Count; i++)
            {
                if (selectedTransactions[i].CompanyName.Contains("VOLVO B"))
                {
                    selectedTransactions[i].MarketValue = Convert.ToInt32(selectedTransactions[i].Shares * VOLVO_B);

                }

                else if (selectedTransactions[i].CompanyName.Contains("ABB LTD"))
                {
                    selectedTransactions[i].MarketValue = Convert.ToInt32(selectedTransactions[i].Shares * ABB_LTD);


                }
                else if (selectedTransactions[i].CompanyName.Contains("SSAB B"))
                {
                    
                    selectedTransactions[i].MarketValue = Convert.ToInt32(selectedTransactions[i].Shares * SSAB_B);
                }

            }
            return selectedTransactions;
        }
    }
}
