# Décisions

## Exercice 1 — Tell, Don't Ask

La multiplication des getters est le fait d'aller chercher les données de l'objet pour faire les opérations dessus tandis que 
Tell, D'ont ask fait en sorte de demander à l'objet de faire l'opération. Cela permet de ne pas devoir aller chercher les
données internes de l'objet.

## Exercice 2 — OCP, LSP, ISP et composition

À compléter :

- attentes communes des calculateurs substituables;
- raison pour laquelle le contrat de calcul reste étroit et la description
  destinée à l’affichage sort des calculateurs;
- délégation du calcul sous 50 $ par la classe du calculateur gratuit;
- correction de la hiérarchie fragile;
- ajout permis par OCP;
- raison pour laquelle le polymorphisme obtenu n'est pas encore Strategy.

## Exercice 3 — Strategy

- cascade ou sélection qui fragilise la classe `ServiceLivraisons`:
	- Calcul des frais de livraison (les ifs)
- comportement variable:
	- Gratuit, standard, et prioritaire
- responsabilité stable du contexte:
	- Savoir si le client est prioritaire
- Qui choisis stratégie concrète:
	- Objet détenant `ServiceLivraison`
- classes ou interfaces jouant les rôles de contexte, de contrat Strategy, de
  stratégies concrètes et emplacement servant de point de composition;
- rôle de la méthode statique `Program.ChoisirCalculateur` et endroit où
  subsistent les conditions de sélection;
- liens avec OCP, DIP et la composition;
- distinction entre le mécanisme de polymorphisme et le patron Strategy.
