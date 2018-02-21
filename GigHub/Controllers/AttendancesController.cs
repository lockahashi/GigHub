using System.Web.Http;
using GigHub.Models;
using Microsoft.AspNet.Identity;

namespace GigHub.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }
        //public IHttpActionResult Attend(int gigId)
        //{
        //    var attendance = new Attendance
        //    {
        //        GigId = gigId,
        //        AttendeeId = User.Identity.GetUserId()
        //    };

        //}
    }
}
