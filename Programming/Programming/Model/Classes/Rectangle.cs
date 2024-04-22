using System;
///<summary>
///Прямоугольник. 
///</summary>
public class Rectangle
{
    private static int _allRectanglesCount = 0;
    private readonly int _id;
    private Point2D _center;
    private int _height;
	private int _width;

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
    public int Height
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
    public int Width
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
    ///Возвращает и задает координаты центра прямоугольника
    ///</summary>
    public Point2D Center { get; set; }

    ///<summary>
    ///Создает экземпляр прямоугольника
    ///</summary>
    ///<param name = "name">Длина.</param>
    ///<param name = "name">Ширина.</param>
    ///<param name = "name">Цвет.</param>
    public Rectangle(int height, int width, Point2D center)
	{
		Height = height;
		Width = width;
        Center = center;
        _allRectanglesCount++;
        _id = _allRectanglesCount;
    }

    public Rectangle() { }
}