using KmnlkUMSApi.Constants;
using KmnlkUMSApi.Management;
using KmnlkUMSApi.Models;
using KmnlkCommon.Shareds;
using KmnlkUMSEngine.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static KmnlkCommon.Shareds.RWFManagement;
using static KmnlkCommon.Shareds.LoggerManagement;
using KmnlkUMSApi.Filters;
using KmnlkUMSDll.Exceptions;
using KmnlkUMSApi.Exceptions;

namespace KmnlkUMSApi.Controllers
{
    public class RoleContactController : ApiController
    {
        PackageManagement package = null;

        public RoleContactController(PackageManagement repo)
        {
            package = repo;
        }

        [HttpGet]
        [ActionName("All")]
        public HttpResponseMessage Index() 
        {
                            package.context.logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstants.MSG_SUCCESS);
            string startTime = DateTime.Now.ToString("hh:mm:ss");
            string endTime = "";
            HttpResponseMessage res;
            try
            {
                var data = package.context.instanceRoleContactBussinesManagement().All(new clsRoleContact());
                endTime = DateTime.Now.ToString("hh:mm:ss");
                var response = new ResponseModel(data, modConstants.MSG_SUCCESS, HttpStatusCode.OK, startTime, endTime);
                res = Request.CreateResponse<ResponseModel>(HttpStatusCode.OK, response);
                 package.context.logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstants.MSG_SUCCESS);
            
                return res;
            }
            catch(Exception e)
            {
                new ApiException(package.context.logger, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                endTime = DateTime.Now.ToString("hh:mm:ss");
                var response = new ResponseModel(null, e.Message, HttpStatusCode.BadRequest, startTime, endTime);
                return Request.CreateResponse<ResponseModel>(HttpStatusCode.OK, response);
            }
        }

        [HttpPost]
        [ActionName("Search")]
        public HttpResponseMessage Find([FromUri]int size,[FromUri]int page,[FromBody]clsRoleContact model)
        {
                            package.context.logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstants.MSG_SUCCESS);
            string startTime = DateTime.Now.ToString("hh:mm:ss");
            string endTime = "";
            HttpResponseMessage res;
            try
            {
                if (!isValid(model))
                {
                    throw new Exception(modConstants.MSG_NOT_VALID_MODEL);
                }
                var data = package.context.instanceRoleContactBussinesManagement().Find(size,page, model);
                endTime = DateTime.Now.ToString("hh:mm:ss");
                var response = new ResponseModel(data, modConstants.MSG_SUCCESS, HttpStatusCode.OK, startTime, endTime);
                res = Request.CreateResponse<ResponseModel>(HttpStatusCode.OK, response);
                 package.context.logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstants.MSG_SUCCESS);

