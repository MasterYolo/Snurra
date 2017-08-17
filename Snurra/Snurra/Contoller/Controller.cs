using Snurra.Enteties;
using Snurra.Operation;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Snurra
{
    /// <summary>
    /// Controller passes to and recieves values back (Exception writing to file) 
    /// between the classes that handles the identification, filehandler, calculation
    /// and the graphical interface.
    /// </summary>
    public class Controller
    {
        public TransactionEntety[] readFile()
        {
            FileHandler.FileHandler fileHandler = new FileHandler.FileHandler();
            string[] lines = fileHandler.readFile();
            IdentifyEntety identifyEntety = new IdentifyEntety(lines);
            return identifyEntety.identify();
        }
        public List<TransactionEntety> calculateAqustitionValue(List<TransactionEntety> selectedTransactions)
        {
            Calculate calc = new Calculate();
            return calc.calculateAqustitionValue(selectedTransactions);
            
        }
        public List<TransactionEntety> calculateMarketValue(List<TransactionEntety> selectedTransactions)
        {
            Calculate calc = new Calculate();
            return calc.calculateMarketValue(selectedTransactions);
        }
        public void writeAssignmentOneToFile(List<TransactionEntety> transactions)
        {
            FileHandler.FileHandler fileHandler = new FileHandler.FileHandler();
            fileHandler.WriteAssignmentOneToFile(transactions);
        }
        public void writeAssignmentTwoToFile(List<TransactionEntety> transactions)
        {
            FileHandler.FileHandler fileHandler = new FileHandler.FileHandler();
            fileHandler.writeAssignmentTwoToFile(transactions);
        }

    }
}
