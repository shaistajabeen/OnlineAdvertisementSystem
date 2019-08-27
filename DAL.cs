using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Advertiser
{
    public class DAL
    {
        public DAL()
        { 
        }

        public static void Insert(string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [Advertise].[dbo].[U_register]([EmailID],[UN],[Password],[RePW],[Name],[Address],[MobileNo],[PhoneNo],[Designation],[Gender],[IsDeleted])VALUES(@EmailID,@UN,@Password,@RePW,@Name,@Address,@MobileNo,@PhoneNo,@Designation,@Gender,'f')", GetConnection());
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@EmailID", p1);
            cmd.Parameters.AddWithValue("@UN", p2);
            cmd.Parameters.AddWithValue("@Password", p3);
            cmd.Parameters.AddWithValue("@RePW", p4);
            cmd.Parameters.AddWithValue("@Name", p5);
            cmd.Parameters.AddWithValue("@Address", p6);
            cmd.Parameters.AddWithValue("@MobileNo", p7);
            cmd.Parameters.AddWithValue("@PhoneNo", p8);
            cmd.Parameters.AddWithValue("@Designation", p9);
            cmd.Parameters.AddWithValue("@Gender", p10);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static SqlConnection GetConnection()
        {
            string Connection = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection sqlConnection1 = new SqlConnection(Connection);
            return sqlConnection1;


        }

        public static void Inserti(string par1, string par2, string par3, string par4, string par5, string par6, string par7)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [Advertise].[dbo].[Internet] ([Website],[Date_From],[Date_To],[AdSize],[Pattern],[Price],[UploadYourFile],[isdeleted])VALUES(@Website,@Date_From,@Date_To,@AdSize,@Pattern,@Price,@UploadYourFile,'F')", GetConnection());
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@Website", par1);
            cmd.Parameters.AddWithValue("@Date_From", par2);
            cmd.Parameters.AddWithValue("@Date_To", par3);
            cmd.Parameters.AddWithValue("@AdSize", par4);
            cmd.Parameters.AddWithValue("@Pattern", par5);
            cmd.Parameters.AddWithValue("@Price", par6);
            cmd.Parameters.AddWithValue("@UploadYourFile", par7);
            cmd.Parameters.AddWithValue("isdeleted", 'F');
            

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static void Insertm(string pa1, string pa2, string pa3, string pa4, string pa5, string pa6, string pa7, string pa8, string pa9)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [Advertise].[dbo].[Magazine] ([MagName],[Date_From],[Date_To],[AdPage],[AdSize],[Issues],[Pattern],[Price],[UploadYourFile],[isdeleted])VALUES(@MagName,@Date_From,@Date_To,@AdPage,@AdSize,@Issues,@Pattern,@Price,@UploadYourFile,'F')", GetConnection());
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@MagName", pa1);
            cmd.Parameters.AddWithValue("@Date_From", pa2);
            cmd.Parameters.AddWithValue("@Date_To", pa3);
            cmd.Parameters.AddWithValue("@AdPage",pa4);
            cmd.Parameters.AddWithValue("@AdSize", pa5);
            cmd.Parameters.AddWithValue("@Issues",pa6);
            cmd.Parameters.AddWithValue("@Pattern", pa7);
            cmd.Parameters.AddWithValue("@Price", pa8);
            cmd.Parameters.AddWithValue("@UploadYourFile", pa9);
            cmd.Parameters.AddWithValue("isdeleted", 'F');


            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static void Insertr(string pr1,string pr2,string pr3,string pr4,string pr5,string pr6,string pr7,string pr8,string pr9,string pr10 )
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [Advertise].[dbo].[Radio] ([Station],[Date_From],[Date_To],[Program],[BTime],[PDur],[AdDur],[Repeat],[Price],[UploadYourFile],[isdeleted])VALUES(@Station,@Date_From,@Date_To,@Program,@BTime,@PDur,@AdDur,@Repeat,@Price,@UploadYourFile,'F')", GetConnection());
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@Station", pr1);
            cmd.Parameters.AddWithValue("@Date_From", pr2);
            cmd.Parameters.AddWithValue("@Date_To", pr3);
            cmd.Parameters.AddWithValue("@Program",pr4);
            cmd.Parameters.AddWithValue("@BTime", pr5);
            cmd.Parameters.AddWithValue("@PDur", pr6);
            cmd.Parameters.AddWithValue("@AdDur",pr7);
            cmd.Parameters.AddWithValue("@Repeat",pr8);
           
            cmd.Parameters.AddWithValue("@Price", pr9);
            cmd.Parameters.AddWithValue("@UploadYourFile", pr10);
            cmd.Parameters.AddWithValue("isdeleted", 'F');


            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
public static void Insertn(string pn1,string pn2,string pn3,string pn4,string pn5, string pn6,string pn7,string pn8,string pn9,string pn10 )

 
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [Advertise].[dbo].[Newspaper] ([NPName],[Date_From],[Date_To],[AdPage],[NEd],[Adsize],[Issues],[Pattern],[Price],[UploadYourFile],[isdeleted])VALUES(@NPName,@Date_From,@Date_To,@AdPage,@NEd,@AdSize,@Issues,@Pattern,@Price,@UploadYourFile,'F')", GetConnection());
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@NPName", pn1);
            cmd.Parameters.AddWithValue("@Date_From", pn2);
            cmd.Parameters.AddWithValue("@Date_To", pn3);
            cmd.Parameters.AddWithValue("@AdPage",pn4);
            cmd.Parameters.AddWithValue("@NEd",pn5);
            cmd.Parameters.AddWithValue("@AdSize", pn6);
            cmd.Parameters.AddWithValue("@Issues",pn7);
            cmd.Parameters.AddWithValue("@Pattern", pn8);
            cmd.Parameters.AddWithValue("@Price", pn9);
            cmd.Parameters.AddWithValue("@UploadYourFile", pn10);
            cmd.Parameters.AddWithValue("isdeleted", 'F');


            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
public static void Insertb(string pb1, string pb2, string pb3, string pb4, string pb5, string pb6, string pb7, string pb8,string pb9)
{
    SqlCommand cmd = new SqlCommand("INSERT INTO [Advertise].[dbo].[Banner] ([State],[Location],[Place],[Date_From],[Date_To],[BType],[BSize],[Price],[UploadYourFile],[isdeleted])VALUES(@State,@Location,@Place,@Date_From,@Date_To,@BType,@BSize,@Price,@UploadYourFile,'F')", GetConnection());
    cmd.Connection = GetConnection();
    cmd.Connection.Open();
    cmd.Parameters.AddWithValue("@State", pb1);
    cmd.Parameters.AddWithValue("@Location",pb2);
    cmd.Parameters.AddWithValue("@Place",pb3);
    cmd.Parameters.AddWithValue("@Date_From", pb4);
    cmd.Parameters.AddWithValue("@Date_To", pb5);
    cmd.Parameters.AddWithValue("@BType",pb6);
    cmd.Parameters.AddWithValue("@BSize", pb7);
    cmd.Parameters.AddWithValue("@Price", pb8);
    cmd.Parameters.AddWithValue("@UploadYourFile", pb9);
    cmd.Parameters.AddWithValue("isdeleted", 'F');


    cmd.ExecuteNonQuery();
    cmd.Connection.Close();
}
public static void Insertt(string pt1,string pt2,string pt3,string pt4,string pt5,string pt6,string pt7,string pt8,string pt9,string pt10)
{
    SqlCommand cmd = new SqlCommand("INSERT INTO [Advertise].[dbo].[TV] ([Channel],[Date_From],[Date_To],[Program],[Telecast],[PDur],[AdDur],[Repeat],[Price],[UploadYourFile],[isdeleted])VALUES(@Channel,@Date_From,@Date_To,@Program,@Telecast,@PDur,@AdDur,@Repeat,@Price,@UploadYourFile,'F')", GetConnection());
    cmd.Connection = GetConnection();
    cmd.Connection.Open();
    cmd.Parameters.AddWithValue("@Channel", pt1);
    cmd.Parameters.AddWithValue("@Date_From", pt2);
    cmd.Parameters.AddWithValue("@Date_To", pt3);
    cmd.Parameters.AddWithValue("@Program",pt4);
    cmd.Parameters.AddWithValue("@Telecast", pt5);
    cmd.Parameters.AddWithValue("@PDur", pt6);
    cmd.Parameters.AddWithValue("@AdDur", pt7);
    cmd.Parameters.AddWithValue("@Repeat",pt8);
    cmd.Parameters.AddWithValue("@Price",pt9);
    cmd.Parameters.AddWithValue("@UploadYourFile", pt10);
    cmd.Parameters.AddWithValue("isdeleted", 'F');


    cmd.ExecuteNonQuery();
    cmd.Connection.Close();
}


public static DataTable ExecuteQuery(string query, string tablename, string where)
{
    string connection = System.Configuration.ConfigurationManager.
              ConnectionStrings["ConnectionString"].ConnectionString;
    SqlConnection sqlConnection1 = new SqlConnection(connection);
    try
    {

        DataTable dt = new DataTable();
        string statement = query + tablename + where;

        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        cmd.CommandText = statement;
        cmd.CommandType = CommandType.Text;
        cmd.Connection = sqlConnection1;

        sqlConnection1.Open();

        reader = cmd.ExecuteReader();

        dt.Load(reader);
        sqlConnection1.Close();

        return dt;

           
    }
      
    catch (Exception ex)
    {
        throw ex;
    }
   
}

public static DataTable SelectRecordI(string Where)
{
    string connection = System.Configuration.ConfigurationManager.
    ConnectionStrings["ConnectionString"].ConnectionString;
    DataTable dt = new DataTable();
    string query = "select * from Internet" + Where;
    SqlConnection sqlConnection1 = new SqlConnection(connection);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader reader;
    cmd.CommandText = query;
    cmd.CommandType = CommandType.Text;
    cmd.Connection = sqlConnection1;
    sqlConnection1.Open();
    reader = cmd.ExecuteReader();
    dt.Load(reader);
    return dt;
}

public static DataTable SelectRecordB(string Where)
{
    string connection = System.Configuration.ConfigurationManager.
    ConnectionStrings["ConnectionString"].ConnectionString;
    DataTable dt = new DataTable();
    string query = "select * from Banner" + Where;
    SqlConnection sqlConnection1 = new SqlConnection(connection);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader reader;
    cmd.CommandText = query;
    cmd.CommandType = CommandType.Text;
    cmd.Connection = sqlConnection1;
    sqlConnection1.Open();
    reader = cmd.ExecuteReader();
    dt.Load(reader);
    return dt;
}
public static DataTable SelectRecordN(string Where)
{
    string connection = System.Configuration.ConfigurationManager.
    ConnectionStrings["ConnectionString"].ConnectionString;
    DataTable dt = new DataTable();
    string query = "select * from Newspaper" + Where;
    SqlConnection sqlConnection1 = new SqlConnection(connection);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader reader;
    cmd.CommandText = query;
    cmd.CommandType = CommandType.Text;
    cmd.Connection = sqlConnection1;
    sqlConnection1.Open();
    reader = cmd.ExecuteReader();
    dt.Load(reader);
    return dt;
}
public static DataTable SelectRecordR(string Where)
{
    string connection = System.Configuration.ConfigurationManager.
    ConnectionStrings["ConnectionString"].ConnectionString;
    DataTable dt = new DataTable();
    string query = "select * from Radio" + Where;
    SqlConnection sqlConnection1 = new SqlConnection(connection);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader reader;
    cmd.CommandText = query;
    cmd.CommandType = CommandType.Text;
    cmd.Connection = sqlConnection1;
    sqlConnection1.Open();
    reader = cmd.ExecuteReader();
    dt.Load(reader);
    return dt;
}
public static DataTable SelectRecordT(string Where)
{
    string connection = System.Configuration.ConfigurationManager.
    ConnectionStrings["ConnectionString"].ConnectionString;
    DataTable dt = new DataTable();
    string query = "select * from TV" + Where;
    SqlConnection sqlConnection1 = new SqlConnection(connection);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader reader;
    cmd.CommandText = query;
    cmd.CommandType = CommandType.Text;
    cmd.Connection = sqlConnection1;
    sqlConnection1.Open();
    reader = cmd.ExecuteReader();
    dt.Load(reader);
    return dt;
}
public static DataTable SelectRecordM(string Where)
{
    string connection = System.Configuration.ConfigurationManager.
    ConnectionStrings["ConnectionString"].ConnectionString;
    DataTable dt = new DataTable();
    string query = "select * from Magazine" + Where;
    SqlConnection sqlConnection1 = new SqlConnection(connection);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader reader;
    cmd.CommandText = query;
    cmd.CommandType = CommandType.Text;
    cmd.Connection = sqlConnection1;
    sqlConnection1.Open();
    reader = cmd.ExecuteReader();
    dt.Load(reader);
    return dt;
}
/*public static DataTable DeleteI(string Where)
{
    string connection = System.Configuration.ConfigurationManager.
    ConnectionStrings["ConnectionString"].ConnectionString;
    DataTable dt = new DataTable();
    SqlConnection sqlConnection1 = new SqlConnection(connection);
    SqlCommand cmd = new SqlCommand("Delete  from Internet where cid='" + id + "'");
    SqlDataReader reader;
    cmd.CommandType = CommandType.Text;
    cmd.Connection = sqlConnection1;
    sqlConnection1.Open();
    reader = cmd.ExecuteReader();
    dt.Load(reader);
    return dt;
}*/
    }


}


