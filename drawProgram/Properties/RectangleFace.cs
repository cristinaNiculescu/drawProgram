using System;
using Cairo;

namespace drawProgram
{
	public class RectangleFace
	{
		public int height;
		public int x;
		public int y;
		public int width;

		public RectangleFace (int x, int y, int height, int width)
		{ this.x = x;
			this.y = y;
			this.height = height;
			this.width = width;
		}

		public void draw(Context rectContext)
		{ 
			rectContext.MoveTo (x, y);
			rectContext.LineTo (x, y + height);
			rectContext.LineTo (x + width, y + height);
			rectContext.LineTo (x + width, y);
			rectContext.ClosePath ();
			rectContext.Fill ();
			rectContext.Stroke ();

		}

	}
}

