using GestionOI.Services;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/campagnes", (string filtre) =>
{
    return ServiceCampagne.FilterCampagnes(filtre);
});

app.Run();