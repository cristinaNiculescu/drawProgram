using System;
using Gtk;
using Cairo; 

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected void onExit (object sender, EventArgs e)
	{
		Application.Quit();
	}



	protected void faceClicked (object sender, EventArgs e)
	{using (Cairo.Context canvas = Gdk.CairoHelper.Create (drawingarea1.GdkWindow))
		{
			drawProgram.RectangleFace nose =  new drawProgram.RectangleFace (175,175,50,50);
			nose.draw (canvas);
			drawProgram.CircleFace leftEye = new drawProgram.CircleFace(40,150,50);
			leftEye.draw(canvas);
			drawProgram.CircleFace rightEye = new drawProgram.CircleFace(40,275,50);
			rightEye.draw(canvas);
		}

	}


	protected void circleClicked (object sender, EventArgs e)
	{
		using (Cairo.Context canvas = Gdk.CairoHelper.Create (drawingarea1.GdkWindow))
		{
			//	canvas.MoveTo(200,200);
			canvas.Arc(175,100, 50, 0, 360);
			canvas.SetSourceRGB(0,1,0.5);
			canvas.Fill();
			canvas.Stroke();
		}
	}

	protected void lineClicked (object sender, EventArgs e)
	{
		using (Cairo.Context  graphic = Gdk.CairoHelper.Create (drawingarea1.GdkWindow))
		{
			graphic.MoveTo(100,100);
			graphic.LineTo(150,150);
			//graphic.LineTo(125,155);
			//graphic.ClosePath();
			graphic.LineWidth=5;
			graphic.SetSourceRGB(1,0.2,0);
			graphic.Stroke();
		}
	}

}