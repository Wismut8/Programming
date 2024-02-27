using System;
///<summary>
///Предмет. 
///</summary>
public class Subject
{
    private string _name;
    private string _professor;
    private int _assessment;

    ///<summary>
    ///Возвращает и задает наименование предмета
    ///</summary>
    private string Name { get; set; }

    ///<summary>
    ///Возвращает и задает фамилию преподавателя
    ///</summary>
    private string Professor { get; set; }

    ///<summary>
    ///Возвращает и задает оценку по предмету
    ///</summary>
    private int Assessment
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
    ///Создает экземпляр предмета
    ///</summary>
    ///<param name = "name">Наименование.</param>
    ///<param name = "name">Преподаватель.</param>
    ///<param name = "name">Оценка.</param>
    public Subject(string name, string professor, int assessment)
    {
        Name = name;
        Professor = professor;
        Assessment = assessment;
    }
}