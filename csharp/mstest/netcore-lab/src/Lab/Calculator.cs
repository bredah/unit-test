using System;
namespace Lab
{
    /// <summary>
    /// 
    /// </summary>
    public class Calculator
    {
        public int ValueA { get; set; }
        public int ValueB { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="equation"></param>
        /// <returns></returns>
        public int Result(Equation equation)
        {
            switch (equation)
            {
                case Equation.ADD:
                    return ValueA + ValueB;
                case Equation.SUBTRACT:
                    return ValueA - ValueB;
                case Equation.MULTIPLY:
                    return ValueA * ValueB;
                case Equation.DIVIDE:
                    return ValueA / ValueB;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="equation"></param>
        /// <returns></returns>
        public int Result(string equation)
        {
            if (string.IsNullOrEmpty(equation))
            {
                throw new ArgumentException("Equation is null or empty");
            }
            switch (equation.ToUpper())
            {
                case "ADD":
                    return ValueA + ValueB;
                case "SUBTRACT":
                    return ValueA - ValueB;
                case "MULTIPLY":
                    return ValueA * ValueB;
                case "DIVIDE":
                    return ValueA / ValueB;
                default:
                    return 0;
            }
        }
    }
}
