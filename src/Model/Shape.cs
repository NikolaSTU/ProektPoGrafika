using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace Draw
{
	/// <summary>
	/// Базовия клас на примитивите, който съдържа общите характеристики на примитивите.
	/// </summary>
	/// 
	[Serializable]
	public abstract class Shape
	{
		#region Constructors
		
		public Shape()
		{
		}
		
		public Shape(RectangleF rect)
		{
			rectangle = rect;
		}
		
		public Shape(Shape shape)
		{
			this.Height = shape.Height;
			this.Width = shape.Width;
			this.Location = shape.Location;
			this.rectangle = shape.rectangle;
			
			this.FillColor =  shape.FillColor;
		}
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Обхващащ правоъгълник на елемента.
		/// </summary>
		private RectangleF rectangle;
		public virtual RectangleF Rectangle {
			get { return rectangle; }
			set { rectangle = value; }
		}
		
		/// <summary>
		/// Широчина на елемента.
		/// </summary>
		public virtual float Width {
			get { return Rectangle.Width; }
			set { rectangle.Width = value; }
		}
		
		/// <summary>
		/// Височина на елемента.
		/// </summary>
		public virtual float Height {
			get { return Rectangle.Height; }
			set { rectangle.Height = value; }
		}
		
		/// <summary>
		/// Горен ляв ъгъл на елемента.
		/// </summary>
		public virtual PointF Location {
			get { return Rectangle.Location; }
			set { rectangle.Location = value; }
		}
		
		/// <summary>
		/// Цвят на елемента.
		/// </summary>
		private Color fillColor;
		public virtual Color FillColor {
			get { return fillColor; }
			set { fillColor = value; }
		}


		private Color strokeColor;
		public virtual Color StrokeColor
		{
			get { return strokeColor; }
			set { strokeColor = value; }
		}

		//stroke width
		//opacity
		[NonSerialized]
		private Matrix transformMatrix = new Matrix();
		public virtual Matrix TransformMatrix
		{
			get { return transformMatrix; }
			set { transformMatrix = value; }
		}

		//event that happens before serialization
		//we get the values from the transform matrix
		//and se them to the matrix data 2d array
		[OnSerializing]
		internal void OnSerializingMethod(StreamingContext context)
		{
			int index = 0;
			var elements = TransformMatrix.Elements;

				for (int i = 0; i <= 2; i++)
				{
					for(int j = 0; j <=1; j++)
					{
						MatrixData[i, j] = elements[index++];
					}
				}
		}

		//event that happens after deserialization
		[OnDeserialized]
		internal void OnDeserializingMethod(StreamingContext context)
		{
			float m11 = MatrixData[0, 0];
			float m12 = MatrixData[0, 1];
			float m21 = MatrixData[1, 0];
			float m22 = MatrixData[1, 1];
			float dx = MatrixData[2, 0];
			float dy = MatrixData[2, 1];

			//create new matrix and pass the six parameters
			//Public Matrix(float m11, float m12, float m21, float m22, float dx, float dy)
			//set the transform matrix to be the new matrix
		}

		// we use matrix data 2d array to store the parameters
		// from the transform matrix
		private float[,] matrixData = new float[3, 2];
		public virtual float[,] MatrixData
		{
			get { return matrixData; }
			set { matrixData = value; }
		}

		private string name;
		public virtual string Name
		{
			get { return name; }
			set { name = value; }
		}

		#endregion
		
		
		/// <summary>
		/// Проверка дали точка point принадлежи на елемента.
		/// </summary>
		/// <param name="point">Точка</param>
		/// <returns>Връща true, ако точката принадлежи на елемента и
		/// false, ако не пренадлежи</returns>
		public virtual bool Contains(PointF point)
		{
			Matrix inverseMatrix = TransformMatrix.Clone();
			inverseMatrix.Invert();

			PointF[] points = new[] { point };
			inverseMatrix.TransformPoints(points);

			return Rectangle.Contains(points[0]);
		}
		
		/// <summary>
		/// Визуализира елемента.
		/// </summary>
		/// <param name="grfx">Къде да бъде визуализиран елемента.</param>
		public virtual void DrawSelf(Graphics grfx)
		{
			// shape.Rectangle.Inflate(shape.BorderWidth, shape.BorderWidth);
		}

		/// <summary>
		/// Returns the center (in world/global coordinates) of the shape.
		/// Default implementation uses the bounding rectangle center transformed by the shape's TransformMatrix.
		/// </summary>
		public virtual PointF GetShapeCenter()
		{
			float cx = Rectangle.X + Rectangle.Width / 2f;
			float cy = Rectangle.Y + Rectangle.Height / 2f;

			PointF[] pts = new[] { new PointF(cx, cy) };

			if (TransformMatrix != null)
			{
				Matrix m = TransformMatrix.Clone();
				m.TransformPoints(pts);
			}

			return pts[0];
		}
		
		public virtual GraphicsPath GetShapePath()
		{
			GraphicsPath path = new GraphicsPath();
			path.AddRectangle(Rectangle);
			path.Transform(transformMatrix);
			return path;
		}
	}
}
