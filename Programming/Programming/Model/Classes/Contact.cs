using System;
///<summary>
///�������. 
///</summary>
public class Contact
{
    private string _name;
    private string _secondName;
    private int _telephone;
    private string _notes;

    ///<summary>
    ///���������� � ������ ��� ��������
    ///</summary>
    private string Name { get; set; }

    ///<summary>
    ///���������� � ������ ������� ��������
    ///</summary>
    private string SecondName { get; set; }

    ///<summary>
    ///���������� � ������ �������
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
    ///���������� � ������ ������� � ��������
    ///</summary>
    private string Notes { get; set; }

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
        SecondName = secondName;
        Telephone = telephone;
        Notes = notes;
    }
}