using System;
namespace _11_Files
{
    internal class Stock : IAsset
    {
        public int NumShares;
        public double PricePerShare;
        public string Symbol;

        public long Id { get; internal set; }

        public Stock(string name, double price, int shares)
        {
            Symbol = name;
            PricePerShare = price;
            NumShares = shares;

        }
        public Stock()
        {
        }



        public double GetValue()
        {
            return NumShares * PricePerShare;
        }

        public static double TotalValue(Stock[] stocks)
        {
            double sum = 0;
            for (int i = 0; i < stocks.Length; i++)
            {
                sum += stocks[i].GetValue();

            }
            return sum;
        }

  

        public override string ToString()
        {

            return "Stock[symbol=" + Symbol + ",pricePerShare=" + PricePerShare.ToString().Replace(",", ".") + ",numShares=" + NumShares + "]";
        }
        public override bool Equals(object obj)
        {
            if (ToString() == obj.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string GetName()
        {
            return Symbol;
        }
       
    }
}