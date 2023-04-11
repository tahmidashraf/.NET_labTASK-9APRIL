using BILL.DTOs;
using BILL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LABTASK_FINAL.Controllers
{
    public class ProjectController : ApiController
    {
        public HttpResponseMessage AllProject()
        {
            try
            {
                var data = ProjectService.Get();

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpGet]
        [Route("api/project/{id}")]
        public HttpResponseMessage GetProject(int id)
        {

            try
            {
                var data = ProjectService.Get(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/project/add")]
        public HttpResponseMessage Add(ProjectDTO data)
        {
            try
            {
                var res = ProjectService.Insert(data);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/project/update")]
        public HttpResponseMessage Update(ProjectDTO cat)
        {

            var exmp = MemberService.Get(cat.Id);

            if (exmp != null)
            {
                try
                {
                    var res = ProjectService.Update(cat);

                    return Request.CreateResponse(HttpStatusCode.OK, "Updated");

                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            else
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Project not found");
        }

        [HttpPost]
        [Route("api/project/{status}")]
        public HttpResponseMessage GetStatus(ProjectDTO cat)
        {

            var exmp = ProjectService.Get(cat.Status);

            if (exmp != null)
            {
                try
                {
                    var res = MemberService.Update(cat);
                    return Request.CreateResponse(HttpStatusCode.OK, "Updated");

                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            else
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Member not found");
        }

    }
}
