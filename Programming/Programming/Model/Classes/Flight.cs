using System;
///<summary>
///Рейс. 
///</summary>
public class Flight
{
    private string _departurePoint;
    private string _destination;
    private int _flightTimeInMinutes;

    ///<summary>
    ///Возвращает и задает пункт вылета
    ///</summary>
    public string DeparturePoint { get; set; }

    ///<summary>
    ///Возвращает и задает пункт назначения
    ///</summary>
    public string Destination { get; set; }

    ///<summary>
    ///Возвращает и задает время полета в минутах
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

    ///<summary>
	///Создает экземпляр рейса
	///</summary>
	///<param name = "name">Пункт вылета.</param>
	///<param name = "name">Пункт назначения.</param>
	///<param name = "name">Время полета в минутах.</param>
	public Flight(string departurePoint, string destination, int flightTimeInMinutes)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        FlightTimeInMinutes = flightTimeInMinutes;
    }

    public Flight() { }
}