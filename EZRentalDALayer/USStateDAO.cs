using System;
using System.Collections.Generic;
using System.Data; //ADO.NET data access class
using System.Data.SqlClient; //Sql client provider

namespace EZRentalDALayer
{
    public class USStateDAO : IUserInterfaceDAO<USStateDTO>
    {
        public USStateDTO GetRecordByID(int key)
        {
            SqlConnection objSqlConnection = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                objSqlConnection.Open();

                string strSQL = "SELECT StateID, StateCode, StateName From USState WHERE StateID = @StateID;";

                SqlCommand objSqlCmd = new SqlCommand(strSQL, objSqlConnection);
                objSqlCmd.CommandType = CommandType.Text;

                objSqlCmd.Parameters.Add("@StateID", SqlDbType.TinyInt).Value = key;
                SqlDataReader objDR = objSqlCmd.ExecuteReader();

                if (objDR.HasRows)
                {
                    USStateDTO objUSStateDTO = new USStateDTO();

                    objUSStateDTO.StateID = objDR.GetByte(0);
                    objUSStateDTO.StateCode = objDR.GetString(1);
                    objUSStateDTO.StateName = objDR.GetString(2);

                    return objUSStateDTO;
                }
                //Terminate ADO objects
                objDR.Close();
                objDR = null;
                objSqlCmd.Dispose();
                objSqlCmd = null;
                //No data found
                return null;
            }
            catch (Exception objE)
            {
                throw new Exception("Exception in USStateDAO GetRecordByID Method: {0} " + objE.Message);
            }
            finally
            {
                objSqlConnection.Close();
                objSqlConnection.Dispose();
                objSqlConnection = null;
            }
        }

        public bool Insert(USStateDTO objDTO)
        {
            SqlConnection objSqlConnection = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                objSqlConnection.Open();

                string strSQL =
                    "INSERT INTO USState (StateID, StateCode, StateName)"
                    + " VALUES(@StateID, @StateCode, @StateName);";

                SqlCommand objSqlCmd = new SqlCommand(strSQL, objSqlConnection);
                objSqlCmd.CommandType = CommandType.Text;

                objSqlCmd.Parameters.Add("@StateID", SqlDbType.TinyInt).Value = objDTO.StateID;
                objSqlCmd.Parameters.Add("@StateCode", SqlDbType.Char).Value = objDTO.StateCode;
                objSqlCmd.Parameters.Add("@StateName", SqlDbType.VarChar).Value = objDTO.StateName;

                int intRecordsAffected = objSqlCmd.ExecuteNonQuery();

                if (intRecordsAffected == 1)
                {
                    return true;
                }
                //Terminate ADO objects
                objSqlCmd.Dispose();
                objSqlCmd = null;
                //No record inserted
                return false;
            }
            catch (Exception objE)
            {
                throw new Exception("Exception in USStateDAO Insert Method: {0} " + objE.Message);
            }
            finally
            {
                objSqlConnection.Close();
                objSqlConnection.Dispose();
                objSqlConnection = null;
            }
        }

        public bool Update(USStateDTO objDTO)
        {
            SqlConnection objSqlConnection = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                objSqlConnection.Open();

                string strSQL =  "UPDATE USState";
                strSQL = strSQL + " SET StateID = @StateID,";
                strSQL = strSQL + "StateCode = @StateCode,";
                strSQL = strSQL + "StateName = @StateName";
                strSQL = strSQL + " WHERE StateID = @StateID;";

                SqlCommand objSqlCmd = new SqlCommand(strSQL, objSqlConnection);
                objSqlCmd.CommandType = CommandType.Text;

                objSqlCmd.Parameters.Add("@StateID", SqlDbType.TinyInt).Value = objDTO.StateID;
                objSqlCmd.Parameters.Add("@StateCode", SqlDbType.Char).Value = objDTO.StateCode;
                objSqlCmd.Parameters.Add("@StateName", SqlDbType.VarChar).Value = objDTO.StateName;

                int intRecordsAffected = objSqlCmd.ExecuteNonQuery();

                if (intRecordsAffected == 1)
                {
                    return true;
                }
                //Terminate ADO objects
                objSqlCmd.Dispose();
                objSqlCmd = null;
                //No record updated
                return false;
            }
            catch (Exception objE)
            {

                throw new Exception("Exception in USStateDAO Update Method: {0} " + objE.Message);
            }
            finally
            {
                objSqlConnection.Close();
                objSqlConnection.Dispose();
                objSqlConnection = null;
            }
        }

        public bool Delete(int key)
        {
            SqlConnection objSqlConnection = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                objSqlConnection.Open();

                string strSQL = "DELETE FROM USState WHERE StateID = @StateID;";

                SqlCommand objSqlCmd = new SqlCommand(strSQL, objSqlConnection);
                objSqlCmd.CommandType = CommandType.Text;

                objSqlCmd.Parameters.Add("@StateID", SqlDbType.TinyInt).Value = key;

                int intAffectedRecords = objSqlCmd.ExecuteNonQuery();

                if(intAffectedRecords == 1)
                {
                    return true;
                }
                //Terminate ADO objects
                objSqlCmd.Dispose();
                objSqlCmd = null;
                //No record deleted
                return false;
            }
            catch(Exception objE)
            {
                throw new Exception("Exception in USStateDAO Delete Method: {0} " + objE.Message);
            }
            finally
            {
                objSqlConnection.Close();
                objSqlConnection.Dispose();
                objSqlConnection = null;
            }
        }

        public List<USStateDTO> GetAllRecords()
        {
            SqlConnection objSqlConnection = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                objSqlConnection.Open();

                string strSQL = "SELECT StateID, StateCode, StateName From USState;";

                SqlCommand objSqlCmd = new SqlCommand(strSQL, objSqlConnection);
                objSqlCmd.CommandType = CommandType.Text;

                SqlDataReader objDR = objSqlCmd.ExecuteReader();

                if(objDR.HasRows)
                {
                    List<USStateDTO> listUSState = new List<USStateDTO>();

                    while (objDR.Read())
                    {
                        USStateDTO objUSStateDTO = new USStateDTO();

                        objUSStateDTO.StateID = objDR.GetByte(0);
                        objUSStateDTO.StateCode = objDR.GetString(1);
                        objUSStateDTO.StateName = objDR.GetString(2);

                        listUSState.Add(objUSStateDTO);
                    }

                    return listUSState;
                }
                //Terminate ADO objects
                objDR.Close();
                objDR = null;
                objSqlCmd.Dispose();
                objSqlCmd = null;
                //No data found
                return null;
            }
            catch (Exception objE)
            {
                throw new Exception("Exception in USStateDAO GetAllRecords Method: {0} " + objE.Message);
            }
            finally
            {
                objSqlConnection.Close();
                objSqlConnection.Dispose();
                objSqlConnection = null;
            }
        }
    }
}
