using System;
///<summary>
///�������. 
///</summary>
public class Contact
{
    private string _name;
    private string _surname;
    private int _telephone;
    private string _notes;

    ///<summary>
    ///���������, �������� �� ������ ������ ��������
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
    ///���������� � ������ ��� ��������
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
    ///���������� � ������ ������� ��������
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
    ///���������� � ������ �������
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
    ///���������� � ������ ������� � ��������
    ///</summary>
    public string Notes { get; set; }

    ///<summary>
    ///������� ��������� ����������� ��������
    ///</summary>
    ///<param name = "name">���.</param>
    ///<param name = "name">�������.</param>
    ///<param name = "name">�������.</param>
    ///<param name = "name">�������.</param>
    public Contact(string name, string secondName, int telephone, string notes)
    {
        Name = name;
        SurName = secondName;
        Telephone = telephone;
        Notes = notes;
    }

    public Contact() { }


}