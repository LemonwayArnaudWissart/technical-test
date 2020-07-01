Test technique Lemonway

Afin de pouvoir exploiter la solution correctement, je vous demande deux petites actions que je ne suis pas parvenu à sauvegarder au niveau des fichiers projets "pour tous" (malgré avoir coché la case "pour tous les utilisateurs" ?) mais au niveau des fichiers user, qui sont exclus via git ignore.

1/ Aller dans les propriétés du projet SoapService de manière à lui demander de démarrer sur la page WebService.asmx

2/ Au niveau des propriétés de la solution, cette fois, faire en sorte qu'il y ait 2 (ou 3) projets de démarrage (SoapService et WinformsApp et éventuellement ConsoleApp)

Désolé pour ce petit désagrément mais je suis à court de temps et soit je vous renvoie le test maintenant dans cet état, soit je le corrige mais ce ne sera pas dans au moins deux jours...

Les packages utilisés : 

- NewtonSoft JSON
- Log4Net

J'ai cherché de l'inspiration sur, essentiellement, Code Project ou Stackoverflow pour une implémentation de la suite de Fibonacci (j'ai opté pour la version récursive) et afin de voir s'il existait des solutions un peu plus modernes et "friendly" de la gestion asynchrone sous Winforms car j'en étais resté au backgroundWorker (ça faisait un moment que je n'avais pas fait de winfoms).

J'ai mis quelques tests unitaires concernant les deux fonctionnalités du service.

Quant à Log4Net, là encore, j'ai été un peu pris par le temps, je n'ai mis qu'une très simple implémentation dans le projet de service, qui log donc dans un fichier (log-file.txt) à la racine de celui-ci.

Je reste à votre disposition sur arnaud.wissart@live.fr
