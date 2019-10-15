using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GraceRc0737737_ASP_A2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalc_Click(object sender, EventArgs e)
        {
            double a1, a2, a3, a4, a5;//assignment local variables
            double t1, t2, t3; //tests local variables
            double testTotal, assignTotal, courseTotal, GPA;
            string grades;
            testTotal = assignTotal = courseTotal = 0.0;

            //Assign the values from textboxes to local variables
            a1 = double.Parse(txtA1.Text);
            a2 = double.Parse(txtA2.Text);
            a3 = double.Parse(txtA3.Text);
            a4 = double.Parse(txtA4.Text);
            a5 = double.Parse(txtA5.Text);
            assignTotal = a1 * 0.05 + a2 * 0.05 + a3 * 0.05 + a4 * 0.05 + a5 * 0.05;

            t1 = double.Parse(txtT1.Text);
            t2 = double.Parse(txtT2.Text);
            t3 = double.Parse(txtT3.Text);
            testTotal = t1 * 0.25 + t2 * 0.25 + t3 * 0.25;

            courseTotal = assignTotal + testTotal;

            //find the grade 
            if (courseTotal >= 94.00 && courseTotal <= 100)
                grades = "A+";
            else if (courseTotal >= 87.00 && courseTotal <= 93.99)
                grades = "A";
            else if (courseTotal >= 80.00 && courseTotal <= 86.99)
                grades = "A-";
            else if (courseTotal >= 77.00 && courseTotal <= 79.99)
                grades = "B+";
            else if (courseTotal >= 73.00 && courseTotal <= 76.99)
                grades = "B";
            else if (courseTotal >= 70.00 && courseTotal <= 72.99)
                grades = "B-";
            else if (courseTotal >= 67.00 && courseTotal <= 69.99)
                grades = "C+";
            else if (courseTotal >= 63.00 && courseTotal <= 66.99)
                grades = "C";
            else if (courseTotal >= 60.00 && courseTotal <= 62.99)
                grades = "C-";
            else if (courseTotal >= 50.00 && courseTotal <= 59.99)
                grades = "D";
            else
                grades = "F";
            if (courseTotal >= 94.00 && courseTotal <= 100)
                grades = "A+";
            else if (courseTotal >= 87.00 && courseTotal <= 93.99)
                grades = "A";
            else if (courseTotal >= 80.00 && courseTotal <= 86.99)
                grades = "A-";
            else if (courseTotal >= 77.00 && courseTotal <= 79.99)
                grades = "B+";
            else if (courseTotal >= 73.00 && courseTotal <= 76.99)
                grades = "B";
            else if (courseTotal >= 70.00 && courseTotal <= 72.99)
                grades = "B-";
            else if (courseTotal >= 67.00 && courseTotal <= 69.99)
                grades = "C+";
            else if (courseTotal >= 63.00 && courseTotal <= 66.99)
                grades = "C";
            else if (courseTotal >= 60.00 && courseTotal <= 62.99)
                grades = "C-";
            else if (courseTotal >= 50.00 && courseTotal <= 59.99)
                grades = "D";
            else
                grades = "F";


            if (courseTotal >= 94.00 && courseTotal <= 100)
                GPA = 4.0;
            else if (courseTotal >= 87.00 && courseTotal <= 93.99)
                GPA = 3.7;
            else if (courseTotal >= 80.00 && courseTotal <= 86.99)
                GPA = 3.5;
            else if (courseTotal >= 77.00 && courseTotal <= 79.99)
                GPA = 3.2;
            else if (courseTotal >= 73.00 && courseTotal <= 76.99)
                GPA = 3.0;
            else if (courseTotal >= 70.00 && courseTotal <= 72.99)
                GPA = 2.7;
            else if (courseTotal >= 67.00 && courseTotal <= 69.99)
                GPA = 2.3;
            else if (courseTotal >= 63.00 && courseTotal <= 66.99)
                GPA = 2.0;
            else if (courseTotal >= 60.00 && courseTotal <= 62.99)
                GPA = 1.7;
            else if (courseTotal >= 50.00 && courseTotal <= 59.99)
                GPA = 1.0;
            else
                GPA = 0.0;
            txtTotal.Text = courseTotal.ToString();
            txtGrade.Text = grades;
            txtGPA.Text = GPA.ToString();


        }

    }
}