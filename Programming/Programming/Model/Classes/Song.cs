using System;
///<summary>
///Песня. 
///</summary>
public class Song
{
    private string _name;
    private string _singer;
    private int _yearOfIssue;
    private int _durationInSeconds;

    ///<summary>
    ///Возвращает и задает название песни
    ///</summary>
    private string Name { get; set; }

    ///<summary>
    ///Возвращает и задает исполнителя
    ///</summary>
    private string Singer { get; set; }

    ///<summary>
    ///Возвращает и задает год выпуска
    ///</summary>
    private int YearOfIssue
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
    ///Возвращает и задает длительность песни в секундах
    ///</summary>
    private int DurationInSeconds
    {
        get
        {
            return _durationInSeconds;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
            _durationInSeconds = value;
        }
    }

    ///<summary>
	///Создает экземпляр песни
	///</summary>
	///<param name = "name">Название.</param>
	///<param name = "name">Исполнитель.</param>
	///<param name = "name">Год выпуска.</param>
    ///<param name = "name">Продолжительность в секундах.</param>
	public Song(string name, string singer, int yearOfIssue, int durationInSeconds)
    {
        Name = name;
        Singer = singer;
        YearOfIssue = yearOfIssue;
        DurationInSeconds = durationInSeconds;
    }
}