using SharpGL;
namespace lr4graphics
{
    class Body
    {
        public Tail Tail { get; set; }
        public Foot leftFoot { get; set; }
        public Foot rightFoot { get; set; }
        public Body()
        {
            Tail = new Tail();
            leftFoot = new Foot(true);
            rightFoot = new Foot(false);
        }
        public void Draw(OpenGL gl)
        {
            Tail.Draw(gl);
            leftFoot.Draw(gl);
            rightFoot.Draw(gl);
            gl.LoadIdentity();

            gl.Translate(0.0f, 0f, -5.0f);
            gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
            gl.Translate(0.0f, 0f, 5.0f);
            gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);

            gl.Translate(0.0f, -1.5f, -5.0f);
            gl.Rotate(90, -1f, 0f, 0f);
            gl.Begin(OpenGL.GL_QUADS);

            gl.Color(1f, 0f, 0f);
            var quadric = gl.NewQuadric();
            gl.Cylinder(quadric, 0.9, 0.4, 1.7, 100, 150);

            gl.End();

        }
    }
}
