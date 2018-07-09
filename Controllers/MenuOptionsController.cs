using System.Collections.Generic;
using System.Linq;
using deleohynekwedding.Data;
using deleohynekwedding.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace deleohynekwedding.Controllers
{
    [Route("api/menu")]
    public class MenuOptionsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public MenuOptionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET api/menu
        [HttpGet]
        public List<MenuOption> Get()
        {
            var repo = _unitOfWork.Repository<MenuOption>();
            return repo.GetAll().ToList();
        }
    }
}
