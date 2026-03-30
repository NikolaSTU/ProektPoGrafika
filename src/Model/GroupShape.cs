using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace Draw.src.Model
{
    [Serializable]

    internal class GroupShape : Shape
    {
        public GroupShape() : base() { }

        public GroupShape(RectangleF rectangle) : base(rectangle)
        {
        }

        public GroupShape(GroupShape group) : base(group)
        {

        }

        public List<Shape> SubShape = new List<Shape>();

        public override bool Contains(PointF point)
        {
            foreach (Shape shape in SubShape)
            {
                if (shape.Contains(point))
                    return true;
            }

            return false;

        }

        public override void DrawSelf(Graphics grfx)
        {
            var state = grfx.Save();
            grfx.Transform = TransformMatrix;

            foreach (Shape shape in SubShape)
            {
                shape.DrawSelf(grfx);
            }

            grfx.Restore(state);
        }

        public void CalculateBoundingBox()
        {
            if (SubShape.Count == 0)
                return;

            float minX = float.MaxValue;
            float minY = float.MaxValue;
            float maxX = float.MinValue;
            float maxY = float.MinValue;

            foreach (Shape shape in SubShape)
            {
                minX = Math.Min(minX, shape.Rectangle.Left);
                minY = Math.Min(minY, shape.Rectangle.Top);

                maxX = Math.Max(maxX, shape.Rectangle.Right);
                maxY = Math.Max(maxY, shape.Rectangle.Bottom);
            }

            Rectangle = new RectangleF(minX, minY, maxX - minX, maxY - minY);

        }

        public void CalculateBoundingBoxTransformer()
        {
            if (SubShape == null || SubShape.Count == 0)
                return;

            RectangleF? bounds = null;

            foreach (Shape shape in SubShape)
            {
                using (GraphicsPath path = shape.GetShapePath())
                {
                    RectangleF b = path.GetBounds();
                    if (bounds == null)
                        bounds = b;
                    else
                        bounds = RectangleF.Union(bounds.Value, b);
                }
            }

            if (bounds.HasValue)
                Rectangle = bounds.Value;
        }
    }
}
