using System.Linq;
using deleohynekwedding.Data;
using deleohynekwedding.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace deleohynekwedding.Controllers
{
    [Route("api/[controller]")]
    public class InvitationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public InvitationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET api/invitation
        [HttpGet]
        public Invitation Get()
        {
            var repo = _unitOfWork.Repository<Invitation>();
            var invite = repo.Find(x => GetAuthorizationCode() == x.RsvpCode.ToLower()).FirstOrDefault();
            return invite;
        }

        // PUT api/invitation
        [HttpPut]
        public StatusCodeResult Put([FromBody] Invitation updatedInvite)
        {
            var repo = _unitOfWork.Repository<Invitation>();
            if (updatedInvite.RsvpCode.ToLower() != Request.Headers["Authorization"].ToString().ToLower()) return StatusCode(StatusCodes.Status401Unauthorized);

            var invite = repo.Find(x => GetAuthorizationCode() == x.RsvpCode.ToLower()).FirstOrDefault();
            invite?.Map(updatedInvite);
            repo.SaveChanges();
            return StatusCode(StatusCodes.Status202Accepted);
        }

        private string GetAuthorizationCode()
        {
            return Request.Headers["Authorization"].ToString().ToLower().Replace(" ", string.Empty);
        }
    }
}
