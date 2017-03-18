using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AddOneToAnother
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            computate.Click += new EventHandler(calculateBtn_Click);
        }

        protected void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int input = Convert.ToInt32(inputBox.Text);

                AddOneReference.AddOneServiceClient addObj = new AddOneReference.AddOneServiceClient();

                input = addObj.addOne(input);
                result.Text = Convert.ToString(input);
            }
            catch(FormatException ee)
            {
                result.Text = "type in an integer";
            }
        }
    }
}