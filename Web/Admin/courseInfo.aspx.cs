using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Admin
{
    public partial class courseInfo : Pagebase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mode = Request.QueryString["id"];
            if (string.IsNullOrEmpty(mode))
            {
                DetailsView1.DefaultMode = DetailsViewMode.Insert;
            }

        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}