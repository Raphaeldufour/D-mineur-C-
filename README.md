# Démineur MVC en C#

Ce projet est une implémentation du jeu classique de Démineur, développé en C# en utilisant le modèle MVC (Modèle-Vue-Contrôleur). L'architecture MVC permet une séparation claire entre la logique de l'application, l'interface utilisateur et la gestion des événements, rendant le code plus maintenable et modulaire. Ce projet exploite également le principe de polymorphisme pour renforcer la flexibilité et la réutilisabilité du code, particulièrement au niveau de la gestion des différents types de cases du plateau de jeu.

## Fonctionnalités

- **Modèle MVC** : Architecture modulaire avec séparation des responsabilités entre le Modèle, la Vue et le Contrôleur.
- **Polymorphisme** : Utilisation du polymorphisme pour gérer les différents types de cases (libres, mines, etc.), facilitant l’extension du code pour de nouvelles fonctionnalités.
- **Interface utilisateur interactive** : Un affichage clair et intuitif du plateau de jeu avec une détection des événements utilisateurs.
- **Gestion de la logique du Démineur** : Placement aléatoire de mines, calcul du nombre de mines voisines et gestion de la révélation des cases.

## Technologies utilisées

- **Langage** : C#
- **Patron de conception** : MVC
