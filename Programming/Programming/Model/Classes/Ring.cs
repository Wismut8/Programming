using System;
///<summary>
///Кольцо. 
///</summary>
public class Ring
{
    private Point2D _center;
    private double _outerRadius;
    private double _innerRadius;

    ///<summary>
    ///Возвращает и задает точку центра
    ///</summary>
    public Point2D RingCenter { get; set; }

    ///<summary>
    ///Возвращает и задает внутренний радиус
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
    ///Возвращает и задает внешний радиус
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

    ///<summary>
    ///Возвращает площадь кольца
    ///</summary>
    public double Area
    {
        get
        {
            return Math.PI * (_outerRadius * _outerRadius - _innerRadius * _innerRadius);
        }
    }

    ///<summary>
    ///Создает экземпляр прямоугольника
    ///</summary>
    ///<param name = "name">Длина.</param>
    ///<param name = "name">Ширина.</param>
    ///<param name = "name">Цвет.</param>
    public Ring(Point2D center, double outerRadius, double innerRadius)
    {
        RingCenter = center;
        OuterRadius = outerRadius;
        InnerRadius = innerRadius;
    }

    public Ring() { }
}