using CalculatorMG.Models;

namespace CalculatorMG.Services
{
    public interface ICalculatorService
    {
        Task<Calculator> Addition(Calculator calculator);
        Task<Calculator> Subtraction(Calculator calculator);
        Task<Calculator> Multiplication(Calculator calculator);
        Task<Calculator> Division(Calculator calculator);
        public Calculator Calculate(Calculator calculator);
    }
}