using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace ProyectoSeguridad
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string usuario = login1.UserName;
            string password = login1.Password;
            if (usuario == "juan" & password == "123")
            {
                FormsAuthentication.RedirectFromLoginPage(usuario, false);
            }
            else
            {
                login1.FailureText = "Usuario y/o contraseña incorrecta";
            }
        }
    }
}