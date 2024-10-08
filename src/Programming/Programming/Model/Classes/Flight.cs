using System;
///<summary>
/// Хранит данные о рейсах.
///</summary>
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
    /// Хранит данные о времени полета в минутах.
    /// </summary>
    private int _flightTimeInMinutes;

    ///<summary>
    ///Возвращает и задает пункт вылета.
    ///</summary>
    public string DeparturePoint { get; set; }

    ///<summary>
    ///Возвращает и задает пункт назначения.
    ///</summary>
    public string Destination { get; set; }

    ///<summary>
    ///Возвращает и задает время полета в минутах. Только положительное значение.
    ///</summary>
    public int FlightTimeInMinutes
    {
        get
        {
            return _flightTimeInMinutes;
        }
        set
        {
            if (Validator.AssertOnPositiveValue(value))
            {
                _flightTimeInMinutes = value;
            }
        }
    }

    /// <summary>
    /// Создает экземпляр рейса. <see cref="Flight"/>
    /// </summary>
    /// <param name="departurePoint">Точка отправки.</param>
    /// <param name="destination">Пункт назначения.</param>
    /// <param name="flightTimeInMinutes">Время полета в минутах. Только положительное значение.</param>
	public Flight(string departurePoint, string destination, int flightTimeInMinutes)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        FlightTimeInMinutes = flightTimeInMinutes;
    }

    public Flight() { }
}