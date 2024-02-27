using System;
///<summary>
///Фильм. 
///</summary>
public class Film
{
    private string _name;
    private int _durationInMinutes;
    private int _yearOfIssue;
    private string _genre;
    private double _rating;

    ///<summary>
    ///Возвращает и задает название фильма
    ///</summary>
    private string Name { get; set; }

    ///<summary>
    ///Возвращает и задает длительность фильма в минутах
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
    ///Возвращает и задает год выпуска фильма
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
    ///Возвращает и задает жанр фильма
    ///</summary>
    private string Genre { get; set; }

    ///<summary>
    ///Возвращает и задает рейтинг фильма
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
	///Создает экземпляр фильма
	///</summary>
	///<param name = "name">Название.</param>
	///<param name = "name">Продолжительность в минутах.</param>
	///<param name = "name">Год выпуска.</param>
    ///<param name = "name">Жанр.</param>
    ///<param name = "name">Рейтинг.</param>
	public Film(string name, int durationInMinutes, int yearOfIssue, string genre, double rating)
    {
        Name = name;
        DurationInMinutes = durationInMinutes;
        YearOfIssue = yearOfIssue;
        Genre = genre;
        Rating = rating;
    }
}