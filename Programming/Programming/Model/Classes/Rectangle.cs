using System;
///<summary>
///�������������. 
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
    ///���������� � ������ ���������� ������ ��������������
    ///</summary>
    public Point2D RectangleCenter { get; set; }

    ///<summary>
    ///���������� � ������ ����� ��������������
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
    ///���������� � ������ ������ ��������������
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
    ///���������� � ������ ���� ��������������
    ///</summary>
    public string Color { get; set; }

    ///<summary>
    ///���������� � ������ ���������� ������ ��������������
    ///</summary>
    public Point2D Center { get; private set; }

    ///<summary>
    ///������� ��������� ��������������
    ///</summary>
    ///<param name = "name">�����.</param>
    ///<param name = "name">������.</param>
    ///<param name = "name">����.</param>
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