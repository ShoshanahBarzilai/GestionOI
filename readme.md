## Projet
Plateforme Ecommerce pour acheter des campagnes

### Sources
- Lecture json : https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/deserialization
- LinQ : https://learn.microsoft.com/fr-fr/dotnet/csharp/linq/
- Gestion de chaine vide : https://learn.microsoft.com/fr-fr/dotnet/api/system.string.isnullorempty?view=net-10.0
- Règles de comparaison (pour la lecture du json) : https://learn.microsoft.com/fr-fr/dotnet/api/system.string.contains?view=net-10.0
- Reconstruction du chemin vers Data/campagnes.json (pour éviter le chemin relatif) : Demande à Copilot en lui précisant d'utiliser "le fichier .csproj
- Migration de l'applicationConsole en API REST : https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-8.0 et https://learn.microsoft.com/en-us/dotnet/core/project-sdk/overview

### Architecture prévue
- Domaine : service qui applique la logique métier (filtres...), model, interface du repository
- Application : usecase qui appelle le domaine, y récupère les filtres, et appelle le repository pour récupérer les données depuis l infra
- Infra : lit les données Json et les parse dans l implementation du repository

- Repository : transmet ces données au domaine => implémentation coté infra et interface coté Domaine

### Arborescence prévue
| - Domaine
  | - Model
  | - InterfaceRepository
  | - Service
| - Application
  | - Controller
  | - UseCase
| - Infra
  | - Json
  | - ImplementationRepository
	
#### Fonctionnalités actuelle
- Recherche de données via un filtre dans l'url (baseUrl/campagnes?filtre=nom ou baseUrl/campagnes?filtre=acheteur)

#### Fonctionnalités prévus
- manipulation des données du tableau : ajout de campagne, suppression... et donc réecriture du json pour persister