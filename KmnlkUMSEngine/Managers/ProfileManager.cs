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
    public class ProfileManager : ModelManager, ICURDOperations, IReaderSqlOperations , IReaderOracleOperations, IValidationOperations
    {
        public ConnectionManager connectionManager;
        public ILog log;
        
        public ProfileManager(ConnectionManager CM,ILog logger)
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
            clsProfile instance = (clsProfile)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.GetAllprofiles, ts,this);
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
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.GetAllprofiles, ts,this);
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
            clsProfile instance = (clsProfile)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@flduid", Value = instance.fldUid });
                    KmnlkUMSModel result = manager.Get(PROCEDURES.GetprofileById, ts,this);
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
                    KmnlkUMSModel result = manager.Get(PROCEDURES.GetprofileById, ts,this);
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

        public KmnlkUMSModel GetByUser(KmnlkUMSModel model)
        {
            if (!isValid(model))
            {
                return null;
            }
            clsProfile instance = (clsProfile)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@flduseruid", Value = instance.fldUserUid });
                    KmnlkUMSModel result = manager.Get(PROCEDURES.GetprofileByUserid, ts, this);
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
                    KmnlkUMSModel result = manager.Get(PROCEDURES.GetprofileByUserid, ts, this);
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
            clsProfile instance = (clsProfile)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@flduid", Value = instance.fldUid });
                    int result = manager.Delete(PROCEDURES.Deleteprofile, ts);
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
                    int result = manager.Delete(PROCEDURES.Deleteprofile, ts);
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
            clsProfile instance = (clsProfile)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@size", Value = size, DbType = DbType.Int64 });
                    ts.Add(new SqlParameter() { ParameterName = "@page", Value = page, DbType = DbType.Int64 });
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.FindAllprofiles, ts, this);
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
                    List<KmnlkUMSModel> result = manager.All(PROCEDURES.FindAllprofiles, ts, this);
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
            clsProfile instance = (clsProfile)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@flduseruid", Value = instance.fldUserUid });
                    ts.Add(new SqlParameter() { ParameterName = "@fldefirstname", Value = instance.fldEFirstName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldefamilyname", Value = instance.fldEFamilyName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldelocalfirstname", Value = instance.fldELocalFirstName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldelocalfamilyname", Value = instance.fldELocalFamilyName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldetitle", Value = instance.fldETitle });
                    ts.Add(new SqlParameter() { ParameterName = "@fldelocaltitle", Value = instance.fldELocalTitle });
                    ts.Add(new SqlParameter() { ParameterName = "@fldenickname", Value = instance.fldENickName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldedisplayname", Value = instance.fldEDisplayName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldlfirstname", Value = instance.fldLFirstName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldlfamilyname", Value = instance.fldLFamilyName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldllocalfirstname", Value = instance.fldLLocalFirstName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldllocalfamilyname", Value = instance.fldLLocalFamilyName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldltitle", Value = instance.fldLTitle });
                    ts.Add(new SqlParameter() { ParameterName = "@fldllocaltitle", Value = instance.fldLLocalTitle });
                    ts.Add(new SqlParameter() { ParameterName = "@fldldisplayname", Value = instance.fldLDisplayName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldphonenumber", Value = instance.fldPhoneNumber });
                    ts.Add(new SqlParameter() { ParameterName = "@fldemail", Value = instance.fldEmail });
                    ts.Add(new SqlParameter() { ParameterName = "@fldfax", Value = instance.fldFax });

                    ts.Add(new SqlParameter() { ParameterName = "@fldcreated", Value = instance.fldCreated });
                    ts.Add(new SqlParameter() { ParameterName = "@fldupdated", Value = instance.fldUpdated });
                    int result = manager.Insert(PROCEDURES.Addprofile, ts);
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
                    ts.Add(new OracleParameter() { ParameterName = "@flduseruid", Value = instance.fldUserUid });
                    ts.Add(new OracleParameter() { ParameterName = "@fldefirstname", Value = instance.fldEFirstName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldefamilyname", Value = instance.fldEFamilyName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldelocalfamilyname", Value = instance.fldELocalFamilyName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldetitle", Value = instance.fldETitle });
                    ts.Add(new OracleParameter() { ParameterName = "@fldelocaltitle", Value = instance.fldELocalTitle });
                    ts.Add(new OracleParameter() { ParameterName = "@fldenickname", Value = instance.fldENickName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldedisplayname", Value = instance.fldEDisplayName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldlfirstname", Value = instance.fldLFirstName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldlfamilyname", Value = instance.fldLFamilyName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldllocalfirstname", Value = instance.fldLLocalFirstName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldllocalfamilyname", Value = instance.fldLLocalFamilyName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldltitle", Value = instance.fldLTitle });
                    ts.Add(new OracleParameter() { ParameterName = "@fldllocaltitle", Value = instance.fldLLocalTitle });
                    ts.Add(new OracleParameter() { ParameterName = "@fldldisplayname", Value = instance.fldLDisplayName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldphonenumber", Value = instance.fldPhoneNumber });
                    ts.Add(new OracleParameter() { ParameterName = "@fldemail", Value = instance.fldEmail });
                    ts.Add(new OracleParameter() { ParameterName = "@fldfax", Value = instance.fldFax });
                    ts.Add(new OracleParameter() { ParameterName = "@fldcreated", Value = instance.fldCreated });
                    ts.Add(new OracleParameter() { ParameterName = "@fldupdated", Value = instance.fldUpdated });
                    int result = manager.Insert(PROCEDURES.Addprofile, ts);
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
            clsProfile instance = (clsProfile)model;
            if (connectionManager.GetTypeDB() == Enums.DB_TYPE.SQL)
            {
                                    log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "{flduid="+instance.fldUid+"}", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS); 
 try
                {
                    SqlConnectionManager manager = (SqlConnectionManager)connectionManager;
                    List<SqlParameter> ts = new List<SqlParameter>();
                    ts.Add(new SqlParameter() { ParameterName = "@flduid", Value = instance.fldUid });
                    ts.Add(new SqlParameter() { ParameterName = "@flduseruid", Value = instance.fldUserUid });
                    ts.Add(new SqlParameter() { ParameterName = "@fldefirstname", Value = instance.fldEFirstName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldefamilyname", Value = instance.fldEFamilyName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldelocalfamilyname", Value = instance.fldELocalFamilyName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldetitle", Value = instance.fldETitle });
                    ts.Add(new SqlParameter() { ParameterName = "@fldelocaltitle", Value = instance.fldELocalTitle });
                    ts.Add(new SqlParameter() { ParameterName = "@fldenickname", Value = instance.fldENickName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldedisplayname", Value = instance.fldEDisplayName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldlfirstname", Value = instance.fldLFirstName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldlfamilyname", Value = instance.fldLFamilyName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldllocalfirstname", Value = instance.fldLLocalFirstName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldllocalfamilyname", Value = instance.fldLLocalFamilyName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldltitle", Value = instance.fldLTitle });
                    ts.Add(new SqlParameter() { ParameterName = "@fldllocaltitle", Value = instance.fldLLocalTitle });
                    ts.Add(new SqlParameter() { ParameterName = "@fldldisplayname", Value = instance.fldLDisplayName });
                    ts.Add(new SqlParameter() { ParameterName = "@fldphonenumber", Value = instance.fldPhoneNumber });
                    ts.Add(new SqlParameter() { ParameterName = "@fldemail", Value = instance.fldEmail });
                    ts.Add(new SqlParameter() { ParameterName = "@fldfax", Value = instance.fldFax });
                    //ts.Add(new SqlParameter() { ParameterName = "@fldcreated", Value = instance.fldCreated });
                    ts.Add(new SqlParameter() { ParameterName = "@fldupdated", Value = instance.fldUpdated });
                    int result = manager.Update(PROCEDURES.Editprofile, ts);
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
                    ts.Add(new OracleParameter() { ParameterName = "@flduseruid", Value = instance.fldUserUid });
                    ts.Add(new OracleParameter() { ParameterName = "@fldefirstname", Value = instance.fldEFirstName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldefamilyname", Value = instance.fldEFamilyName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldelocalfamilyname", Value = instance.fldELocalFamilyName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldetitle", Value = instance.fldETitle });
                    ts.Add(new OracleParameter() { ParameterName = "@fldelocaltitle", Value = instance.fldELocalTitle });
                    ts.Add(new OracleParameter() { ParameterName = "@fldenickname", Value = instance.fldENickName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldedisplayname", Value = instance.fldEDisplayName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldlfirstname", Value = instance.fldLFirstName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldlfamilyname", Value = instance.fldLFamilyName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldllocalfirstname", Value = instance.fldLLocalFirstName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldllocalfamilyname", Value = instance.fldLLocalFamilyName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldltitle", Value = instance.fldLTitle });
                    ts.Add(new OracleParameter() { ParameterName = "@fldllocaltitle", Value = instance.fldLLocalTitle });
                    ts.Add(new OracleParameter() { ParameterName = "@fldldisplayname", Value = instance.fldLDisplayName });
                    ts.Add(new OracleParameter() { ParameterName = "@fldphonenumber", Value = instance.fldPhoneNumber });
                    ts.Add(new OracleParameter() { ParameterName = "@fldemail", Value = instance.fldEmail });
                    ts.Add(new OracleParameter() { ParameterName = "@fldfax", Value = instance.fldFax });
                    //ts.Add(new OracleParameter() { ParameterName = "@fldcreated", Value = instance.fldCreated });
                    ts.Add(new OracleParameter() { ParameterName = "@fldupdated", Value = instance.fldUpdated });

                    int result = manager.Update(PROCEDURES.Editprofile, ts);
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
            List<clsProfile> results = new List<clsProfile>();
            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        clsProfile result = new clsProfile();
                        if (reader["fldUid"] != DBNull.Value)
                            result.fldUid = reader["fldUid"].ToString();

                        if (reader["flduseruid"] != DBNull.Value)
                            result.fldUserUid = reader["flduseruid"].ToString();

                        if (reader["fldefirstname"] != DBNull.Value)
                            result.fldEFirstName = reader["fldefirstname"].ToString();

                        if (reader["fldefamilyname"] != DBNull.Value)
                            result.fldELocalFamilyName = reader["fldefamilyname"].ToString();

                        if (reader["fldelocalfirstname"] != DBNull.Value)
                            result.fldELocalFirstName = reader["fldelocalfirstname"].ToString();

                        if (reader["fldelocalfamilyname"] != DBNull.Value)
                            result.fldELocalFamilyName = reader["fldelocalfamilyname"].ToString();


                        if (reader["fldetitle"] != DBNull.Value)
                            result.fldETitle = reader["fldetitle"].ToString();

                        if (reader["fldelocaltitle"] != DBNull.Value)
                            result.fldELocalTitle = reader["fldelocaltitle"].ToString();

                        if (reader["fldenickname"] != DBNull.Value)
                            result.fldENickName = reader["fldenickname"].ToString();

                        if (reader["fldedisplayname"] != DBNull.Value)
                            result.fldEDisplayName = reader["fldedisplayname"].ToString();

                        if (reader["fldlfirstname"] != DBNull.Value)
                            result.fldLFirstName = reader["fldlfirstname"].ToString();


                        if (reader["fldlfamilyname"] != DBNull.Value)
                            result.fldLFamilyName = reader["fldlfamilyname"].ToString();

                        if (reader["fldllocalfirstname"] != DBNull.Value)
                            result.fldLLocalFirstName = reader["fldllocalfirstname"].ToString();

                        if (reader["fldllocalfamilyname"] != DBNull.Value)
                            result.fldLLocalFamilyName = reader["fldllocalfamilyname"].ToString();

                        if (reader["fldltitle"] != DBNull.Value)
                            result.fldLTitle = reader["fldltitle"].ToString();

                        if (reader["fldllocaltitle"] != DBNull.Value)
                            result.fldLLocalTitle = reader["fldllocaltitle"].ToString();


                        if (reader["fldlnickname"] != DBNull.Value)
                            result.fldLNickName = reader["fldlnickname"].ToString();

                        if (reader["fldldisplayname"] != DBNull.Value)
                            result.fldLDisplayName = reader["fldldisplayname"].ToString();

                        if (reader["fldphonenumber"] != DBNull.Value)
                            result.fldPhoneNumber = reader["fldphonenumber"].ToString();

                        if (reader["fldemail"] != DBNull.Value)
                            result.fldEmail = reader["fldemail"].ToString();

                        if (reader["fldfax"] != DBNull.Value)
                            result.fldFax = reader["fldfax"].ToString();


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
            List<clsProfile> results = new List<clsProfile>();

            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        clsProfile result = new clsProfile();

                        if (reader["fldUid"] != DBNull.Value)
                            result.fldUid = reader["fldUid"].ToString();

                        if (reader["flduseruid"] != DBNull.Value)
                            result.fldUserUid = reader["flduseruid"].ToString();

                        if (reader["fldefirstname"] != DBNull.Value)
                            result.fldEFirstName = reader["fldefirstname"].ToString();

                        if (reader["fldefamilyname"] != DBNull.Value)
                            result.fldELocalFamilyName = reader["fldefamilyname"].ToString();

                        if (reader["fldelocalfirstname"] != DBNull.Value)
                            result.fldELocalFirstName = reader["fldelocalfirstname"].ToString();

                        if (reader["fldelocalfamilyname"] != DBNull.Value)
                            result.fldELocalFamilyName = reader["fldelocalfamilyname"].ToString();


                        if (reader["fldetitle"] != DBNull.Value)
                            result.fldETitle = reader["fldetitle"].ToString();

                        if (reader["fldelocaltitle"] != DBNull.Value)
                            result.fldELocalTitle = reader["fldelocaltitle"].ToString();

                        if (reader["fldenickname"] != DBNull.Value)
                            result.fldENickName = reader["fldenickname"].ToString();

                        if (reader["fldedisplayname"] != DBNull.Value)
                            result.fldEDisplayName = reader["fldedisplayname"].ToString();

                        if (reader["fldlfirstname"] != DBNull.Value)
                            result.fldLFirstName = reader["fldlfirstname"].ToString();


                        if (reader["fldlfamilyname"] != DBNull.Value)
                            result.fldLFamilyName = reader["fldlfamilyname"].ToString();

                        if (reader["fldllocalfirstname"] != DBNull.Value)
                            result.fldLLocalFirstName = reader["fldllocalfirstname"].ToString();

                        if (reader["fldllocalfamilyname"] != DBNull.Value)
                            result.fldLLocalFamilyName = reader["fldllocalfamilyname"].ToString();

                        if (reader["fldltitle"] != DBNull.Value)
                            result.fldLTitle = reader["fldltitle"].ToString();

                        if (reader["fldllocaltitle"] != DBNull.Value)
                            result.fldLLocalTitle = reader["fldllocaltitle"].ToString();


                        if (reader["fldlnickname"] != DBNull.Value)
                            result.fldLNickName = reader["fldlnickname"].ToString();

                        if (reader["fldldisplayname"] != DBNull.Value)
                            result.fldLDisplayName = reader["fldldisplayname"].ToString();

                        if (reader["fldphonenumber"] != DBNull.Value)
                            result.fldPhoneNumber = reader["fldphonenumber"].ToString();

                        if (reader["fldemail"] != DBNull.Value)
                            result.fldEmail = reader["fldemail"].ToString();

                        if (reader["fldfax"] != DBNull.Value)
                            result.fldFax = reader["fldfax"].ToString();


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
            clsProfile result = new clsProfile();

            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
            try
            {
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        if (reader["fldUid"] != DBNull.Value)
                            result.fldUid = reader["fldUid"].ToString();

                        if (reader["flduseruid"] != DBNull.Value)
                            result.fldUserUid = reader["flduseruid"].ToString();

                        if (reader["fldefirstname"] != DBNull.Value)
                            result.fldEFirstName = reader["fldefirstname"].ToString();

                        if (reader["fldefamilyname"] != DBNull.Value)
                            result.fldELocalFamilyName = reader["fldefamilyname"].ToString();

                        if (reader["fldelocalfirstname"] != DBNull.Value)
                            result.fldELocalFirstName = reader["fldelocalfirstname"].ToString();

                        if (reader["fldelocalfamilyname"] != DBNull.Value)
                            result.fldELocalFamilyName = reader["fldelocalfamilyname"].ToString();


                        if (reader["fldetitle"] != DBNull.Value)
                            result.fldETitle = reader["fldetitle"].ToString();

                        if (reader["fldelocaltitle"] != DBNull.Value)
                            result.fldELocalTitle = reader["fldelocaltitle"].ToString();

                        if (reader["fldenickname"] != DBNull.Value)
                            result.fldENickName = reader["fldenickname"].ToString();

                        if (reader["fldedisplayname"] != DBNull.Value)
                            result.fldEDisplayName = reader["fldedisplayname"].ToString();

                        if (reader["fldlfirstname"] != DBNull.Value)
                            result.fldLFirstName = reader["fldlfirstname"].ToString();


                        if (reader["fldlfamilyname"] != DBNull.Value)
                            result.fldLFamilyName = reader["fldlfamilyname"].ToString();

                        if (reader["fldllocalfirstname"] != DBNull.Value)
                            result.fldLLocalFirstName = reader["fldllocalfirstname"].ToString();

                        if (reader["fldllocalfamilyname"] != DBNull.Value)
                            result.fldLLocalFamilyName = reader["fldllocalfamilyname"].ToString();

                        if (reader["fldltitle"] != DBNull.Value)
                            result.fldLTitle = reader["fldltitle"].ToString();

                        if (reader["fldllocaltitle"] != DBNull.Value)
                            result.fldLLocalTitle = reader["fldllocaltitle"].ToString();


                        if (reader["fldlnickname"] != DBNull.Value)
                            result.fldLNickName = reader["fldlnickname"].ToString();

                        if (reader["fldldisplayname"] != DBNull.Value)
                            result.fldLDisplayName = reader["fldldisplayname"].ToString();

                        if (reader["fldphonenumber"] != DBNull.Value)
                            result.fldPhoneNumber = reader["fldphonenumber"].ToString();

                        if (reader["fldemail"] != DBNull.Value)
                            result.fldEmail = reader["fldemail"].ToString();

                        if (reader["fldfax"] != DBNull.Value)
                            result.fldFax = reader["fldfax"].ToString();


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
            clsProfile result = new clsProfile();

            log.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);
            try
            {
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        if (reader["fldUid"] != DBNull.Value)
                            result.fldUid = reader["fldUid"].ToString();

                        if (reader["flduseruid"] != DBNull.Value)
                            result.fldUserUid = reader["flduseruid"].ToString();

                        if (reader["fldefirstname"] != DBNull.Value)
                            result.fldEFirstName = reader["fldefirstname"].ToString();

                        if (reader["fldefamilyname"] != DBNull.Value)
                            result.fldELocalFamilyName = reader["fldefamilyname"].ToString();

                        if (reader["fldelocalfirstname"] != DBNull.Value)
                            result.fldELocalFirstName = reader["fldelocalfirstname"].ToString();

                        if (reader["fldelocalfamilyname"] != DBNull.Value)
                            result.fldELocalFamilyName = reader["fldelocalfamilyname"].ToString();


                        if (reader["fldetitle"] != DBNull.Value)
                            result.fldETitle = reader["fldetitle"].ToString();

                        if (reader["fldelocaltitle"] != DBNull.Value)
                            result.fldELocalTitle = reader["fldelocaltitle"].ToString();

                        if (reader["fldenickname"] != DBNull.Value)
                            result.fldENickName = reader["fldenickname"].ToString();

                        if (reader["fldedisplayname"] != DBNull.Value)
                            result.fldEDisplayName = reader["fldedisplayname"].ToString();

                        if (reader["fldlfirstname"] != DBNull.Value)
                            result.fldLFirstName = reader["fldlfirstname"].ToString();


                        if (reader["fldlfamilyname"] != DBNull.Value)
                            result.fldLFamilyName = reader["fldlfamilyname"].ToString();

                        if (reader["fldllocalfirstname"] != DBNull.Value)
                            result.fldLLocalFirstName = reader["fldllocalfirstname"].ToString();

                        if (reader["fldllocalfamilyname"] != DBNull.Value)
                            result.fldLLocalFamilyName = reader["fldllocalfamilyname"].ToString();

                        if (reader["fldltitle"] != DBNull.Value)
                            result.fldLTitle = reader["fldltitle"].ToString();

                        if (reader["fldllocaltitle"] != DBNull.Value)
                            result.fldLLocalTitle = reader["fldllocaltitle"].ToString();


                        if (reader["fldlnickname"] != DBNull.Value)
                            result.fldLNickName = reader["fldlnickname"].ToString();

                        if (reader["fldldisplayname"] != DBNull.Value)
                            result.fldLDisplayName = reader["fldldisplayname"].ToString();

                        if (reader["fldphonenumber"] != DBNull.Value)
                            result.fldPhoneNumber = reader["fldphonenumber"].ToString();

                        if (reader["fldemail"] != DBNull.Value)
                            result.fldEmail = reader["fldemail"].ToString();

                        if (reader["fldfax"] != DBNull.Value)
                            result.fldFax = reader["fldfax"].ToString();


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
