using SharpGL;
namespace lr4graphics
{
	class Ear
	{
        bool IsLeft = false;
		public Ear(bool IsLeft)
		{
            this.IsLeft = IsLeft;
		}
		public void Draw(OpenGL gl)
		{
            if(IsLeft)
            DrawLeftEar(gl);
            else
            DrawRightEar(gl);
        }

        private void DrawLeftEar(OpenGL gl)
        {
            gl.LoadIdentity();

            gl.Translate(0f, 0f, -5f);
            gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
            gl.Translate(0, 0f, 5);

            gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);
            gl.Rotate(30, 0f, 0f, 1f);
            gl.Translate(0f, 1f, -4.7f);
            gl.Scale(0.5, 0.5, 0.5);
            gl.Begin(OpenGL.GL_TRIANGLE_STRIP);

            gl.Color(1, 1, 1);
            gl.Vertex(0.0f, 0f, 0f);

            gl.Color(1f, 0.64f, 0f);
            gl.Vertex(0.5f, 0f, -0.5f);

            gl.Color(1, 1, 1);
            gl.Vertex(0.5f, 1.0f, 0.0f);
  
            gl.Vertex(1f, 0.0f, 0f);

            gl.End();
        }

        private void DrawRightEar(OpenGL gl)
        {
            gl.LoadIdentity();

            gl.Translate(0f, 0f, -5f);
            gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
            gl.Translate(0, 0f, 5);
            gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);
            gl.Rotate(-30, 0f, 0f, 1f);
            gl.Translate(-0.5f, 1f, -4.7f);
            gl.Scale(0.5, 0.5, 0.5);
            gl.Begin(OpenGL.GL_TRIANGLE_STRIP);

            gl.Color(1, 1, 1);
            gl.Vertex(0.0f, 0f, 0f);

            gl.Color(1f, 0.64f, 0f);
            gl.Vertex(0.5f, 0f, -0.5f);

            gl.Color(1, 1, 1);
            gl.Vertex(0.5f, 1.0f, 0.0f);

            gl.Vertex(1f, 0.0f, 0f);

            gl.End();
        }

    }
}
