using System;
///<summary>
///����. 
///</summary>
public class Flight
{
    private string _departurePoint;
    private string _destination;
    private int _flightTimeInMinutes;

    ///<summary>
    ///���������� � ������ ����� ������
    ///</summary>
    public string DeparturePoint { get; set; }

    ///<summary>
    ///���������� � ������ ����� ����������
    ///</summary>
    public string Destination { get; set; }

    ///<summary>
    ///���������� � ������ ����� ������ � �������
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
	///������� ��������� �����
	///</summary>
	///<param name = "name">����� ������.</param>
	///<param name = "name">����� ����������.</param>
	///<param name = "name">����� ������ � �������.</param>
	public Flight(string departurePoint, string destination, int flightTimeInMinutes)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        FlightTimeInMinutes = flightTimeInMinutes;
    }

    public Flight() { }
}