using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TooManyStudentsThomasA
{
    public partial class frmTooManyStudents : Form
    {
        // Declare constants and variables
        const int maxStudents = 24;
        int numStudents;

        public frmTooManyStudents()
        {
            InitializeComponent();
        }

        // Display text when the button is pressed
        private void btnCheckSize_Click(object sender, EventArgs e)
        {
            // Get the number of students from the text box. Convert from string to a 32 bit integer
            numStudents = Convert.ToInt32(txtNumStudents.Text);

            // If number of students is greater then 24
            if (numStudents > 24)
            {
                // Display text to inform user they have too many students
                lblResult.Text = "You entered too many students";
            }
            else
            {
                // Display text to inform user they have the right amount of students
                lblResult.Text = "Just the right amount of students";
            }
        }
    }
}