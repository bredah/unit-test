using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Lab.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calc;

        [TestInitialize]
        public void SetUp()
        {
            _calc = new Calculator();
        }

        [TestMethod, Priority(1), TestCategory("UnitTest")]
        [DynamicData(nameof(EnumValidationData))]
        public void Calculator_Enum(Equation equation, int valueA, int valueB, int expectedResult)
        {
            // Setup or Prepare
            _calc.ValueA = valueA;
            _calc.ValueB = valueB;
            // Execution
            int result = _calc.Result(equation);
            // Validation
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod, Priority(1), TestCategory("UnitTest")]
        [DynamicData(nameof(StringValidationData))]
        public void Calculator_String(string equation, int valueA, int valueB, int expectedResult)
        {
            // Setup or Prepare
            _calc.ValueA = valueA;
            _calc.ValueB = valueB;
            // Execution
            int result = _calc.Result(equation);
            // Validation
            Assert.AreEqual(expectedResult, result);
        }

        private static IEnumerable<object[]> EnumValidationData =>
            new List<object[]>
            {
                new object[]{Equation.ADD, 4, 2, 6},
                new object[]{Equation.SUBTRACT, 4, 2, 2},
                new object[]{Equation.MULTIPLY, 4, 2, 8},
                new object[]{Equation.DIVIDE, 4, 2, 2},
            };

        private static IEnumerable<object[]> StringValidationData =>
            new List<object[]>
            {
                new object[]{ "ADD", 4, 2, 6},
                new object[]{ "SUBTRACT", 4, 2, 2},
                new object[]{ "MULTIPLY", 4, 2, 8},
                new object[]{ "DIVIDE", 4, 2, 2},
            };
    }
}
