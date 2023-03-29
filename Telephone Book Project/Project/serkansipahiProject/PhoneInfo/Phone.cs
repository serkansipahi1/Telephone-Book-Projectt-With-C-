using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serkansipahiProject.PhoneInfo
{
    class Phone
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string phoneNum { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Language { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["serkansipahiProject.Properties.Settings.serkansProjectConnectionString"].ConnectionString;

        public DataTable Select()
        {

            SqlConnection conn = new SqlConnection(myconnstrng);


            DataTable dt = new DataTable();
            try
            {

                string sql = "SELECT * FROM Person";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool Insert(Phone ph)
        {

            bool isSuccess = false;


            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {

                string sql = "INSERT INTO Person (Id, Name, Surname ,phoneNum ,Address ,Gender ,Language  " +
                    ") VALUES (@Id, @Name, @Surname, @phoneNum ,@Address ,@Gender ,@Language ) ";


                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Id", ph.Id);
                cmd.Parameters.AddWithValue("@Name", ph.Name);
                cmd.Parameters.AddWithValue("@Surname", ph.Surname);
                cmd.Parameters.AddWithValue("@phoneNum", ph.phoneNum);
                cmd.Parameters.AddWithValue("@Address", ph.Address);
                cmd.Parameters.AddWithValue("@Gender", ph.Gender);
                cmd.Parameters.AddWithValue("@Language", ph.Language);
                



                conn.Open();


                int rows = cmd.ExecuteNonQuery();


                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }


        public bool Update(Phone ph)
        {

            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {

                string sql = "UPDATE Person SET Name=@Name, Surname=@Surname, phoneNum=@phoneNum ,Address=@Address," +
                              "Gender=@Gender, Language=@Language WHERE Id = @Id";



                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.Add("@Id", ph.Id);
                cmd.Parameters.Add("@Name", ph.Name);
                cmd.Parameters.Add("@Surname", ph.Surname);
                cmd.Parameters.Add("@phoneNum", ph.phoneNum);
                cmd.Parameters.Add("@Address", ph.Address);
                cmd.Parameters.Add("@Gender", ph.Gender);
                cmd.Parameters.Add("@Language", ph.Language);






                conn.Open();


                int rows = cmd.ExecuteNonQuery();


                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool Delete(Phone ph)
        {

            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {

                string sql = "DELETE FROM Person WHERE Id = @Id ";


                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@Id", ph.Id);


                conn.Open();


                int rows = cmd.ExecuteNonQuery();


                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
