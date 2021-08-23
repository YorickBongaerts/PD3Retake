Ik heb 2 versies ingediend:
V1 bevat een werkend project zonder dat de gamestates geimplementeerd zijn
V2 bevat een poging tot het implementeren van deze states


Antwoorden op de vragen in de .docx:


MULTIPLE PLAYERS:

Om het onderscheid weg te halen zorg ik dat enemies en hun movecommands
niet geregistered worden

de actieve pion kan uit Board.Pieces gehaald worden
op basis van Board._currentPlayerIndex

Alle pionnen staan in Board.Pieces

De speler wordt geactiveerd door het object in PlayerGameState._player
te steken en gedeactiveerd door het eruit te halen of een ander object er in
te steken. Ook wordt er in dezelfde methode de view van de oude player
unhighlighted en de view van de nieuwe gehighlight

TODO: 2 states maken
geen idee hoe ik dit zou moeten doen, ik begrijp gamestates enzo niet volledig,
dus opteer ik om dit niet te maken zodat ik een werkend project kan inleveren




TELEPORT:

Het path wordt berekend dmv AStar
in TeleportCard.Tiles(Tile playerTile, Tile cardTile)

Het path wordt weergeven door de pathtiles (die we uit TeleportCard.Tiles krijgen)
mee te geven aan _board.Highlight in de PlayerGameState

Ik heb dit gekoppeld door de originele Tiles() methode te vervangen door de nieuwe