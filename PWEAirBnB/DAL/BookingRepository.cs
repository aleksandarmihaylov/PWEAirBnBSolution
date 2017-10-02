using PWEAirBnB.Models;
using PWEAirBnB.Utilts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PWEAirBnB.DAL
{
    public class BookingRepository : BaseRepository
    {
        public void SaveBooking(Booking booking)
        {
            SqlConnection connection = CreateConnection();

            try
            {
                //Defending SQL injections
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT into Booking (StartTime, EndTime, RoomId) values(@starttime, @endtime, @roomid)";
                command.Parameters.Add("@starttime", SqlDbType.DateTime).Value = booking.StartTime;
                command.Parameters.Add("@endtime", SqlDbType.DateTime).Value = booking.EndTime;
                command.Parameters.Add("@roomid", SqlDbType.Int).Value = booking.RoomId;

                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Log.LogException(ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Booking> LoadAllBookings()
        {
            //create the result
            List<Booking> allBookings = new List<Booking>();
            SqlConnection connection = CreateConnection();
            try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT RoomId,StartTime,EndTime FROM Booking";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Booking booking = new Booking();
                    booking.RoomId = reader.GetInt32(0);
                    booking.StartTime = reader.GetDateTime(1);
                    booking.EndTime = reader.GetDateTime(2);
                    // add it to the list for return
                    allBookings.Add(booking);
                }
            }
            catch(Exception ex)
            {
                Log.LogException(ex);
            }
            finally
            {
                connection.Close(); 
            }
            return allBookings;
        }
    }
}