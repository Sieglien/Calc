using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveryDay.Calc.Calculation.Interface
{
    public interface IOperation
{   
    /// <summary>
    /// Найменование
    /// </summary>

    string Name { get; }


    /// <summary>
    /// Входные параметры
    /// </summary>
    double[] Input { get; set; }

    /// <summary>
    /// Получить результат
    /// </summary>
    /// <returns></returns>

    double? Getresult();
        IOperation First(Func<object, bool> p);
    }
}
