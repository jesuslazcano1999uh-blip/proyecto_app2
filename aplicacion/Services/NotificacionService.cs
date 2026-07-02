using MySql.Data.MySqlClient;

namespace aplicacion.Services
{
    public class NotificacionService
    {
        private readonly string _connectionString;

        public NotificacionService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MySqlConnection");
        }

        public int Guardar(
            string titulo,
            string? descripcion,
            DateTime fecha,
            TimeSpan hora,
            string categoria)
        {
            using var conn = new MySqlConnection(_connectionString);

            conn.Open();

            string sql = @"INSERT INTO tbl_notificaciones
                           (Titulo,Descripcion,Fecha,Hora,Categoria)
                           VALUES
                           (@titulo,@descripcion,@fecha,@hora,@categoria);

                           SELECT LAST_INSERT_ID();";

            using var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@titulo", titulo);
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@hora", hora);
            cmd.Parameters.AddWithValue("@categoria", categoria);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
