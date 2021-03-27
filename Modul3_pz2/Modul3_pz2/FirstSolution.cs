namespace Modul3_pz2
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;

    public class FirstSolution
    {
        private event Func<double, double, double> _func;

        public void Start()
        {
            _func += Sum;
            _func += Sum;

            double result = 0;

            Try(() =>
            {
                var list = _func.GetInvocationList();

                foreach (var item in list)
                {
                    result += (double)item.DynamicInvoke(2, 4);
                }

                for (int i = 0; i < list.Length; i++)
                {
                    _func -= Sum;
                }
            });

            Console.WriteLine(result);
        }

        private double Sum(double x, double y) => x + y;

        private void Try(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
