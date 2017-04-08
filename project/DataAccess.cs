using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace project
{
    public class DataAccess

    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Books> GetBook()
        {
            List<Books> lastbook = new List<Books>();
            try
            {
                SqlConnection conn = new SqlConnection("Data source=HOMEPC;initial catalog=MAP; integrated security=true");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Books ", conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lastbook.Add(new Books()
                    {
                        Bookid = rd.GetInt32(0),
                        Name = rd.GetString(1),
                        price = rd.GetInt32(2),
                        Edition = rd.GetInt32(3)
                    });

                }

                return lastbook;

            }
            catch (Exception)
            {

                throw;
            }

           
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="price"></param>
        /// <param name="Edition"></param>
        public void URcadd  (string Name, int price, int Edition)
            {
            SqlConnection cn = new SqlConnection("data source= HOMEPC; initial catalog=MAP; integrated security= true");
            cn.Open();
            SqlCommand cmd = new SqlCommand("urces", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = Name;
            cmd.Parameters.Add("@price", SqlDbType.Int).Value = price;
            cmd.Parameters.Add("@edition", SqlDbType.Int).Value = Edition;
            cmd.ExecuteNonQuery();
        }
       
        
/*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="BookId"></param>
        /// <param name="Name"></param>
        /// <param name="price"></param>
        /// <param name="Edition"></param>
        public void update(int BookId ,string Name ,int price ,int Edition)
        {
            SqlConnection cn = null;
            {
                try
                    
                {
                   
                     cn = new SqlConnection("data source= HOMEPC; initial catalog=MAP; integrated security= true");
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select * from Books", cn);
                   // cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("Bookid", SqlDbType.Int).Value = BookId;
                    cmd.Parameters.Add("Name", SqlDbType.VarChar, 50).Value = Name;
                    cmd.Parameters.Add("price", SqlDbType.Int).Value = price;
                    cmd.Parameters.Add("Edition", SqlDbType.Int).Value = Edition;
                    cmd.ExecuteNonQuery();


                }
                catch (Exception)
                {

                }
                finally
                {
                    cn.Close();
                }
               
            }*/
            
            
        }
    }
