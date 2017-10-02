using PWEAirBnB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PWEAirBnB.DAL
{
    /// <summary>
    /// Responsible for communicating with the database for basic CRUD
    /// </summary>
    public class RoomRepository : BaseRepository
    {
        public void SaveRoom(Room room)
        {
            //save it to the database
            //1. Create and configurate the connection
            SqlConnection connection = CreateConnection();

            try
            {
                connection.Open();
                //2. Create and configurate the command
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Room (Name, Description, RoomNumber) values('" + room.Name + "', '" + room.Description + "', " + room.RoomNumber + ")";
                //3. Execute the command - the INSERT statement
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //do some logging or something here
            }
            //Finally is always runned after the try or the catch
            finally
            {
                connection.Close();
            }
            
        }

        public List<Room> LoadAllRooms()
        {
            //create a result variable of type list
            List<Room> result = new List<Room>();
            SqlConnection connection = CreateConnection();
            try
            {
                connection.Open();
                //2. Create and configurate the command
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT Id, Name, Description, RoomNumber from Room";
                //3. Create SqlDataReader to get the data
                SqlDataReader reader = command.ExecuteReader();
                //4. Read as long as there is data in the reader
                while (reader.Read())
                {
                    //create a room and add it to a list
                    Room room = new Room();
                    room.Id = reader.GetInt32(0);
                    room.Name = reader.GetString(1);
                    room.Description = reader.GetString(2);
                    room.RoomNumber = reader.GetInt32(3);
                    //add it to the list
                    result.Add(room);
                }


            }
            catch (Exception ex)
            {
                //do some logging or something here
            }
            //Finally is always runned after the try or the catch
            finally
            {
                connection.Close();
            }
            return result;
        }

        public void UpdateRoom(Room room)
        {
            //update the value to the database
            //1. Create and configurate the connection
            SqlConnection connection = CreateConnection();
            try
            {
                connection.Open();
                //2. Create and configurate the command
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "UPDATE ROOM set Name ='"+room.Name+ "', Description ='" + room.Description + "', RoomNumber=" + room.RoomNumber + " WHERE ID = " + room.Id;
                //3. Execute the command - the UPDATE statement
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //do some logging or something here
            }
            //Finally is always runned after the try or the catch
            finally
            {
                connection.Close();
            }
        }

        public Room LoadRoom(int id)
        {
            Room result = new Room();
            SqlConnection connection = CreateConnection();
            try
            {
                connection.Open();
                //2. Create and configurate the command
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT Id, Name, Description, RoomNumber from Room WHERE Id = " + id;
                //3. Create SqlDataReader to get the data
                SqlDataReader reader = command.ExecuteReader();
                //4. Read as long as there is data in the reader
                reader.Read();
                    //create a room
                    Room room = new Room();
                    room.Id = reader.GetInt32(0);
                    room.Name = reader.GetString(1);
                    room.Description = reader.GetString(2);
                    room.RoomNumber = reader.GetInt32(3);
                //return a room
                result = room;
            }
            catch (Exception ex)
            {
                //do some logging or something here
            }
            //Finally is always runned after the try or the catch
            finally
            {
                connection.Close();
            }
            return result;
        }

        public void DeleteRoom(int id)
        {
            //delete the room from the database
            //1. Create and configurate the connection
            SqlConnection connection = CreateConnection();
            try
            {
                connection.Open();
                //2. Create and configurate the command
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "DELETE FROM ROOM WHERE Id = " + id;
                //3. Execute the command - the DELETE statement
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //do some logging or something here
            }
            //Finally is always runned after the try or the catch
            finally
            {
                connection.Close();
            }
        }

    }
}