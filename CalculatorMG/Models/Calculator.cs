namespace CalculatorMG.Models
{
    public class Calculator
    {
        public decimal? FirstNumber { get; set; }
        public decimal? SecondNumber { get; set; }
        public decimal ResultNumber { get; set; }
        public string? ErrorMessage { get; set; }
        public int OperationType { get; set; }

    }
}
