using SplashKitSDK;

namespace ShapeDrawer
{
    class Rectangle : Shape
    {
        private int _width, _height;

        public Rectangle() : this(Color.Green, 0, 0, 100, 100)
        { }

        public Rectangle(Color clr, float x, float y, int width, int height) : base(clr)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public override void Draw()
        {
            if (_selected) DrawOutline();
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }

        public override void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, _x - 2, _y - 2, _width + 4, _height + 4);
        }

        public override bool IsAt(Point2D pt)
        {
            return ((pt.X >= _x && pt.X <= (_x + _width)) && (pt.Y >= _y && pt.Y <= (_y + _height)));
        }
    }
}
