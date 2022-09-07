using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JobDomain.Dtos.Candidate;
using JobDomain.Core.Interfaces.Services;

namespace JobApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CandidateController : ControllerBase
    {
        private ICandidateService _candidateService;

        public CandidateController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        // POST: CandidateController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromBody] CandidateDto candidate)
        {
            try
            {
                _candidateService.AddAsync(candidate);
                return Ok();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        // POST: CandidateController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public void Edit(int id, IFormCollection collection)
        {
            try
            {
                //return Ok();
            }
            catch
            {
                ;
            }
        }


        // POST: CandidateController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public void Delete(int id, IFormCollection collection)
        {
            try
            {
                // return Ok();
            }
            catch
            {
                ;
            }
        }
    }
}
