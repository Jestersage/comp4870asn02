using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleAuthSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddRole : System.Web.UI.Page
{
    ApplicationDbContext usrCtx = new ApplicationDbContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindRoles();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(usrCtx));
        if (!roleManager.RoleExists(tbRole.Text)) {
            var result = roleManager.Create(new IdentityRole(tbRole.Text));
            if (result.Succeeded) {
                lblMsg.Text = string.Format("Role '{0}' added.", tbRole.Text);
                lblMsg.ForeColor = System.Drawing.Color.Green;
            } else {
                string err = string.Format("Could not add role: '{0}'.", tbRole.Text);
                foreach (var item in result.Errors) {
                    err += "<br />" + item.ToString();
                }
                lblMsg.Text = err;
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }

        } else {
            lblMsg.Text = string.Format("User '{0}' not found.", tbRole.Text);
            lblMsg.ForeColor = System.Drawing.Color.Red;
        }
        BindRoles();
    }
    protected void BindRoles()
    {
        gvRoles.DataSource = usrCtx.Roles.OrderBy(r => r.Name).ToList();
        gvRoles.DataBind();
    }
}