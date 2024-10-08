using System;
///<summary>
/// Реализует проверку на неотрицательное значение.
///</summary>
public static class Validator
{
    /// <summary>
    /// Осуществляет проверку на неотрицательное значение.
    /// </summary>
    /// <param name="value">Проверяемое целое значение.</param>
    /// <returns>Возвращает true, если значение неотрицательное, false если значение меньше 0.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static bool AssertOnPositiveValue(int value)
    {
        if (value < 0)
        {
            throw new ArgumentException($"Invalid value: {value}. The value must be a positive number.");
        }
        return true;
    }

    /// <summary>
    /// Осуществляет проверку на неотрицательное значение.
    /// </summary>
    /// <param name="value">Проверяемое вещественное значение.</param>
    /// <returns>Возвращает true, если значение неотрицательное, false если значение меньше 0.0.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static bool AssertOnPositiveValue(double value)
    {
        if (value < 0.0)
        {
            throw new ArgumentException($"Invalid value: {value}. The value must be a positive number.");
        }
        return true;
    }
}