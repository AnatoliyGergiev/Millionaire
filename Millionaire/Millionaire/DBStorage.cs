using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionaire
{
    class DBStorage:IStorage
    {
        public List<string> Download()
        {
            List<string> str = new List<string>();
            SqlConnection connect = new SqlConnection();
            SqlCommand command = new SqlCommand();

            try
            {
                connect.ConnectionString = @"Initial Catalog=Millionaire;Data Source=(local);Integrated Security=SSPI";
                connect.Open();
                command.Connection = connect;
                command.CommandText = "select question, answer1, answer2, answer3, answer4 from Millionaire_table";
                SqlDataReader reader = command.ExecuteReader();
                int count = reader.FieldCount;
                while (reader.Read())
                {
                    string temp = "";
                    for (int i = 0; i < count; i++)
                    {
                        temp = reader[i].ToString();
                        str.Add(temp);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                command.Dispose();
                connect.Close();
            }
            return str;
        }
        public void SaveQuestion(string[] str)
        {
            SqlConnection connect = new SqlConnection();
            SqlCommand cmd = null;
            SqlTransaction trans = null;
            try
            {
                connect.ConnectionString = @"Initial Catalog=Millionaire;Data Source=(local);Integrated Security=SSPI";
                connect.Open();
                trans = connect.BeginTransaction();
                cmd = connect.CreateCommand();

                cmd.Connection = connect;
                cmd.Transaction = trans;

                cmd.CommandText = "insert into Millionaire_table (question, answer1, answer2, answer3, answer4) values ('" + str[0] + "', '" + str[1] + "', '" + str[2] + "', '" + str[3] + "', '" + str[4] + "')";
                cmd.ExecuteNonQuery();

                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
            }
            finally
            {
                cmd.Dispose();
                connect.Close();
            }
        }
        public void RemoveQuestion(string question, Game g)
        {
            SqlConnection connect = new SqlConnection();
            SqlCommand cmd = null;
            SqlTransaction trans = null;
            try
            {
                connect.ConnectionString = @"Initial Catalog=Millionaire;Data Source=(local);Integrated Security=SSPI";
                connect.Open();
                trans = connect.BeginTransaction();
                cmd = connect.CreateCommand();

                cmd.Connection = connect;
                cmd.Transaction = trans;

                cmd.CommandText = "delete from Millionaire_table where question = '" + question +"'";
                cmd.ExecuteNonQuery();

                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
            }
            finally
            {
                cmd.Dispose();
                connect.Close();
            }
        }
        public void EditQuestion(string[] str, Game g)
        {
            SqlConnection connect = new SqlConnection();
            SqlCommand cmd = null;
            SqlTransaction trans = null;
            try
            {
                connect.ConnectionString = @"Initial Catalog=Millionaire;Data Source=(local);Integrated Security=SSPI";
                connect.Open();
                trans = connect.BeginTransaction();
                cmd = connect.CreateCommand();

                cmd.Connection = connect;
                cmd.Transaction = trans;

                cmd.CommandText = "update Millionaire_table set question='" + str[0] + "', answer1='" + str[1] + "', answer2='" + str[2] + "', answer3='" + str[3] + "', answer4='" + str[4] + "' where question='" + str[5] +"'";
                cmd.ExecuteNonQuery();

                trans.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
            }
            finally
            {
                cmd.Dispose();
                connect.Close();
            }
        }
    }
}
