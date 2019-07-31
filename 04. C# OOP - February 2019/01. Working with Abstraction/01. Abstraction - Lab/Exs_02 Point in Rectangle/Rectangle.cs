namespace Exs_02_Point_in_Rectangle
{
    class Rectangle
    {

        private Point topLeft;
        private Point bottomRight;

        public Rectangle(int x1, int y1, int x2, int y2)
        {
            this.topLeft.X = x1;
            this.topLeft.Y = y1;
            this.bottomRight.X = x2;
            this.bottomRight.Y = y2;
        }

        public bool Contains(Point point)
        {
            bool isInHorizontally = point.X >= this.topLeft.X && point.Y <= this.bottomRight.X;
            bool isInVertically = point.Y >= this.bottomRight.Y && point.Y <= this.topLeft.Y;
            bool isIn = isInHorizontally && isInVertically;
            return isIn;
        }

    }
}
