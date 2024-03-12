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
    public string Name { get; set; }

    ///<summary>
    ///���������� � ������ ������������ ������ � �������
    ///</summary>
    public int DurationInMinutes
    {
        get
        {
            return _durationInMinutes;
        }
        set
        {
            if (Validator.AssertOnPositiveValue(value))
            {
                _durationInMinutes = value;
            }
        }
    }

    ///<summary>
    ///���������� � ������ ��� ������� ������
    ///</summary>
    public int YearOfIssue 
    {
        get
        {
            return _yearOfIssue;
        }
        set
        {
            if (value > 1900)
            {
                if (value < DateTime.Now.Year + 1)
                {
                    _yearOfIssue = value;
                }
            }
        }
    }

    ///<summary>
    ///���������� � ������ ���� ������
    ///</summary>
    public string Genre { get; set; }

    ///<summary>
    ///���������� � ������ ������� ������
    ///</summary>
    public double Rating
    {
        get
        {
            return _rating;
        }
        set
        {
            if (value < 0.0 || value > 10.0)
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

    public Film() { }
}