namespace SensoresIoT.Models
{
    // Clase SensorTemperatura hereda de clase abstracta se
    public class SensorTemperatura : Sensor
    {
        public int Temperatura { get; set; }
        public SensorTemperatura() { }

        // Se aplica polimorfismo a método ProcesarDatos de clase padre Sensor
        public virtual SensorTemperatura ProcesarDatos()
        {
            return new SensorTemperatura();
        }
        
    }
}
