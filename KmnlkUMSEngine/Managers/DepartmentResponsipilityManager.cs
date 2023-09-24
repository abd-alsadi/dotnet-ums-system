﻿using KmnlkUMSEngine.Constants;
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
    public class DepartmentResponsipilityManager : ModelManager, ICURDOperations, IReaderSqlOperations , IReaderOracleOperations, IValidationOperations
    {
        public ConnectionManager connectionManager;
        public ILog log;
        
        public DepartmentResponsipilityManager(ConnectionManager CM,ILog logger)
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
            clsDepartmentResponsipility instance = (clsDepartmentResponsipility)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.GetAlldepartmentsresponsipilities, ts,this);
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
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.GetAlldepartmentsresponsipilities, ts,this);
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
            clsDepartmentResponsipility instance = (clsDepartmentResponsipility)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@flduid", Value = instance.fldUid });
                    KmnlkUMSModel result = manager.Get(PROCEDURES.GetdepartmentresponsipilityById, ts,this);
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
                    KmnlkUMSModel result = manager.Get(PROCEDURES.GetdepartmentresponsipilityById, ts,this);
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

        public List<KmnlkUMSModel> GetByDepartment(KmnlkUMSModel model)
        {
            if (!isValid(model))
            {
                return null;
            }
            clsDepartmentResponsipility instance = (clsDepartmentResponsipility)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@flddepartmentuid", Value = instance.fldDepartmentUid });
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.Getdepartmentsresponsipilitiesbydepartmentid, ts, this);
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
                    ts.Add(new OracleParameter() { ParameterName = "@flddepartmentuid", Value = instance.fldDepartmentUid });
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.Getdepartmentsresponsipilitiesbydepartmentid, ts, this);
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
            clsDepartmentResponsipility instance = (clsDepartmentResponsipility)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@flduid", Value = instance.fldUid });
                    int result = manager.Delete(PROCEDURES.Deletedepartmentresponsipility, ts);
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
                    int result = manager.Delete(PROCEDURES.Deletedepartmentresponsipility, ts);
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
            clsDepartmentResponsipility instance = (clsDepartmentResponsipility)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@size", Value = size, DbType = DbType.Int64 });
                    ts.Add(new SqlParameter() { ParameterName = "@page", Value = page, DbType = DbType.Int64 });
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.FindAlldepartmentsresponsipilities, ts, this);
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
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.FindAlldepartmentsresponsipilities, ts, this);
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
            clsDepartmentResponsipility instance = (clsDepartmentResponsipility)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@fldDepartmentuid", Value = instance.fldDepartmentUid });
                    ts.Add(new SqlParameter() { ParameterName = "@fldcode", Value = instance.fldCode });
                    ts.Add(new SqlParameter() { ParameterName = "@fldisactive", Value = instance.fldIsActive, SqlDbType = SqlDbType.Bit });
                    ts.Add(new SqlParameter() { ParameterName = "@fldpriority", Value = instance.fldPriority });
                    ts.Add(new SqlParameter() { ParameterName = "@fldename", Value = instance.fldEName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldlname", Value = instance.fldLName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldnote", Value = instance.fldNote });
                    ts.Add(new SqlParameter() { ParameterName = "@fldflags", Value = instance.fldFlags, SqlDbType = SqlDbType.BigInt });
                    ts.Add(new SqlParameter() { ParameterName = "@fldcreated", Value = instance.fldCreated });
                    ts.Add(new SqlParameter() { ParameterName = "@fldupdated", Value = instance.fldUpdated });
                    int result = manager.Insert(PROCEDURES.Adddepartmentresponsipility, ts);
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
                    ts.Add(new OracleParameter() { ParameterName = "@flduid", Value = instance.fldUid });
                    ts.Add(new OracleParameter() { ParameterName = "@fldDepartmentuid", Value = instance.fldDepartmentUid });
                    ts.Add(new OracleParameter() { ParameterName = "@fldcode", Value = instance.fldCode });
                    ts.Add(new OracleParameter() { ParameterName = "@fldisactive", Value = instance.fldIsActive, DbType = DbType.Int16 });
                    ts.Add(new OracleParameter() { ParameterName = "@fldpriority", Value = instance.fldPriority });
                    ts.Add(new OracleParameter() { ParameterName = "@fldename", Value = instance.fldEName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldlname", Value = instance.fldLName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldnote", Value = instance.fldNote });
                    ts.Add(new OracleParameter() { ParameterName = "@fldflags", Value = instance.fldFlags, DbType = DbType.Int64 });
                    ts.Add(new OracleParameter() { ParameterName = "@fldcreated", Value = instance.fldCreated });
                    ts.Add(new OracleParameter() { ParameterName = "@fldupdated", Value = instance.fldUpdated });
                    int result = manager.Insert(PROCEDURES.Adddepartmentresponsipility, ts);
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
            clsDepartmentResponsipility instance = (clsDepartmentResponsipility)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@flduid", Value = instance.fldUid });
                    ts.Add(new SqlParameter() { ParameterName = "@fldDepartmentuid", Value = instance.fldDepartmentUid });
                    ts.Add(new SqlParameter() { ParameterName = "@fldcode", Value = instance.fldCode });
                    ts.Add(new SqlParameter() { ParameterName = "@fldisactive", Value = instance.fldIsActive, SqlDbType = SqlDbType.Bit });
                    ts.Add(new SqlParameter() { ParameterName = "@fldpriority", Value = instance.fldPriority });
                    ts.Add(new SqlParameter() { ParameterName = "@fldename", Value = instance.fldEName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldlname", Value = instance.fldLName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldnote", Value = instance.fldNote });
                    ts.Add(new SqlParameter() { ParameterName = "@fldflags", Value = instance.fldFlags, SqlDbType = SqlDbType.BigInt });
                    //ts.Add(new SqlParameter() { ParameterName = "@fldcreated", Value = instance.fldCreated });
                    ts.Add(new SqlParameter() { ParameterName = "@fldupdated", Value = instance.fldUpdated });
                    int result = manager.Update(PROCEDURES.Editdepartmentresponsipility, ts);
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
                    ts.Add(new OracleParameter() { ParameterName = "@fldcode", Value = instance.fldCode });
                    ts.Add(new OracleParameter() { ParameterName = "@fldisactive", Value = instance.fldIsActive, DbType = DbType.Int16 });
                    ts.Add(new OracleParameter() { ParameterName = "@fldpriority", Value = instance.fldPriority });
                    ts.Add(new OracleParameter() { ParameterName = "@fldename", Value = instance.fldEName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldlname", Value = instance.fldLName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldnote", Value = instance.fldNote });
                    ts.Add(new OracleParameter() { ParameterName = "@fldflags", Value = instance.fldFlags, DbType = DbType.Int64 });
                    //ts.Add(new OracleParameter() { ParameterName = "@fldcreated", Value = instance.fldCreated });
                    ts.Add(new OracleParameter() { ParameterName = "@fldupdated", Value = instance.fldUpdated });

                    int result = manager.Update(PROCEDURES.Editdepartmentresponsipility, ts);
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
            List<clsDepartmentResponsipility> results = new List<clsDepartmentResponsipility>();
            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        clsDepartmentResponsipility result = new clsDepartmentResponsipility();
                        if (reader["fldUid"] != DBNull.Value)
                            result.fldUid = reader["fldUid"].ToString();

                        if (reader["fldDepartmentuid"] != DBNull.Value)
                            result.fldDepartmentUid = reader["fldDepartmentuid"].ToString();


                        if (reader["fldcode"] != DBNull.Value)
                            result.fldCode = reader["fldcode"].ToString();


                        if (reader["fldpriority"] != DBNull.Value)
                            result.fldPriority = (char)reader["fldpriority"];

                        if (reader["fldename"] != DBNull.Value)
                            result.fldEName = reader["fldename"].ToString();

                        if (reader["fldlname"] != DBNull.Value)
                            result.fldLName = reader["fldlname"].ToString();

                        if (reader["fldnote"] != DBNull.Value)
                            result.fldNote = reader["fldnote"].ToString();

                        if (reader["fldflags"] != DBNull.Value)
                            result.fldFlags = int.Parse(reader["fldflags"].ToString());

                        if (reader["fldisactive"] != DBNull.Value)
                            result.fldIsActive = int.Parse(reader["fldisactive"].ToString());


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
            List<clsDepartmentResponsipility> results = new List<clsDepartmentResponsipility>();

            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        clsDepartmentResponsipility result = new clsDepartmentResponsipility();
                        if (reader["fldUid"] != DBNull.Value)
                            result.fldUid = reader["fldUid"].ToString();

                        if (reader["fldDepartmentuid"] != DBNull.Value)
                            result.fldDepartmentUid = reader["fldDepartmentuid"].ToString();


                        if (reader["fldcode"] != DBNull.Value)
                            result.fldCode = reader["fldcode"].ToString();


                        if (reader["fldpriority"] != DBNull.Value)
                            result.fldPriority = (char)reader["fldpriority"];

                        if (reader["fldename"] != DBNull.Value)
                            result.fldEName = reader["fldename"].ToString();

                        if (reader["fldlname"] != DBNull.Value)
                            result.fldLName = reader["fldlname"].ToString();

                        if (reader["fldnote"] != DBNull.Value)
                            result.fldNote = reader["fldnote"].ToString();

                        if (reader["fldflags"] != DBNull.Value)
                            result.fldFlags = int.Parse(reader["fldflags"].ToString());

                        if (reader["fldisactive"] != DBNull.Value)
                            result.fldIsActive = int.Parse(reader["fldisactive"].ToString());


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
            clsDepartmentResponsipility result = new clsDepartmentResponsipility();

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


                        if (reader["fldcode"] != DBNull.Value)
                            result.fldCode = reader["fldcode"].ToString();


                        if (reader["fldpriority"] != DBNull.Value)
                            result.fldPriority = (char)reader["fldpriority"];

                        if (reader["fldename"] != DBNull.Value)
                            result.fldEName = reader["fldename"].ToString();

                        if (reader["fldlname"] != DBNull.Value)
                            result.fldLName = reader["fldlname"].ToString();

                        if (reader["fldnote"] != DBNull.Value)
                            result.fldNote = reader["fldnote"].ToString();

                        if (reader["fldflags"] != DBNull.Value)
                            result.fldFlags = int.Parse(reader["fldflags"].ToString());

                        if (reader["fldisactive"] != DBNull.Value)
                            result.fldIsActive = int.Parse(reader["fldisactive"].ToString());


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
            clsDepartmentResponsipility result = new clsDepartmentResponsipility();

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

                        if (reader["fldcode"] != DBNull.Value)
                            result.fldCode = reader["fldcode"].ToString();

                        if (reader["fldpriority"] != DBNull.Value)
                            result.fldPriority = (char)reader["fldpriority"];

                        if (reader["fldename"] != DBNull.Value)
                            result.fldEName = reader["fldename"].ToString();

                        if (reader["fldlname"] != DBNull.Value)
                            result.fldLName = reader["fldlname"].ToString();

                        if (reader["fldnote"] != DBNull.Value)
                            result.fldNote = reader["fldnote"].ToString();

                        if (reader["fldflags"] != DBNull.Value)
                            result.fldFlags = int.Parse(reader["fldflags"].ToString());

                        if (reader["fldisactive"] != DBNull.Value)
                            result.fldIsActive = int.Parse(reader["fldisactive"].ToString());

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
