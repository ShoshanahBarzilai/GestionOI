## Projet
Plateforme Ecommerce pour acheter des campagnes

### Architecture prévue
- Domaine : service qui applique la logique métier (filtres...), model, interface du repository
- Application : usecase qui appelle le domaine, y récupère les filtres, et appelle le repository pour récupérer les données depuis l infra
- Infra : lit les données Json et les parse dans l implementation du repository

- Repository : transmet ces données au domaine => implémentation coté infra et interface coté Domaine

### Arborescence prévue
	|-- Domaine
	|   |-- Models
	|      |-- Campagne.cs
	|   |-- InterfaceRepository.cs
	|   |-- Service.cs
	|-- Application
	|   |-- CampagneController.cs
	|   |-- CampagneUseCase.cs
	|-- Infra
	|   |-- Data
	|      |-- Campagnes.json
	|   |-- ImplementationRepository.cs
	`-- README.md

	
### Fonctionnalités actuelles
- Recherche de données via un filtre dans l'url (baseUrl/campagnes?filtre=nom ou baseUrl/campagnes?filtre=acheteur)

### Fonctionnalités prévues
- manipulation des données du tableau : ajout de campagne, suppression... et donc réecriture du json pour persister