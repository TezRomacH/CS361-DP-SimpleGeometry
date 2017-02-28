using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Абстрактный класс формы
    /// </summary>
    public abstract class Shape : IPrintable
    {
        /// <summary>
        /// Получает строковую информацию о классе
        /// </summary>
        /// <returns></returns>
        public abstract string Print();

        /// <summary>
        /// Вычисляет площадь фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double Area();
    }
}
