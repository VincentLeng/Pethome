using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALFactory;
using System.Data.SqlClient;
using System.Data;
using Bll;
using Models;

namespace WEB
{
    public partial class zhaolingxiangqing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["FindID"] = Convert.ToInt32(Request.QueryString["id"]);

            }
            BindFindID();
        }
        private void BindFindID()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            DataTable dt = FindService.SelectFindID(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                LvText.DataSource = dt;
                LvText.DataBind();
            }
        }

        //protected void TbFindAdd_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}