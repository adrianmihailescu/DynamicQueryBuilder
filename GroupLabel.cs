using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimpleDemo
{
	internal partial class GroupLabel : Label
	{
		public GroupLabel()
		{
			this.AutoSize = false;
			this.TextAlign = ContentAlignment.MiddleLeft;
			this.ForeColor = Color.CornflowerBlue;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			Size textSize = TextRenderer.MeasureText(this.Text, this.Font);

			Point p1 = new Point(this.ClientRectangle.Left + this.Padding.Left + textSize.Width + 5, this.ClientRectangle.Height / 2 + 1);
			Point p2 = new Point(this.ClientRectangle.Right - 2, this.ClientRectangle.Height / 2 + 1);

			e.Graphics.DrawLine(SystemPens.ControlDark, p1, p2);
			
		}
	}
}
