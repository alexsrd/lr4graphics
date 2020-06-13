using SharpGL;

namespace lr4graphics
{
	class Head
	{
		public Ear leftEar { get; set; }
        public Ear rightEar { get; set; }
        public Eye leftEye { get; set; }
        public Eye rightEye { get; set; }
        public Nose Nose { get; set; }
        public Whiskers Whiskers { get; set; }
        public Head()
        {
			leftEar = new Ear(true);
            rightEar = new Ear(false);
            leftEye = new Eye(true);
            rightEye = new Eye(false);
            Nose = new Nose();
            Whiskers = new Whiskers();
        }
		public void Draw(OpenGL gl)
		{
            Nose.Draw(gl);
            leftEar.Draw(gl);
            rightEar.Draw(gl);
            leftEye.Draw(gl);
            rightEye.Draw(gl);
            for (int i = 0; i < 6; i++) Whiskers.Draw(gl,i);

            gl.LoadIdentity();

            gl.Translate(0f, 0f, -5f);
            gl.Rotate(TransformInfo.AngleX, TransformInfo.AngleY, TransformInfo.AngleZ);
            gl.Translate(0, 0f, 5);
            gl.Scale(TransformInfo.ScaleX, TransformInfo.ScaleY, TransformInfo.ScaleZ);
            gl.Translate(0f, 0.6f, -5.0f);
            gl.Rotate(90,1f, 0f, 0f);

            gl.Begin(OpenGL.GL_QUADS);
            var quadric = gl.NewQuadric();
            gl.Color(1f, 0.64f, 0f);
            gl.Sphere(quadric, 0.7, 100, 100);
            gl.End();

        }
    }
}
