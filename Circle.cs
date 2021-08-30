using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    class Circle : Shape
    {
        private int _radius;

        public Circle() : this(Color.Blue, 50)
        { }

        public Circle(Color clr, int radius) : base(clr)
        {
            _radius = radius;
        }

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public override void Draw()
        {
            if (_selected) DrawOutline();
            SplashKit.FillCircle(_color, _x, _y, _radius);
        }

        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, _x, _y, _radius+2);
        }

        public override bool IsAt(Point2D pt)
        {
            return ((Math.Abs(pt.X - _x) <= _radius) && (Math.Abs(pt.Y - _y) <= _radius));
        }
    }
}
