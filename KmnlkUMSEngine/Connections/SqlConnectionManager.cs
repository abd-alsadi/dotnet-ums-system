using KmnlkUMSEngine.Constants;
using KmnlkUMSEngine.Interfaces;
using KmnlkCommon.Shareds;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KmnlkCommon.Shareds.LoggerManagement;
using System.IO;

namespace KmnlkUMSEngine.Connections
{
    public class SqlConnectionManager :ConnectionManager
    {
     
        public SqlConnectionManager(string conn, ILog log)
        {
            typeDB= Enums.DB_TYPE.SQL;
            connectionString = conn;
            this.log = log;
        }
        public SqlConnectionManager(string ds,string db,ILog log, string user="sa",string pass="sa",bool auth=false,int time=100000)
        {
            this.typeDB = Enums.DB_TYPE.SQL;
            this.userID = user;
            this.password = pass;
            this.dataSource = ds;
            this.database = db;
            this.timeOut = time;
            this.auth = auth;
            this.log = log;
            if(auth)
            connectionString = @"Data Source=" + ds+ "; Initial Catalog =" + db+ "; User id =" + user+ "; password=" + pass;
            else
            connectionString = @"Data Source=" + ds + "; Initial Catalog =" + db + "; Integrated Security=SSPI";
        }
        public int Insert(string procedureName,List<SqlParameter> parameters)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), procedureName, ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
                 try
                {
                    conn.Open();
                    string transactionName = procedureName + "_" + modConstant.transactionDefaultName;
                    transaction = conn.BeginTransaction(transactionName);
                    string procedureWithpackageName = modConstant.packageProceduresName + "." + procedureName;
                    var command = new SqlCommand(procedureWithpackageName, conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = this.timeOut ;
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
                                            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
                 try
                        {
                            transaction.Rollback(procedureName);
                        }catch(Exception ee)
                        {

                        }
                    }
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.EXCEPTION,ENUM_TYPE_Block_LOGGER.END, e.Message);
                    conn.Close();
                    return -1;
                }
            }
        }
        public int Update(string procedureName, List<SqlParameter> parameters)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), procedureName, ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
                 try
                {
                    conn.Open();
                    string transactionName = procedureName + "_" + modConstant.transactionDefaultName;
                    transaction = conn.BeginTransaction(transactionName);
                    string procedureWithpackageName = modConstant.packageProceduresName + "." + procedureName;
                    var command = new SqlCommand(procedureWithpackageName, conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = this.timeOut;
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
                                            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
                 try
                        {
                            transaction.Rollback(procedureName);
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
        public int Delete(string procedureName, List<SqlParameter> parameters)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), procedureName, ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
                 try
                {
                    conn.Open();
                    string transactionName = procedureName + "_" + modConstant.transactionDefaultName;
                    transaction = conn.BeginTransaction(transactionName);
                    string procedureWithpackageName = modConstant.packageProceduresName + "." + procedureName;
                    var command = new SqlCommand(procedureWithpackageName, conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = this.timeOut;
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
                                            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
                 try
                        {
                            transaction.Rollback(procedureName);
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

        public KmnlkUMSModel Get(string procedureName, List<SqlParameter> parameters,IReaderSqlOperations IRSO)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), procedureName, ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
                 try
                {
                    conn.Open();
                    string procedureWithpackageName = modConstant.packageProceduresName + "." + procedureName;
                    var command = new SqlCommand(procedureWithpackageName, conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = this.timeOut;
                    parameters = FixParameters(parameters);
                    command.Parameters.AddRange(parameters.ToArray());
                    SqlDataReader reader = command.ExecuteReader();
                    KmnlkUMSModel model= IRSO.Read(reader);
                    conn.Close();
                    return model;
                }
                catch (Exception e)
                {
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.EXCEPTION,ENUM_TYPE_Block_LOGGER.END, e.Message);
                    conn.Close();
                    return null;
                }
            }
        }
        public List<KmnlkUMSModel> All(string procedureName, List<SqlParameter> parameters,IReaderSqlOperations IRSO)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), procedureName, ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
                 try
                {
                    conn.Open();
                    string procedureWithpackageName = modConstant.packageProceduresName + "." + procedureName;
                    var command = new SqlCommand(procedureWithpackageName, conn);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandTimeout = this.timeOut;
                    parameters = FixParameters(parameters);
                    command.Parameters.AddRange(parameters.ToArray());
                    SqlDataReader reader = command.ExecuteReader();
                    KmnlkUMSModel[] models = IRSO.ReadAll(reader);
                    conn.Close();
                    return models.ToList();
                }
                catch (Exception e)
                {
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.EXCEPTION,ENUM_TYPE_Block_LOGGER.END, e.Message);
                    conn.Close();
                    return null;
                }
            }
        }
        private List<SqlParameter> FixParameters(List<SqlParameter>  parameters)
        {
            foreach (var param in parameters)
            {
                if (param.Value == null)
                    param.Value = DBNull.Value;
            }
            return parameters;
        }
        public override void execute(string query) {
            using (var conn = new SqlConnection(connectionString))
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()),query, ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
                 try
                {
                    conn.Open();
                    var command = new SqlCommand(query, conn);
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
        public override void updateDB(string path) {
                                log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()),path, ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
                 try
            {
                StringBuilder st = new StringBuilder();
                st.Append(File.ReadAllText(path));
                execute(st.ToString());

            }catch(Exception e)
            {
                log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.EXCEPTION,ENUM_TYPE_Block_LOGGER.END, e.Message);
            }
        }
        public override void createDB(string path) {
                                log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), path, ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
                 try
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
