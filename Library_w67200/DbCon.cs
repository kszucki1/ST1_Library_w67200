using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Library_w67200
{
    public static class DbCon
    {
        public static DataSet DbConnectDataSet(String query)
        {

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString =
                    "data source = KACPER\\SQLEXPRESS; database = Library_w67200; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
            
                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show("Operation aborted, Error:" + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        public static void DbConnect(String query)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString =
                    "data source = KACPER\\SQLEXPRESS; database = Library_w67200; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Operation aborted, Error:" + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
                
            }
            
        }

        public static void DbExport(String query, String Path)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection("data source = KACPER\\SQLEXPRESS; database = Library_w67200; integrated security=True");
                sqlCon.Open(); 

                SqlCommand sqlCmd = new SqlCommand(
                    query, sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();

                string fileName = Path;//"C:/Users/szuck/RiderProjects/Library_w67200/Library_w67200/Export/Students.xlsx";
                StreamWriter sw = new StreamWriter(fileName);
                object[] output = new object[reader.FieldCount];

                for (int i = 0; i < reader.FieldCount; i++)
                    output[i] = reader.GetName(i);

                sw.WriteLine(string.Join(",", output));

                while (reader.Read())
                {
                    reader.GetValues(output);
                    sw.WriteLine(string.Join(",", output));
                }

                sw.Close();
                reader.Close();
                sqlCon.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Operation aborted, Error:" + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
            
        }
    }
} 