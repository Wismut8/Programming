using System;
///<summary>
///�������. 
///</summary>
public class Subject
{
    private string _name;
    private string _professor;
    private int _assessment;

    ///<summary>
    ///���������� � ������ ������������ ��������
    ///</summary>
    public string Name { get; set; }

    ///<summary>
    ///���������� � ������ ������� �������������
    ///</summary>
    public string Professor { get; set; }

    ///<summary>
    ///���������� � ������ ������ �� ��������
    ///</summary>
    public int Assessment
    {
        get
        {
            return _assessment;
        }
        set
        {
            if (value < 0 || value > 5)
                {
                throw new ArgumentException();
            }
            _assessment = value;
        }
    }

    ///<summary>
    ///������� ��������� ��������
    ///</summary>
    ///<param name = "name">������������.</param>
    ///<param name = "name">�������������.</param>
    ///<param name = "name">������.</param>
    public Subject(string name, string professor, int assessment)
    {
        Name = name;
        Professor = professor;
        Assessment = assessment;
    }

    public Subject() { }
}