using SharpGL;

namespace lr4graphics
{
    class Nose
    {

        public void Draw(OpenGL gl)
        {
            gl.LoadIdentity();

            gl.Translate(0f, 0f, -5f);
            gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
            gl.Translate(0, 0f, 5);

            gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);

            gl.Translate(0f, 0.5f, -4.35f);

            gl.Rotate(180, 0, 1, 0);

            gl.Begin(OpenGL.GL_QUADS);
            var quadric = gl.NewQuadric();
            gl.Color(1f, 0.07f, 0.57f);
            gl.Sphere(quadric, 0.1, 10, 10);
            gl.End();

        }
    }
}
