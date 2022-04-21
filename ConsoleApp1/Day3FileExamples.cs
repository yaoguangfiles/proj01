using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training {
    public class Day3FileExamples {
        private const string textFile1 = @"C:\main\skillStorm\projects\proj01\ConsoleApp1\TextFile1.txt";
        private const string textFile2 = @"C:\main\skillStorm\projects\proj01\ConsoleApp1\TextFile2.csv";
        private const string csvFile = @"C:\main\skillStorm\projects\proj01\ConsoleApp1\contacts.csv";

        //private string fileDir = Environment.CurrentDirectory;

        public void ReadFromTextFile1() {
            string textFileContents = File.ReadAllText(textFile1);

            Console.WriteLine($"All text {textFileContents}");


        }

        public void WriteToTextFile() {
            
            //if(File!File.Exists(textFile2)) {

            //}

            using (StreamWriter writer = File.AppendText(textFile1))
            {
                writer.WriteLine("More text added to the end of the file");
                writer.Write("This text appears on a different line");
                writer.Write("But this is on the same line as the last");
                writer.WriteLine("------------");
            }
        }

        public IEnumerable<CSVData> ReadCsvData() {
            List<CSVData> csvData = new List<CSVData>();

            using StreamReader reader = new StreamReader(csvFile);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');
                csvData.Add(new CSVData(values[0], values[1], values[2]));
            }

            return csvData;
        }
        
    }
}
