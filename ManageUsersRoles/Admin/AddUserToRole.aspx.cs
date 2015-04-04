using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleAuthSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddUserToRole : System.Web.UI.Page
{
    ApplicationDbContext usrCtx = new ApplicationDbContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            BindUsers();
            BindRoles();
        }
    }
    protected void BindUsers()
    {
        gvUsers.DataSource = usrCtx.Users.OrderBy(u => u.UserName).ToList();
        gvUsers.DataBind();

        ddlUsers.DataSource = usrCtx.Users.OrderBy(u => u.UserName).ToList();
        ddlUsers.DataTextField = "UserName";
        ddlUsers.DataValueField = "UserName";
        ddlUsers.DataBind();
    }
    protected void BindRoles()
    {
        gvRoles.DataSource = usrCtx.Roles
            .OrderBy(r => r.Name)
            .ToList();
        gvRoles.DataBind();

        ddlRoles.DataSource = usrCtx.Roles.OrderBy(r => r.Name).ToList();
        ddlRoles.DataTextField = "Name";
        ddlRoles.DataValueField = "Name";
        ddlRoles.DataBind();
    }
    protected void btnAdd2Role_Click(object sender, EventArgs e)
    {
        var userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(usrCtx));
        var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(usrCtx));

        if (userManager.FindByName(ddlUsers.Text) != null) {
            var user = userManager.FindByName(ddlUsers.Text);
            if (roleManager.RoleExists(ddlRoles.Text)) {
                if (userManager.IsInRole(user.Id, ddlRoles.Text)) {
                    lblMsg.Text = string.Format("User '{0}' is already in '{1}' role.", ddlUsers.Text, ddlRoles.Text);
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                var result = userManager.AddToRole(user.Id, ddlRoles.Text);
                if (result.Succeeded) {
                    lblMsg.Text = string.Format("User '{0}' added to '{1}' role.", ddlUsers.Text, ddlRoles.Text);
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                } else {
                    string err = string.Format("Could not add '{0}' to role '{1}'.", ddlUsers.Text, ddlRoles.Text);
                    foreach (var item in result.Errors) {
                        err += "<br />" + item.ToString();
                    }
                    lblMsg.Text = err;
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                }
            } else {
                lblMsg.Text = string.Format("Role '{0}' does not exist.", ddlRoles.Text);
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        } else {
            lblMsg.Text = string.Format("User '{0}' does not exist.", ddlUsers.Text);
            lblMsg.ForeColor = System.Drawing.Color.Red;
        }


    }
}