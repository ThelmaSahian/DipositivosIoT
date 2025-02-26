namespace SensoresIoT.Models
{
    // Clase padre abstracta con método ProcesarDatos
     public abstract class Sensor
     {
        public long ID { get; set; }
        public string? Tipo { get; set; }

        public virtual void ProcesarDatos()
        {

        }

        // Se aplica principio de encapsulamiento para acceder al método privado ProcesarDatos
        private string ProcesarDatos(string tipo, int cantidad)
        {
            return "El dispositivo " + tipo  + " tiene " + cantidad.ToString() + " de valor.";
        }

        public void ProcesarDatosSensor(string tipo, int cantidad)
        {
            ProcesarDatos(tipo, cantidad);
        }
    }
}
