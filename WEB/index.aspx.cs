using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Bll;
using System.Data.SqlClient;
using System.Configuration;
using Models;

namespace WEB
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bindimage();
            BindFindContent();
            BindFindAdd();
            BindFindStatus();
            BindFindTime();
            BindFindUserPhone();

            BindFoundLostTime();

            BindFosterTime();
            
        }
        private void Bindimage()
        {
            DataTable dt = Bll.CategoriesService.SelectAll();
            if (dt != null && dt.Rows.Count > 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
             private void BindFindContent()
        {
            DataTable dt = Bll.FindService.SelectTopOne();
            if (dt != null && dt.Rows.Count > 0)
            {
                ListView2.DataSource = dt;
                ListView2.DataBind();
            }
        }
        private void BindFindAdd()
        {
            DataTable dt = Bll.FindService.SelectTopOne();
            if (dt != null && dt.Rows.Count > 0)
            {
                ListView2.DataSource = dt;
                ListView2.DataBind();
            }
        }
        private void BindFindTime()
        {
            DataTable dt = Bll.FindService.SelectTopOne();
            if (dt != null && dt.Rows.Count > 0)
            {
                ListView2.DataSource = dt;
                ListView2.DataBind();
            }
        }
        private void BindFindUserPhone()
        {
            DataTable dt = Bll.FindService.SelectTopOne();
            if (dt != null && dt.Rows.Count > 0)
            {
                ListView2.DataSource = dt;
                ListView2.DataBind();
            }
        }
        private void BindFindStatus()
        {
            DataTable dt = Bll.FindService.SelectTopOne();
            if (dt != null && dt.Rows.Count > 0)
            {
                ListView2.DataSource = dt;
                ListView2.DataBind();
            }
        }
        private void BindFoundLostTime()
        {
            DataTable dt = Bll.FoundService.SelectTopOne();
            if (dt != null && dt.Rows.Count > 0)
            {
                ListView3.DataSource = dt;
                ListView3.DataBind();
            }
        }
        private void BindFosterTime()
        {
            DataTable dt = Bll.FosterService.SelectTopOne();
            if (dt != null && dt.Rows.Count > 0)
            {
                ListView4.DataSource = dt;
                ListView4.DataBind();
            }
        }
        //private void BindFContent()
        //{
        //    DataTable dt = Bll.FoundService.SelectAll();
        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        ListView3.DataSource = dt;
        //        ListView3.DataBind();
        //    }
        //}

    }
}