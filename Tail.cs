using SharpGL;

namespace lr4graphics
{
    class Tail
    {
		public void Draw(OpenGL gl)
        {
			gl.LoadIdentity();

			gl.Translate(0.0f, 0f, -5.0f);
			gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
			gl.Translate(0.0f, 0f, 5.0f);
			gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);
			gl.Translate(-0.7f, -1.45f, -5.0f);
			gl.Rotate(90, 0f, -1f, 0f);
			gl.Begin(OpenGL.GL_QUADS);

			gl.Color(1f, 0.64f, 0f);
			var quadric = gl.NewQuadric();
			gl.Cylinder(quadric, 0.05, 0.05, 1, 50, 50);

			gl.End();
		}
    }
}
