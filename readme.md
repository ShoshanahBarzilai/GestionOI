## Projet
Plateforme Ecommerce pour acheter des produits

### Sources
- Lecture json : https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/deserialization
- LinQ : https://learn.microsoft.com/fr-fr/dotnet/csharp/linq/
- Gestion de chaine vide : https://learn.microsoft.com/fr-fr/dotnet/api/system.string.isnullorempty?view=net-10.0
- Règles de comparaison (pour la lecture du json) : https://learn.microsoft.com/fr-fr/dotnet/api/system.string.contains?view=net-10.0
- Reconstruction du chemin vers Data/campagnes.json (pour éviter le chemin relatif) : Demande à Copilot en lui précisant d'utiliser le fichier .csproj

#### Fonctionnalités
Recherche de campagnes via l'acheteur => donner le nom de l'acheteur en argument de ligne de commande : lancer dotnet run -- nomAcheteur