using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycle2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected override void OnPreInit(EventArgs e)
        {
            Response.Write("<br/> Inside OnPreInit Method");
            base.OnPreInit(e);
        }
        protected override void OnInit(EventArgs e)
        {
            Response.Write("<br/> Inside OnInit Method");
            base.OnInit(e);
        }
        protected override void OnInitComplete(EventArgs e)
        {
            Response.Write("<br/> Inside OnInitComplete Method");
            base.OnInitComplete(e);
        }
        protected override void OnPreLoad(EventArgs e)
        {
            Response.Write("<br/> Inside OnPreLoad Method");
            base.OnPreLoad(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            Response.Write("<br/> Inside OnLoad Method");
            base.OnLoad(e);
        }
        protected override void OnLoadComplete(EventArgs e)
        {
            Response.Write("<br/> Inside OnLoadComplete Method");
            base.OnLoadComplete(e);
        }
        protected override void OnPreRender(EventArgs e)
        {
            Response.Write("<br/> Inside OnPreRender Method");
            base.OnPreRender(e);
        }
        protected override void OnPreRenderComplete(EventArgs e)
        {
            Response.Write("<br/> Inside OnPreRenderComplete Method");
            base.OnPreRenderComplete(e);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<br/> Inside Page_Load Method");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<br/> Inside Button1_Click Method");

        }
    }
}