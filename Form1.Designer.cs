namespace lr4graphics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.AutoRotateXButton = new System.Windows.Forms.Button();
            this.AutoRotateYButton = new System.Windows.Forms.Button();
            this.AutoRotateZButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AutoScaleXButton = new System.Windows.Forms.Button();
            this.AutoScaleYButton = new System.Windows.Forms.Button();
            this.AutoScaleZButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.RotateXUpDown = new System.Windows.Forms.NumericUpDown();
            this.RotateYUpDown = new System.Windows.Forms.NumericUpDown();
            this.RotateZUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ScaleZUpDown = new System.Windows.Forms.NumericUpDown();
            this.ScaleYUpDown = new System.Windows.Forms.NumericUpDown();
            this.ScaleXUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateZUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleZUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleXUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl1
            // 
            this.openGLControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.openGLControl1.DrawFPS = true;
            this.openGLControl1.FrameRate = 1000;
            this.openGLControl1.Location = new System.Drawing.Point(12, 4);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(656, 442);
            this.openGLControl1.TabIndex = 0;
            this.openGLControl1.OpenGLInitialized += new System.EventHandler(this.openGLControl1_OpenGLInitialized);
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw_1);
            // 
            // AutoRotateXButton
            // 
            this.AutoRotateXButton.Location = new System.Drawing.Point(668, 331);
            this.AutoRotateXButton.Name = "AutoRotateXButton";
            this.AutoRotateXButton.Size = new System.Drawing.Size(85, 23);
            this.AutoRotateXButton.TabIndex = 1;
            this.AutoRotateXButton.Text = "Start rotate X";
            this.AutoRotateXButton.UseVisualStyleBackColor = true;
            this.AutoRotateXButton.Click += new System.EventHandler(this.AutoRotateXButton_Click);
            // 
            // AutoRotateYButton
            // 
            this.AutoRotateYButton.Location = new System.Drawing.Point(668, 370);
            this.AutoRotateYButton.Name = "AutoRotateYButton";
            this.AutoRotateYButton.Size = new System.Drawing.Size(85, 23);
            this.AutoRotateYButton.TabIndex = 2;
            this.AutoRotateYButton.Text = "Start rotate Y";
            this.AutoRotateYButton.UseVisualStyleBackColor = true;
            this.AutoRotateYButton.Click += new System.EventHandler(this.AutoRotateYButton_Click);
            // 
            // AutoRotateZButton
            // 
            this.AutoRotateZButton.Location = new System.Drawing.Point(668, 408);
            this.AutoRotateZButton.Name = "AutoRotateZButton";
            this.AutoRotateZButton.Size = new System.Drawing.Size(85, 23);
            this.AutoRotateZButton.TabIndex = 3;
            this.AutoRotateZButton.Text = "Start rotate Z";
            this.AutoRotateZButton.UseVisualStyleBackColor = true;
            this.AutoRotateZButton.Click += new System.EventHandler(this.AutoRotateZButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Auto transforms";
            // 
            // AutoScaleXButton
            // 
            this.AutoScaleXButton.Location = new System.Drawing.Point(779, 331);
            this.AutoScaleXButton.Name = "AutoScaleXButton";
            this.AutoScaleXButton.Size = new System.Drawing.Size(75, 23);
            this.AutoScaleXButton.TabIndex = 5;
            this.AutoScaleXButton.Text = "Start scale X";
            this.AutoScaleXButton.UseVisualStyleBackColor = true;
            this.AutoScaleXButton.Click += new System.EventHandler(this.AutoScaleXButton_Click);
            // 
            // AutoScaleYButton
            // 
            this.AutoScaleYButton.Location = new System.Drawing.Point(779, 370);
            this.AutoScaleYButton.Name = "AutoScaleYButton";
            this.AutoScaleYButton.Size = new System.Drawing.Size(75, 23);
            this.AutoScaleYButton.TabIndex = 6;
            this.AutoScaleYButton.Text = "Start scale Y";
            this.AutoScaleYButton.UseVisualStyleBackColor = true;
            this.AutoScaleYButton.Click += new System.EventHandler(this.AutoScaleYButton_Click);
            // 
            // AutoScaleZButton
            // 
            this.AutoScaleZButton.Location = new System.Drawing.Point(779, 408);
            this.AutoScaleZButton.Name = "AutoScaleZButton";
            this.AutoScaleZButton.Size = new System.Drawing.Size(75, 23);
            this.AutoScaleZButton.TabIndex = 7;
            this.AutoScaleZButton.Text = "Start scale Z";
            this.AutoScaleZButton.UseVisualStyleBackColor = true;
            this.AutoScaleZButton.Click += new System.EventHandler(this.AutoScaleZButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(723, 289);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // RotateXUpDown
            // 
            this.RotateXUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RotateXUpDown.Location = new System.Drawing.Point(798, 26);
            this.RotateXUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.RotateXUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.RotateXUpDown.Name = "RotateXUpDown";
            this.RotateXUpDown.Size = new System.Drawing.Size(56, 20);
            this.RotateXUpDown.TabIndex = 9;
            this.RotateXUpDown.ValueChanged += new System.EventHandler(this.RotateXUpDown_ValueChanged);
            // 
            // RotateYUpDown
            // 
            this.RotateYUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RotateYUpDown.Location = new System.Drawing.Point(798, 61);
            this.RotateYUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.RotateYUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.RotateYUpDown.Name = "RotateYUpDown";
            this.RotateYUpDown.Size = new System.Drawing.Size(56, 20);
            this.RotateYUpDown.TabIndex = 10;
            this.RotateYUpDown.ValueChanged += new System.EventHandler(this.RotateYUpDown_ValueChanged);
            // 
            // RotateZUpDown
            // 
            this.RotateZUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RotateZUpDown.Location = new System.Drawing.Point(798, 90);
            this.RotateZUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.RotateZUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.RotateZUpDown.Name = "RotateZUpDown";
            this.RotateZUpDown.Size = new System.Drawing.Size(56, 20);
            this.RotateZUpDown.TabIndex = 11;
            this.RotateZUpDown.ValueChanged += new System.EventHandler(this.RotateZUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rotation angle X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(693, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rotation angle Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(693, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rotation angle Z";
            // 
            // ScaleZUpDown
            // 
            this.ScaleZUpDown.DecimalPlaces = 2;
            this.ScaleZUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ScaleZUpDown.Location = new System.Drawing.Point(798, 204);
            this.ScaleZUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ScaleZUpDown.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            131072});
            this.ScaleZUpDown.Name = "ScaleZUpDown";
            this.ScaleZUpDown.Size = new System.Drawing.Size(56, 20);
            this.ScaleZUpDown.TabIndex = 15;
            this.ScaleZUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScaleZUpDown.ValueChanged += new System.EventHandler(this.ScaleZUpDown_ValueChanged);
            // 
            // ScaleYUpDown
            // 
            this.ScaleYUpDown.DecimalPlaces = 2;
            this.ScaleYUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ScaleYUpDown.Location = new System.Drawing.Point(798, 176);
            this.ScaleYUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            65536});
            this.ScaleYUpDown.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            131072});
            this.ScaleYUpDown.Name = "ScaleYUpDown";
            this.ScaleYUpDown.Size = new System.Drawing.Size(56, 20);
            this.ScaleYUpDown.TabIndex = 16;
            this.ScaleYUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScaleYUpDown.ValueChanged += new System.EventHandler(this.ScaleYUpDown_ValueChanged);
            // 
            // ScaleXUpDown
            // 
            this.ScaleXUpDown.DecimalPlaces = 2;
            this.ScaleXUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ScaleXUpDown.Location = new System.Drawing.Point(798, 145);
            this.ScaleXUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            65536});
            this.ScaleXUpDown.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            131072});
            this.ScaleXUpDown.Name = "ScaleXUpDown";
            this.ScaleXUpDown.Size = new System.Drawing.Size(56, 20);
            this.ScaleXUpDown.TabIndex = 17;
            this.ScaleXUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScaleXUpDown.ValueChanged += new System.EventHandler(this.ScaleXUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Scaling value Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Scaling value Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(693, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Scaling value X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 458);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ScaleXUpDown);
            this.Controls.Add(this.ScaleYUpDown);
            this.Controls.Add(this.ScaleZUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RotateZUpDown);
            this.Controls.Add(this.RotateYUpDown);
            this.Controls.Add(this.RotateXUpDown);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.AutoScaleZButton);
            this.Controls.Add(this.AutoScaleYButton);
            this.Controls.Add(this.AutoScaleXButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutoRotateZButton);
            this.Controls.Add(this.AutoRotateYButton);
            this.Controls.Add(this.AutoRotateXButton);
            this.Controls.Add(this.openGLControl1);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotateZUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleZUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleXUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.Button AutoRotateXButton;
        private System.Windows.Forms.Button AutoRotateYButton;
        private System.Windows.Forms.Button AutoRotateZButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AutoScaleXButton;
        private System.Windows.Forms.Button AutoScaleYButton;
        private System.Windows.Forms.Button AutoScaleZButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.NumericUpDown RotateXUpDown;
        private System.Windows.Forms.NumericUpDown RotateYUpDown;
        private System.Windows.Forms.NumericUpDown RotateZUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ScaleZUpDown;
        private System.Windows.Forms.NumericUpDown ScaleYUpDown;
        private System.Windows.Forms.NumericUpDown ScaleXUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

