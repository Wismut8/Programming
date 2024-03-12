public static class CollisionManager
{
    public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        int deltaX = Math.Abs(rectangle1.RectangleCenter.X - rectangle2.RectangleCenter.X);
        int deltaY = Math.Abs(rectangle1.RectangleCenter.Y - rectangle2.RectangleCenter.Y);

        double sumHalfWidths = (rectangle1.Width + rectangle2.Width) / 2;
        double sumHalfHeights = (rectangle1.Height + rectangle2.Height) / 2;

        return deltaX < sumHalfWidths && deltaY < sumHalfHeights;
    }

    public static bool IsCollision(Ring ring1, Ring ring2)
    {
        double distance = Math.Sqrt(Math.Pow(ring1.RingCenter.X - ring2.RingCenter.X, 2) + Math.Pow(ring1.RingCenter.Y - ring2.RingCenter.Y, 2));
        double sumRadii = ring1.OuterRadius + ring2.OuterRadius;

        if (distance < sumRadii)
        {
            if (distance + ring1.InnerRadius < ring2.OuterRadius || distance + ring2.InnerRadius < ring1.OuterRadius)
            {
                return false; // учет коллизии
            }
            return true;
        }
        return false;
    }
}