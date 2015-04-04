using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleAuthSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddUser : System.Web.UI.Page
{
    ApplicationDbContext usrCtx = new ApplicationDbContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindUsers();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        var userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(usrCtx));

        var user = new ApplicationUser { UserName = tbUserName.Text };
        if (userManager.FindByName(tbUserName.Text) == null) {
            var result = userManager.Create(user, tbPassword.Text);

            if (result.Succeeded) {
                lblMsg.Text = string.Format("User '{0}' added.", tbUserName.Text);
                lblMsg.ForeColor = System.Drawing.Color.Green;
            } else {
                string err = string.Format("Could not add user: '{0}'.", tbUserName.Text);
                foreach (var item in result.Errors) {
                    err += "<br />" + item.ToString();
                }
                lblMsg.Text = err;
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }

        } else {
            lblMsg.Text = string.Format("User '{0}' is already taken.", tbUserName.Text);
            lblMsg.ForeColor = System.Drawing.Color.Red;
        }


        BindUsers();
    }

    protected void BindUsers()
    {
        gvUsers.DataSource = usrCtx.Users.OrderBy(u => u.UserName).ToList();
        gvUsers.DataBind();
    }
}