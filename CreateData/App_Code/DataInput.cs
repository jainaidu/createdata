using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

class DataInput
{
    public static void saveDept(DataVariables objtest)
    {
        string DBCon = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        string Deptproc = "Insert_Department";


        SqlParameter pdept_name = new SqlParameter("@dept_name", SqlDbType.VarChar);
        pdept_name.Value = objtest.Strdept_name;


        SqlParameter pbuilding = new SqlParameter("@building", SqlDbType.VarChar);
        pbuilding.Value = objtest.Strbuilding;

        SqlParameter pbudget = new SqlParameter("@budget", SqlDbType.VarChar);
        pbudget.Value = objtest.Intbudget;

        SqlConnection conn = new SqlConnection(DBCon);
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Deptproc;
            cmd.Parameters.Add(pdept_name);
            cmd.Parameters.Add(pbuilding);
            cmd.Parameters.Add(pbudget);

            cmd.ExecuteNonQuery();
        }
        catch (Exception)
        {
            throw;
        }


    }
    public static void saveIns(DataVariables objins)
    {
        string DBCon = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        string Insproc = "Insert_Instructor";

        SqlParameter pi_id = new SqlParameter("@I_ID", SqlDbType.VarChar);
        pi_id.Value = objins.Insi_id;

        SqlParameter pi_name = new SqlParameter("@I_NAME", SqlDbType.VarChar);
        pi_name.Value = objins.Stri_name;

        SqlParameter psalary = new SqlParameter("@salary", SqlDbType.VarChar);
        psalary.Value = objins.Inssalary;


        SqlParameter pdept_name = new SqlParameter("@dept_name", SqlDbType.VarChar);
        pdept_name.Value = objins.Strdept_name;

        SqlConnection con = new SqlConnection(DBCon);
        try
        {
            con.Open();
            SqlCommand cm = new SqlCommand();
            cm.Connection = con;
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = Insproc;
            cm.Parameters.Add(pi_id);
            cm.Parameters.Add(pi_name);
            cm.Parameters.Add(pdept_name);
            cm.Parameters.Add(psalary);
            cm.ExecuteNonQuery();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public static void saveStudent(DataVariables objStu)
    {
        string DBCon = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        string Stuproc = "Insert_Student";

        SqlParameter ps_id = new SqlParameter("@S_ID", SqlDbType.VarChar);
        ps_id.Value = objStu.Stus_id;

        SqlParameter ps_name = new SqlParameter("@S_name", SqlDbType.VarChar);
        ps_name.Value = objStu.Stus_name;

        SqlParameter ps_dept = new SqlParameter("@dept_name", SqlDbType.VarChar);
        ps_dept.Value = objStu.Strdept_name;

        SqlConnection connect = new SqlConnection(DBCon);
        try
        {
            connect.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = connect;
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = Stuproc;
            cmd1.Parameters.Add(ps_id);
            cmd1.Parameters.Add(ps_name);
            cmd1.Parameters.Add(ps_dept);
            cmd1.ExecuteNonQuery();
        }
        catch (Exception)
        {
            throw;
        }
    }
}
