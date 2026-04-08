using System.Text.Json;

namespace GestionOI.Campagne;

public class ModelCampagne
{
    public static void DataContent()
    {
        var json = File.ReadAllText("../../../Data/campagnes.json");
        //return new StringContent(jsonString, Encoding.UTF8);
        var data = JsonSerializer.Deserialize<List<Campagne>>(json);

        if (data != null)
            foreach (var campagne in data)
            {
                Console.WriteLine($"Id de la campagne: {campagne.Id}");
            }
    }
    public class Campagne {
        public int Id {  get; set; } 
        public double Budget { get; set; }
        public string? Acheteur { get; set; }
        public string? Commentaire { get; set; }
            
     };

}