using SharpGL;
using System;
using System.Windows.Forms;

namespace lr4graphics
{
    public partial class Form1 : Form
	{
		bool IsDecreaseX = false,
			IsDecreaseY = false,
			IsDecreaseZ = false;

		static bool AutoRotateX = false,
			AutoRotateY = false,
			AutoRotateZ = false;

		static bool AutoScaleX = false,
			AutoScaleY = false,
			AutoScaleZ = false;

		Head head;
		Body body;
		public Form1()
		{
			InitializeComponent();
			head = new Head();
			body = new Body();

			TransformInfo.ScaleX = 1f;
			TransformInfo.ScaleY = 1f;
			TransformInfo.ScaleZ = 1f;
		}

		private void AutoRotateXButton_Click(object sender, EventArgs e)
		{
			if (AutoRotateX)
			{
				AutoRotateX = false;
				AutoRotateXButton.Text = "Start rotate X";
			}
			else
			{
				AutoRotateX = true;
				AutoRotateXButton.Text = "Stop rotate X";
			}
		}

		private void AutoRotateYButton_Click(object sender, EventArgs e)
		{
			if (AutoRotateY)
			{
				AutoRotateY = false;
				AutoRotateYButton.Text = "Start rotate Y";
			}
			else
			{
				AutoRotateY = true;
				AutoRotateYButton.Text = "Stop rotate Y";
			}
		}

		private void AutoRotateZButton_Click(object sender, EventArgs e)
		{
			if (AutoRotateZ)
			{
				AutoRotateZ = false;
				AutoRotateZButton.Text = "Start rotate Z";
			}
			else
			{
				AutoRotateZ = true;
				AutoRotateZButton.Text = "Stop rotate Z";
			}
		}

		private void ResetButton_Click(object sender, EventArgs e)
		{
			ScaleXUpDown.Value = ScaleYUpDown.Value = ScaleZUpDown.Value = 1;
			TransformInfo.ScaleX = TransformInfo.ScaleY = TransformInfo.ScaleZ = 1f;

			RotateXUpDown.Value = RotateYUpDown.Value = RotateZUpDown.Value =
			TransformInfo.AngleX = TransformInfo.AngleY = TransformInfo.AngleZ = 0;

		}

		private void RotateXUpDown_ValueChanged(object sender, EventArgs e)
		{
			if (RotateXUpDown.Value == 360) RotateXUpDown.Value = 0;
			else if (RotateXUpDown.Value == -2) RotateXUpDown.Value = 359;
			TransformInfo.AngleX = (int)RotateXUpDown.Value;
		}

		private void RotateYUpDown_ValueChanged(object sender, EventArgs e)
		{
			if (RotateYUpDown.Value == 360) RotateYUpDown.Value = 0;
			else if (RotateYUpDown.Value == -2) RotateYUpDown.Value = 359;
			TransformInfo.AngleY = (int)RotateYUpDown.Value;
		}

		private void RotateZUpDown_ValueChanged(object sender, EventArgs e)
		{
			if (RotateZUpDown.Value == 360) RotateZUpDown.Value = 0;
			else if (RotateZUpDown.Value == -2) RotateZUpDown.Value = 359;
			TransformInfo.AngleZ = (int)RotateZUpDown.Value;
		}

		private void ScaleXUpDown_ValueChanged(object sender, EventArgs e)
		{
			TransformInfo.ScaleX = (float)ScaleXUpDown.Value;
		}

		private void ScaleYUpDown_ValueChanged(object sender, EventArgs e)
		{
			TransformInfo.ScaleY = (float)ScaleYUpDown.Value;
		}

		private void ScaleZUpDown_ValueChanged(object sender, EventArgs e)
		{
			TransformInfo.ScaleZ = (float)ScaleZUpDown.Value;
		}

		private void AutoScaleXButton_Click(object sender, EventArgs e)
		{
			if (AutoScaleX)
			{
				AutoScaleX = false;
				AutoScaleXButton.Text = "Start scale X";
			}
			else
			{
				AutoScaleX = true;
				AutoScaleXButton.Text = "Stop scale X";
			}
		}

		private void AutoScaleYButton_Click(object sender, EventArgs e)
		{
			if (AutoScaleY)
			{
				AutoScaleY = false;
				AutoScaleYButton.Text = "Start scale Y";
			}
			else
			{
				AutoScaleY = true;
				AutoScaleYButton.Text = "Stop scale Y";
			}
		}

