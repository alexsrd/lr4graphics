using SharpGL;
namespace lr4graphics
{
    class Eye
    {
        Pupil leftPupil { get; set; }
        Pupil rightPupil { get; set; }
        bool IsLeft { get; set; }
        public Eye(bool IsLeft)
        {
            this.IsLeft = IsLeft;
            leftPupil = new Pupil(true);
            rightPupil = new Pupil(false);
        }

        public void Draw(OpenGL gl)
        {
            if (IsLeft)
            {
                DrawLeftEye(gl);
                leftPupil.Draw(gl);
                rightPupil.Draw(gl);
            }
                
            else
                DrawRightEye(gl);
        }

        private void DrawLeftEye(OpenGL gl)
        {
            gl.LoadIdentity();

            gl.Translate(0f, 0f, -5f);
            gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
            gl.Translate(0, 0f, 5);

            gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);

            gl.Scale(1.25f, 1f, 1f);
            gl.Translate(-0.2f, 0.7f, -4.4f);

            gl.Begin(OpenGL.GL_QUADS);
            var quadric = gl.NewQuadric();
            gl.Color(0f, 0.5f, 0f);
            gl.Sphere(quadric, 0.1, 10, 10);
            gl.End();
        }

        private void DrawRightEye(OpenGL gl)
        {
            gl.LoadIdentity();

            gl.Translate(0f, 0f, -5f);
            gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
            gl.Translate(0, 0f, 5);
            gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);
            gl.Scale(1.25f, 1f, 1f);
            gl.Translate(0.2f, 0.7f, -4.4f);

            gl.Begin(OpenGL.GL_QUADS);
            var quadric = gl.NewQuadric();
            gl.Color(0f, 0.5f, 0f);
            gl.Sphere(quadric, 0.1, 10, 10);
            gl.End();
        }
    }
}
