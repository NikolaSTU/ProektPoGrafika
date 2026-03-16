using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Draw
{
	/// <summary>
	/// Класът, който ще бъде използван при управляване на диалога.
	/// </summary>
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor

		public DialogProcessor()
		{
		}

		#endregion

		#region Properties

		/// <summary>
		/// Избран елемент.
		/// </summary>
		private List<Shape> selection = new List<Shape>();
		public List<Shape> Selection
		{
			get { return selection; }
			set { selection = value; }
		}

		/// <summary>
		/// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
		/// </summary>
		private bool isDragging;
		public bool IsDragging
		{
			get { return isDragging; }
			set { isDragging = value; }
		}

		/// <summary>
		/// Последна позиция на мишката при "влачене".
		/// Използва се за определяне на вектора на транслация.
		/// </summary>
		private PointF lastLocation;
		public PointF LastLocation
		{
			get { return lastLocation; }
			set { lastLocation = value; }
		}

		private bool isResizing;
        public bool IsResizing
		{
			get { return isResizing; }
			set { isResizing = value; }
		}


        private ResizeHandle activeHandle = ResizeHandle.None;
        public ResizeHandle ActiveHandle
        {
            get { return activeHandle; }
            set { activeHandle = value; }
        }

        private RectangleF originalBounds;



        public enum ResizeHandle
        {
            None,
            TopLeft,
            TopRight,
            BottomLeft,
            BottomRight
        }



        #endregion

        /// <summary>
        /// Добавя примитив - правоъгълник на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomRectangle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			RectangleShape rect = new RectangleShape(new Rectangle(x, y, 200, 200));
			rect.FillColor = Color.White;
			rect.StrokeColor = Color.Black;

			ShapeList.Add(rect);
		}

		public void AddRandomElipse()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			ElipseShape elipse = new ElipseShape(new Rectangle(x, y, 200, 200));
			elipse.FillColor = Color.White;
			elipse.StrokeColor = Color.Black;

			ShapeList.Add(elipse);
		}

		/// <summary>
		/// Проверява дали дадена точка е в елемента.
		/// Обхожда в ред обратен на визуализацията с цел намиране на
		/// "най-горния" елемент т.е. този който виждаме под мишката.
		/// </summary>
		/// <param name="point">Указана точка</param>
		/// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
		public Shape ContainsPoint(PointF point)
		{
			for (int i = ShapeList.Count - 1; i >= 0; i--)
			{
				if (ShapeList[i].Contains(point))
				{
					//ShapeList[i].FillColor = Color.Red;

					return ShapeList[i];
				}
			}
			return null;
		}

		/// <summary>
		/// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
		/// </summary>
		/// <param name="p">Вектор на транслация.</param>
		public void TranslateTo(PointF p)
		{
			if (selection != null)
			{
				foreach (Shape item in selection)
				{
					item.Location = new PointF(item.Location.X + p.X - lastLocation.X, item.Location.Y + p.Y - lastLocation.Y);
					lastLocation = p;
				}
			}
		}

		public void Translate(PointF p)
		{
			if (Selection != null)
			{

                float dX = p.X - lastLocation.X;
                float dY = p.Y - lastLocation.Y;

                foreach (Shape item in Selection)
				{
					Matrix translateMatrix = item.TransformMatrix.Clone();
					translateMatrix.Translate(dX, dY, MatrixOrder.Append);
					item.TransformMatrix = translateMatrix;
				}
                lastLocation = p;
            }
		}

		public void RotateAt(float angleDeg)
		{
			if (Selection == null)
				return;
			foreach (Shape item in Selection)
			{
				//get local center
				float cx = item.Rectangle.X + item.Rectangle.Width / 2;
				float cy = item.Rectangle.Y + item.Rectangle.Height / 2;

				PointF center = new PointF(cx, cy);
				PointF[] pts = new PointF[] { center }; //zashtoto metoda vzima masiv

				// transform the local center into global coordinates
				item.TransformMatrix.TransformPoints(pts);
				PointF transformedCenter = pts[0];

				Matrix rotationMatrix = item.TransformMatrix.Clone();

				rotationMatrix.Translate(-transformedCenter.X, -transformedCenter.Y, MatrixOrder.Append);
				rotationMatrix.Rotate(angleDeg, MatrixOrder.Append);
				rotationMatrix.Translate(transformedCenter.X, transformedCenter.Y, MatrixOrder.Append);

				item.TransformMatrix = rotationMatrix;
			}
		}

		public void Scale(float scaleX, float scaleY)
		{
			if (Selection == null)
				return;

			foreach (Shape item in Selection)
			{
				//get local center
				float cx = item.Rectangle.X + item.Rectangle.Width / 2;
				float cy = item.Rectangle.Y + item.Rectangle.Height / 2;

				PointF center = new PointF(cx, cy);
				PointF[] pts = new PointF[] { center };

				// transform the local center into global coordinates
				item.TransformMatrix.TransformPoints(pts);
				PointF transformedCenter = pts[0];


				Matrix scaleMatrix = item.TransformMatrix.Clone();
				scaleMatrix.Translate(-transformedCenter.X, -transformedCenter.Y, MatrixOrder.Append);
				scaleMatrix.Scale(scaleX, scaleY, MatrixOrder.Append);
				scaleMatrix.Translate(transformedCenter.X, transformedCenter.Y, MatrixOrder.Append);

				item.TransformMatrix = scaleMatrix;
			}

		}

		public void AnchorScale(float scaleX, float scaleY, PointF anchor)
		{
            if (Selection == null)
                return;

            foreach (Shape item in Selection)
            {
                Matrix scaleMatrix = item.TransformMatrix.Clone();
                scaleMatrix.Translate(-anchor.X, -anchor.Y, MatrixOrder.Append);
                scaleMatrix.Scale(scaleX, scaleY, MatrixOrder.Append);
                scaleMatrix.Translate(anchor.X, anchor.Y, MatrixOrder.Append);

                item.TransformMatrix = scaleMatrix;
            }
        }

		public void Sheer(float sheerX, float sheerY)
		{
			if (Selection == null) return;

			foreach (Shape item in Selection)
			{
                float cx = item.Rectangle.X + item.Rectangle.Width / 2;
                float cy = item.Rectangle.Y + item.Rectangle.Height / 2;

                PointF center = new PointF(cx, cy);
                PointF[] pts = new PointF[] { center };

                item.TransformMatrix.TransformPoints(pts);
                PointF transformedCenter = pts[0];

                Matrix sheerMatrix = item.TransformMatrix.Clone();
                sheerMatrix.Translate(-transformedCenter.X, -transformedCenter.Y, MatrixOrder.Append);
                sheerMatrix.Shear(sheerX, sheerY, MatrixOrder.Append);
                sheerMatrix.Translate(transformedCenter.X, transformedCenter.Y, MatrixOrder.Append);

                item.TransformMatrix = sheerMatrix;
            }
		}


		public override void Draw(Graphics grfx)
		{
			base.Draw(grfx);

			DrawSelection(grfx);
		}

		public void DrawSelection(Graphics grfx)
		{
			const float offset = 10f;

			foreach (Shape item in Selection)
			{
				GraphicsPath shapePath = item.GetShapePath();

				RectangleF bounds = shapePath.GetBounds();
				bounds.Inflate(offset, offset);

				using (Pen pen = new Pen(Color.DeepPink))
				{
					pen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
					pen.DashPattern = new float[] { 10.0F, 5.0F, 10.0F, 5.0F };
                    grfx.DrawRectangle(pen, bounds.X, bounds.Y, bounds.Width, bounds.Height);

                    const float handleSize = 10f;

                    RectangleF tl = new RectangleF(bounds.Left - handleSize / 2, bounds.Top - handleSize / 2, handleSize, handleSize);
                    RectangleF tr = new RectangleF(bounds.Right - handleSize / 2, bounds.Top - handleSize / 2, handleSize, handleSize);
                    RectangleF bl = new RectangleF(bounds.Left - handleSize / 2, bounds.Bottom - handleSize / 2, handleSize, handleSize);
                    RectangleF br = new RectangleF(bounds.Right - handleSize / 2, bounds.Bottom - handleSize / 2, handleSize, handleSize);

                    grfx.FillRectangle(Brushes.White, tl);
                    grfx.FillRectangle(Brushes.White, tr);
                    grfx.FillRectangle(Brushes.White, bl);
                    grfx.FillRectangle(Brushes.White, br);

                    grfx.DrawRectangle(Pens.DeepPink, tl.X, tl.Y, tl.Width, tl.Height);
                    grfx.DrawRectangle(Pens.DeepPink, tr.X, tr.Y, tr.Width, tr.Height);
                    grfx.DrawRectangle(Pens.DeepPink, bl.X, bl.Y, bl.Width, bl.Height);
                    grfx.DrawRectangle(Pens.DeepPink, br.X, br.Y, br.Width, br.Height);
                }
			}
		}

        public ResizeHandle HitTestResizeHandle(PointF point)
        {
            if (Selection == null || Selection.Count == 0)
                return ResizeHandle.None;

            RectangleF bounds = Selection[0].GetShapePath().GetBounds();
            bounds.Inflate(10f, 10f);

            if (GetHandleRectangle(bounds, ResizeHandle.TopLeft).Contains(point))
                return ResizeHandle.TopLeft;

            if (GetHandleRectangle(bounds, ResizeHandle.TopRight).Contains(point))
                return ResizeHandle.TopRight;

            if (GetHandleRectangle(bounds, ResizeHandle.BottomLeft).Contains(point))
                return ResizeHandle.BottomLeft;

            if (GetHandleRectangle(bounds, ResizeHandle.BottomRight).Contains(point))
                return ResizeHandle.BottomRight;

            return ResizeHandle.None;
        }


        private RectangleF GetHandleRectangle(RectangleF bounds, ResizeHandle handle)
        {
            float size = 10f;
            float half = size / 2f;

            switch (handle)
            {
                case ResizeHandle.TopLeft:
                    return new RectangleF(bounds.Left - half, bounds.Top - half, size, size);

                case ResizeHandle.TopRight:
                    return new RectangleF(bounds.Right - half, bounds.Top - half, size, size);

                case ResizeHandle.BottomLeft:
                    return new RectangleF(bounds.Left - half, bounds.Bottom - half, size, size);

                case ResizeHandle.BottomRight:
                    return new RectangleF(bounds.Right - half, bounds.Bottom - half, size, size);

                default:
                    return RectangleF.Empty;
            }
        }

        public void Group()
        {
            if (Selection == null || Selection.Count < 2)
            {
                return;
            }
            GroupShape group = new GroupShape();

            foreach (Shape shape in Selection)
            {
                group.SubShape.Add(shape);
            }

            group.CalculateBoundingBox();

			foreach (Shape shape in Selection)
			{
				ShapeList.Remove(shape);
			}

			ShapeList.Add(group);

			Selection.Clear();
			Selection.Add(group);

        }
    }

	
    }


