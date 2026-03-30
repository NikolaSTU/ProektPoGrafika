using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    [Serializable]

    public class TriangleShape : Shape    
    {
        public TriangleShape(RectangleF rect) : base(rect) 
        { 
        }

        public TriangleShape(TriangleShape triangle) : base(triangle) 
        { 
        }

        public override bool Contains(PointF point)
        {
            // Invert the matrix to convert point to local space
            Matrix inverse = TransformMatrix.Clone();
            inverse.Invert();

            PointF[] pts = new PointF[] { point };
            inverse.TransformPoints(pts);
            PointF localPoint = pts[0];

            // Triangle vertices in local coordinates
            PointF p1 = new PointF(Width / 2, 0);
            PointF p2 = new PointF(0, Height);
            PointF p3 = new PointF(Width, Height);

            float Sign(PointF p1_, PointF p2_, PointF p3_)
            {
                return (p1_.X - p3_.X) * (p2_.Y - p3_.Y) - (p2_.X - p3_.X) * (p1_.Y - p3_.Y);
            }

            bool b1 = Sign(localPoint, p1, p2) < 0.0f;
            bool b2 = Sign(localPoint, p2, p3) < 0.0f;
            bool b3 = Sign(localPoint, p3, p1) < 0.0f;

            return (b1 == b2) && (b2 == b3);
        }


        public override void DrawSelf(Graphics grfx)
        {
            var state = grfx.Save();

            grfx.Transform = TransformMatrix;

            PointF point1 = new PointF(Width / 2, 0);
            PointF point2 = new PointF(0, Height);
            PointF point3 = new PointF(Width, Height);

            PointF[] points = { point1, point2, point3 };

            using (SolidBrush brush = new SolidBrush(FillColor))
            using (Pen pen = new Pen(StrokeColor, 2))
            {
                grfx.FillPolygon(brush, points);
                grfx.DrawPolygon(pen, points);
            }

            grfx.Restore(state);
        }

        public override GraphicsPath GetShapePath()
        {
            GraphicsPath path = new GraphicsPath();
            PointF p1 = new PointF(Width / 2, 0);
            PointF p2 = new PointF(0, Height);
            PointF p3 = new PointF(Width, Height);

            path.AddPolygon(new[] { p1, p2, p3 });

            path.Transform(TransformMatrix);  // same as ellipse

            return path;
        }

        public override PointF GetShapeCenter()
        {
            PointF p1 = new PointF(Width / 2, 0);
            PointF p2 = new PointF(0, Height);
            PointF p3 = new PointF(Width, Height);

            float cx = (p1.X + p2.X + p3.X) / 3f;
            float cy = (p1.Y + p2.Y + p3.Y) / 3f;

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
