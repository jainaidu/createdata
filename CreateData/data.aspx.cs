using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


    public partial class data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtsubmit_Click(object sender, EventArgs e)
        {
        DataVariables objcreate = new DataVariables();
        objcreate.Strdept_name = txtdept.Text;
        objcreate.Strbuilding = txtbuilding.Text;
        objcreate.Intbudget = txtbudget.Text;

        DataInput.saveDept(objcreate);
        Response.Write("New Department is Created");
        }

    protected void txtsubmit1_Click(object sender, EventArgs e)
    {
        DataVariables objins = new DataVariables();
        objins.Insi_id = txti_id.Text;
        objins.Stri_name = txti_name.Text;
        objins.Strdept_name = txti_dept.Text;
        objins.Inssalary = txti_salary.Text;

        DataInput.saveIns(objins);
        Response.Write("New Instructor is Created");
    }

    protected void txtsub_click(object sender, EventArgs e)
    {
        DataVariables objStu = new DataVariables();
        objStu.Stus_id = txts_id.Text;
        objStu.Stus_name = txts_name.Text;
        objStu.Strdept_name = txts_dept.Text;
        objStu.Strcredits = txts_cred.Text;

        DataInput.saveStudent(objStu);
        Response.Write("New Student is Created");


    }
}
