using KmnlkUMSEngine.Constants;
using KmnlkUMSEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KmnlkUMSEngine.Connections;
using KmnlkUMSEngine.Models;
using KmnlkCommon.Shareds;
using System.Data.OracleClient;
using static KmnlkCommon.Shareds.LoggerManagement;
using KmnlkUMSEngine.Exceptions;

namespace KmnlkUMSEngine.Managers
{
    public class DepartmentPrivilageManager : ModelManager, ICURDOperations, IReaderSqlOperations , IReaderOracleOperations, IValidationOperations
    {
        public ConnectionManager connectionManager;
        public ILog log;
        
        public DepartmentPrivilageManager(ConnectionManager CM,ILog logger)
        {
            connectionManager = CM;
            log = logger;
        }

        public List<KmnlkUMSModel> All(KmnlkUMSModel model)
        {
            if (!isValid(model))
            {
                return null;
            }
            clsDepartmentPrivilage instance = (clsDepartmentPrivilage)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.GetAlldepartmentsprivilages, ts,this);
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END,modConstant.MSG_SUCCESS);
                    return result;
                }catch(Exception e)
                {
                    new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                    return null;
                }
            }
            else
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    OracleConnectionManager manager = (OracleConnectionManager)connectionManager;
                    List<OracleParameter> ts = new List<OracleParameter>();
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.GetAlldepartmentsprivilages, ts,this);
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                    return result;
                }
                catch (Exception e)
                {
                    new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                    return null;
                }
            }
        }

        public KmnlkUMSModel Get(KmnlkUMSModel model)
        {
            if (!isValid(model))
            {
                return null;
            }
            clsDepartmentPrivilage instance = (clsDepartmentPrivilage)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@flduid", Value = instance.fldUid });
                    KmnlkUMSModel result = manager.Get(PROCEDURES.GetdepartmentprivilageById, ts,this);
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                    return result;
                }
                catch(Exception e)
                {
                    new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                    return null;
                }
            }
            else
            {

                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    OracleConnectionManager manager = (OracleConnectionManager)connectionManager;
                    List<OracleParameter> ts = new List<OracleParameter>();
                    ts.Add(new OracleParameter() { ParameterName = "@flduid", Value = instance.fldUid });
                    KmnlkUMSModel result = manager.Get(PROCEDURES.GetdepartmentprivilageById, ts,this);
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid=" + instance.fldUid + "}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                    return result;
                }
                catch (Exception e)
                {
                    new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                    return null ;
                }
            }
        }
        public List<KmnlkUMSModel> GetByPrivilage(KmnlkUMSModel model)
        {
            if (!isValid(model))
            {
                return null;
            }
            clsDepartmentPrivilage instance = (clsDepartmentPrivilage)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@fldprivilageuid", Value = instance.fldPrivilageUid });
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.GetdepartmentsprivilagesByprivilageId, ts, this);
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid=" + instance.fldUid + "}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                    return result;
                }
                catch (Exception e)
                {
                    new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                    return null;
                }
            }
            else
            {

                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    OracleConnectionManager manager = (OracleConnectionManager)connectionManager;
                    List<OracleParameter> ts = new List<OracleParameter>();
                    ts.Add(new OracleParameter() { ParameterName = "@fldprivilageuid", Value = instance.fldPrivilageUid });
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.GetdepartmentsprivilagesByprivilageId, ts, this);
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid=" + instance.fldUid + "}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                    return result;
                }
                catch (Exception e)
                {
                    new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                    return null;
                }
            }
        }

        public int Delete(KmnlkUMSModel model)
        {
            if (!isValid(model))
            {
                return -1;
            }
            clsDepartmentPrivilage instance = (clsDepartmentPrivilage)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@flduid", Value = instance.fldUid });
                    int result = manager.Delete(PROCEDURES.Deletedepartmentprivilage, ts);
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                    return result;
                }
                catch (Exception e)
                {
                    new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                    return -1;
                }
            }
            else
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    OracleConnectionManager manager = (OracleConnectionManager)connectionManager;
                    List<OracleParameter> ts = new List<OracleParameter>();
                    ts.Add(new OracleParameter() { ParameterName = "@flduid", Value = instance.fldUid });
                    int result = manager.Delete(PROCEDURES.Deletedepartmentprivilage, ts);
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                    return result;
                }
                catch (Exception e)
                {
                    new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                    return -1;
                }
            }
        }
        public List<KmnlkUMSModel> Find(int size, int page, KmnlkUMSModel model)
        {
            if (!isValid(model))
            {
                return null;
            }
            clsDepartmentPrivilage instance = (clsDepartmentPrivilage)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@size", Value = size, DbType = DbType.Int64 });
                    ts.Add(new SqlParameter() { ParameterName = "@page", Value = page, DbType = DbType.Int64 });
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.FindAlldepartmentsprivilages, ts, this);
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                    return result;
                }
                catch (Exception e)
                {
                    new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                    return null;
                }
            }
            else
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    OracleConnectionManager manager = (OracleConnectionManager)connectionManager;
                    List<OracleParameter> ts = new List<OracleParameter>();
                    ts.Add(new OracleParameter() { ParameterName = "@size", Value = size, DbType = DbType.Int64 });
                    ts.Add(new OracleParameter() { ParameterName = "@page", Value = page, DbType = DbType.Int64 });
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.FindAlldepartmentsprivilages, ts, this);
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                    return result;
                }
                catch (Exception e)
                {
                    new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                    return null;
                }
            }
        }
        public int Insert(KmnlkUMSModel model)
        {
            if (!isValid(model))
            {
                return -1;
            }
            clsDepartmentPrivilage instance = (clsDepartmentPrivilage)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@fldDepartmentuid", Value = instance.fldDepartmentUid });
                    ts.Add(new SqlParameter() { ParameterName = "@fldprivilageuid", Value = instance.fldPrivilageUid });
                    ts.Add(new SqlParameter() { ParameterName = "@fldattributes", Value = instance.fldAttributes, SqlDbType = SqlDbType.Decimal });
                    ts.Add(new SqlParameter() { ParameterName = "@fldflags", Value = instance.fldFlags, SqlDbType = SqlDbType.BigInt });
                    ts.Add(new SqlParameter() { ParameterName = "@fldcreated", Value = instance.fldCreated });
                    ts.Add(new SqlParameter() { ParameterName = "@fldupdated", Value = instance.fldUpdated });
                    int result = manager.Insert(PROCEDURES.Adddepartmentprivilage, ts);
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{result="+result.ToString()+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                    return result;
                }catch (Exception e)
                {
                    new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                    return -1;
                }
            }
            else
            {

                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    OracleConnectionManager manager = (OracleConnectionManager)connectionManager;
                    List<OracleParameter> ts = new List<OracleParameter>();
                    ts.Add(new OracleParameter() { ParameterName = "@fldDepartmentuid", Value = instance.fldDepartmentUid });
                    ts.Add(new OracleParameter() { ParameterName = "@fldprivilageuid", Value = instance.fldPrivilageUid });
                    ts.Add(new OracleParameter() { ParameterName = "@fldattributes", Value = instance.fldAttributes, DbType = DbType.Decimal });
                    ts.Add(new OracleParameter() { ParameterName = "@fldflags", Value = instance.fldFlags, DbType = DbType.Int64 });
                    ts.Add(new OracleParameter() { ParameterName = "@fldcreated", Value = instance.fldCreated });
                    ts.Add(new OracleParameter() { ParameterName = "@fldupdated", Value = instance.fldUpdated });
                    int result = manager.Insert(PROCEDURES.Adddepartmentprivilage, ts);
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{result=" + result.ToString() + "}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                    return result;
                }
                catch (Exception e)
                {
                    new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                    return -1;
                }
            }
        }

        public int Update(KmnlkUMSModel model)
        {
            if (!isValid(model))
            {
                return -1;
            }
            clsDepartmentPrivilage instance = (clsDepartmentPrivilage)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@flduid", Value = instance.fldUid });
                    ts.Add(new SqlParameter() { ParameterName = "@fldDepartmentuid", Value = instance.fldDepartmentUid });
                    ts.Add(new SqlParameter() { ParameterName = "@fldprivilageuid", Value = instance.fldPrivilageUid });
                    ts.Add(new SqlParameter() { ParameterName = "@fldattributes", Value = instance.fldAttributes, SqlDbType = SqlDbType.Decimal });
                    ts.Add(new SqlParameter() { ParameterName = "@fldflags", Value = instance.fldFlags, SqlDbType = SqlDbType.BigInt });
                    //ts.Add(new SqlParameter() { ParameterName = "@fldcreated", Value = instance.fldCreated });
                    ts.Add(new SqlParameter() { ParameterName = "@fldupdated", Value = instance.fldUpdated });
                    int result = manager.Update(PROCEDURES.Editdepartmentprivilage, ts);
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{result=" + result.ToString() + "}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                    return result;
                }catch(Exception e)
                {
                    new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                    return -1;
                }
            }
            else
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    OracleConnectionManager manager = (OracleConnectionManager)connectionManager;
                    List<OracleParameter> ts = new List<OracleParameter>();
                    ts.Add(new OracleParameter() { ParameterName = "@flduid", Value = instance.fldUid });
                    ts.Add(new OracleParameter() { ParameterName = "@fldDepartmentuid", Value = instance.fldDepartmentUid });
                    ts.Add(new OracleParameter() { ParameterName = "@fldprivilageuid", Value = instance.fldPrivilageUid });
                    ts.Add(new OracleParameter() { ParameterName = "@fldattributes", Value = instance.fldAttributes, DbType = DbType.Decimal });
                    ts.Add(new OracleParameter() { ParameterName = "@fldflags", Value = instance.fldFlags, DbType = DbType.Int64 });
                    //ts.Add(new OracleParameter() { ParameterName = "@fldcreated", Value = instance.fldCreated });
                    ts.Add(new OracleParameter() { ParameterName = "@fldupdated", Value = instance.fldUpdated });

                    int result = manager.Update(PROCEDURES.Editdepartmentprivilage, ts);
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{result=" + result.ToString() + "}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                    return result;
                }
                catch (Exception e)
                {
                    new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                    return -1;
                }
            }
        }

        public KmnlkUMSModel[] ReadAll(OracleDataReader reader)
        {
            List<clsDepartmentPrivilage> results = new List<clsDepartmentPrivilage>();
            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        clsDepartmentPrivilage result = new clsDepartmentPrivilage();
                        if (reader["fldUid"] != DBNull.Value)
                            result.fldUid = reader["fldUid"].ToString();

                        if (reader["fldDepartmentuid"] != DBNull.Value)
                            result.fldDepartmentUid = reader["fldDepartmentuid"].ToString();

                        if (reader["fldprivilageuid"] != DBNull.Value)
                            result.fldPrivilageUid = reader["fldprivilageuid"].ToString();

                        if (reader["fldattributes"] != DBNull.Value)
                            result.fldAttributes = decimal.Parse(reader["fldattributes"].ToString());


                        if (reader["fldflags"] != DBNull.Value)
                            result.fldFlags = int.Parse(reader["fldflags"].ToString());


                        if (reader["fldcreated"] != DBNull.Value)
                            result.fldCreated = reader["fldcreated"].ToString();

                        if (reader["fldupdated"] != DBNull.Value)
                            result.fldUpdated = reader["fldupdated"].ToString();
                        results.Add(result);
                    }
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                }
            }
            catch (Exception e)
            {
                new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
            }

            return results.ToArray();
        }

        public KmnlkUMSModel[] ReadAll(SqlDataReader reader)
        {
            List<clsDepartmentPrivilage> results = new List<clsDepartmentPrivilage>();

            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        clsDepartmentPrivilage result = new clsDepartmentPrivilage();

                        if (reader["fldUid"] != DBNull.Value)
                            result.fldUid = reader["fldUid"].ToString();

                        if (reader["fldDepartmentuid"] != DBNull.Value)
                            result.fldDepartmentUid = reader["fldDepartmentuid"].ToString();

                        if (reader["fldprivilageuid"] != DBNull.Value)
                            result.fldPrivilageUid = reader["fldprivilageuid"].ToString();

                        if (reader["fldattributes"] != DBNull.Value)
                            result.fldAttributes = decimal.Parse(reader["fldattributes"].ToString());


                        if (reader["fldflags"] != DBNull.Value)
                            result.fldFlags = int.Parse(reader["fldflags"].ToString());


                        if (reader["fldcreated"] != DBNull.Value)
                            result.fldCreated = reader["fldcreated"].ToString();

                        if (reader["fldupdated"] != DBNull.Value)
                            result.fldUpdated = reader["fldupdated"].ToString();

                        results.Add(result);
                    }
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                }
            }
            catch (Exception e)
            {
                new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
            }
            return results.ToArray();
        }

        public KmnlkUMSModel Read(OracleDataReader reader)
        {
            clsDepartmentPrivilage result = new clsDepartmentPrivilage();

            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
            try
            {
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        if (reader["fldUid"] != DBNull.Value)
                            result.fldUid = reader["fldUid"].ToString();

                        if (reader["fldDepartmentuid"] != DBNull.Value)
                            result.fldDepartmentUid = reader["fldDepartmentuid"].ToString();

                        if (reader["fldprivilageuid"] != DBNull.Value)
                            result.fldPrivilageUid = reader["fldprivilageuid"].ToString();

                        if (reader["fldattributes"] != DBNull.Value)
                            result.fldAttributes = decimal.Parse(reader["fldattributes"].ToString());


                        if (reader["fldflags"] != DBNull.Value)
                            result.fldFlags = int.Parse(reader["fldflags"].ToString());


                        if (reader["fldcreated"] != DBNull.Value)
                            result.fldCreated = reader["fldcreated"].ToString();

                        if (reader["fldupdated"] != DBNull.Value)
                            result.fldUpdated = reader["fldupdated"].ToString();

                    }
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                }
            }
            catch (Exception e)
            {
                new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
            }
            return result;
        }

        public KmnlkUMSModel Read(SqlDataReader reader)
        {
            clsDepartmentPrivilage result = new clsDepartmentPrivilage();

            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
            try
            {
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        if (reader["fldUid"] != DBNull.Value)
                            result.fldUid = reader["fldUid"].ToString();

                        if (reader["fldDepartmentuid"] != DBNull.Value)
                            result.fldDepartmentUid = reader["fldDepartmentuid"].ToString();

                        if (reader["fldprivilageuid"] != DBNull.Value)
                            result.fldPrivilageUid = reader["fldprivilageuid"].ToString();

                        if (reader["fldattributes"] != DBNull.Value)
                            result.fldAttributes = decimal.Parse(reader["fldattributes"].ToString());


                        if (reader["fldflags"] != DBNull.Value)
                            result.fldFlags = int.Parse(reader["fldflags"].ToString());


                        if (reader["fldcreated"] != DBNull.Value)
                            result.fldCreated = reader["fldcreated"].ToString();

                        if (reader["fldupdated"] != DBNull.Value)
                            result.fldUpdated = reader["fldupdated"].ToString();

                    }
                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                }
            }
            catch (Exception e)
            {
                new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
            }

            return result;
        }

        public bool isValid(KmnlkUMSModel model)
        {
            //throw new NotImplementedException();
            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
            try
            {
                return true;
            }
            catch(Exception e)
            {
                new EngineException(log, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                return false;
            }
            
        }

     
    }
}
