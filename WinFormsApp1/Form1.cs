using RomanMaths;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            Output.Text = RomanMathCalculator.Evalute(Input.Text);
            //Output.Text = RomanMathEvalutor.Evalute(Input.Text);
        }
    }
}