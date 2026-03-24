using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLB3
{
    internal class Transportation
    {
        public string FirmName;
        public double[] TrukLoadCopacity;
        public decimal CostPerTon;
        public decimal TotalCargoWeight;
        public decimal TotalCost;

        public Transportation()
            : this("Noname", [0], 0, 0,0)
        { 
            //this.FirmName = "Noname";
            //this.TrukLoadCopacity = new double[0];
            //this.CostPerTon = 0;
            //this.TotalCargoWeight = 0;
        }

        public Transportation(string firmName, decimal costPerTon)
            :this(firmName, [0], costPerTon,0,0) 
        {
            //this.FirmName = firmName;
            //this.CostPerTon = costPerTon;
        }

        public Transportation(string firmName, double[] trukLoadCopacity, decimal costPerTon, decimal totalCargoWeight, decimal totalCost)
        {
            this.FirmName = firmName;
            //this.TrukLoadCopacity = trukLoadCopacity;
            this.CostPerTon = costPerTon;
            this.TotalCargoWeight = totalCargoWeight;

            if (CostPerTon >= 0 && CostPerTon < 10000)
                this.CostPerTon = costPerTon;
            else
                this.CostPerTon = 0;

            if (totalCargoWeight > 0 && totalCargoWeight < 1000000000)
                this.TotalCargoWeight = totalCargoWeight;
            else
                this.TotalCargoWeight = 1;

            if (totalCost > 0)
                this.TotalCost = totalCost;
            else
                this.TotalCost = 0;

                var normalizeArray = new double[trukLoadCopacity.Length];

            for (int i = 0; i < trukLoadCopacity.Length; i++)
            {
                normalizeArray[i] = trukLoadCopacity[i] < 0 ? 0 : trukLoadCopacity[i];
            }

            this.TrukLoadCopacity = normalizeArray;
            TotalCost = totalCost;
        }

        public override string ToString()
        {
            string? ArrStr = null;
            string? ResStr = null;
            foreach (var item in TrukLoadCopacity)
            {
                ArrStr = ArrStr + item.ToString() + " ";
            }
            ResStr = $"Название организации:{FirmName}\nГрузоподьемность:{ArrStr}\nСтоимость перевозки одной тонны:{CostPerTon}\nСуммарная масса перевезенных грузов:{TotalCargoWeight}\nСумма расходов на транспартировку:{TotalCost}";
            //return base.ToString();
            return ResStr;
        }

        public decimal GetRevenuePercentage(){

            return TotalCargoWeight * CostPerTon;
        
        }

        public void m2()
        {
            double MaxLoadCopacity = 0; 
            foreach (var item in TrukLoadCopacity)
            {
                 MaxLoadCopacity = +item;
            }

            if (((TotalCargoWeight * 100) / Convert.ToDecimal(MaxLoadCopacity)) < 60)
            {
                CostPerTon = CostPerTon * Convert.ToDecimal(0.85);
            }

        }

        public decimal Rent(Transportation Transportation)
        {
            decimal _TotalCost = Transportation.TotalCost;
            decimal _CostPerTon = Transportation.CostPerTon;
            decimal _TotalCargoWeight = Transportation.TotalCargoWeight;

            decimal _revenue = _CostPerTon * _TotalCargoWeight;

            decimal rent = 0;

            rent = ((_revenue - _TotalCost) / _revenue) * Convert.ToDecimal(100);

            return rent;
        }

        public bool ToRent(Transportation Transportation) {
            
            decimal rent1 = 0;
            decimal rent2 = 0;

            rent1 = Rent(this);
            rent2 = Rent(Transportation);

            //Console.WriteLine($"{rent1}");
            //Console.WriteLine($"{rent2}");

            if (rent1 > rent2)
                return true;
            else
                return false;
        }

        public static Transportation ToRents(Transportation Transportation1, Transportation Transportation2, Transportation Transportation3)
        {
            decimal rent1 = 0;
            decimal rent2 = 0;
            decimal rent3 = 0;

            rent1 = Transportation1.Rent(Transportation1); //a
            rent2 = Transportation2.Rent(Transportation2); //b
            rent3 = Transportation3.Rent(Transportation3); //c

            Console.WriteLine($"{rent1}");
            Console.WriteLine($"{rent2}");
            Console.WriteLine($"{rent3}");

            decimal max = rent1;

            if (rent2 > max)
                max = rent2;
            if (rent3 > max)
                max = rent3;

            if (rent1 == max)
                return Transportation1;
            if (rent2 == max)
                return Transportation2;

            return Transportation3;


        }



    }
}
