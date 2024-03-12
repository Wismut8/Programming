using System;
///<summary>
///�����. 
///</summary>
public class Time
{
    private int _hour;
    private int _minute;
    private int _second;

    ///<summary>
    ///���������� � ������ �������� ����
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
    ///���������� � ������ ����� �����
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
    ///���������� � ������ ����� ������
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
    ///������� ��������� �������
    ///</summary>
    ///<param name = "name">����.</param>
    ///<param name = "name">������.</param>
    ///<param name = "name">�������.</param>
    public Time(int hour, int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    public Time() { }
}