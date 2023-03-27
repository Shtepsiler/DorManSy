
using DAL.Interfaces;
using DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace forum.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuritureController : ControllerBase
    {
        private readonly ILogger<FuritureController> _logger;

        private IUnitOfWork _ADOuow;
        public FuritureController(ILogger<FuritureController> logger,

            IUnitOfWork ado_unitofwork)
        {
            _logger = logger;

            _ADOuow = ado_unitofwork;
        }

        //GET: api/events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dormitory>>> GetAllEventsAsync()
        {
            try
            {
                var results = await _ADOuow._DormitoryRepository.GetAsync();
                
                _logger.LogInformation($"Отримати усі гуртожитки!");
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
