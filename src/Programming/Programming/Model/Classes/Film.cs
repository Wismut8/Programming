using System;
///<summary>
/// Содержит данные о фильме.
///</summary>
public class Film
{
    /// <summary>
    /// Хранит название фильма.
    /// </summary>
    private string _name;
    /// <summary>
    /// Хранит продолжительность фильма в минутах.
    /// </summary>
    private int _durationInMinutes;
    /// <summary>
    /// Хранит год выпуска фильма.
    /// </summary>
    private int _yearOfIssue;
    /// <summary>
    /// Хранит жанр фильма.
    /// </summary>
    private string _genre;
    /// <summary>
    /// Хранит рейтинг фильма.
    /// </summary>
    private double _rating;

    ///<summary>
    ///Возвращает и задает название фильма
    ///</summary>
    public string Name { get; set; }

    ///<summary>
    ///Возвращает и задает длительность фильма в минутах. Только положительное значение. 
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
    ///Возвращает и задает год выпуска фильма. Значения от 1900 до 2024.
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
    ///Возвращает и задает жанр фильма.
    ///</summary>
    public string Genre { get; set; }

    ///<summary>
    ///Возвращает и задает рейтинг фильма. Только вещественные значения от 0.0 до 10.0.
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
	///Создает экземпляр фильма <see cref="Film"/>
	///</summary>
	///<param name = "name">Название.</param>
	///<param name = "durationInMinutes">Продолжительность в минутах. Только положительное значение. </param>
	///<param name = "yearOfIssue">Год выпуска. Только от 1900 до 2024.</param>
    ///<param name = "genre">Жанр.</param>
    ///<param name = "rating">Рейтинг. Только вещественное значение от 0.0 до 10.0.</param>
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