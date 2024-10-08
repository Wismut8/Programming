using System;
///<summary>
/// Хранит даные о предмете в университете.
///</summary>
public class Subject
{
    /// <summary>
    /// Хранит название предмета.
    /// </summary>
    private string _name;
    /// <summary>
    /// Хранит имя преподавателя.
    /// </summary>
    private string _professor;
    /// <summary>
    /// Хранит успеваемость учащегося по этому предмету.
    /// </summary>
    private int _assessment;

    ///<summary>
    ///Возвращает и задает наименование предмета.
    ///</summary>
    public string Name { get; set; }

    ///<summary>
    ///Возвращает и задает ФИО преподавателя.
    ///</summary>
    public string Professor { get; set; }

    ///<summary>
    ///Возвращает и задает оценку по предмету. Значение должно быть от 0 до 5.
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
    ///Создает экземпляр предмета <see cref="Subject"/>
    ///</summary>
    ///<param name = "name">Наименование.</param>
    ///<param name = "professor">Преподаватель.</param>
    ///<param name = "assessment">Оценка. Значение от 0 до 5.</param>
    public Subject(string name, string professor, int assessment)
    {
        Name = name;
        Professor = professor;
        Assessment = assessment;
    }

    public Subject() { }
}