                return res;
            }
            catch (Exception e)
            {
                new ApiException(package.context.logger, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                endTime = DateTime.Now.ToString("hh:mm:ss");
                var response = new ResponseModel(null, e.Message, HttpStatusCode.BadRequest, startTime, endTime);
                return Request.CreateResponse<ResponseModel>(HttpStatusCode.OK, response);
            }
        }


        [HttpGet]
        [ActionName("Get")]
        public HttpResponseMessage Details([FromUri] string uid)
        {
                            package.context.logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstants.MSG_SUCCESS);
            string startTime = DateTime.Now.ToString("hh:mm:ss");
            string endTime = "";
            HttpResponseMessage res;
            try
            {
                if (!isValid(uid))
                {
                    throw new Exception(modConstants.MSG_NOT_VALID_MODEL);
                }
                
                var data = package.context.instanceRoleContactBussinesManagement().Get(new clsRoleContact() { fldUid= uid});
                endTime = DateTime.Now.ToString("hh:mm:ss");
                var response = new ResponseModel(data, modConstants.MSG_SUCCESS, HttpStatusCode.OK, startTime, endTime);
                res = Request.CreateResponse<ResponseModel>(HttpStatusCode.OK, response);
                 package.context.logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstants.MSG_SUCCESS);

                return res;
            }
            catch (Exception e)
            {
                new ApiException(package.context.logger, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                endTime = DateTime.Now.ToString("hh:mm:ss");
                var response = new ResponseModel(null, e.Message, HttpStatusCode.BadRequest, startTime, endTime);
                return Request.CreateResponse<ResponseModel>(HttpStatusCode.OK, response);
            }
        }
        [HttpGet]
        [ActionName("GetByRole")]
        public HttpResponseMessage GetByRole([FromUri] string uid)
        {
                            package.context.logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstants.MSG_SUCCESS);
            string startTime = DateTime.Now.ToString("hh:mm:ss");
            string endTime = "";
            HttpResponseMessage res;
            try
            {
                if (!isValid(uid))
                {
                    throw new Exception(modConstants.MSG_NOT_VALID_MODEL);
                }

                var data = package.context.instanceRoleContactBussinesManagement().GetByRole(new clsRoleContact() { fldRoleUid = uid });
                endTime = DateTime.Now.ToString("hh:mm:ss");
                var response = new ResponseModel(data, modConstants.MSG_SUCCESS, HttpStatusCode.OK, startTime, endTime);
                res = Request.CreateResponse<ResponseModel>(HttpStatusCode.OK, response);
                 package.context.logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstants.MSG_SUCCESS);

                return res;
            }
            catch (Exception e)
            {
                new ApiException(package.context.logger, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                endTime = DateTime.Now.ToString("hh:mm:ss");
                var response = new ResponseModel(null, e.Message, HttpStatusCode.BadRequest, startTime, endTime);
                return Request.CreateResponse<ResponseModel>(HttpStatusCode.OK, response);
            }
        }


        [HttpPost]
        [ActionName("Update")]
        public HttpResponseMessage Post([FromBody] clsRoleContact model)
        {
                            package.context.logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstants.MSG_SUCCESS);
            string startTime = DateTime.Now.ToString("hh:mm:ss");
            string endTime = "";
            HttpResponseMessage res;
            try
            {
                if (!isValid(model))
                {
                    throw new Exception(modConstants.MSG_NOT_VALID_MODEL);
                }
                var data = package.context.instanceRoleContactBussinesManagement().Update(model);
                endTime = DateTime.Now.ToString("hh:mm:ss");
                var response = new ResponseModel(data, modConstants.MSG_SUCCESS, HttpStatusCode.OK, startTime, endTime);
                res = Request.CreateResponse<ResponseModel>(HttpStatusCode.OK, response);
                 package.context.logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstants.MSG_SUCCESS);

                return res;
            }
            catch (Exception e)
            {
                new ApiException(package.context.logger, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                endTime = DateTime.Now.ToString("hh:mm:ss");
                var response = new ResponseModel(null, e.Message, HttpStatusCode.BadRequest, startTime, endTime);
                return Request.CreateResponse<ResponseModel>(HttpStatusCode.OK, response);
            }
        }


        [HttpPost]
        [ActionName("Add")]
        public HttpResponseMessage Add([FromBody] clsRoleContact model)
        {
                            package.context.logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstants.MSG_SUCCESS);
            string startTime = DateTime.Now.ToString("hh:mm:ss");
            string endTime = "";
            HttpResponseMessage res;
            try
            {
                if (!isValid(model))
                {
                    throw new Exception(modConstants.MSG_NOT_VALID_MODEL);
                }
                var data = package.context.instanceRoleContactBussinesManagement().Insert(model);
                endTime = DateTime.Now.ToString("hh:mm:ss");
                var response = new ResponseModel(data, modConstants.MSG_SUCCESS, HttpStatusCode.OK, startTime, endTime);
                res = Request.CreateResponse<ResponseModel>(HttpStatusCode.OK, response);
                 package.context.logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstants.MSG_SUCCESS);

                return res;
            }
            catch (Exception e)
            {
                new ApiException(package.context.logger, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                endTime = DateTime.Now.ToString("hh:mm:ss");
                var response = new ResponseModel(null, e.Message, HttpStatusCode.BadRequest, startTime, endTime);
                return Request.CreateResponse<ResponseModel>(HttpStatusCode.OK, response);
            }
        }


        [HttpDelete]
        [ActionName("Delete")]
        public HttpResponseMessage Delete([FromUri] string uid)
        {
                            package.context.logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.START, modConstants.MSG_SUCCESS);
            string startTime = DateTime.Now.ToString("hh:mm:ss");
            string endTime = "";
            HttpResponseMessage res;
            try
            {
                if (!isValid(uid))
                {
                    throw new Exception(modConstants.MSG_NOT_VALID_MODEL);
                }
                var data = package.context.instanceRoleContactBussinesManagement().Delete(new clsRoleContact() { fldUid=uid});
                endTime = DateTime.Now.ToString("hh:mm:ss");
                var response = new ResponseModel(data, modConstants.MSG_SUCCESS, HttpStatusCode.OK, startTime, endTime);
                res = Request.CreateResponse<ResponseModel>(HttpStatusCode.OK, response);
                 package.context.logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstants.MSG_SUCCESS);

                return res;
            }
            catch (Exception e)
            {
                new ApiException(package.context.logger, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                endTime = DateTime.Now.ToString("hh:mm:ss");
                var response = new ResponseModel(null, e.Message, HttpStatusCode.BadRequest, startTime, endTime);
                return Request.CreateResponse<ResponseModel>(HttpStatusCode.OK, response);
            }
        }


        
        [NonAction]
        public bool isValid(clsRoleContact model)
        {
            try
            {
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }
        [NonAction]
        public bool isValid(string uid)
        {
            return ValidateManagement.validateGuid(uid );
        }

    }
}
