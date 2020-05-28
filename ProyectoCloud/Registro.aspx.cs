using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ProyectoCloud
{
    public partial class Registro : System.Web.UI.Page
    {
        DataSet1TableAdapters.registroTableAdapter taRegistro = new DataSet1TableAdapters.registroTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_aceptar_Click(object sender, EventArgs e)
        {
            taRegistro.InsertQuery(txt_email.Text, txt_nombre.Text, txt_apellido.Text);
            txt_apellido.Text = "";
            txt_email.Text = "";
            txt_nombre.Text = "";
            lbl_Gracias.Text = "GRACIAS POR INGRESAR SUS DATOS!";
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}