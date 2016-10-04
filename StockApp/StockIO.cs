using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Files
{
    class StockIO
    {
        
        string NL = Environment.NewLine;
        internal void WriteStock(StringWriter sw, Stock asset)
        {
            sw.Write(asset.Symbol + NL + asset.PricePerShare + NL + asset.NumShares + NL);          
             
        }

        internal Stock ReadStock(StringReader data)
        {
           
            Stock datastock = new Stock(data.ReadLine(), Convert.ToDouble(data.ReadLine()) , Convert.ToInt32(data.ReadLine()));
          
            return datastock;
        }
        internal Stock ReadStock(FileInfo output)
        {
            string s = "";         
            using (StreamReader fs = output.OpenText())
            {
               s = fs.ReadToEnd();             

            }

            string[] data = s.Split();

            Stock datastock = new Stock(data[0], Convert.ToDouble(data[1]), Convert.ToInt32(data[2]));
            return datastock;
        }

        internal void WriteStock(FileInfo output, Stock asset)
        {            
            using (StreamWriter writer = output.AppendText())
            {
                writer.WriteLine(asset.Symbol + " " + asset.PricePerShare + " " + asset.NumShares);
            }
        }
    }
}
