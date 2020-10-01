namespace geometry_formulas_calculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rdoRectangle = new System.Windows.Forms.RadioButton();
            this.rdoSquare = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoHexagon = new System.Windows.Forms.RadioButton();
            this.rdoPentagon = new System.Windows.Forms.RadioButton();
            this.rdoCircle = new System.Windows.Forms.RadioButton();
            this.rdoTrapezoid = new System.Windows.Forms.RadioButton();
            this.rdoTriangle = new System.Windows.Forms.RadioButton();
            this.rdoRhombus = new System.Windows.Forms.RadioButton();
            this.rdoParallelogram = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoAreaPerimeter = new System.Windows.Forms.RadioButton();
            this.rdoPerimeter = new System.Windows.Forms.RadioButton();
            this.rdoArea = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoRectangle
            // 
            this.rdoRectangle.AutoSize = true;
            this.rdoRectangle.Location = new System.Drawing.Point(12, 19);
            this.rdoRectangle.Name = "rdoRectangle";
            this.rdoRectangle.Size = new System.Drawing.Size(74, 17);
            this.rdoRectangle.TabIndex = 0;
            this.rdoRectangle.TabStop = true;
            this.rdoRectangle.Text = "Rectangle";
            this.rdoRectangle.UseVisualStyleBackColor = true;
            // 
            // rdoSquare
            // 
            this.rdoSquare.AutoSize = true;
            this.rdoSquare.Location = new System.Drawing.Point(12, 42);
            this.rdoSquare.Name = "rdoSquare";
            this.rdoSquare.Size = new System.Drawing.Size(59, 17);
            this.rdoSquare.TabIndex = 1;
            this.rdoSquare.TabStop = true;
            this.rdoSquare.Text = "Square";
            this.rdoSquare.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoHexagon);
            this.groupBox1.Controls.Add(this.rdoPentagon);
            this.groupBox1.Controls.Add(this.rdoCircle);
            this.groupBox1.Controls.Add(this.rdoTrapezoid);
            this.groupBox1.Controls.Add(this.rdoTriangle);
            this.groupBox1.Controls.Add(this.rdoRhombus);
            this.groupBox1.Controls.Add(this.rdoParallelogram);
            this.groupBox1.Controls.Add(this.rdoRectangle);
            this.groupBox1.Controls.Add(this.rdoSquare);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 236);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Shape";
            // 
            // rdoHexagon
            // 
            this.rdoHexagon.AutoSize = true;
            this.rdoHexagon.Location = new System.Drawing.Point(12, 209);
            this.rdoHexagon.Name = "rdoHexagon";
            this.rdoHexagon.Size = new System.Drawing.Size(68, 17);
            this.rdoHexagon.TabIndex = 8;
            this.rdoHexagon.TabStop = true;
            this.rdoHexagon.Text = "Hexagon";
            this.rdoHexagon.UseVisualStyleBackColor = true;
            // 
            // rdoPentagon
            // 
            this.rdoPentagon.AutoSize = true;
            this.rdoPentagon.Location = new System.Drawing.Point(12, 185);
            this.rdoPentagon.Name = "rdoPentagon";
            this.rdoPentagon.Size = new System.Drawing.Size(71, 17);
            this.rdoPentagon.TabIndex = 7;
            this.rdoPentagon.TabStop = true;
            this.rdoPentagon.Text = "Pentagon";
            this.rdoPentagon.UseVisualStyleBackColor = true;
            // 
            // rdoCircle
            // 
            this.rdoCircle.AutoSize = true;
            this.rdoCircle.Location = new System.Drawing.Point(12, 161);
            this.rdoCircle.Name = "rdoCircle";
            this.rdoCircle.Size = new System.Drawing.Size(51, 17);
            this.rdoCircle.TabIndex = 6;
            this.rdoCircle.TabStop = true;
            this.rdoCircle.Text = "Circle";
            this.rdoCircle.UseVisualStyleBackColor = true;
            // 
            // rdoTrapezoid
            // 
            this.rdoTrapezoid.AutoSize = true;
            this.rdoTrapezoid.Location = new System.Drawing.Point(12, 137);
            this.rdoTrapezoid.Name = "rdoTrapezoid";
            this.rdoTrapezoid.Size = new System.Drawing.Size(72, 17);
            this.rdoTrapezoid.TabIndex = 5;
            this.rdoTrapezoid.TabStop = true;
            this.rdoTrapezoid.Text = "Trapezoid";
            this.rdoTrapezoid.UseVisualStyleBackColor = true;
            // 
            // rdoTriangle
            // 
            this.rdoTriangle.AutoSize = true;
            this.rdoTriangle.Location = new System.Drawing.Point(12, 113);
            this.rdoTriangle.Name = "rdoTriangle";
            this.rdoTriangle.Size = new System.Drawing.Size(63, 17);
            this.rdoTriangle.TabIndex = 4;
            this.rdoTriangle.TabStop = true;
            this.rdoTriangle.Text = "Triangle";
            this.rdoTriangle.UseVisualStyleBackColor = true;
            // 
            // rdoRhombus
            // 
            this.rdoRhombus.AutoSize = true;
            this.rdoRhombus.Location = new System.Drawing.Point(12, 89);
            this.rdoRhombus.Name = "rdoRhombus";
            this.rdoRhombus.Size = new System.Drawing.Size(70, 17);
            this.rdoRhombus.TabIndex = 3;
            this.rdoRhombus.TabStop = true;
            this.rdoRhombus.Text = "Rhombus";
            this.rdoRhombus.UseVisualStyleBackColor = true;
            // 
            // rdoParallelogram
            // 
            this.rdoParallelogram.AutoSize = true;
            this.rdoParallelogram.Location = new System.Drawing.Point(12, 65);
            this.rdoParallelogram.Name = "rdoParallelogram";
            this.rdoParallelogram.Size = new System.Drawing.Size(88, 17);
            this.rdoParallelogram.TabIndex = 2;
            this.rdoParallelogram.TabStop = true;
            this.rdoParallelogram.Text = "Parallelogram";
            this.rdoParallelogram.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoAreaPerimeter);
            this.groupBox2.Controls.Add(this.rdoPerimeter);
            this.groupBox2.Controls.Add(this.rdoArea);
            this.groupBox2.Location = new System.Drawing.Point(133, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 83);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculation";
            // 
            // rdoAreaPerimeter
            // 
            this.rdoAreaPerimeter.AutoSize = true;
            this.rdoAreaPerimeter.Location = new System.Drawing.Point(7, 59);
            this.rdoAreaPerimeter.Name = "rdoAreaPerimeter";
            this.rdoAreaPerimeter.Size = new System.Drawing.Size(103, 17);
            this.rdoAreaPerimeter.TabIndex = 2;
            this.rdoAreaPerimeter.TabStop = true;
            this.rdoAreaPerimeter.Text = "Area && Perimeter";
            this.rdoAreaPerimeter.UseVisualStyleBackColor = true;
            // 
            // rdoPerimeter
            // 
            this.rdoPerimeter.AutoSize = true;
            this.rdoPerimeter.Location = new System.Drawing.Point(7, 36);
            this.rdoPerimeter.Name = "rdoPerimeter";
            this.rdoPerimeter.Size = new System.Drawing.Size(69, 17);
            this.rdoPerimeter.TabIndex = 1;
            this.rdoPerimeter.TabStop = true;
            this.rdoPerimeter.Text = "Perimeter";
            this.rdoPerimeter.UseVisualStyleBackColor = true;
            // 
            // rdoArea
            // 
            this.rdoArea.AutoSize = true;
            this.rdoArea.Location = new System.Drawing.Point(7, 13);
            this.rdoArea.Name = "rdoArea";
            this.rdoArea.Size = new System.Drawing.Size(47, 17);
            this.rdoArea.TabIndex = 0;
            this.rdoArea.TabStop = true;
            this.rdoArea.Text = "Area";
            this.rdoArea.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(133, 125);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(73, 312);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 6;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(73, 347);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 7;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(73, 380);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 8;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 312);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(23, 13);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "lbl1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 350);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(23, 13);
            this.lbl2.TabIndex = 10;
            this.lbl2.Text = "lbl2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(12, 383);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(23, 13);
            this.lbl3.TabIndex = 11;
            this.lbl3.Text = "lbl3";
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Location = new System.Drawing.Point(33, 277);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(54, 13);
            this.lblFormula.TabIndex = 12;
            this.lblFormula.Text = "lblFormula";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "rectangle.gif");
            this.imageList1.Images.SetKeyName(1, "square.gif");
            this.imageList1.Images.SetKeyName(2, "parallelogram.gif");
            this.imageList1.Images.SetKeyName(3, "rhombus.gif");
            this.imageList1.Images.SetKeyName(4, "triangle.gif");
            this.imageList1.Images.SetKeyName(5, "trapezoid.gif");
            this.imageList1.Images.SetKeyName(6, "circle.gif");
            this.imageList1.Images.SetKeyName(7, "pentagon.png");
            this.imageList1.Images.SetKeyName(8, "hexagon.png");
            this.imageList1.Images.SetKeyName(9, "sqrroot.png");
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(134, 155);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(189, 110);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(12, 415);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(23, 13);
            this.lbl4.TabIndex = 14;
            this.lbl4.Text = "lbl4";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(73, 415);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 20);
            this.txt4.TabIndex = 15;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(33, 456);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(23, 13);
            this.lbl5.TabIndex = 16;
            this.lbl5.Text = "lbl5";
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(73, 453);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(100, 20);
            this.txt5.TabIndex = 17;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(208, 329);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(39, 13);
            this.lblArea.TabIndex = 18;
            this.lblArea.Text = "lblArea";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(208, 363);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(61, 13);
            this.lblPerimeter.TabIndex = 19;
            this.lblPerimeter.Text = "lblPerimeter";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(260, 326);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 21;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(260, 360);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(100, 20);
            this.txtPerimeter.TabIndex = 22;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(211, 432);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 585);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPerimeter);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "geometry formulas calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoRectangle;
        private System.Windows.Forms.RadioButton rdoSquare;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoHexagon;
        private System.Windows.Forms.RadioButton rdoPentagon;
        private System.Windows.Forms.RadioButton rdoCircle;
        private System.Windows.Forms.RadioButton rdoTrapezoid;
        private System.Windows.Forms.RadioButton rdoTriangle;
        private System.Windows.Forms.RadioButton rdoRhombus;
        private System.Windows.Forms.RadioButton rdoParallelogram;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoAreaPerimeter;
        private System.Windows.Forms.RadioButton rdoPerimeter;
        private System.Windows.Forms.RadioButton rdoArea;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Button btnClear;
    }
}

