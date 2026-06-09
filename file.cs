using System;
using System.Net.Http;
using System.Threading.Tasks;

class PublicIPViewer
{
    static async Task Main()
    {
        Console.WriteLine("╔════════════════════════════════╗");
        Console.WriteLine("║   ИНФОРМАЦИЯ О ГЛОБАЛЬНОМ IP  ║");
        Console.WriteLine("╚════════════════════════════════╝\n");
        
        try
        {
            using(HttpClient client = new HttpClient())
            {
                Console.WriteLine("⏳ Получаю данные...\n");
                
                // Способ 1: ipify
                string publicIP = await client.GetStringAsync("https://api.ipify.org");
                Console.WriteLine($"🌍 Ваш публичный IP: {publicIP}");
                
                // Дополнительная информация
                Console.WriteLine("\n📍 Дополнительная информация:\n");
                string geoData = await client.GetStringAsync($"https://ipapi.co/{publicIP}/json/");
                Console.WriteLine(geoData);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"❌ Ошибка: {ex.Message}");
            Console.WriteLine("Убедись, что у тебя есть интернет!");
        }
    }
}
