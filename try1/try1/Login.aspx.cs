using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace try1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
                CheckBox2.Visible = true;
                CheckBox1.Visible = false;
            }
           else
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
                CheckBox2.Visible = false;
                CheckBox1.Visible = true;
            }
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox2.Checked)
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
                CheckBox2.Visible = false;
                CheckBox1.Visible = true;
            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
                CheckBox2.Visible = true;
                CheckBox1.Visible = false;
            } 

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            PlaceHolder1.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            PlaceHolder2.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CheckBox1.Visible = true;
            Panel1.Visible = true;
            Вход.Visible = false;
        }
    }
}