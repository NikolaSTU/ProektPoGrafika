using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    [Serializable]

    public class ElipseShape : Shape
    {
        public ElipseShape(RectangleF rect) : base(rect) 
        {
        }

        public ElipseShape(ElipseShape elipse) : base(elipse)
        { 
        }

        public override bool Contains(PointF point)
        {
            //inver the matrix so that we work with local coordinates
            Matrix inverse = TransformMatrix.Clone();
            inverse.Invert();

            PointF[] pts = new PointF[] { point };
            inverse.TransformPoints(pts);

            PointF localPoint = pts[0];

            bool isInside = false;
            float a = Rectangle.Width / 2;
            float b = Rectangle.Height / 2;

            float cx = Rectangle.X + a;
            float cy = Rectangle.Y + b;

            float dx = localPoint.X - cx;
            float dy = localPoint.Y - cy;

            isInside = (dx * dx) / (a * a) + (dy * dy) / (b * b) <= 1f;

            return isInside;
        }

        public override void DrawSelf(Graphics grfx)
        {
            //save the graphics context
            var state = grfx.Save();

            base.DrawSelf(grfx);

            //take into account the transform matrix when draxing the primitive
            grfx.Transform = TransformMatrix;

            Color strokeColor = Color.FromArgb(100, StrokeColor);

            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(new Pen(new SolidBrush(StrokeColor), StrokeWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            grfx.Restore(state);
        }

        public override PointF GetShapeCenter()
        {
            // center of bounding rectangle in local coordinates
            float cx = Rectangle.X + Rectangle.Width / 2f;
            float cy = Rectangle.Y + Rectangle.Height / 2f;

            PointF[] pts = new PointF[] { new PointF(cx, cy) };
            if (TransformMatrix != null)
            {
                Matrix m = TransformMatrix.Clone();
                m.TransformPoints(pts);
            }

            return pts[0];
        }
    }
}
