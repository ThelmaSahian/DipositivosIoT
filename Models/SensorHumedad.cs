namespace SensoresIoT.Models
{
    //Clase SensorHumedad Hereda de Sensor
    public class SensorHumedad : Sensor
    {
        public long IdSensor {  get; set; }
        public string? TipoSensor { get; set; }

        public string? Humedad { get; set; }
        public SensorHumedad() { }

        // Se aplica polimorfismo a método ProcesarDatos de clase padre Sensor
        public virtual SensorHumedad ProcesarDatos()
        {
            
            return new SensorHumedad();
        }
    }
}
