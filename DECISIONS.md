# Décisions

## Exercice 1 — Tell, Don't Ask

La multiplication des getters est le fait d'aller chercher les données de l'objet pour faire les opérations dessus tandis que 
Tell, D'ont ask fait en sorte de demander à l'objet de faire l'opération. Cela permet de ne pas devoir aller chercher les
données internes de l'objet.

## Exercice 2 — OCP, LSP, ISP et composition

À compléter :

- raison pour laquelle le contrat de calcul reste étroit et la description destinée à l’affichage sort des calculateurs:
	- Service ne devrait pas produire du texte pour l'interface
- correction de la hiérarchie fragile:
	- CLGratuit n'hérite plus de CLStandard
- ajout permis par OCP:
	- Permet d'ajouter des modes de calcul de frais sans modifier ServiceLivraison
- raison pour laquelle le polymorphisme obtenu n'est pas encore Strategy:
	- On laisse toujours le calcul de frais dans ServiceLivraison

## Exercice 3 — Strategy

- cascade ou sélection qui fragilise la classe `ServiceLivraisons`:
	- Calcul des frais de livraison (les ifs)
- comportement variable:
	- Gratuit, standard, et prioritaire
- responsabilité stable du contexte:
	- Savoir si le client est prioritaire
- qui choisis stratégie concrète:
	- Objet détenant `ServiceLivraison`
- classes ou interfaces jouant les rôles de contexte, de contrat Strategy, de
  stratégies concrètes et emplacement servant de point de composition:
	- Contexte -> ServiceLivraison
	- Strategy -> ICalculateur
	- Stratégies concrétes -> Héritant de ICalculateur
	- Dans Program.ChoisirCalculateur
- rôle de la méthode statique `Program.ChoisirCalculateur` et endroit où
  subsistent les conditions de sélection:
	- Choisit le calculateur dépendanment du client et du mode
- liens avec OCP, DIP et la composition:
	- Compose `ServiceLivraison` avec le calculateur de frais
	- OCP: On essaye d'ajouter des stratégie concrètes à place de modifier la méthode elle-même
	- DIP: La dépendance est une interface
- distinction entre le mécanisme de polymorphisme et le patron Strategy:
	- Le polymorphisme agit sur les objet eux-même tandis que le patron agit sur l'organisation d'un groupe d'objet
