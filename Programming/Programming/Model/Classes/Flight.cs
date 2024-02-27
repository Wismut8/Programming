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
    private string DeparturePoint { get; set; }

    ///<summary>
    ///���������� � ������ ����� ����������
    ///</summary>
    private string Destination { get; set; }

    ///<summary>
    ///���������� � ������ ����� ������ � �������
    ///</summary>
    private int FlightTimeInMinutes
    {
        get
        {
            return _flightTimeInMinutes;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
            _flightTimeInMinutes = value;
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
}