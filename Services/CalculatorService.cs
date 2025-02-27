﻿using calservice.Interfaces;

namespace calservice.Services
{
    public class CalculatorService : ICalculatorServices
    {
        public double Add(double num1, double num2) => num1 + num2;

        public double Subtract(double num1, double num2) => num1 - num2;

        public double Multiply(double num1, double num2) => num1 * num2;

        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException("Division by zero is not allowed u know this ?why keep trying ?.");
            return num1 / num2;
        }
    }
}
