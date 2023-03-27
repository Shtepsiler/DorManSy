using DAL.Entity;
using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {

        private readonly ILogger<RoomController> _logger;

        private IUnitOfWork _ADOuow;
        public RoomController(ILogger<RoomController> logger,

            IUnitOfWork ado_unitofwork)
        {
            _logger = logger;

            _ADOuow = ado_unitofwork;
        }

        //GET: api/events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetAllEventsAsync()
        {
            try
            {
                var results = await _ADOuow._roomRepository.GetAsync();

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
