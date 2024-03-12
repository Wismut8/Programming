using System;
///<summary>
///Время. 
///</summary>
public class Time
{
    private int _hour;
    private int _minute;
    private int _second;

    ///<summary>
    ///Возвращает и задает значение часа
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
    ///Возвращает и задает число минут
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
    ///Возвращает и задает число секунд
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
    ///Создает экземпляр времени
    ///</summary>
    ///<param name = "name">Часы.</param>
    ///<param name = "name">Минуты.</param>
    ///<param name = "name">Секунды.</param>
    public Time(int hour, int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    public Time() { }
}