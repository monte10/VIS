using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection.Database
{
    class Databaze
    {
        private OracleConnection Connection { get; set; }
        private OracleTransaction SqlTransaction { get; set; }
        public string Language { get; set; }

        //private String conStr = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=dbsys.cs.vsb.cz)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=oracle.dbsys.cs.vsb.cz)));User Id=hor0402;Password=scA4jTKbVF;Connection Timeout=45;";

        public Databaze()
        {
            Connection = new OracleConnection();
            Language = "en";
        }


        public bool Connect(String conString)
        {
            if (Connection.State != System.Data.ConnectionState.Open)
            {
                Connection.ConnectionString = conString;
                Connection.Open();
            }
            return true;
        }


        public bool Connect()
        {
            bool ret = true;

            if (Connection.State != System.Data.ConnectionState.Open)
            {
                //ret = Connect(ConfigurationManager.ConnectionStrings["ConnectionStringOracle"].ConnectionString);
                ret = Connect("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=dbsys.cs.vsb.cz)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=oracle.dbsys.cs.vsb.cz)));User Id=hor0402;Password=kZtothRHMv;Connection Timeout=45;");
            }

            return ret;
        }

        public void Close()
        {
            Connection.Close();
        }

        public OracleTransaction BeginTransaction()
        {
            SqlTransaction = Connection.BeginTransaction(IsolationLevel.Serializable);
            return SqlTransaction;
        }

        public void EndTransaction()
        {
            SqlTransaction.Commit();
            Close();
        }

        public OracleConnection GetConnection()
        {
            return new OracleConnection();
        }

        public void Rollback()
        {
            SqlTransaction.Rollback();
        }


        public int ExecuteNonQuery(OracleCommand command)
        {
            int rowNumber = 0;
            try
            {
                rowNumber = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Close();
            }
            return rowNumber;
        }

        public OracleCommand CreateCommand(string strCommand)
        {
            OracleCommand command = new OracleCommand(strCommand, Connection);

            if (SqlTransaction != null)
            {
                command.Transaction = SqlTransaction;
            }
            return command;
        }

        public OracleDataReader Select(OracleCommand command)
        {
            OracleDataReader sqlReader = command.ExecuteReader();
            return sqlReader;
        }
    }
}
