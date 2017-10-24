using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursOfWorkLib
{
    public class Import
    {
        #region Constructors

        public Import()
        {
            
        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        public List<TimeDataset> ImportCSVFile(String path)
        {
            List<TimeDataset> data = new List<TimeDataset>();

            using (StreamReader sr = new StreamReader(path))
            {

                // Read and display lines from the file until the end of 
                // the file is reached.
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();
                    String[] values = line.Split(',');

                    TimeDataset tempDataset = new TimeDataset();
                    tempDataset.Date = Convert.ToDateTime(values[0]);

                    data.Add(tempDataset);
                }
            }

            return data;
        }

        #endregion
    }
}
