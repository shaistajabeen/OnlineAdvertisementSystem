using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web.UI.WebControls;

namespace Advertiser
{
    public class BLL
    {
        public static string Name = string.Empty;
        public static string Password = string.Empty;



        public BLL()
        {
        }
        public static void Register(string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9,string p10)
        {
            DAL.Insert(p1, p2, p3, p4, p5, p6, p7, p8, p9,p10);
        }
        public static void Internet(string par1, string par2, string par3, string par4, string par5, string par6, string par7)
        {
            DAL.Inserti(par1, par2, par3, par4, par5, par6, par7);
        }
        public static void Magazine(string pa1, string pa2, string pa3, string pa4, string pa5, string pa6, string pa7, string pa8, string pa9)
        {
            DAL.Insertm(pa1, pa2, pa3, pa4, pa5, pa6, pa7, pa8, pa9);
        }
        public static void Radio(string pr1, string pr2, string pr3, string pr4, string pr5, string pr6, string pr7, string pr8, string pr9, string pr10)
        {
            DAL.Insertr(pr1, pr2, pr3, pr4, pr5, pr6, pr7, pr8, pr9, pr10);
        }
        public static void Newspaper(string pn1, string pn2, string pn3, string pn4, string pn5, string pn6, string pn7, string pn8, string pn9, string pn10)
        {
            DAL.Insertn(pn1, pn2, pn3, pn4, pn5, pn6, pn7, pn8, pn9, pn10);
        }
        public static void Banner(string pb1, string pb2, string pb3, string pb4, string pb5, string pb6, string pb7, string pb8, string pb9)
        {
            DAL.Insertb(pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9);
        }
        public static void TV(string pt1, string pt2, string pt3, string pt4, string pt5, string pt6, string pt7, string pt8, string pt9, string pt10)
        {
            DAL.Insertt(pt1,pt2,pt3,pt4,pt5,pt6,pt7,pt8,pt9,pt10);
        }

        public static ArrayList AuthenticateAdmin(string userId, string password)
        {
            ArrayList Result = new ArrayList();
            string Where = "where UserName='" + userId + "' and Password='" + password + "' ";
            DataTable dt = DAL.ExecuteQuery("select * from ", " AdminLog_In ", Where);

            if (dt.Rows.Count == 0)
            {


                Result.Add("False");

            }
            else
            {
                Result.Add("True");
                Name = dt.Rows[0]["UserName"].ToString();
                Password = dt.Rows[0]["Password"].ToString();
                Result.Add(Name);
                Result.Add(Password);
            }

            return Result;

        }

        public static ArrayList AuthenticateUser(string userId, string password)
        {
            ArrayList Result = new ArrayList();
            string Where = "where UserName='" + userId + "' and Password='" + password + "' ";
            DataTable dt = DAL.ExecuteQuery("select * from ", " UserLog_In ", Where);

            if (dt.Rows.Count == 0)
            {


                Result.Add("False");

            }
            else
            {
                Result.Add("True");
                Name = dt.Rows[0]["UserName"].ToString();
                Password = dt.Rows[0]["Password"].ToString();
                Result.Add(Name);
                Result.Add(Password);
            }

            return Result;

        }
        public static ArrayList AuthenticateUserR(string userId, string password)
        {
            ArrayList Result = new ArrayList();
            string Where = "where UserName='" + userId + "' and Password='" + password + "' ";
            DataTable dt = DAL.ExecuteQuery("select * from ", " U ", Where);

            if (dt.Rows.Count == 0)
            {


                Result.Add("False");

            }
            else
            {
                Result.Add("True");
                Name = dt.Rows[0]["UserName"].ToString();
                Password = dt.Rows[0]["Password"].ToString();
                Result.Add(Name);
                Result.Add(Password);
            }

            return Result;

        }
        public void ShowUsersI(GridView grd)
        {

            string where = string.Empty;

            grd.DataSource = DAL.SelectRecordI(where);
            grd.DataBind();
        }
        public void ShowUsersB(GridView grd)
        {

            string where = string.Empty;

            grd.DataSource = DAL.SelectRecordB(where);
            grd.DataBind();
        }
        public void ShowUsersN(GridView grd)
        {

            string where = string.Empty;

            grd.DataSource = DAL.SelectRecordN(where);
            grd.DataBind();
        }
        public void ShowUsersR(GridView grd)
        {

            string where = string.Empty;

            grd.DataSource = DAL.SelectRecordR(where);
            grd.DataBind();
        }
        public void ShowUsersT(GridView grd)
        {

            string where = string.Empty;

            grd.DataSource = DAL.SelectRecordT(where);
            grd.DataBind();
        }
        public void ShowUsersM(GridView grd)
        {

            string where = string.Empty;

            grd.DataSource = DAL.SelectRecordM(where);
            grd.DataBind();
        }
        public static bool IfExists(string RoleId, string FormID, string rightid, Label RoleRightID)
        {

            string Where = "where RoleID='" + RoleId + "' and FormID='" + FormID + "' " + "and RightID='" + rightid + "' ";
            DataTable dt = DAL.ExecuteQuery("select * from ", " RoleRight ", Where);

            if (dt.Rows.Count == 0)
            {
                return false;

            }
            else
            {
                RoleRightID.Text = dt.Rows[0]["RoleRights ID"].ToString();
                return true;

            }


        }

        public static bool IfExists(string RoleId, string FormID, string rightid)
        {

            string Where = "where RoleID='" + RoleId + "' and FormID='" + FormID + "' " + "and RightID='" + rightid + "' ";
            DataTable dt = DAL.ExecuteQuery("select * from ", " RoleRight ", Where);

            if (dt.Rows.Count == 0)
            {
                return false;

            }
            else
            {

                return true;

            }


        }

    }
}