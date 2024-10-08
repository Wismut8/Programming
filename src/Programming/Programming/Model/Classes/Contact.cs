using System;
///<summary>
///Хранит данные о человеке и его контактных данных. 
///</summary>
public class Contact
{
    /// <summary>
    /// Хранит имя пользователя.
    /// </summary>
    private string _name;
    /// <summary>
    /// Хранит фамилию пользователя.
    /// </summary>
    private string _surname;
    /// <summary>
    /// Хранит номер пользователя. 
    /// </summary>
    private int _telephone;
    /// <summary>
    /// Хранит заметки о пользователе.
    /// </summary>
    private string _notes;

    ///<summary>
    ///Проверяет, что строка содержит только латинские буквы.
    ///</summary>
    ///<param name="value">Проверяемая строка.</param>
    ///<returns>Возвращает true, если строка состоит из латинских букв. И false, если есть хотя бы одна не латинская буква.</returns>
    private bool AssertStringContainsOnlyLetters(string value)
    {
        foreach (char c in value)
        {
            if ((c < 'A' || c > 'Z') && (c < 'a' || c > 'z'))
            {
                return false;
            }
        }
        return true;
    }

    ///<summary>
    ///Возвращает и задает имя контакта. Должна быть на латинице. 
    ///</summary>
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (!AssertStringContainsOnlyLetters(_name))
            {
                throw new ArgumentException("Name must contain only latin alfabet");
            }
            _name = value;
        }
    }

    ///<summary>
    ///Возвращает и задает фамилию контакта. Должна быть на латинице.
    ///</summary>
    public string SurName
    {
        get
        {
            return _surname;
        }
        set
        {
            if (!AssertStringContainsOnlyLetters(_surname))
            {
                throw new ArgumentException("Surname must contain only latin alfabet");
            }
            _surname = value;
        }
    }

    ///<summary>
    ///Возвращает и задает телефонный номер пользователя. Должен быть не длиньше 11.
    ///</summary>
    public int Telephone
    {
        get
        {
            return _telephone;
        }
        set
        {
            string stringNumber = value.ToString();
            if (stringNumber.Length != 11)
            {
                throw new ArgumentException();
            }
            _telephone = value;
        }
    }

    ///<summary>
    ///Возвращает и задает заметки к контакту.
    ///</summary>
    public string Notes { get; set; }

    ///<summary>
    ///Создает экземпляр телефонного контакта <see cref="Contact"/>
    ///</summary>
    ///<param name = "name">Имя. Должно состоять только из латинских букв.</param>
    ///<param name = "secondName">Фамилия. Должна состоять только из латинских букв.</param>
    ///<param name = "telephone">Телефон. Не более 11 символов.</param>
    ///<param name = "notes">Заметки.</param>
    public Contact(string name, string secondName, int telephone, string notes)
    {
        Name = name;
        SurName = secondName;
        Telephone = telephone;
        Notes = notes;
    }

    public Contact() { }


}