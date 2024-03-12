using System;
///<summary>
///Прямоугольник. 
///</summary>
public class Rectangle
{
    private static int _allRectanglesCount = 0;
    private readonly int _id;
    private Point2D _center;
    private double _height;
	private double _width;
	private string _color;

    public int Id
    {
        get { return _id; }
    }

    public static int AllRectanglesCount()
    {
        return _allRectanglesCount;
    }

    ///<summary>
    ///Возвращает и задает координаты центра прямоугольника
    ///</summary>
    public Point2D RectangleCenter { get; set; }

    ///<summary>
    ///Возвращает и задает длину прямоугольника
    ///</summary>
    public double Height
    {
        get
        {
            return _height;
        }
        set
        {
            if (Validator.AssertOnPositiveValue(value))
            {
                _height = value;
            }
        }
    }

    ///<summary>
    ///Возвращает и задает ширину прямоугольника
    ///</summary>
    public double Width
    {
        get
        {
            return _width;
        }
        set
        {
            if (Validator.AssertOnPositiveValue(value))
            {
               _width = value;
            }
        }
    }

    ///<summary>
    ///Возвращает и задает цвет прямоугольника
    ///</summary>
    public string Color { get; set; }

    ///<summary>
    ///Возвращает и задает координаты центра прямоугольника
    ///</summary>
    public Point2D Center { get; private set; }

    ///<summary>
    ///Создает экземпляр прямоугольника
    ///</summary>
    ///<param name = "name">Длина.</param>
    ///<param name = "name">Ширина.</param>
    ///<param name = "name">Цвет.</param>
    public Rectangle(double height, double width, string color, Point2D center)
	{
		Height = height;
		Width = width;
		Color = color;
        Center = center;
        _allRectanglesCount++;
        _id = _allRectanglesCount;
    }

    public Rectangle() { }
}