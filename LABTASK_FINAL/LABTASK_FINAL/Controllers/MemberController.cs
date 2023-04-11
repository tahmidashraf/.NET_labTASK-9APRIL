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
    public class MemberController : ApiController
    {
        [HttpGet]
        [Route("api/member/getall")]
        public HttpResponseMessage AllMember()
        {
            try
            {
                var data = MemberService.Get();

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpGet]
        [Route("api/service/{id}")]
        public HttpResponseMessage GetMember(int id)
        {

            try
            {
                var data = MemberService.Get(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/member/add")]
        public HttpResponseMessage Add(MemberDTO data)
        {
            try
            {
                var res = MemberService.Insert(data);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/members/update")]
        public HttpResponseMessage Update(MemberDTO cat)
        {

            var exmp = MemberService.Get(cat.Id);

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

        [HttpPost]
        [Route("api/members/delete")]
        public HttpResponseMessage Delete(MemberDTO mem)
        {

            var exmp = MemberService.Get(mem.Id);
            

            if (exmp != null)
            {
                try
                {
                    var res = MemberService.Delete(mem.Id);
                    return Request.CreateResponse(HttpStatusCode.OK, "Deleted");

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
