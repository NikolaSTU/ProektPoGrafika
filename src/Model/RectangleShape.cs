using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
    /// <summary>
    /// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
    /// </summary>
    /// 
    [Serializable]

    public class RectangleShape : Shape
	{
		#region Constructor
		
		public RectangleShape(RectangleF rect) : base(rect)
		{
		}
		
		public RectangleShape(RectangleShape rectangle) : base(rectangle)
		{
		}
		
		#endregion

		/// <summary>
		/// Проверка за принадлежност на точка point към правоъгълника.
		/// В случая на правоъгълник този метод може да не бъде пренаписван, защото
		/// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
		/// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
		/// елемента в този случай).
		/// </summary>
		public override bool Contains(PointF point)
		{
			if (base.Contains(point))
				// Проверка дали е в обхващащия правоъгълник само, ако точката е в обхващащия правоъгълник.
				// В случая на правоъгълник - директно връщаме true
				return true;
			else
				// Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
				return false;
		}
		
		/// <summary>
		/// Частта, визуализираща конкретния примитив.
		/// </summary>
		public override void DrawSelf(Graphics grfx)
		{
            var state = grfx.Save();

            base.DrawSelf(grfx);

            grfx.Transform = TransformMatrix;
            grfx.FillRectangle(new SolidBrush(FillColor),Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(new Pen(new SolidBrush(StrokeColor), 2), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            grfx.Restore(state);

        }

        public override System.Drawing.PointF GetShapeCenter()
        {
            // bounding rect center in local coords
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
