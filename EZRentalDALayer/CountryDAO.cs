using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //ADO.NET Data Access Classes
using System.Data.SqlClient; //SQL Client Provider

namespace EZRentalDALayer
{
    public class CountryDAO : IUserInterfaceDAO<CountryDTO>
    {
        public CountryDTO GetRecordByID(int key)
        {
            SqlConnection objSqlConnection = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                objSqlConnection.Open();
                string strSQL = "SELECT CountryID, CountryCode2, CountryCode3, CountryName, NumericCode FROM Country WHERE CountryID = @CountryID;";

                SqlCommand objSqlCommand = new SqlCommand(strSQL, objSqlConnection);
                objSqlCommand.CommandType = CommandType.Text;

                objSqlCommand.Parameters.Add("@CountryID", SqlDbType.TinyInt).Value = key;

                SqlDataReader sqlDR = objSqlCommand.ExecuteReader();

                if (sqlDR.HasRows)
                {
                    CountryDTO objCountryDTO = new CountryDTO();

                    objCountryDTO.CountryID = sqlDR.GetByte(0);
                    objCountryDTO.CountryCode2 = sqlDR.GetString(1);
                    objCountryDTO.CountryCode3 = sqlDR.GetString(2);
                    objCountryDTO.CountryName = sqlDR.GetString(3);
                    objCountryDTO.NumericCode = sqlDR.GetInt16(4);

                    return objCountryDTO;
                }
                //Terminate ADO objects
                sqlDR.Close();
                sqlDR = null;
                objSqlCommand.Dispose();
                objSqlCommand = null;
                //No data found
                return null;
            }
            catch (Exception objE)
            {
                throw new Exception("Exception in CountryDAO GetRecordByID Method: {0} " + objE.Message);
            }
            finally
            {
                objSqlConnection.Close();
                objSqlConnection.Dispose();
                objSqlConnection = null;
            }
        
        }

        public bool Insert(CountryDTO objDTO)
        {
            SqlConnection objSqlConnection = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                string strSQL =
                    "INSERT INTO Country (CountryID, CountryCode2, CountryCode3, CountryName, NumericCode)"
                    + " VALUES(@CountryID, @CountryCode2, @CountryCode3, @CountryName, @NumericCode);";

                SqlCommand objSqlCommand = new SqlCommand(strSQL, objSqlConnection);
                objSqlCommand.CommandType = CommandType.Text;

                objSqlCommand.Parameters.Add("@CountryID", SqlDbType.TinyInt).Value = objDTO.CountryID;
                objSqlCommand.Parameters.Add("@CountryCode2", SqlDbType.Char).Value = objDTO.CountryCode2;
                objSqlCommand.Parameters.Add("@CountryCode3", SqlDbType.Char).Value = objDTO.CountryCode3;
                objSqlCommand.Parameters.Add("@CountryName", SqlDbType.VarChar).Value = objDTO.CountryName;
                objSqlCommand.Parameters.Add("@NumericCode", SqlDbType.SmallInt).Value = objDTO.NumericCode;

                int intintRecordsAffected = objSqlCommand.ExecuteNonQuery();

                if(intintRecordsAffected == 1)
                {
                    return true;
                }
                //Terminate ADO objects
                objSqlCommand.Dispose();
                objSqlCommand = null;
                //No record inserted
                return false;
            }
            catch (Exception objE)
            {
                throw new Exception("Exception in CountryDAO Insert Method: {0} " + objE.Message);
            }
            finally
            {
                objSqlConnection.Close();
                objSqlConnection.Dispose();
                objSqlConnection = null;
            }
        }

        public bool Update(CountryDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int key)
        {
            SqlConnection objSqlConnection = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                objSqlConnection.Open();

                string strSQL = "DELETE FROM Country WHERE CountryID = @CountryID";

                SqlCommand objSqlCommand = new SqlCommand(strSQL, objSqlConnection);
                objSqlCommand.CommandType = CommandType.Text;

                int intintRecordsAffected = objSqlCommand.ExecuteNonQuery();

                if (intintRecordsAffected == 1)
                {         
                    return true;
                }

                //Terminate ADO objects
                objSqlCommand.Dispose();
                objSqlCommand = null;
                //No record deleted
                return false;
            }
            catch (Exception objE)
            {
                throw new Exception("Exception in CountryDAO Update Method: {0} " + objE.Message);
            }
            finally
            {
                objSqlConnection.Close();
                objSqlConnection.Dispose();
                objSqlConnection = null;
            }
        }

        public List<CountryDTO> GetAllRecords()
        {
            SqlConnection objSqlConnection = new SqlConnection(SQLServerDAOFactory.ConnectionString());

            try
            {
                objSqlConnection.Open();

                string strSQL = "SELECT CountryID, CountryCode2, CountryCode3, CountryName, NumericCode FROM Country";

                SqlCommand objSqlCommand = new SqlCommand(strSQL, objSqlConnection);
                objSqlCommand.CommandType = CommandType.Text;

                SqlDataReader sqlRD = objSqlCommand.ExecuteReader();

                if (sqlRD.HasRows)
                {
                    List<CountryDTO> objListDTO = new List<CountryDTO>();

                    while (sqlRD.Read()) 
                    {
                        CountryDTO objCountryDTO = new CountryDTO();

                        objCountryDTO.CountryID = sqlRD.GetByte(0);
                        objCountryDTO.CountryCode2 = sqlRD.GetString(1);
                        objCountryDTO.CountryCode3 = sqlRD.GetString(2);
                        objCountryDTO.CountryName = sqlRD.GetString(3);
                        objCountryDTO.NumericCode = sqlRD.GetInt16(4);

                        objListDTO.Add(objCountryDTO);
                    }

                    return objListDTO;
                }
                //Terminate ADO objects
                sqlRD.Close();
                sqlRD = null;
                objSqlCommand.Dispose();
                objSqlCommand = null;
                //No records found
                return null;
            }
            catch (Exception objE)
            {
                throw new Exception("Exception in CountryDAO GetAllRecords Method: {0} " + objE.Message);
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
