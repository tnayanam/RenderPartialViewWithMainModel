using System;
using System.ServiceModel;

namespace CalculatorClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                int numerator = Convert.ToInt32(txtNumerator.Text);
                int denominator = Convert.ToInt32(txtDenominator.Text);
                CalculatorService.CalculatorServiceClient client =
                    new CalculatorService.CalculatorServiceClient();
                lblResult.Text = client.Divide(numerator, denominator).ToString();
            }
            catch (FaultException exp)
            {

                lblResult.Text = exp.Message;
            }

        }

        protected void txtNumerator_TextChanged(object sender, EventArgs e)
        {

        }
    }
}