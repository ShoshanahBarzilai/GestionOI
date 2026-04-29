using GestionOI.Models;
using System.Text.Json;

namespace GestionOI.Services;

public class ServiceCampagne
{
    public static List<Campagne> DataContent()
    {
        var json = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Data", "campagnes.json"));
        var dataJson = JsonSerializer.Deserialize<List<Campagne>>(json);

        return dataJson ?? [];
    }

    public static List<string> FilterCampagnes(string filtre)
    {
        var data = DataContent();
        var result = filtre switch
        {
            "nom" => data
                .Where(campagne => !string.IsNullOrEmpty(campagne.Nom))
                .Select(campagne => campagne.Nom!)
                .ToList(),
            "acheteur" => data
                .Where(campagne => !string.IsNullOrEmpty(campagne.Acheteur))
                .Select(campagne => campagne.Acheteur!)
                .ToList(),
            _ => []
        };
       
        return result;
    }
}