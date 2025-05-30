using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_ImpUserInterface
{
    internal class Class_Task1 : IEvaluate
    {
        public int NumOfVariant { get; set; }
        public int ParamValue { get; set; }
        public void Invoke_Variant(int numOfVariant, int paramValueDefault)
        {
            NumOfVariant = numOfVariant;
            ParamValue = paramValueDefault;
        }

        public string Execute_Variant()
        {
            int N = 27;
            int result = N * ParamValue;
            if(result > N)
            {
                result = N;
            }
            else
            {
                if(result < -N)
                {
                    result = -N;
                }
            }

            string str_ParVal = result.ToString();
            int count = str_ParVal.Length;

            string str = String.Format("Результат: {0}, в числе {1} символов", result, count);
                return str;
        }
    }
}
