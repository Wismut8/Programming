using System;
///<summary>
/// Хранит данные о песне. 
///</summary>
public class Song
{
    /// <summary>
    /// Хранит название песни.
    /// </summary>
    private string _name;
    /// <summary>
    /// Хранит исполниеля.
    /// </summary>
    private string _singer;
    /// <summary>
    /// Хранит год выпуска.
    /// </summary>
    private int _yearOfIssue;
    /// <summary>
    /// Хранит длительность в минутах.
    /// </summary>
    private int _durationInSeconds;

    ///<summary>
    ///Возвращает и задает название песни.
    ///</summary>
    public string Name { get; set; }

    ///<summary>
    ///Возвращает и задает исполнителя.
    ///</summary>
    public string Singer { get; set; }

    ///<summary>
    ///Возвращает и задает год выпуска. Значение от 1860 до 2024.
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
    ///Возвращает и задает длительность песни в секундах. Только положительное значение.
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
	///Создает экземпляр песни <see cref="Song"/>
	///</summary>
	///<param name = "name">Название.</param>
	///<param name = "singer">Исполнитель.</param>
	///<param name = "yearOfIssue">Год выпуска. От 1860 до 2024.</param>
    ///<param name = "durationInSeconds">Продолжительность в секундах. Только положительное значение.</param>
	public Song(string name, string singer, int yearOfIssue, int durationInSeconds)
    {
        Name = name;
        Singer = singer;
        YearOfIssue = yearOfIssue;
        DurationInSeconds = durationInSeconds;
    }

    public Song() { }
}