using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejemploCrudAsp
{
    public partial class formularioCrud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {  
            using (System.Data.SqlClient.SqlConnection openCon = new System.Data.SqlClient.SqlConnection("Data Source=HECTORJOSUE;Initial Catalog=tutorialCrud;Integrated Security=True"))
            {
                string saveStaff = "SELECT id_articulo from tbl_articulos where nombre = 'Mochilas'   ";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;                    
                    openCon.Open();
                    SqlDataReader reader = querySaveStaff.ExecuteReader();

                    if (reader.Read())
                    {
                        TextBox1.Text = reader.GetSqlInt32(0).ToString();
                    }
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection openCon = new SqlConnection("Data Source=HECTORJOSUE;Initial Catalog=tutorialCrud;Integrated Security=True"))
            {
                string saveStaff = "INSERT into tbl_articulos (nombre, precio) VALUES (@nombre, @precio)";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = TextBox2.Text;
                    querySaveStaff.Parameters.Add("@precio", SqlDbType.VarChar, 30).Value = TextBox5.Text;
                    openCon.Open();
                    querySaveStaff.ExecuteNonQuery();
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
               using (SqlConnection openCon = new SqlConnection("Data Source=HECTORJOSUE;Initial Catalog=tutorialCrud;Integrated Security=True"))
            {
                string saveStaff = "UPDATE tbl_articulos SET nombre= @nombre, precio= @precio where id_articulo =6";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = TextBox3.Text;
                    querySaveStaff.Parameters.Add("@precio", SqlDbType.Money).Value = TextBox6.Text;
                    openCon.Open();
                    querySaveStaff.ExecuteNonQuery();
                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection openCon = new SqlConnection("Data Source=HECTORJOSUE;Initial Catalog=tutorialCrud;Integrated Security=True"))
            {
                string saveStaff = "DELETE FROM tbl_articulos WHERE id_articulo = @id_articulo";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@id_articulo", SqlDbType.VarChar, 30).Value = TextBox4.Text;
                    openCon.Open();
                    querySaveStaff.ExecuteNonQuery();
                }
            }

        }
    }
    
}