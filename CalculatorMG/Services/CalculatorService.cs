﻿using AutoMapper;
using CalculatorMG.Models;

namespace CalculatorMG.Services
{
    public class CalculatorService : ICalculatorService
    {
        
        public async Task<Calculator> Addition(Calculator calculator)
        {
            
            if (calculator.FirstNumber != null && calculator.SecondNumber != null)
            {
                calculator.ResultNumber = (double)calculator.FirstNumber + (double)calculator.SecondNumber;
                return calculator;
            }
            else
            {
                calculator.ErrorMessage = "Please insert valid values";
                return calculator;
            }
        }

        public async Task<Calculator> Division(Calculator calculator)
        {
            if(calculator.FirstNumber!= null && calculator.SecondNumber != null)
            {
                if (calculator.SecondNumber != 0)
                {
                    calculator.ResultNumber = (double)calculator.FirstNumber / (double)calculator.SecondNumber;
                    return calculator;
                }
                else
                {
                    calculator.ErrorMessage = "You can't divide by zero";
                    return calculator;
                }
            }
            else
            {
                calculator.ErrorMessage = "Please insert valid values";
                return calculator;
            }
        }

        public async Task<Calculator> Multiplication(Calculator calculator)
        {
            if (calculator.FirstNumber != null && calculator.SecondNumber != null)
            {
                calculator.ResultNumber = (double)calculator.FirstNumber * (double)calculator.SecondNumber;
                return calculator;
            }
            else
            {
                calculator.ErrorMessage = "Please insert valid values";
                return calculator;
            }
        }

        public async Task<Calculator> Subtraction(Calculator calculator)
        {
            if (calculator.FirstNumber != null && calculator.SecondNumber != null)
            {
                calculator.ResultNumber = (double)calculator.FirstNumber - (double)calculator.SecondNumber;
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
