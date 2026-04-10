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

    public static void FindCampagneByAcheteur(string acheteur)
    {
        var data = DataContent();
        var elements = data
            .Where(campagne => !string.IsNullOrEmpty(campagne.Acheteur) && campagne.Acheteur.Contains(acheteur, StringComparison.OrdinalIgnoreCase))
            .Select(campagne => campagne.Nom)
            .ToList();


        foreach (var campagne in elements)
            Console.WriteLine(campagne);
    }

}