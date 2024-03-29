using System;
///<summary>
///�����. 
///</summary>
public class Song
{
    private string _name;
    private string _singer;
    private int _yearOfIssue;
    private int _durationInSeconds;

    ///<summary>
    ///���������� � ������ �������� �����
    ///</summary>
    public string Name { get; set; }

    ///<summary>
    ///���������� � ������ �����������
    ///</summary>
    public string Singer { get; set; }

    ///<summary>
    ///���������� � ������ ��� �������
    ///</summary>
    public int YearOfIssue
    {
        get
        {
            return _yearOfIssue;
        }
        set
        {
            if (value < 1860 || value > 2024)
                {
                throw new ArgumentException();
            }
            _yearOfIssue = value;
        }
    }

    ///<summary>
    ///���������� � ������ ������������ ����� � ��������
    ///</summary>
    public int DurationInSeconds
    {
        get
        {
            return _durationInSeconds;
        }
        set
        {
            if (Validator.AssertOnPositiveValue(value))
            {
                _durationInSeconds = value;
            }
        }
    }

    ///<summary>
	///������� ��������� �����
	///</summary>
	///<param name = "name">��������.</param>
	///<param name = "name">�����������.</param>
	///<param name = "name">��� �������.</param>
    ///<param name = "name">����������������� � ��������.</param>
	public Song(string name, string singer, int yearOfIssue, int durationInSeconds)
    {
        Name = name;
        Singer = singer;
        YearOfIssue = yearOfIssue;
        DurationInSeconds = durationInSeconds;
    }

    public Song() { }
}