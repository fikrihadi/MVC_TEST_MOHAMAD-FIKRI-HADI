using System;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace MVC_TEST_MOHAMAD_FIKRI_HADI.View
{
    public partial class DynamicallyGenerated : System.Web.UI.Page
    {
        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            pnlGeneratedControls.Controls.Clear(); // Clear existing controls

            // Get selected control type and number of controls
            string controlType = ddlControlType.SelectedValue;
            int numberOfControls;

            if (int.TryParse(txtNumberOfControls.Text, out numberOfControls) && numberOfControls > 0)
            {
                for (int i = 1; i <= numberOfControls; i++)
                {
                    // Dynamically generate controls based on user selection
                    Control generatedControl = null;
                    switch (controlType)
                    {
                        case "TextBox":
                            generatedControl = new TextBox { ID = "TextBox" + i, Text = "TextBox " + i };
                            break;
                        case "CheckBox":
                            generatedControl = new CheckBox { ID = "CheckBox" + i, Text = "CheckBox " + i };
                            break;
                        case "Button":
                            generatedControl = new Button { ID = "Button" + i, Text = "Button " + i };
                            break;
                    }

                    if (generatedControl != null)
                    {
                        // Add the control to the panel
                        pnlGeneratedControls.Controls.Add(generatedControl);
                        pnlGeneratedControls.Controls.Add(new Literal { Text = "<br />" }); // Line break for layout
                    }
                }
            }
            else
            {
                // Handle invalid input
                pnlGeneratedControls.Controls.Add(new Literal { Text = "Please enter a valid number of controls." });
            }
        }
    }

}