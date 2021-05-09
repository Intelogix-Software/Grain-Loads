using Main.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.SQL
{
    class SQlCon
    {
        public DataTable sendPickupToSQL(GrainLoadPickup u)
        {
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(Properties.Settings.Default.SqlConQuery))
                try
                {
                    using (var command = new SqlCommand("Update_GrainLoads_Pickup", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        conn.Open();
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@id_GrainLoad", (object)u.id_grainload?? DBNull.Value);
                        command.Parameters.AddWithValue("id_customer", u.id_customer);
                        command.Parameters.AddWithValue("@ID_Pickup_Location", u.id_pickup_location);
                        command.Parameters.AddWithValue("@ID_GrainType", u.id_grainType);
                        command.Parameters.AddWithValue("@ID_Driver", u.id_driver);
                        command.Parameters.AddWithValue("@who", u.id_who);
                        command.Parameters.AddWithValue("@regdate", u.regdate);
                        command.Parameters.AddWithValue("@Release", u.release);
                        command.Parameters.AddWithValue("@Factura", u.factura);
                        command.Parameters.AddWithValue("@Pickup_Date", u.pickup_date);
                        command.Parameters.AddWithValue("@Pickup_Ticket", u.pickup_ticket);
                        command.Parameters.AddWithValue("@Gross_Pickup", u.gross_pickup);
                        command.Parameters.AddWithValue("@Tare_Pickup", u.tare_pickup);
                        command.Parameters.AddWithValue("@Neto_Pickup ", u.neto_pickup);
                        var Smsg = command.Parameters.Add("msg", SqlDbType.VarChar);
                        Smsg.Direction = ParameterDirection.ReturnValue;
                        var IDS = command.Parameters.Add("ID", SqlDbType.VarChar);
                        IDS.Direction = ParameterDirection.ReturnValue;
                        var Val = command.Parameters.Add("Validacion", SqlDbType.VarChar);
                        Val.Direction = ParameterDirection.ReturnValue;
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            dt.Load(dr);
                        }
                        conn.Close();
                    }
                    //Console.WriteLine(dt.Rows[0].ItemArray[1].ToString()+"+");
                }
                catch (SqlException a)
                {
                    Console.WriteLine("The process failed: {0}", a.ToString());
                }
            return dt;
        }
        public DataTable sendDeliveryToSQL(GrainLoadPickup u)
        {
            DataTable dt = new DataTable();




            return dt;
        }
    }
}
