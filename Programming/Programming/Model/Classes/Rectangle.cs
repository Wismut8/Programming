using System;
///<summary>
///�������������. 
///</summary>
public class Rectangle
{
	private double _height;
	private double _width;
	private string _color;

    ///<summary>
    ///���������� � ������ ����� ��������������
    ///</summary>
    private double Height
    {
        get
        {
            return _height;
        }
        set
        {
            if (value < 0.0)
            {
                throw new ArgumentException();
            }
            _height = value;
        }
    }

    ///<summary>
    ///���������� � ������ ������ ��������������
    ///</summary>
    private double Width
    {
        get
        {
            return _width;
        }
        set
        {
            if (value < 0.0)
            {
                throw new ArgumentException();
            }
            _width = value;
        }
    }

    ///<summary>
    ///���������� � ������ ���� ��������������
    ///</summary>
    private string Color { get; set; }

	///<summary>
	///������� ��������� ��������������
	///</summary>
	///<param name = "name">�����.</param>
	///<param name = "name">������.</param>
	///<param name = "name">����.</param>
	public Rectangle(double height, double width, string color)
	{
		Height = height;
		Width = width;
		Color = color;
	}
}