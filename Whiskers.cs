using SharpGL;

namespace lr4graphics
{
	class Whiskers
	{
		public void Draw(OpenGL gl,int whiskerIndex)
		{
			switch(whiskerIndex)
			{
				case 0:
					DrawFirst(gl);
					break;
				case 1:
					DrawSecond(gl);
					break;
				case 2:
					DrawThird(gl);
					break;
				case 3:
					DrawFourth(gl);
					break;
				case 4:
					DrawFifth(gl);
					break;
				case 5:
					DrawSixth(gl);
					break;
			}
		}

		private void DrawFirst(OpenGL gl)
		{
			gl.LoadIdentity();

			gl.Translate(0.0f, 0f, -5.0f);
			gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
			gl.Translate(0.0f, 0f, 5.0f);

			gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);

			gl.Translate(0f, 0.5f, -4.35f);
			gl.Rotate(90, 0f, -1f, 0f);
			gl.Rotate(10, -1f, 0f, 0f);
			gl.Begin(OpenGL.GL_QUADS);

			gl.Color(0f,0f,0f);
			var quadric = gl.NewQuadric();
			gl.Cylinder(quadric, 0.015, 0.015, 1, 50, 50);

			gl.End();
		}

		private void DrawSecond(OpenGL gl)
		{
			gl.LoadIdentity();

			gl.Translate(0.0f, 0f, -5.0f);
			gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
			gl.Translate(0.0f, 0f, 5.0f);

			gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);

			gl.Translate(0f, 0.47f, -4.35f);
			gl.Rotate(90, 0f, -1f, 0f);
			gl.Begin(OpenGL.GL_QUADS);

			gl.Color(0f, 0f, 0f);
			var quadric = gl.NewQuadric();
			gl.Cylinder(quadric, 0.015, 0.015, 1, 50, 50);

			gl.End();
		}

		private void DrawThird(OpenGL gl)
		{
			gl.LoadIdentity();

			gl.Translate(0.0f, 0f, -5.0f);
			gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
			gl.Translate(0.0f, 0f, 5.0f);

			gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);

			gl.Translate(0f, 0.45f, -4.35f);
			gl.Rotate(90, 0f, -1f, 0f);
			gl.Rotate(-10, -1f, 0f, 0f);
			gl.Begin(OpenGL.GL_QUADS);

			gl.Color(0f, 0f, 0f);
			var quadric = gl.NewQuadric();
			gl.Cylinder(quadric, 0.015, 0.015, 1, 50, 50);

			gl.End();
		}

		private void DrawFourth(OpenGL gl)
		{
			gl.LoadIdentity();

			gl.Translate(0.0f, 0f, -5.0f);
			gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
			gl.Translate(0.0f, 0f, 5.0f);

			gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);

			gl.Scale(-1f, 1f, 1f);
			gl.Translate(0f, 0.5f, -4.35f);
			gl.Rotate(90, 0f, -1f, 0f);
			gl.Rotate(10, -1f, 0f, 0f);
			gl.Begin(OpenGL.GL_QUADS);

			gl.Color(0f, 0f, 0f);
			var quadric = gl.NewQuadric();
			gl.Cylinder(quadric, 0.015, 0.015, 1, 50, 50);

			gl.End();
		}

		private void DrawFifth(OpenGL gl)
		{
			gl.LoadIdentity();

			gl.Translate(0.0f, 0f, -5.0f);
			gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
			gl.Translate(0.0f, 0f, 5.0f);

			gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);

			gl.Scale(-1f, 1f, 1f);
			gl.Translate(0f, 0.47f, -4.35f);
			gl.Rotate(90, 0f, -1f, 0f);
			gl.Begin(OpenGL.GL_QUADS);

			gl.Color(0f, 0f, 0f);
			var quadric = gl.NewQuadric();
			gl.Cylinder(quadric, 0.015, 0.015, 1, 50, 50);

			gl.End();
		}

		private void DrawSixth(OpenGL gl)
		{
			gl.LoadIdentity();

			gl.Translate(0.0f, 0f, -5.0f);
			gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
			gl.Translate(0.0f, 0f, 5.0f);

			gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);

			gl.Scale(-1f, 1f, 1f);
			gl.Translate(0f, 0.45f, -4.35f);
			gl.Rotate(90, 0f, -1f, 0f);
			gl.Rotate(-10, -1f, 0f, 0f);
			gl.Begin(OpenGL.GL_QUADS);

			gl.Color(0f, 0f, 0f);
			var quadric = gl.NewQuadric();
			gl.Cylinder(quadric, 0.015, 0.015, 1, 50, 50);

			gl.End();
		}
	}
}
