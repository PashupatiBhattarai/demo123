using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using project;
using System.Data;

namespace newdata
{
    public partial class output : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            if(!IsPostBack)

            {
                DataAccess dat = new DataAccess();

                // dat.GetBook();
                GridView1.DataSource = dat.GetBook();
                GridView1.DataBind();

            }
                       
        }

        protected void txtbutton_Click(object sender, EventArgs e)
        {
            DataAccess obj = new DataAccess();
            obj.URcadd(txtname.Text, Convert.ToInt32(txtprice.Text), Convert.ToInt32(txtedition.Text));
            txtlabel.Text = "data  is saved";

       private void  clearbox()
        {

                txtname.Text = string.Empty;
                txtprice.Text = string.Empty;
                txtedition.Text = string.Empty;

            }
        }

       /* protected void Button1_Click(object sender, EventArgs e)
        {
            DataAccess bvj = new DataAccess();
            bvj.update(Convert.ToInt32(txtUserid.Text), txtname.Text, Convert.ToInt32(txtprice.Text), Convert.ToInt32(txtedition.Text));
            txtlabel.Text = "data  is updated";

        
        }*/
       
    }
}