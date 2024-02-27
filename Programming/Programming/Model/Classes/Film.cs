using System;
///<summary>
///�����. 
///</summary>
public class Film
{
    private string _name;
    private int _durationInMinutes;
    private int _yearOfIssue;
    private string _genre;
    private double _rating;

    ///<summary>
    ///���������� � ������ �������� ������
    ///</summary>
    private string Name { get; set; }

    ///<summary>
    ///���������� � ������ ������������ ������ � �������
    ///</summary>
    private int DurationInMinutes
    {
        get
        {
            return _durationInMinutes;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
            _durationInMinutes = value;
        }
    }

    ///<summary>
    ///���������� � ������ ��� ������� ������
    ///</summary>
    private int YearOfIssue
    {
        get
        {
            return _yearOfIssue;
        }
        set
        {
            if (value < 1900 || value > 2024)
            {
                throw new ArgumentException();
            }
            _yearOfIssue = value;
        }
    }

    ///<summary>
    ///���������� � ������ ���� ������
    ///</summary>
    private string Genre { get; set; }

    ///<summary>
    ///���������� � ������ ������� ������
    ///</summary>
    private double Rating
    {
        get
        {
            return _rating;
        }
        set
        {
            if (value < 0.0 ||value > 10.0)
                {
                throw new ArgumentException();
            }
            _rating = value;
        }
    }

    ///<summary>
	///������� ��������� ������
	///</summary>
	///<param name = "name">��������.</param>
	///<param name = "name">����������������� � �������.</param>
	///<param name = "name">��� �������.</param>
    ///<param name = "name">����.</param>
    ///<param name = "name">�������.</param>
	public Film(string name, int durationInMinutes, int yearOfIssue, string genre, double rating)
    {
        Name = name;
        DurationInMinutes = durationInMinutes;
        YearOfIssue = yearOfIssue;
        Genre = genre;
        Rating = rating;
    }
}