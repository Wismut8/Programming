using System;
///<summary>
///Контакт. 
///</summary>
public class Contact
{
    private string _name;
    private string _secondName;
    private int _telephone;
    private string _notes;

    ///<summary>
    ///Возвращает и задает имя контакта
    ///</summary>
    private string Name { get; set; }

    ///<summary>
    ///Возвращает и задает фамилию контакта
    ///</summary>
    private string SecondName { get; set; }

    ///<summary>
    ///Возвращает и задает телефон
    ///</summary>
    private int Telephone
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
    private string Notes { get; set; }

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
        SecondName = secondName;
        Telephone = telephone;
        Notes = notes;
    }
}