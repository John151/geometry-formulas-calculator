using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometry_formulas_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetValuesToBlank();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (btnCalculate.Text == "&Calculate")
            {
                btnCalculate.Text = "Answer";
                btnCalculate.Name = "btnAnswer";
                SetValuesToBlank();
                SelectingShape(); //calls the function to display information on different shape's formulas
            }
            else if (btnCalculate.Text == "Answer")
            {
                if (rdoArea.Checked)
                {
                    lblArea.Text = "Area";
                    txtArea.Visible = true;                   
                }
                else if (rdoPerimeter.Checked)
                {
                    lblPerimeter.Text = "Perimeter";
                    txtPerimeter.Visible = true;
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lblArea.Text = "Area";
                    txtArea.Visible = true;
                    lblPerimeter.Text = "Perimeter";
                    txtPerimeter.Visible = true;
                }
                CalculatingAreaPerimeter(); //calls the function to ask for input and make calculations

            }
        }//End of btnCalculate Click event

        private void SelectingShape()
        {
            //formulas for rectangle
            if (rdoRectangle.Checked)
            {
                if (rdoArea.Checked)
                {
                    lbl1.Text = "Length";
                    lbl2.Text = "Width";                    
                    txt1.Visible = true;
                    txt2.Visible = true;
                    lblFormula.Text = "Area = Length X Width";
                }
                else if (rdoPerimeter.Checked)
                {
                    lbl1.Text = "Length";
                    lbl2.Text = "Width";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    lblFormula.Text = "Perimeter = 2 X Length + 2 X Width";
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lbl1.Text = "Length";
                    lbl2.Text = "Width";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    lblFormula.Text = "Perimeter = 2 X Length + 2 X Width \r\nArea = Length X Width";
                }
                pictureBox.Image = imageList1.Images[0];
            }
            //formulas for square
            if (rdoSquare.Checked)
            {
                if (rdoArea.Checked)
                {
                    lbl1.Text = "Side";
                    txt1.Visible = true;
                    lblFormula.Text = "Area = Side X Side";
                }
                else if (rdoPerimeter.Checked)
                {
                    lbl1.Text = "Length";
                    txt1.Visible = true;
                    lblFormula.Text = "Perimeter = 4 X Side";
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lbl1.Text = "Length";
                    txt1.Visible = true;
                    lblFormula.Text = "Area = Side X Side\r\nPerimeter = 4 X Side";
                }
                pictureBox.Image = imageList1.Images[1];
            }
            //formulas for parallelogram
            if (rdoParallelogram.Checked)
            {
                txt2.Visible = true;
                lbl2.Text = "Base";
                if (rdoArea.Checked)
                pictureBox.Image = imageList1.Images[2];
                {
                    lbl3.Text = "Height";
                    txt3.Visible = true;
                    lblFormula.Text = "Area = Base X Height";
                }
                else if (rdoPerimeter.Checked)
                {
                    lbl1.Text = "Side A";
                    txt1.Visible = true;
                    lblFormula.Text = "Perimeter = 2 X A + 2 X B";
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lbl1.Text = "Side A";
                    lbl3.Text = "Height";
                    txt1.Visible = true;
                    txt3.Visible = true;
                    lblFormula.Text = "Area = Base X Height\r\nPerimeter = 2 X A + 2 X B";
                }
            }
            //formulas for rhombus
            if (rdoRhombus.Checked)
            {
                if (rdoArea.Checked)
                {
                    lbl1.Text = "Base";
                    lbl2.Text = "Height";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    lblFormula.Text = "Area = Base X Height";
                }
                else if (rdoPerimeter.Checked)
                {
                    lbl1.Text = "Base";
                    txt1.Visible = true;
                    lblFormula.Text = "Perimeter = 4 X Base";
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lbl1.Text = "Base";
                    lbl2.Text = "Height";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    lblFormula.Text = "Area = Base X Height \r\nPerimeter = 4 X Base";
                }
                pictureBox.Image = imageList1.Images[3];
            }
            //formulas for triangle
            if (rdoTriangle.Checked)
            {
                if (rdoArea.Checked)
                {
                    lbl1.Text = "Base";
                    lbl2.Text = "Height";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    lblFormula.Text = "Area = (Base X Height) / 2";
                }
                else if (rdoPerimeter.Checked)
                {
                    lbl1.Text = "A";
                    lbl2.Text = "B";
                    lbl3.Text = "C";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    lblFormula.Text = "Perimeter = A + B + C";
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lbl1.Text = "A";
                    lbl2.Text = "B (Base)";
                    lbl3.Text = "C";
                    lbl4.Text = "H";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    lblFormula.Text = "Area = (Base X Height) / 2\r\nPerimeter = A + B + C";
                }
                pictureBox.Image = imageList1.Images[4];
            }
            //formulas for trapqzoid
            if (rdoTrapezoid.Checked)
            {
                if (rdoArea.Checked)
                {
                    lbl1.Text = "A";
                    lbl2.Text = "B";
                    lbl3.Text = "Height";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    lblFormula.Text = "Area = ((A + B) / 2) X H";
                }
                else if (rdoPerimeter.Checked)
                {
                    lbl1.Text = "A";
                    lbl2.Text = "B";
                    lbl3.Text = "C";
                    lbl4.Text = "D";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = true;
                    lblFormula.Text = "Perimeter = A + B + C + D";
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lbl1.Text = "A";
                    lbl2.Text = "B";
                    lbl3.Text = "C";
                    lbl4.Text = "D";
                    lbl5.Text = "Height";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = true;
                    txt5.Visible = true;
                    lblFormula.Text = "Perimeter = A + B + C + D\r\nArea = ((A + B) / 2) X H";
                }
                pictureBox.Image = imageList1.Images[5];
            }
            //formulas for circle
            if (rdoCircle.Checked)
            {
                if (rdoArea.Checked)
                {
                    lbl1.Text = "Radius";
                    txt1.Visible = true;
                    lblFormula.Text = "Area = pi x Radius^2";
                }
                else if (rdoPerimeter.Checked)
                {
                    lbl1.Text = "Radius";
                    txt1.Visible = true;
                    lblFormula.Text = "Perimeter = 2 X pi X R";
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lbl1.Text = "Radius";
                    txt1.Visible = true;
                    lblFormula.Text = "Area = pi x Radius^2 \r\nPerimeter = 2 X pi X R";
                }
                pictureBox.Image = imageList1.Images[6];
            }
            //formulas for pentagon
            if (rdoPentagon.Checked)
            {
                if (rdoArea.Checked)
                {
                    lbl1.Text = "Perimeter";
                    lbl2.Text = "Apothem";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    lblFormula.Text = "Area = Perimeter X Apothem";
                }
                else if (rdoPerimeter.Checked)
                {
                    lbl1.Text = "Side";
                    txt1.Visible = true;
                    lblFormula.Text = "Perimeter = 5 X Side";
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lbl1.Text = "Perimeter";
                    lbl2.Text = "Apothem";
                    lbl3.Text = "Side";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    lblFormula.Text = "Area = Perimeter X Apothem\r\n Perimeter = Side X 5";
                }
                pictureBox.Image = imageList1.Images[7];
            }
            //formulas for hexagon
            if (rdoHexagon.Checked)
            {
                if (rdoArea.Checked)
                {
                    lbl1.Text = "Side";
                    txt1.Visible = true;
                    lblFormula.Text = "Area = ((3 X square root of 3) / 2) X A^2";
                }
                else if (rdoPerimeter.Checked)
                {
                    lbl1.Text = "Side";
                    txt1.Visible = true;
                    lblFormula.Text = "Perimeter = Side X 6";
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lbl1.Text = "Side";
                    txt1.Visible = true;
                    lblFormula.Text = "Area = ((3 X square root of 3) / 2) X A^2\r\n Perimeter = Side X 6";
                }
                pictureBox.Image = imageList1.Images[8];

            }
        }


        private void CalculatingAreaPerimeter()
        {
            //this method takes input on measurements of shapes, makes calculations
            //converts values to strings for output
            if (rdoRectangle.Checked)
            {
                double length = double.Parse(txt1.Text);
                double width = double.Parse(txt2.Text);
                double area = length * width;
                txtArea.Text = area.ToString();
                double perimeter = 2 * length + 2 * width;
                txtPerimeter.Text = perimeter.ToString();
            }
            //formulas for square
            if (rdoSquare.Checked)
            {
                double side = double.Parse(lbl1.Text);
                double area = side * side;
                txtArea.Text = area.ToString();
                double perimeter = 4 * side;
                txtPerimeter.Text = perimeter.ToString();
            }
            //formulas for parallelogram
            if (rdoParallelogram.Checked)
            {
                if (rdoArea.Checked)
                {
                    lbl3.Text = "Height";
                    lbl2.Text = "Base";
                    txt3.Visible = true;
                    txt2.Visible = true;
                    lblFormula.Text = "Area = Base X Height";
                }
                else if (rdoPerimeter.Checked)
                {
                    lbl1.Text = "Side A";
                    lbl2.Text = "Base";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    lblFormula.Text = "Perimeter = 2 X A + 2 X B";
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lbl1.Text = "Side A";
                    lbl2.Text = "Base";
                    lbl3.Text = "Height";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    lblFormula.Text = "Area = Base X Height\r\nPerimeter = 2 X A + 2 X B";
                }
                pictureBox.Image = imageList1.Images[2];
            }
            //formulas for rhombus
            if (rdoRhombus.Checked)
            {
                if (rdoArea.Checked)
                {
                    lbl1.Text = "Base";
                    lbl2.Text = "Height";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    lblFormula.Text = "Area = Base X Height";
                }
                else if (rdoPerimeter.Checked)
                {
                    lbl1.Text = "Base";
                    txt1.Visible = true;
                    lblFormula.Text = "Perimeter = 4 X Base";
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lbl1.Text = "Base";
                    lbl2.Text = "Height";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    lblFormula.Text = "Area = Base X Height \r\nPerimeter = 4 X Base";
                }
                pictureBox.Image = imageList1.Images[3];
            }
            //formulas for triangle
            if (rdoTriangle.Checked)
            {
                if (rdoArea.Checked)
                {
                    lbl1.Text = "Base";
                    lbl2.Text = "Height";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    lblFormula.Text = "Area = (Base X Height) / 2";
                }
                else if (rdoPerimeter.Checked)
                {
                    lbl1.Text = "A";
                    lbl2.Text = "B";
                    lbl3.Text = "C";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    lblFormula.Text = "Perimeter = A + B + C";
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lbl1.Text = "A";
                    lbl2.Text = "B (Base)";
                    lbl3.Text = "C";
                    lbl4.Text = "H";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    lblFormula.Text = "Area = (Base X Height) / 2\r\nPerimeter = A + B + C";
                }
                pictureBox.Image = imageList1.Images[4];
            }
            //formulas for trapqzoid
            if (rdoTrapezoid.Checked)
            {
                if (rdoArea.Checked)
                {
                    lbl1.Text = "A";
                    lbl2.Text = "B";
                    lbl3.Text = "Height";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    lblFormula.Text = "Area = ((A + B) / 2) X H";
                }
                else if (rdoPerimeter.Checked)
                {
                    lbl1.Text = "A";
                    lbl2.Text = "B";
                    lbl3.Text = "C";
                    lbl4.Text = "D";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = true;
                    lblFormula.Text = "Perimeter = A + B + C + D";
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lbl1.Text = "A";
                    lbl2.Text = "B";
                    lbl3.Text = "C";
                    lbl4.Text = "D";
                    lbl5.Text = "Height";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = true;
                    txt5.Visible = true;
                    lblFormula.Text = "Perimeter = A + B + C + D\r\nArea = ((A + B) / 2) X H";
                }
                pictureBox.Image = imageList1.Images[5];
            }
            //formulas for circle
            if (rdoCircle.Checked)
            {
                if (rdoArea.Checked)
                {
                    lbl1.Text = "Radius";
                    txt1.Visible = true;
                    lblFormula.Text = "Area = pi x Radius^2";
                }
                else if (rdoPerimeter.Checked)
                {
                    lbl1.Text = "Radius";
                    txt1.Visible = true;
                    lblFormula.Text = "Perimeter = 2 X pi X R";
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lbl1.Text = "Radius";
                    txt1.Visible = true;
                    lblFormula.Text = "Area = pi x Radius^2 \r\nPerimeter = 2 X pi X R";
                }
                pictureBox.Image = imageList1.Images[6];
            }
            //formulas for pentagon
            if (rdoPentagon.Checked)
            {
                if (rdoArea.Checked)
                {
                    lbl1.Text = "Perimeter";
                    lbl2.Text = "Apothem";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    lblFormula.Text = "Area = Perimeter X Apothem";
                }
                else if (rdoPerimeter.Checked)
                {
                    lbl1.Text = "Side";
                    txt1.Visible = true;
                    lblFormula.Text = "Perimeter = 5 X Side";
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lbl1.Text = "Perimeter";
                    lbl2.Text = "Apothem";
                    lbl3.Text = "Side";
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    lblFormula.Text = "Area = Perimeter X Apothem\r\n Perimeter = Side X 5";
                }
                pictureBox.Image = imageList1.Images[7];
            }
            //formulas for hexagon
            if (rdoHexagon.Checked)
            {
                if (rdoArea.Checked)
                {
                    lbl1.Text = "Side";
                    txt1.Visible = true;
                    lblFormula.Text = "Area = ((3 X square root of 3) / 2) X A^2";
                }
                else if (rdoPerimeter.Checked)
                {
                    lbl1.Text = "Side";
                    txt1.Visible = true;
                    lblFormula.Text = "Perimeter = Side X 6";
                }
                else if (rdoAreaPerimeter.Checked)
                {
                    lbl1.Text = "Side";
                    txt1.Visible = true;
                    lblFormula.Text = "Area = ((3 X square root of 3) / 2) X A^2\r\n Perimeter = Side X 6";
                }
                pictureBox.Image = imageList1.Images[8];

            }
        }

        private void SetValuesToBlank()
        {   //this chunk below sets the labels for numeric inputs to "" so they do not appear when not needed
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lblFormula.Text = "";
            //these next two hide the calculation labels when they are not needed
            lblArea.Text = "";
            lblPerimeter.Text = "";
            //this chunk hides the text input boxes when they aren't needed
            txt1.Visible = false;
            txt2.Visible = false;
            txt3.Visible = false;
            txt4.Visible = false;
            txt5.Visible = false;
            txtArea.Visible = false;
            txtPerimeter.Visible = false;
        }
    }
}
