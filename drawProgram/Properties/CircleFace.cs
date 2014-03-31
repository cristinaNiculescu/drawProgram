using System;
using Cairo;

namespace drawProgram
{
	public class CircleFace
	{ 
		public int radius;
		public int x;
		public int y; 
		public CircleFace (int radius, int x, int y)
		{ this.radius = radius;
			this.x = x;
			this.y = y;
		}

		public void draw (Context circleCanvas)
		{
			circleCanvas.Arc(x,y,radius, 0, 360);
			circleCanvas.SetSourceRGB(0,1,0.5);
			circleCanvas.Fill();
			circleCanvas.Stroke();
		}
	}
}

