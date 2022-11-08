using AutoMapper;
using CalculatorMG.Models;

namespace CalculatorMG.Services
{
    public class CalculatorService : ICalculatorService
    {

        
        public async Task<Calculator> Addition(Calculator calculator)
        {

            calculator.OperationType = 1;
            Calculate(calculator);
            return calculator;
        }
        public async Task<Calculator> Subtraction(Calculator calculator)
        {
            calculator.OperationType = 2;
            Calculate(calculator);
            return calculator;
        }
        public async Task<Calculator> Multiplication(Calculator calculator)
        {
            calculator.OperationType = 3;
            Calculate(calculator);
            return calculator;
        }

        public async Task<Calculator> Division(Calculator calculator)
        {
            calculator.OperationType = 4;
            Calculate(calculator);
            return calculator;
        }


        public Calculator Calculate(Calculator calculator)
        {
            if (calculator.FirstNumber != null && calculator.SecondNumber != null)
            {
                switch(calculator.OperationType)
                {
                case 1:
                    calculator.ResultNumber = (decimal)calculator.FirstNumber + (decimal)calculator.SecondNumber;
                break;

                case 2:
                    calculator.ResultNumber = (decimal)calculator.FirstNumber - (decimal)calculator.SecondNumber;
                break;

                case 3:
                    calculator.ResultNumber = (decimal)calculator.FirstNumber * (decimal)calculator.SecondNumber;
                break;

                case 4:
                        if (calculator.SecondNumber != 0)
                        {
                            calculator.ResultNumber = Math.Round((decimal)calculator.FirstNumber / (decimal)calculator.SecondNumber, 8);
                        }
                        else
                        {
                            calculator.ErrorMessage = "You can't divide by zero";
                        }
                        break;
                }
                return calculator;
            }
            else
            {
                calculator.ErrorMessage = "Please insert valid values";
                return calculator;
            }
        }
    }
}
