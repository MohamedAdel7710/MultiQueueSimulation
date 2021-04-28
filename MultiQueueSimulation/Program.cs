using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueTesting;
using MultiQueueModels;
using System.IO;
using System.Text;

namespace MultiQueueSimulation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SimulationSystem system = new SimulationSystem();
            var list = ReadFile();
            //init(system,lines);
            /*for (int i = 0; i < int.Parse(list[1]); i++)
            {
                system.Servers.Add(new Server());
                system.Servers[i].ID = i + 1;
            }*/
            Console.WriteLine("number of servers is"  + system.Servers.Count);
            string result = TestingManager.Test(system, Constants.FileNames.TestCase1);
            MessageBox.Show(result);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }
        static List<String> ReadFile()
        {
            String filePath = @"C:\Users\Abdelrahman Saad\Desktop\Template_Students\MultiQueueSimulation\MultiQueueSimulation\TestCases\TestCase1.txt";
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var sr = new StreamReader(fileStream, Encoding.UTF8);
            String line;
            List<String> list = new List<string>();
            while ((line = sr.ReadLine()) != null)
                list.Add(line);
            Console.WriteLine(list.Count);
            return list;
        }
        static void init(SimulationSystem system, List<String> lines)
        {
            /*
             *  This is to initalize the simulation system from a text file
             */
            var NumOfServer = int.Parse(lines[1]);
            var StoppingNUmber = int.Parse(lines[4]);
            var StoppingCriteria = int.Parse(lines[7]);
            var SelectionMethod = int.Parse(lines[10]);
            Dictionary<int, List<double>> IntervalDistribution = new Dictionary<int, List<double>>();
            int i = 13;
            while (lines[i].Length == 0)
            {
                var results = lines[i].Split(',');
                IntervalDistribution.Add(int.Parse(results[0]), new List<double> { double.Parse(results[1]) });
            }
            /*
             * update the list with the cummulative probability and min/max range
             */
            for (int j = 0; j < IntervalDistribution.Count; j++)
            {
             //   if(j ==0)
               //     IntervalDistribution[j].Add(IntervalDistribution[j])
            }
            // handeling the server tables
            /*i = 19;
            Dictionary<int, List<double>> ServiceDistribution = new Dictionary<int, List<double>>();
            while (lines[i].Length == 0)
            {
                var results = lines[i].Split(',');
                IntervalDistribution.Add(int.Parse(results[0]), new List<double> { double.Parse(results[1]) });
            }*/
        }
    }
}
