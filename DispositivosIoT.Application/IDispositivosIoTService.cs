using SensoresIoT.DispositivosIot.Domain.Models;

namespace Dipositivos.DispositivosIoT.Application
{
    public interface IDispositivosIoTService
    {
        /// <summary>
        /// Servicio para obtener los dispositivos por idTipo
        /// </summary>
        /// <param name="idTipo"></param>
        /// <returns></returns>
        Task<List<Dispositivos>> GetDispositivosByIdTipo(int idTipo);

        /// <summary>
        /// Servicio para obtener la información de los sensores
        /// </summary>
        /// <returns></returns>
        Task<List<Dispositivos>> GetInformation();

        /// <summary>
        /// Servicio para obtener la información de los sensores
        /// </summary>
        /// <returns></returns>
        Task<List<Dispositivos>> GetInformacionLimit(int limit);
    }
}