		private void AutoScaleZButton_Click(object sender, EventArgs e)
		{
			if (AutoScaleZ)
			{
				AutoScaleZ = false;
				AutoScaleZButton.Text = "Start scale Z";
			}
			else
			{
				AutoScaleZ = true;
				AutoScaleZButton.Text = "Stop scale Z";
			}
		}

		private void openGLControl1_OpenGLDraw_1(object sender, RenderEventArgs args)
		{
			OpenGL gl = openGLControl1.OpenGL;
			gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
			head.Draw(gl);
			body.Draw(gl);

			if (AutoRotateX)
			{
				TransformInfo.AngleX += 2;
				RotateXUpDown.Value = TransformInfo.AngleX;
				RotateXUpDown_ValueChanged(this, null);
			}
			if (AutoRotateY)
			{
				TransformInfo.AngleY += 2;
				RotateYUpDown.Value = TransformInfo.AngleY;
			}
			if (AutoRotateZ)
			{
				TransformInfo.AngleZ += 2;
				RotateZUpDown.Value = TransformInfo.AngleZ;
			}


			if (TransformInfo.ScaleX >= 3.0f) IsDecreaseX = true;
			else if (TransformInfo.ScaleX <= 0.1f) IsDecreaseX = false;
			if (AutoScaleX)
			{
				if (IsDecreaseX)
				{
					TransformInfo.ScaleX -= 0.05f;
					ScaleXUpDown.Value = (decimal)TransformInfo.ScaleX;
				}
				else
				{
					TransformInfo.ScaleX += 0.05f;
					ScaleXUpDown.Value = (decimal)TransformInfo.ScaleX;
				}
			}

			if (TransformInfo.ScaleY >= 3.0f) IsDecreaseY = true;
			else if (TransformInfo.ScaleY <= 0.1f) IsDecreaseY = false;
			if (AutoScaleY)
			{
				if (IsDecreaseY)
				{
					TransformInfo.ScaleY -= 0.05f;
					ScaleYUpDown.Value = (decimal)TransformInfo.ScaleY;
				}
				else
				{
					TransformInfo.ScaleY += 0.05f;
					ScaleYUpDown.Value = (decimal)TransformInfo.ScaleY;
				}
			}

			if (TransformInfo.ScaleZ >= 3.0f) IsDecreaseZ = true;
			else if (TransformInfo.ScaleZ <= 0.1f) IsDecreaseZ = false;
			if (AutoScaleZ)
			{
				if (IsDecreaseZ)
				{
					TransformInfo.ScaleZ -= 0.05f;
					ScaleZUpDown.Value = (decimal)TransformInfo.ScaleZ;
				}
				else
				{
					TransformInfo.ScaleZ += 0.05f;
					ScaleZUpDown.Value = (decimal)TransformInfo.ScaleZ;
				}
			}
		}

		private void openGLControl1_OpenGLInitialized(object sender, EventArgs e)
		{
			var gl = openGLControl1.OpenGL;
			gl.Enable(OpenGL.GL_DEPTH_TEST);
			gl.ClearColor(1f, 1f, 1f, 1f);
			float[] global_ambient = new float[] { 0.3f, 0.3f, 0.3f, 1f };
			float[] position = { -10.0f, 0.0f, 1.0f, 1.0f };
			float[] light0ambient = new float[] { 0.2f, 0.2f, 0.2f, 1f };
			float[] light0diffuse = new float[] { 0.3f, 0.3f, 0.3f, 1f };
			float[] light0specular = new float[] { 0.8f, 0.8f, 0.8f, 1f };


			gl.LightModel(OpenGL.GL_LIGHT_MODEL_AMBIENT, global_ambient);
			gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_POSITION, position);
			gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_AMBIENT, light0ambient);
			gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_DIFFUSE, light0diffuse);
			gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_SPECULAR, light0specular);
			gl.Enable(OpenGL.GL_LIGHTING);
			gl.Enable(OpenGL.GL_LIGHT0);
			gl.Enable(OpenGL.GL_COLOR_MATERIAL);
			gl.ShadeModel(OpenGL.GL_SMOOTH);
		}
	}
}
