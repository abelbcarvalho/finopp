using Npgsql;

namespace Database
{
    public class DBConnection
    {
        private static readonly string HOST = Environment.GetEnvironmentVariable("HOST") ?? "";
        private static readonly string USER = Environment.GetEnvironmentVariable("USER") ?? "";
        private static readonly string PASSWD = Environment.GetEnvironmentVariable("PASSWD") ?? "";
        private static readonly int PORT = int.Parse(Environment.GetEnvironmentVariable("PORT") ?? "5432");
        private static readonly string DBNAME = Environment.GetEnvironmentVariable("DB_NAME") ?? "";

        private static readonly string connectionString = $"Host={HOST};Username={USER};Password={PASSWD};Database={DBNAME};Port={PORT}";

        private static readonly Lazy<Task<NpgsqlConnection>> connectionTask = new(async () =>
        {
            var connection = new NpgsqlConnection(connectionString);
            await connection.OpenAsync();
            return connection;
        });

        public static async Task<NpgsqlConnection> GetConnectionAsync()
        {
            return await connectionTask.Value;
        }

        public static async Task<NpgsqlCommand> CommandAsync(string query)
        {
            var connection = await GetConnectionAsync();
            return new NpgsqlCommand(query, connection);
        }
    }
}