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
    public class RolePositionAttachmentManager : ModelManager, ICURDOperations, IReaderSqlOperations , IReaderOracleOperations, IValidationOperations
    {
        public ConnectionManager connectionManager;
        public ILog log;
        
        public RolePositionAttachmentManager(ConnectionManager CM,ILog logger)
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
            clsRolePositionAttachment instance = (clsRolePositionAttachment)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.GetAllrolespositionsattachments, ts,this);
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
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.GetAllrolespositionsattachments, ts,this);
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
            clsRolePositionAttachment instance = (clsRolePositionAttachment)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@flduid", Value = instance.fldUid });
                    KmnlkUMSModel result = manager.Get(PROCEDURES.GetrolepositionattachmentByid, ts,this);
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
                    KmnlkUMSModel result = manager.Get(PROCEDURES.GetrolepositionattachmentByid, ts,this);
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
        public List<KmnlkUMSModel> GetByRolePosition(KmnlkUMSModel model)
        {
            if (!isValid(model))
            {
                return null;
            }
            clsRolePositionAttachment instance = (clsRolePositionAttachment)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@fldrolepositionuid", Value = instance.fldRolePositionUid });
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.GetrolespositionsattachmentsByrolepositionId, ts, this);
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
                    ts.Add(new OracleParameter() { ParameterName = "@fldrolepositionuid", Value = instance.fldRolePositionUid });
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.GetrolespositionsattachmentsByrolepositionId, ts, this);
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

        public List<KmnlkUMSModel> GetByUser(KmnlkUMSModel model)
        {
            if (!isValid(model))
            {
                return null;
            }
            clsRolePositionAttachment instance = (clsRolePositionAttachment)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@flduseruid", Value = instance.fldUserUid });
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.GetrolespositionsattachmentsByuserId, ts, this);
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
                    ts.Add(new OracleParameter() { ParameterName = "@flduseruid", Value = instance.fldUserUid });
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.GetrolespositionsattachmentsByuserId, ts, this);
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
            clsRolePositionAttachment instance = (clsRolePositionAttachment)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@flduid", Value = instance.fldUid });
                    int result = manager.Delete(PROCEDURES.Deleterolepositionattachment, ts);
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
                    int result = manager.Delete(PROCEDURES.Deleterolepositionattachment, ts);
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
            clsRolePositionAttachment instance = (clsRolePositionAttachment)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@size", Value = size, DbType = DbType.Int64 });
                    ts.Add(new SqlParameter() { ParameterName = "@page", Value = page, DbType = DbType.Int64 });
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.FindAllrolespositionsattachments, ts, this);
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
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.FindAllrolespositionsattachments, ts, this);
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
            clsRolePositionAttachment instance = (clsRolePositionAttachment)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@fldrolepositionuid", Value = instance.fldRolePositionUid });
                    ts.Add(new SqlParameter() { ParameterName = "@flduseruid", Value = instance.fldUserUid });
                    ts.Add(new SqlParameter() { ParameterName = "@fldtype", Value = instance.fldType });
                    ts.Add(new SqlParameter() { ParameterName = "@fldfilepath", Value = instance.fldFilePath });
                    ts.Add(new SqlParameter() { ParameterName = "@fldfilecaption", Value = instance.fldFileCaption });
                    ts.Add(new SqlParameter() { ParameterName = "@fldfileext", Value = instance.fldFileExt });
                    ts.Add(new SqlParameter() { ParameterName = "@fldnote", Value = instance.fldNote });
                    ts.Add(new SqlParameter() { ParameterName = "@fldflags", Value = instance.fldFlags, SqlDbType = SqlDbType.BigInt });
                    ts.Add(new SqlParameter() { ParameterName = "@fldcreated", Value = instance.fldCreated });
                    ts.Add(new SqlParameter() { ParameterName = "@fldupdated", Value = instance.fldUpdated });
                    int result = manager.Insert(PROCEDURES.Addrolepositionattachment, ts);
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
                    ts.Add(new OracleParameter() { ParameterName = "@fldrolepositionuid", Value = instance.fldRolePositionUid });
                    ts.Add(new OracleParameter() { ParameterName = "@flduseruid", Value = instance.fldUserUid });
                    ts.Add(new OracleParameter() { ParameterName = "@fldtype", Value = instance.fldType });
                    ts.Add(new OracleParameter() { ParameterName = "@fldfilepath", Value = instance.fldFilePath });
                    ts.Add(new OracleParameter() { ParameterName = "@fldfilecaption", Value = instance.fldFileCaption });
                    ts.Add(new OracleParameter() { ParameterName = "@fldfileext", Value = instance.fldFileExt });
                    ts.Add(new OracleParameter() { ParameterName = "@fldnote", Value = instance.fldNote });
                    ts.Add(new OracleParameter() { ParameterName = "@fldflags", Value = instance.fldFlags, DbType = DbType.Int64 });
                    ts.Add(new OracleParameter() { ParameterName = "@fldcreated", Value = instance.fldCreated });
                    ts.Add(new OracleParameter() { ParameterName = "@fldupdated", Value = instance.fldUpdated });
                    int result = manager.Insert(PROCEDURES.Addrolepositionattachment, ts);
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
            clsRolePositionAttachment instance = (clsRolePositionAttachment)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@flduid", Value = instance.fldUid });
                    ts.Add(new SqlParameter() { ParameterName = "@fldrolepositionuid", Value = instance.fldRolePositionUid });
                    ts.Add(new SqlParameter() { ParameterName = "@flduseruid", Value = instance.fldUserUid });
                    ts.Add(new SqlParameter() { ParameterName = "@fldtype", Value = instance.fldType });
                    ts.Add(new SqlParameter() { ParameterName = "@fldfilepath", Value = instance.fldFilePath });
                    ts.Add(new SqlParameter() { ParameterName = "@fldfilecaption", Value = instance.fldFileCaption });
                    ts.Add(new SqlParameter() { ParameterName = "@fldfileext", Value = instance.fldFileExt });
                    ts.Add(new SqlParameter() { ParameterName = "@fldnote", Value = instance.fldNote });
                    ts.Add(new SqlParameter() { ParameterName = "@fldflags", Value = instance.fldFlags, SqlDbType = SqlDbType.BigInt });
                    //ts.Add(new SqlParameter() { ParameterName = "@fldcreated", Value = instance.fldCreated });
                    ts.Add(new SqlParameter() { ParameterName = "@fldupdated", Value = instance.fldUpdated });
                    int result = manager.Update(PROCEDURES.Editrolepositionattachment, ts);
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
                    ts.Add(new OracleParameter() { ParameterName = "@fldrolepositionuid", Value = instance.fldRolePositionUid });
                    ts.Add(new OracleParameter() { ParameterName = "@flduseruid", Value = instance.fldUserUid });
                    ts.Add(new OracleParameter() { ParameterName = "@fldtype", Value = instance.fldType });
                    ts.Add(new OracleParameter() { ParameterName = "@fldfilepath", Value = instance.fldFilePath });
                    ts.Add(new OracleParameter() { ParameterName = "@fldfilecaption", Value = instance.fldFileCaption });
                    ts.Add(new OracleParameter() { ParameterName = "@fldfileext", Value = instance.fldFileExt });
                    ts.Add(new OracleParameter() { ParameterName = "@fldnote", Value = instance.fldNote });
                    ts.Add(new OracleParameter() { ParameterName = "@fldflags", Value = instance.fldFlags, DbType = DbType.Int64 });
                    //ts.Add(new OracleParameter() { ParameterName = "@fldcreated", Value = instance.fldCreated });
                    ts.Add(new OracleParameter() { ParameterName = "@fldupdated", Value = instance.fldUpdated });

                    int result = manager.Update(PROCEDURES.Editrolepositionattachment, ts);
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
            List<clsRolePositionAttachment> results = new List<clsRolePositionAttachment>();
            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        clsRolePositionAttachment result = new clsRolePositionAttachment();
                        if (reader["fldUid"] != DBNull.Value)
                            result.fldUid = reader["fldUid"].ToString();

                        if (reader["fldrolepositionuid"] != DBNull.Value)
                            result.fldRolePositionUid = reader["fldrolepositionuid"].ToString();

                        if (reader["flduseruid"] != DBNull.Value)
                            result.fldUserUid = reader["flduseruid"].ToString();


                        if (reader["fldtype"] != DBNull.Value)
                            result.fldType = reader["fldtype"].ToString();

                        if (reader["fldfilepath"] != DBNull.Value)
                            result.fldFilePath = reader["fldfilepath"].ToString();

                        if (reader["fldfilecaption"] != DBNull.Value)
                            result.fldFileCaption = reader["fldfilecaption"].ToString();

                        if (reader["fldfileext"] != DBNull.Value)
                            result.fldFileExt = reader["fldfileext"].ToString();

                        if (reader["fldnote"] != DBNull.Value)
                            result.fldNote = reader["fldnote"].ToString();

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
            List<clsRolePositionAttachment> results = new List<clsRolePositionAttachment>();

            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        clsRolePositionAttachment result = new clsRolePositionAttachment();

                        if (reader["fldUid"] != DBNull.Value)
                            result.fldUid = reader["fldUid"].ToString();


                        if (reader["fldrolepositionuid"] != DBNull.Value)
                            result.fldRolePositionUid = reader["fldrolepositionuid"].ToString();

                        if (reader["flduseruid"] != DBNull.Value)
                            result.fldUserUid = reader["flduseruid"].ToString();

                        if (reader["fldtype"] != DBNull.Value)
                            result.fldType = reader["fldtype"].ToString();

                        if (reader["fldfilepath"] != DBNull.Value)
                            result.fldFilePath = reader["fldfilepath"].ToString();

                        if (reader["fldfilecaption"] != DBNull.Value)
                            result.fldFileCaption = reader["fldfilecaption"].ToString();

                        if (reader["fldfileext"] != DBNull.Value)
                            result.fldFileExt = reader["fldfileext"].ToString();

                        if (reader["fldnote"] != DBNull.Value)
                            result.fldNote = reader["fldnote"].ToString();

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
            clsRolePositionAttachment result = new clsRolePositionAttachment();

            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
            try
            {
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        if (reader["fldUid"] != DBNull.Value)
                            result.fldUid = reader["fldUid"].ToString();

                        if (reader["fldrolepositionuid"] != DBNull.Value)
                            result.fldRolePositionUid = reader["fldrolepositionuid"].ToString();

                        if (reader["flduseruid"] != DBNull.Value)
                            result.fldUserUid = reader["flduseruid"].ToString();

                        if (reader["fldtype"] != DBNull.Value)
                            result.fldType = reader["fldtype"].ToString();

                        if (reader["fldfilepath"] != DBNull.Value)
                            result.fldFilePath = reader["fldfilepath"].ToString();

                        if (reader["fldfilecaption"] != DBNull.Value)
                            result.fldFileCaption = reader["fldfilecaption"].ToString();

                        if (reader["fldfileext"] != DBNull.Value)
                            result.fldFileExt = reader["fldfileext"].ToString();

                        if (reader["fldnote"] != DBNull.Value)
                            result.fldNote = reader["fldnote"].ToString();

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
            clsRolePositionAttachment result = new clsRolePositionAttachment();

            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
            try
            {
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        if (reader["fldUid"] != DBNull.Value)
                            result.fldUid = reader["fldUid"].ToString();

                        if (reader["fldrolepositionuid"] != DBNull.Value)
                            result.fldRolePositionUid = reader["fldrolepositionuid"].ToString();

                        if (reader["flduseruid"] != DBNull.Value)
                            result.fldUserUid = reader["flduseruid"].ToString();

                        if (reader["fldtype"] != DBNull.Value)
                            result.fldType = reader["fldtype"].ToString();

                        if (reader["fldfilepath"] != DBNull.Value)
                            result.fldFilePath = reader["fldfilepath"].ToString();

                        if (reader["fldfilecaption"] != DBNull.Value)
                            result.fldFileCaption = reader["fldfilecaption"].ToString();

                        if (reader["fldfileext"] != DBNull.Value)
                            result.fldFileExt = reader["fldfileext"].ToString();

                        if (reader["fldnote"] != DBNull.Value)
                            result.fldNote = reader["fldnote"].ToString();

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
