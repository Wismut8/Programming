using System;
///<summary>
/// Хранит данные о времени.
///</summary>
public class Time
{
    /// <summary>
    /// Хранит значение часа.
    /// </summary>
    private int _hour;
    /// <summary>
    /// Хранит значение минуты.
    /// </summary>
    private int _minute;
    /// <summary>
    /// Хранит значение секунды.
    /// </summary>
    private int _second;

    ///<summary>
    ///Возвращает и задает значение часа. Значение только от 0 до 23.
    ///</summary>
    public int Hour
    {
        get
        {
            return _hour;
        }
        set
        {
            if (value < 0 || value > 23)
                {
                throw new ArgumentException();
            }
            _hour = value;
        }
    }

    ///<summary>
    ///Возвращает и задает число минут. Значение только от 0 до 59.
    ///</summary>
    public int Minute
    {
        get
        {
            return _minute;
        }
        set
        {
            if (value < 0 || value > 59)
                {
                throw new ArgumentException();
            }
            _minute = value;
        }
    }

    ///<summary>
    ///Возвращает и задает число секунд. Значение только от 0 до 59.
    ///</summary>
    public int Second
    {
        get
        {
            return _second;
        }
        set
        {
            if (value < 0 || value > 59)
                {
                throw new ArgumentException();
            }
            _second = value;
        }
    }

    ///<summary>
    ///Создает экземпляр времени. <see cref="Time"/>
    ///</summary>
    ///<param name = "hour">Часы. Значение от 0 до 23.</param>
    ///<param name = "minute">Минуты. Значение от 0 до 59.</param>
    ///<param name = "second">Секунды. Значение от 0 до 59.</param>
    public Time(int hour, int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    public Time() { }
}