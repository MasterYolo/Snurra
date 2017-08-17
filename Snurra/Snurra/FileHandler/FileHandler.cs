using Snurra.Enteties;
using System;
using System.Collections.Generic;
using System.IO;

namespace Snurra.FileHandler
{
    /// <summary>
    /// FileHandler - Reads from the file which is located in "Resources/Transaktioner.dat".
    /// It also writes to seperate outputfiles for assignment one and assignment two.
    /// </summary>
    public class FileHandler
    {
        public String[] readFile()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string[] lines = File.ReadAllLines(System.IO.Path.Combine(currentDirectory, "Resources", "Transaktioner.dat"));
            return lines;

        }
        public void WriteAssignmentOneToFile(List<TransactionEntety> transactions)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            using (var file = new StreamWriter((System.IO.Path.Combine(currentDirectory, "Resources", "OutputAssignmentOne.dat"))))
            {
                for (int i = 0; i < transactions.Count; i++)
                {
                    file.WriteLine(transactions[i].CompanyName + ";" + transactions[i].AqustitionValueByCalculation + ";" + transactions[i].Shares);
                }
            }

        }
        public void writeAssignmentTwoToFile(List<TransactionEntety> transactions)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            using (var file = new StreamWriter((System.IO.Path.Combine(currentDirectory, "Resources", "OutputAssignmentTwo.dat"))))
            {
                for (int i = 0; i < transactions.Count; i++)
                {
                    file.WriteLine(transactions[i].CompanyName + ";" + transactions[i].MarketValue + ";" + transactions[i].Shares);
                }
            }
        }
    }
}
