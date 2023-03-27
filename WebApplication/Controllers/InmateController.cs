using DAL.Entity;
using DAL.Interfaces;
using forum.API.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InmateController : ControllerBase
    {
        private readonly ILogger<InmateController> _logger;

        private IUnitOfWork _ADOuow;
        public InmateController(ILogger<InmateController> logger,

            IUnitOfWork ado_unitofwork)
        {
            _logger = logger;

            _ADOuow = ado_unitofwork;
        }

        //GET: api/events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inmate>>> GetAllEventsAsync()
        {
            try
            {
                var results = await _ADOuow._inmateRepository.GetAsync();

                _logger.LogInformation($"Отримати усіх жильців!");
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Транзакція сфейлилась! Щось пішло не так у методі GetAllEventsAsync() - {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "вот так вот!");
            }
        }

    }
}
