using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTax
{
    public static class CalcPersonTax
    {
        public static decimal GetTaxLevel(this decimal salary, out decimal taxRate, out int fastNum)
        {
            decimal afterSalary = 0, rate = 0;
            int num = 0;
            if (salary > 0 && salary <= 3000)
            {
                afterSalary = salary * ((Decimal)TaxRate.First / 100) - (Decimal)FastNum.First;
                rate = (Decimal)TaxRate.First / 100;
                num = (int)FastNum.First;
            }
            else if (salary > 3000 && salary <= 12000)
            {
                afterSalary = salary * ((Decimal)TaxRate.Second / 100) - (Decimal)FastNum.Second;
                rate = (Decimal)TaxRate.Second / 100;
                num = (int)FastNum.Second;
            }
            else if (salary > 12000 && salary <= 25000)
            {
                afterSalary = salary * ((Decimal)TaxRate.Third / 100) - (Decimal)FastNum.Third;
                rate = (Decimal)TaxRate.Third / 100;
                num = (int)FastNum.Third;
            }
            else if (salary > 25000 && salary <= 35000)
            {
                afterSalary = salary * ((Decimal)TaxRate.Forth / 100) - (Decimal)FastNum.Forth;
                rate = (Decimal)TaxRate.Forth / 100;
                num = (int)FastNum.Forth;
            }
            else if (salary > 35000 && salary <= 55000)
            {
                afterSalary = salary * ((Decimal)TaxRate.Fifth / 100) - (Decimal)FastNum.Fifth;
                rate = (Decimal)TaxRate.Fifth / 100;
                num = (int)FastNum.Fifth;
            }
            else if (salary > 55000 && salary <= 80000)
            {
                afterSalary = salary * ((Decimal)TaxRate.Sixth / 100) - (Decimal)FastNum.Sixth;
                rate = (Decimal)TaxRate.Sixth / 100;
                num = (int)FastNum.Sixth;
            }
            else if (salary > 80000)
            {
                afterSalary = salary * ((Decimal)TaxRate.Last / 100) - (Decimal)FastNum.Last;
                rate = (Decimal)TaxRate.Last / 100;
                num = (int)FastNum.Last;
            }

            taxRate = rate;
            fastNum = num;
            return afterSalary;
        }
    }

    public enum TaxRate
    {
        First = 3,    //<=3000
        Second = 10,  //3000<x<=12000
        Third = 20,    //12000<x<=25000
        Forth = 25,   //25000<x<=35000
        Fifth = 30,   //35000<x<=55000
        Sixth = 35,   //55000<x<=80000
        Last = 45      //x>80000
    }

    public enum FastNum
    {
        First = 0,          //<=3000
        Second = 210,       //3000<x<=12000
        Third = 1410,        //12000<x<=25000
        Forth = 2660,       //25000<x<=35000
        Fifth = 4410,       //35000<x<=55000
        Sixth = 7160,       //55000<x<=80000
        Last = 15160        //x>80000
    }
}
