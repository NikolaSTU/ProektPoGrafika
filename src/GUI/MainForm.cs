using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static Draw.DialogProcessor;

namespace Draw
{
	/// <summary>
	/// Върху главната форма е поставен потребителски контрол,
	/// в който се осъществява визуализацията
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		/// </summary>
		private DialogProcessor dialogProcessor = new DialogProcessor();

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		/// <summary>
		/// Изход от програмата. Затваря главната форма, а с това и програмата.
		/// </summary>
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
		/// </summary>
		void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
		}

        /// <summary>
        /// Бутон, който поставя на произволно място правоъгълник със зададените размери.
        /// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
        /// </summary>
        private void drawRectangleSpeedButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomRectangle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

            viewPort.Invalidate();
        }

        private void drawTriangleSpeedButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomTriangle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на Триъгълник";

            viewPort.Invalidate();
        }

        private void drawElipseSpeedButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomElipse();

            statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";

            viewPort.Invalidate();
        }

        private void RotateSpeedButton_Click(object sender, EventArgs e)
		{
			float rotateDeg = float.Parse(rotateTextBox.Text);

            if (dialogProcessor.Selection.Count > 0)
            {
                dialogProcessor.RotateAt(rotateDeg);
            }
            else
            {
                MessageBox.Show("Не сте селектирали елемент", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                statusBar.Items[0].Text = "Последно действие: Ротиране на елемент";

			viewPort.Invalidate();
		}

		private void ScaleSpeedButton_Click(object sender, EventArgs e)
		{
			float scaleX = float.Parse(scaleXTextBox.Text);
			float scaleY = float.Parse(scaleYTextBox.Text);

			if (scaleX > 0 && scaleY > 0)
			{
				dialogProcessor.Scale(scaleX, scaleY);
				statusBar.Items[0].Text = "Последно действие: Скалиране на елемент";
				viewPort.Invalidate();
			}
		}

		private void ColorPalleteSpeedButton_Click(object sender, EventArgs e)
		{
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				if (dialogProcessor.Selection != null)
				{
					foreach (Shape item in dialogProcessor.Selection)
					{
                        dialogProcessor.SetFillColor(item, colorDialog.Color);

					}
					viewPort.Invalidate();
				}
			}
		}

        private void applyColorFromRGB_Click(object sender, EventArgs e)
        {
            int red = int.Parse(rgbRedTextBox.Text);
            int green = int.Parse(rgbGreenTextBox.Text);
            int blue = int.Parse(rgbBlueTextBox.Text);
            int alpha = int.Parse(rgbAlphaTextBox.Text);

            if ((red > 255 || green > 255 || blue > 255 || alpha > 255) || 
                (red < 0 || green < 0 || blue < 0 || alpha < 0))
            {
                MessageBox.Show("Стойностите трябва да са [0-255]");
                return;
            }

            if (dialogProcessor.Selection.Count == 0)
            {
                MessageBox.Show("Не сте селектирали примитив");
                return;
            }

            foreach (Shape item in dialogProcessor.Selection)
            {
                dialogProcessor.SetFillColor(item, Color.FromArgb(alpha, red, green, blue));
                viewPort.Invalidate();
            }

        }

        private void applyNameSpeedButton_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.Selection.Count == 0)
            {
                MessageBox.Show("Не сте селектирали примитив");
                return;
            }
            string newName = nameTextBox.Text;

            foreach (Shape item in dialogProcessor.Selection)
                dialogProcessor.SetName(item, newName);

            //update name label

            UpdateNameLabel();

            nameTextBox.Clear();
            statusBar.Items[0].Text ="Последно действие: Преименуване на примитив";
            viewPort.Invalidate();

        }

        private void UpdateNameLabel()
        {
            nameLabel.Text = "Name";
            
            int elementsCount = dialogProcessor.Selection.Count;

            if (dialogProcessor.Selection.Count >= 1)
                nameLabel.Text = $"Name: {dialogProcessor.Selection[elementsCount - 1].Name}";
        }

        private void addXSheer_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.Selection.Count == 0)
            {
                MessageBox.Show("Не сте селектирали примитив");
                return;
            }
            else {
                foreach (Shape item in dialogProcessor.Selection)
                    dialogProcessor.Sheer(-0.2f, 0f);        
                
                }

            statusBar.Items[0].Text = "Последно действие: Sheer на елемент";
            viewPort.Invalidate();
        }

        private void removeXSheer_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.Selection.Count == 0)
            {
                MessageBox.Show("Не сте селектирали примитив");
                return;
            }
            else
            {
                foreach (Shape item in dialogProcessor.Selection)
                    dialogProcessor.Sheer(0.2f, 0f);

            }

            statusBar.Items[0].Text = "Последно действие: Sheer на елемент";
            viewPort.Invalidate();
        }

        private void removeYSheer_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.Selection.Count == 0)
            {
                MessageBox.Show("Не сте селектирали примитив");
                return;
            }
            else
            {
                foreach (Shape item in dialogProcessor.Selection)
                    dialogProcessor.Sheer(0f, 0.2f);

            }

            statusBar.Items[0].Text = "Последно действие: Sheer на елемент";
            viewPort.Invalidate();
        }

        private void addYSheer_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.Selection.Count == 0)
            {
                MessageBox.Show("Не сте селектирали примитив");
                return;
            }
            else
            {
                foreach (Shape item in dialogProcessor.Selection)
                    dialogProcessor.Sheer(0f, -0.2f);

            }

            statusBar.Items[0].Text = "Последно действие: Sheer на елемент";
            viewPort.Invalidate();
        }

       

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateSpeedButton_Click(sender, e);
        }

        private void setRandomColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (Shape item in dialogProcessor.Selection)
            dialogProcessor.SetFillColor(item, Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
            viewPort.Invalidate();
        }

        private void groupSpeedButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.Group();
            statusBar.Items[0].Text = "Последно действие: Създаване на група";

            viewPort.Invalidate();

        }

        private void UngroupSpeedButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.Ungroup();
            statusBar.Items[0].Text = "Последно действие: Премахване на група";
            viewPort.Invalidate();


        }

        /// <summary>
        /// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
        /// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
        /// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
        /// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
        /// </summary>
        void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (pickUpSpeedButton.Checked) {

                ResizeHandle handle = dialogProcessor.HitTestResizeHandle(e.Location);

                if (handle != ResizeHandle.None)
                {
                    dialogProcessor.IsResizing = true;
                    dialogProcessor.ActiveHandle = handle;
                    dialogProcessor.LastLocation = e.Location;
                    return;
                }

                Shape selectedShape = dialogProcessor.ContainsPoint(e.Location);

				//ctrl + click for multiple selection
				if ((ModifierKeys & Keys.Control) == Keys.Control)
				{ 
					if (selectedShape != null)
					{
						if(dialogProcessor.Selection.Contains(selectedShape))
						{
							dialogProcessor.Selection.Remove(selectedShape);
						}
						else
						{
							dialogProcessor.Selection.Add(selectedShape);
						}
					}
                }
				else
				{
					dialogProcessor.Selection.Clear();
					if(selectedShape != null)
					{
						dialogProcessor.Selection.Add(selectedShape);
					}
				}

                UpdateNameLabel();

                statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
                dialogProcessor.IsDragging = selectedShape != null;
                dialogProcessor.LastLocation = e.Location;
                viewPort.Invalidate();
            }
		}

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            if (dialogProcessor.IsResizing && dialogProcessor.Selection.Count > 0)
            {
                RectangleF bounds = dialogProcessor.Selection[0].GetShapePath().GetBounds();

                float dx = e.X - dialogProcessor.LastLocation.X;
                float dy = e.Y - dialogProcessor.LastLocation.Y;

                float scaleX = 1f;
                float scaleY = 1f;
				PointF anchor = PointF.Empty;

                switch (dialogProcessor.ActiveHandle)
                {
                    case ResizeHandle.TopLeft:
                        scaleX = 1f - dx / bounds.Width;
                        scaleY = 1f - dy / bounds.Height;
                        anchor = new PointF(bounds.Right, bounds.Bottom);
                        break;

                    case ResizeHandle.TopRight:
                        scaleX = 1f + dx / bounds.Width;
                        scaleY = 1f - dy / bounds.Height;
                        anchor = new PointF(bounds.Left, bounds.Bottom);
                        break;

                    case ResizeHandle.BottomLeft:
                        scaleX = 1f - dx / bounds.Width;
                        scaleY = 1f + dy / bounds.Height;
                        anchor = new PointF(bounds.Right, bounds.Top);
                        break;

                    case ResizeHandle.BottomRight:
                        scaleX = 1f + dx / bounds.Width;
                        scaleY = 1f + dy / bounds.Height;
                        anchor = new PointF(bounds.Left, bounds.Top);
                        break;
                }

                if (scaleX > 0.01f && scaleY > 0.01f)
                {
                    dialogProcessor.AnchorScale(scaleX, scaleY, anchor);
                }

                dialogProcessor.LastLocation = e.Location;
                viewPort.Invalidate();
                return;
            }

            if (dialogProcessor.IsDragging) {
				if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
				dialogProcessor.Translate(e.Location);
				viewPort.Invalidate();
			}
		}



        /// <summary>
        /// Прихващане на отпускането на бутона на мишката.
        /// Излизаме от режим "влачене".
        /// </summary>
        void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.IsDragging = false;
            dialogProcessor.IsResizing = false;
            dialogProcessor.ActiveHandle = ResizeHandle.None;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
        private void viewPort_Load(object sender, EventArgs e)
        {

        }
        private void sheerXTextBox_Click(object sender, EventArgs e)
        {

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
        private void speedMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
        private void pickUpSpeedButton_Click(object sender, EventArgs e)
        {

        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

    }
}
