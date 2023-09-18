using Serilog;
using Serilog.Events;

namespace RentalCars.Application.Logging
{
    public static class ConfigureSerilog
    {
        public static void ConfigureLogger()
        {
            Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug() // En düşük log seviyesi
    .WriteTo.Console() // Logları konsola yaz
    .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day) // Günlük dosyasına yaz, her gün yeni bir dosya oluştur
    
    .Enrich.WithThreadId() // Thread kimliğini log kaydına ekler
    .CreateLogger();

        }
    }
}
