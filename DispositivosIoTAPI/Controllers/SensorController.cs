using Dipositivos.DispositivosIoT.Application;
using Microsoft.AspNetCore.Mvc;
using SensoresIoT.DispositivosIot.Domain.Models;
using System.Collections.Generic;

namespace SensoresIoT.SensoresIoTAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SensorController : ControllerBase
    {
        private IDispositivosIoTService _dispositivosIoTService;
        private readonly ILogger<WeatherForecastController> _logger;

        public SensorController(ILogger<WeatherForecastController> logger, IDispositivosIoTService dispositivosIoTService)
        {
            _dispositivosIoTService = dispositivosIoTService;
            _logger = logger;
        }

        /// GET: SensorController/GetInformation
        /// <summary>
        /// Servicio para obtener la información de los sensores
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Dispositivos>> GetInformation()
        {
            List<Dispositivos> data = await _dispositivosIoTService.GetInformation();
            return data;
        }

        /// GET: SensorController/GetInformation
        /// <summary>
        /// Servicio para obtener la información de los sensores con paginación
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Dispositivos>> GetInformacionLimit(int limit)
        {
            List<Dispositivos> data = await _dispositivosIoTService.GetInformacionLimit(limit);
            return data;
        }
    }
}