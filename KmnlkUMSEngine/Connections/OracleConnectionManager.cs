using KmnlkUMSEngine.Constants;
using KmnlkUMSEngine.Interfaces;
using KmnlkCommon.Shareds;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KmnlkCommon.Shareds.LoggerManagement;
using System.IO;

namespace KmnlkUMSEngine.Connections
{
    public class OracleConnectionManager :ConnectionManager
    {

        public OracleConnectionManager(string conn, ILog log)
        {
            typeDB = Enums.DB_TYPE.ORACLE;
            connectionString = conn;
            this.log = log;
        }
        public OracleConnectionManager(string ds, string db, ILog log,string user = "sa", string pass = "sa", bool auth = false, int time = 100000)
        {
            this.typeDB = Enums.DB_TYPE.ORACLE;
            this.userID = user;
            this.password = pass;
            this.dataSource = ds;
            this.database = db;
            this.timeOut = time;
            this.auth = auth;
            this.log = log;
            if (auth)
                connectionString = @"Data Source=" + ds + "; Initial Catalog =" + db + "; User id =" + user + "; password=" + pass;
            else
                connectionString = @"Data Source=" + ds + "; Initial Catalog =" + db + "; Integrated Security=SSPI";
        }
        public int Insert(string procedureName,List<OracleParameter> parameters)
        {
            using (var conn = new OracleConnection(connectionString))
            {
                OracleTransaction transaction = null;
                log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), procedureName, ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    string procedureWithpackageName = modConstant.packageProceduresName + "." + procedureName;
                    var command = new OracleCommand(procedureWithpackageName, conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = timeOut;
                    parameters = FixParameters(parameters);
                    command.Parameters.AddRange(parameters.ToArray());
                    command.Transaction = transaction;
                    int result=command.ExecuteNonQuery();
                    transaction.Commit();
                    conn.Close();
                    return result;
                }
                catch(Exception e)
                {
                    if (transaction != null)
                    {
                        log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ee)
                        {

                        }
                    }
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.EXCEPTION,ENUM_TYPE_Block_LOGGER.END, e.Message);
                    conn.Close();
                    return -1;
                }
            }
        }
        public int Update(string procedureName, List<OracleParameter> parameters)
        {
            using (var conn = new OracleConnection(connectionString))
            {
                OracleTransaction transaction = null;
                log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), procedureName, ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    string procedureWithpackageName = modConstant.packageProceduresName + "." + procedureName;
                    var command = new OracleCommand(procedureWithpackageName, conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = timeOut;
                    parameters = FixParameters(parameters);
                    command.Parameters.AddRange(parameters.ToArray());
                    command.Transaction = transaction;
                    int result = command.ExecuteNonQuery();
                    transaction.Commit();
                    conn.Close();
                    return result;
                }
                catch (Exception e)
                {
                    if (transaction != null)
                    {
                        log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ee)
                        {

                        }
                    }
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.EXCEPTION,ENUM_TYPE_Block_LOGGER.END, e.Message);
                    conn.Close();
                    return -1;
                }
            }
        }
        public int Delete(string procedureName, List<OracleParameter> parameters)
        {
            using (var conn = new OracleConnection(connectionString))
            {
                OracleTransaction transaction = null;
                log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), procedureName, ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    string procedureWithpackageName = modConstant.packageProceduresName + "." + procedureName;
                    var command = new OracleCommand(procedureWithpackageName, conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = timeOut;
                    parameters = FixParameters(parameters);
                    command.Parameters.AddRange(parameters.ToArray());
                    command.Transaction = transaction;
                    int result = command.ExecuteNonQuery();
                    transaction.Commit();
                    conn.Close();
                    return result;
                }
                catch (Exception e)
                {
                    if (transaction != null)
                    {
                        log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ee)
                        {

                        }
                    }
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.EXCEPTION,ENUM_TYPE_Block_LOGGER.END, e.Message);
                    conn.Close();
                    return -1;
                }
            }
        }

        public KmnlkUMSModel Get(string procedureName, List<OracleParameter> parameters, IReaderOracleOperations IROO)
        {
            using (var conn = new OracleConnection(connectionString))
            {
                log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), procedureName, ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
                try
                {
                    conn.Open();
                    string procedureWithpackageName = modConstant.packageProceduresName + "." + procedureName;
                    var command = new OracleCommand(procedureWithpackageName, conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = timeOut;
                    parameters = FixParameters(parameters);
                    command.Parameters.AddRange(parameters.ToArray());
                    KmnlkUMSModel result = IROO.Read(command.ExecuteReader());
                    conn.Close();
                    return result;
                }
                catch (Exception e)
                {
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.EXCEPTION,ENUM_TYPE_Block_LOGGER.END, e.Message);
                    conn.Close();
                    return null;
                }
            }
        }
        public List<KmnlkUMSModel> All(string procedureName, List<OracleParameter> parameters,IReaderOracleOperations IROO)
        {
            using (var conn = new OracleConnection(connectionString))
            {
                log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), procedureName, ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
                try
                {
                    conn.Open();
                    string procedureWithpackageName = modConstant.packageProceduresName + "." + procedureName;
                    var command = new OracleCommand(procedureWithpackageName, conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = timeOut;
                    parameters = FixParameters(parameters);
                    command.Parameters.AddRange(parameters.ToArray());
                    KmnlkUMSModel[] result = IROO.ReadAll(command.ExecuteReader());
                    conn.Close();
                    return result.ToList();
                }
                catch (Exception e)
                {
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.EXCEPTION,ENUM_TYPE_Block_LOGGER.END, e.Message);
                    conn.Close();
                    return null;
                }
            }
        }
        private List<OracleParameter> FixParameters(List<OracleParameter> parameters)
        {
            foreach (var param in parameters)
            {
                if (param.Value == null)
                    param.Value = DBNull.Value;
            }
            return parameters;
        }
        public override void execute(string query)
        {
            using (var conn = new OracleConnection(connectionString))
            {
                log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), query, ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); try
                {
                    conn.Open();
                    var command = new OracleCommand(query, conn);
                    command.CommandTimeout = this.timeOut;
                    int result = command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.EXCEPTION,ENUM_TYPE_Block_LOGGER.END, e.Message);
                    conn.Close();
                }
            }
        }
        public override void updateDB(string path)
        {
            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), path, ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); try
            {
                StringBuilder st = new StringBuilder();
                st.Append(File.ReadAllText(path));
                execute(st.ToString());

            }
            catch (Exception e)
            {
                log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.EXCEPTION,ENUM_TYPE_Block_LOGGER.END, e.Message);
            }
        }
        public override void createDB(string path)
        {
            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), path, ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); try
            {
                StringBuilder st = new StringBuilder();
                st.Append(File.ReadAllText(path));
                execute(st.ToString());

            }
            catch (Exception e)
            {
                log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.EXCEPTION,ENUM_TYPE_Block_LOGGER.END, e.Message);
            }
        }
    }
}
