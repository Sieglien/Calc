using EveryDay.Calc.Calculation;
using SConsole = System.Console;

namespace EveryDay.Calc.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var oper = args[0].ToLower();
            
            var x = Str2Int(args[1]);

            var y = Str2Int(args[2]);

            var calc = new Calculator();

            double result = 0;

            if (oper == "sum")
            {
                result = calc.Sum(x, y);
            }
            else if (oper == "div")
            {
                result = calc.Div(x, y);
            }
            else if (oper == "sqrt")
            {
                result = calc.Sqrt(x);
            }
            else
            {
                SConsole.WriteLine("Нет такой операции");
            }
            
            SConsole.WriteLine(result.ToString());

            SConsole.ReadKey();
        }


        private static double Str2Int(string str)
        {
            double result;

            if(!double.TryParse(str, out result)){
                SConsole.WriteLine("Не удалось преобразовать \"{0}\" в число", str);
            }
            return result;
        }
    }
}
