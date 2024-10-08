using System;
///<summary>
/// Хранит данные о кольце. 
///</summary>
public class Ring
{
    /// <summary>
    /// Хранит данные о координатах центра кольца.
    /// </summary>
    private Point2D _center;
    /// <summary>
    /// Хранит значение внешнего радиуса.
    /// </summary>
    private double _outerRadius;
    /// <summary>
    /// Хранит значение внутреннего радиуса.
    /// </summary>
    private double _innerRadius;

    ///<summary>
    ///Возвращает и задает точку центра.
    ///</summary>
    public Point2D RingCenter { get; set; }

    ///<summary>
    ///Возвращает и задает внутренний радиус. Значение должно быть положительным и меньше внешнего радиуса.
    ///</summary>
    public double InnerRadius
    {
        get { return _innerRadius; }
        set
        {
            if (value <= 0 || value >= _outerRadius)
            {
                throw new ArgumentException("Inner radius must be a positive number less than the outer radius.");
            }
            _innerRadius = value;
        }
    }

    ///<summary>
    ///Возвращает и задает внешний радиус. Значение должно быть положительным и больше внутреннего радиуса.
    ///</summary>
    public double OuterRadius
    {
        get { return _outerRadius; }
        set
        {
            if (value <= 0 || value <= _innerRadius)
            {
                throw new ArgumentException("Outer radius must be a positive number greater than the inner radius.");
            }
            _outerRadius = value;
        }
    }

    /// <summary>
    /// Возвращает площадь кольца.
    /// </summary>
    public double Area
    {
        get
        {
            return Math.PI * (_outerRadius * _outerRadius - _innerRadius * _innerRadius);
        }
    }

    ///<summary>
    ///Создает экземпляр кольца. <see cref="Ring"/>
    ///</summary>
    ///<param name = "center">Координаты центра кольца.</param>
    ///<param name = "outerRadius">Внешний радиус. Только положительное значение, больше внутреннего радиуса.</param>
    ///<param name = "innerRadius">Внутренний радиус. Только положительное значение, меньше внешнего радиуса.</param>
    public Ring(Point2D center, double outerRadius, double innerRadius)
    {
        RingCenter = center;
        OuterRadius = outerRadius;
        InnerRadius = innerRadius;
    }

    public Ring() { }
}