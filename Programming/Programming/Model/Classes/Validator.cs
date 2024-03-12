using System;
///<summary>
///Проверка на неотрицательное значение
///</summary>
public static class Validator
{
    public static bool AssertOnPositiveValue(int value)
    {
        if (value < 0)
        {
            throw new ArgumentException($"Invalid value: {value}. The value must be a positive number.");
        }
        return true;
    }

    public static bool AssertOnPositiveValue(double value)
    {
        if (value < 0.0)
        {
            throw new ArgumentException($"Invalid value: {value}. The value must be a positive number.");
        }
        return true;
    }
}