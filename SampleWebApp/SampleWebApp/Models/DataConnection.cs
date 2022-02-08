using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SampleWebApp.Models
{
    public class DataConnection
    {
        static string CONNECTIONSTRING = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public List<Doctor> GetAllDoctors()
        {
            var list = new List<Doctor>();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    con.Open();
                    SqlCommand sqlCmd = con.CreateCommand();
                    sqlCmd.CommandText = "SELECT * FROM DOCTOR";
                    var reader = sqlCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var doc = new Doctor();
                        doc.Id = Convert.ToInt32(reader[0]);
                        doc.DocName = reader[1].ToString();
                        doc.Specialization = reader[2].ToString();
                        doc.HospitalName = reader[3].ToString();
                        doc.City = reader[4].ToString();
                        doc.Contact = reader[5].ToString();
                        list.Add(doc);
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            return list;
        }
        public Doctor FindEmployee(int id)
        {
            Doctor doc = new Doctor();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    con.Open();
                    var cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT * FROM DOCTOR WHERE ID = " + id;
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        doc.Id = Convert.ToInt32(reader[0]);
                        doc.DocName = reader[1].ToString();
                        doc.Specialization = reader[2].ToString();
                        doc.HospitalName = reader[3].ToString();
                        doc.City = reader[4].ToString();
                        doc.Contact = reader[5].ToString();
                    }
                    else
                        throw new Exception("No Doctor Found");
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
            return doc;
        }
        public void Update(Doctor doc)
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                var query = $"UPDATE DOCTOR SET DocName = '{doc.DocName}', Specialization = '{doc.Specialization}', HospitalName = '{doc.HospitalName}', City = '{doc.City}', Contact = '{doc.Contact}' WHERE id = {doc.Id}";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("No Details were Updated!");
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public void AddNewDoctor(Doctor doc)
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                var query = "INSERT INTO DOCTOR VALUES(@id, @name, @specialization, @hospital, @city, @contact)";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.Parameters.AddWithValue("@id", doc.Id);
                cmd.Parameters.AddWithValue("@name", doc.DocName);
                cmd.Parameters.AddWithValue("@specialization", doc.Specialization);
                cmd.Parameters.AddWithValue("@hospital", doc.HospitalName);
                cmd.Parameters.AddWithValue("@city", doc.City);
                cmd.Parameters.AddWithValue("@contact", doc.Contact);
                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("Doctor not added!");
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public void RemoveDoctor(int id)
        {
            Doctor doc = new Doctor();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                try
                {
                    con.Open();
                    var cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM DOCTOR WHERE ID = " + id;
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows == 0)
                        throw new Exception("Cannot Remove Doctor");
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}