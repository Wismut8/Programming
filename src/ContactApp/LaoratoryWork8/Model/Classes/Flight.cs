using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
///<summary>
/// Хранит данные о рейсах.
///</summary>
[DataContract]
public class Flight
{
    /// <summary>
    /// Хранит данные о точке отправления.
    /// </summary>
    private string _departurePoint;
    /// <summary>
    /// Хранит данные о пункте назначения.
    /// </summary>
    private string _destination;
    /// <summary>
    /// Хранит время отправления.
    /// </summary>
    private DateTime _departureTime;
    /// <summary>
    /// Хранит данные о времени полета в минутах.
    /// </summary>
    private int _flightTime;
    /// <summary>
    /// Хранит информацию о типе перелета.
    /// </summary>
    private TypeOfFlight _typeOfFlight;

    ///<summary>
    ///Возвращает и задает точку отправления. Длина строки не более 100 символов
    ///</summary>
    [DataMember]
    public string DeparturePoint
    {
        get { return _departurePoint; }
        set
        {
            if (value.Length < 100)
            {
                _departurePoint = value;
            }
        }
    }

    ///<summary>
    ///Возвращает и задает пункт назначения. Длина строки не более 100 символов
    ///</summary>
    [DataMember]
    public string Destination
    {
        get { return _destination; }
        set
        {
            if (value.Length < 100)
            {
                _destination = value;
            }
        }
    }

    /// <summary>
    /// Возвращает и задает время вылета. День не ранее сегодняшней даты.
    /// </summary>
    [DataMember]
    public DateTime DepartureTime { get; set; }

    ///<summary>
    /// Возвращает и задает время полета в минутах. Диапазон значения от 0 до 1000 минут.
    ///</summary>
    [DataMember]
    public int FlightTime
    {
        get { return _flightTime; }
        set
        {
            if (value < 1000 && value > 0)
            {
                _flightTime = value;
            }
        }
    }

    /// <summary>
    /// Возвращает и задает тип полета.
    /// </summary>
    [DataMember]
    public TypeOfFlight TypeOfFlight { get; set; }

    /// <summary>
    /// Создает экземпляр перелета. <see cref="Flight"/>
    /// </summary>
    /// <param name="departurePoint">Точка отправления. Не более 100 символов.</param>
    /// <param name="destination">Пункт назначения. Не более 100 символов.</param>
    /// <param name="departureTime">День отправления. Не ранее сегодняшней даты.</param>
    /// <param name="flightTime">Время полета в минутах. Значения от 0 до 1000.</param>
    /// <param name="typeOfFlight">Тип полета.</param>
    public Flight(string departurePoint, string destination, DateTime departureTime, int flightTime, TypeOfFlight typeOfFlight)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        DepartureTime = departureTime;
        FlightTime = flightTime;
        TypeOfFlight = typeOfFlight;
    }

    public Flight() { }
}