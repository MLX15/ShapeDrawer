﻿using System.Collections.Generic;
using SplashKitSDK;

namespace ShapeDrawer
{
    class Drawing
    {
        private List<Shape> _shapes;
        private Color _background;

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }

        public Drawing() : this (Color.White) { }

        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> SelectedShapes = new List<Shape>();
                foreach(Shape shape in _shapes)
                    if (shape.Selected)
                        SelectedShapes.Add(shape);
                return SelectedShapes;
            }
        }

        public int ShapeCount
        {
            get { return _shapes.Count; }
        }

        public Color Background
        {
            get { return _background; }
            set { _background = value; }
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach(Shape shape in _shapes) { shape.Draw(); }
        }

        public void SelectShapesAt(Point2D pt)
        {
            foreach(Shape shape in _shapes)
            {
                if (shape.IsAt(pt))
                    shape.Selected = true;
                else
                    shape.Selected = false;
            }
        }

        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }

        public void RemoveShape(Shape s)
        {
            _shapes.Remove(s);
        }
    }
}
