using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit;
using fit.Fixtures;

namespace TestingPractice2
{
    public class Premium2 : ColumnFixture
    {
        public int age;
        public string gender;
        public double result;

        public Test t = new Test();

        public double CalcPremium()
        {
            return t.CalcPremium(age, gender);
        }

        internal double CalcPremium(int v1, string v2)
        {
            throw new NotImplementedException();
        }
    }

    public class Test
    {

        public double CalcPremium(int age, string gender)
        {
            double premium;

            if (gender == "female")
                if ((age >= 18) && (age <= 30))
                    premium = 5.0;
                else
                    if (age >= 31)
                    premium = 3.50;
                else
                    premium = 0.0;
            else
            if (gender == "male")
                if ((age >= 18) && (age <= 35))
                    premium = 6.0;
                else
                   if (age >= 36)
                    premium = 5.0;
                else
                    premium = 0.0;
            else
                premium = 0.0;

            if (age >= 50)
                premium = premium * 0.5;

            return premium;
        }
    }

}