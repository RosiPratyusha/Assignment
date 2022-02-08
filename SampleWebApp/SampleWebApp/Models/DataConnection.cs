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
    }
}