using SharpGL;
namespace lr4graphics
{
    class Pupil
    {
        bool IsLeft = false;
        public Pupil(bool IsLeft)
        {
            this.IsLeft = IsLeft;
        }

        public void Draw(OpenGL gl)
        {
            DrawLeftPupil(gl);
            DrawRightPupil(gl);
        }

        private void DrawLeftPupil(OpenGL gl)
        {
            gl.LoadIdentity();

            gl.Translate(0f, 0f, -5f);
            gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
            gl.Translate(0, 0f, 5);
            gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);
            gl.Translate(-0.25f, 0.7f, -4.319f);
            gl.Rotate(180, 0, 1, 0);

            gl.Begin(OpenGL.GL_QUADS);
            var quadric = gl.NewQuadric();
            gl.Color(0f, 0f, 0f);
            
            gl.Sphere(quadric, 0.05, 10, 10);
            gl.End();
        }

        private void DrawRightPupil(OpenGL gl)
        {
            gl.LoadIdentity();

            gl.Translate(0f, 0f, -5f);
            gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
            gl.Translate(0, 0f, 5);
            gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);
            gl.Translate(0.25f, 0.7f, -4.319f);
            gl.Rotate(180, 0, 1, 0);

            gl.Begin(OpenGL.GL_QUADS);
            var quadric = gl.NewQuadric();
            gl.Color(0f, 0f, 0f);
            gl.Sphere(quadric, 0.05, 10, 10);
            gl.End();
        }
    }
}
