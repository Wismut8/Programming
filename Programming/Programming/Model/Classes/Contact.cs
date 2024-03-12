using System;
///<summary>
///Контакт. 
///</summary>
public class Contact
{
    private string _name;
    private string _surname;
    private int _telephone;
    private string _notes;

    ///<summary>
    ///Проверяет, содержит ли строка только латиницу
    ///</summary>
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
    ///Возвращает и задает имя контакта
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
    ///Возвращает и задает фамилию контакта
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
    ///Возвращает и задает телефон
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
    ///Возвращает и задает заметки к контакту
    ///</summary>
    public string Notes { get; set; }

    ///<summary>
    ///Создает экземпляр телефонного контакта
    ///</summary>
    ///<param name = "name">Имя.</param>
    ///<param name = "name">Фамилия.</param>
    ///<param name = "name">Телефон.</param>
    ///<param name = "name">Заметки.</param>
    public Contact(string name, string secondName, int telephone, string notes)
    {
        Name = name;
        SurName = secondName;
        Telephone = telephone;
        Notes = notes;
    }

    public Contact() { }


}