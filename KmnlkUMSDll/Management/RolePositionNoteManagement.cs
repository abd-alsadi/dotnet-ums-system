using KmnlkUMSDll.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KmnlkUMSEngine;
using KmnlkUMSEngine.Managers;
using KmnlkUMSEngine.Connections;
using static KmnlkCommon.Shareds.LoggerManagement;
using static KmnlkUMSDll.Constants.Enums;
using KmnlkCommon.Shareds;
using KmnlkUMSDll.Constants;
using KmnlkUMSDll.Exceptions;

namespace KmnlkUMSDll.Managment
{
    public class RolePositionNoteManagement :ModelManagement, ICURDOperations, IValidationOperations
    {
        private RolePositionNoteManager manager;
        private ILog logger;
        public RolePositionNoteManagement(ConnectionManager conn,ILog logger)
        {
            this.logger = logger;
            manager = new RolePositionNoteManager(conn, logger);  
        }
        public List<KmnlkUMSModel> All(KmnlkUMSModel model)
        {
                        logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
            try 
            {
                if (!isValid(model))
                {
                    return null;
                }
                var result= manager.All(model);
                logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                return result;
            }
            catch (Exception e)
            {
                new DllException(logger, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                return null;
            }
        }
        public List<KmnlkUMSModel> GetByRolePosition(KmnlkUMSModel model)
        {
                        logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
            try 
            {
                if (!isValid(model))
                {
                    return null;
                }
                var result = manager.GetByRolePosition(model);
                logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                return result;
            }
            catch (Exception e)
            {
                new DllException(logger, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                return null;
            }
        }

        public List<KmnlkUMSModel> GetByUser(KmnlkUMSModel model)
        {
                        logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
            try 
            {
                if (!isValid(model))
                {
                    return null;
                }
                var result = manager.GetByUser(model);
                logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                return result;
            }
            catch (Exception e)
            {
                new DllException(logger, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                return null;
            }
        }
        public List<KmnlkUMSModel> Find(int size,int page,KmnlkUMSModel model)
        {
                        logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
            try 
            {
                if (!isValid(model))
                {
                    return null;
                }
                var result = manager.Find(size,page,model);
                logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                return result;
            }
            catch (Exception e)
            {
                new DllException(logger, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                return null;
            }
        }

        public Enum_CURD_Result Delete(KmnlkUMSModel model)
        {
                        logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
            try 
            {
                if (!isValid(model))
                {
                    return Enum_CURD_Result.ERROR_PARAMETERS;
                }
                int result = manager.Delete(model);
                logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                if (result == -1)
                    return Enum_CURD_Result.NOT_SUCCESS;
                else
                    return Enum_CURD_Result.SUCCESS;
            }catch(Exception e)
            {
                new DllException(logger, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                return Enum_CURD_Result.NOT_SUCCESS;
            }
        }

        public KmnlkUMSModel Get(KmnlkUMSModel model)
        {
                        logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
            try 
            {
                if (!isValid(model))
                {
                    return null;
                }
                var result= manager.Get(model);
                logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                return result;
            }
            catch (Exception e)
            {
                new DllException(logger, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                return null;
            }
        }

        public Enum_CURD_Result Insert(KmnlkUMSModel model)
        {
                        logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
            try 
            {
                if (!isValid(model))
                {
                    return Enum_CURD_Result.ERROR_PARAMETERS;
                }
                int result = manager.Insert(model);
                logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                if (result == -1)
                    return Enum_CURD_Result.NOT_SUCCESS;
                else
                    return Enum_CURD_Result.SUCCESS;
            }
            catch (Exception e)
            {
                new DllException(logger, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                return Enum_CURD_Result.NOT_SUCCESS;
            }
        }

        public bool isValid(KmnlkUMSModel model)
        {
            logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS);

            //throw new NotImplementedException();
            logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);

            return true;
        }

        public Enum_CURD_Result Update(KmnlkUMSModel model)
        {
                        logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO, ENUM_TYPE_Block_LOGGER.START, modConstant.MSG_SUCCESS); 
            try 
            {
                if (!isValid(model))
                {
                    return Enum_CURD_Result.ERROR_PARAMETERS;
                }
                int result = manager.Update(model);
                logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstant.MSG_SUCCESS);
                if (result == -1)
                    return Enum_CURD_Result.NOT_SUCCESS;
                else
                    return Enum_CURD_Result.SUCCESS;
            }
            catch (Exception e)
            {
                new DllException(logger, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                return Enum_CURD_Result.NOT_SUCCESS;
            }
        }
    }
}
