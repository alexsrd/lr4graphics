using SharpGL;
namespace lr4graphics
{
    class Foot
    {
        bool IsLeft = false;
        public Foot(bool IsLeft)
        {
            this.IsLeft = IsLeft;
        }

        public void Draw(OpenGL gl)
        {
            if (IsLeft)
                DrawLeftFoot(gl);
            else
                DrawRightFoot(gl);
        }

        private void DrawLeftFoot(OpenGL gl)
        {
            gl.LoadIdentity();

            gl.Translate(0f, 0f, -5f);
            gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
            gl.Translate(0, 0f, 5);
            gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);
            gl.Translate(-0.2f, -0.9f, -4.25f);
            gl.Rotate(-10, 180, 0);
            gl.Scale(1f, 2.5f, 1f);
            gl.Begin(OpenGL.GL_QUADS);
            var quadric = gl.NewQuadric();
            gl.Color(1f, 0.64f, 0f);
            gl.Sphere(quadric, 0.2, 100, 100);
            gl.End();
        }

        private void DrawRightFoot(OpenGL gl)
        {
            gl.LoadIdentity();

            gl.Translate(0f, 0f, -5f);
            gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
            gl.Translate(0, 0f, 5);
            gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);
            gl.Translate(0.2f, -0.9f, -4.25f);
            gl.Rotate(-10, 180, 0);
            gl.Scale(1f, 2.5f, 1f);
            gl.Begin(OpenGL.GL_QUADS);
            var quadric = gl.NewQuadric();
            gl.Color(1f, 0.64f, 0f);
            gl.Sphere(quadric, 0.2, 100, 100);
            gl.End();
        }
    }
}
