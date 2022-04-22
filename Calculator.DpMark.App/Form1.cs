namespace Calculator.DpMark.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtGroupAssignment.Text = "";
            txtIndividualAssignment.Text = "";
            txtTestMark.Text = "";
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            bool isFormValid = true;
            string result = string.Empty;
            decimal groupAssignment;
            decimal individualAssignment;
            decimal testMark;

            if (decimal.TryParse(txtGroupAssignment.Text, out groupAssignment) != true)
            {
                isFormValid = false;
                result = result + "Group Assignment not valid.\r\n";
            }
            
            if (decimal.TryParse(txtIndividualAssignment.Text, out individualAssignment) != true)
            {
                isFormValid = false;
                result = result + "Individual Assignment not valid.\r\n";
            }

            if (decimal.TryParse(txtTestMark.Text, out testMark) != true)
            {
                isFormValid = false;
                result = result + "Group Assignment not valid.\r\n";
            }

            if(groupAssignment > 10 || groupAssignment < 0)
            {
                isFormValid = false;
                result = result + "Group Assignment must be between 0 and 10.\r\n";
            }


            if (individualAssignment > 10 || individualAssignment < 0)
            {
                isFormValid = false;
                result = result + "Individual Assignmentmust be between 0 and 10.\r\n";
            }


            if (testMark > 20 || testMark < 0)
            {
                isFormValid = false;
                result = result + "Group Assignment must be between 0 and 20.\r\n";
            }

            if (isFormValid)
            {
                Logic.Calculator calculator = new Logic.Calculator(individualAssignment, groupAssignment, testMark );

                calculator.Calculate();

                if(calculator.DpMark < 12)
                {
                    result = "Hade dawg, You cannot write the exam.";
                }
                else
                {
                    result = "Congratulations you qualify to write the exam.";
                }
            }

            MessageBox.Show(result);
        }
    }
}