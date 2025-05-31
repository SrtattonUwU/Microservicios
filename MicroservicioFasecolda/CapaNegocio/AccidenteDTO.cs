namespace CapaNegocio
{
    public class AccidenteDTO
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public DateTime Fecha { get; set; }
        public string Severidad { get; set; }

        public AccidenteDTO(){}

        public AccidenteDTO(int id, string placa, DateTime fecha, string severidad)
        {
            this.Id = id;
            this.Placa = placa;
            this.Fecha = fecha;
            this.Severidad = severidad;
        }


    }
}
