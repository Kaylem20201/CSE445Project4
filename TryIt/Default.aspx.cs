using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TryIt.XMLServiceReference;

namespace TryIt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Validate_Click(object sender, EventArgs e)
        {
            XMLServicesClient xmlServicesClient = new XMLServicesClient();
            ValidateResultOutput.Text = xmlServicesClient.verification(ValidateXmlUrlInput.Text, ValidateXsdUrlInput.Text);
            xmlServicesClient.Close();
        }

        protected void XPath_Click(object sender, EventArgs e)
        {
            XMLServicesClient xpathServicesClient = new XMLServicesClient();
            XPathResultOutput.Text = xpathServicesClient.XPathSearch(XPathXmlUrlInput.Text, XPathPathInput.Text);
            xpathServicesClient.Close();
        }
    }
}