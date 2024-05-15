using BLL.DTO;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ad_Manager.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET api/Employee
        [HttpGet]
        [Route("api/Employee")]
        public HttpResponseMessage GetEmployees()
        {
            try
            {
                var data = EmployeeService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        // GET api/Employee/{id}
        [HttpGet]
        [Route("api/Employee/{id}")]
        public HttpResponseMessage GetEmployee(int id)
        {
            try
            {
                var data = EmployeeService.Get(id);
                if (data != null)
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                else
                    return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        // POST api/Employee
        [HttpPost]
        [Route("api/Employee")]
        public HttpResponseMessage CreateEmployee([FromBody] employeeDTO employee)
        {
            try
            {
                var createdEmployee = EmployeeService.Create(employee);
                return Request.CreateResponse(HttpStatusCode.Created, createdEmployee);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        // PUT api/Employee/{id}
        [HttpPut]
        [Route("api/Employee/{id}")]
        public HttpResponseMessage UpdateEmployee(int id, [FromBody] employeeDTO employee)
        {
            try
            {
                var updatedEmployee = EmployeeService.Update(id, employee);
                if (updatedEmployee != null)
                    return Request.CreateResponse(HttpStatusCode.OK, updatedEmployee);
                else
                    return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        // DELETE api/Employee/{id}
        [HttpDelete]
        [Route("api/Employee/{id}")]
        public HttpResponseMessage DeleteEmployee(int id)
        {
            try
            {
                var success = EmployeeService.Delete(id);
                if (success)
                    return Request.CreateResponse(HttpStatusCode.NoContent);
                else
                    return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
