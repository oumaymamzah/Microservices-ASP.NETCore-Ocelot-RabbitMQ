Ce projet implémente une architecture microservices utilisant ASP.NET Core Web API, composée de :

ProductsAPI – microservice de gestion des produits

OrdersAPI – microservice de gestion des commandes

ApiGateway – passerelle API basée sur Ocelot

RabbitMQ + MassTransit – pour la communication asynchrone entre microservices

Le projet illustre :

La séparation des responsabilités (architecture microservices)

La création et exposition d’API indépendantes

L’utilisation d’un API Gateway centralisé

Le routing et virtualisation des endpoints via Ocelot

La communication asynchrone via Message Broker (RabbitMQ)

La synchronisation automatique entre microservices (Products → Orders)

🌐 Architecture générale

L'application est composée de 3 services :

ProductsAPI
Microservice permettant la gestion des produits.

OrdersAPI
Microservice responsable des commandes, recevant les données produits via RabbitMQ.

ApiGateway
Point d’entrée unique basé sur Ocelot pour router les requêtes vers les microservices.

Shared
Bibliothèque de classes contenant les DTO partagés entre les services.

📡 Communication asynchrone

La synchronisation des données s’effectue via :

RabbitMQ (Message Broker)

MassTransit (framework de messages)

Chaque fois qu’un produit est créé dans ProductsAPI, un message ProductCreated est envoyé, consommé ensuite par OrdersAPI.

🚀 Technologies utilisées

ASP.NET Core 6/7 Web API

Entity Framework Core

Ocelot API Gateway

RabbitMQ

MassTransit

Docker

SQL Server

Postman (tests)
