Antwoorden op de vragen in de .docx


Om het onderscheid weg te halen zorg ik dat enemies en hun movecommands
niet geregistered worden

de actieve pion kan uit Board.Pieces gehaald worden
op basis van Board._currentPlayerIndex

Alle pionnen staan in Board.Pieces

De speler wordt geactiveerd door het object in PlayerGameState._player
te steken en gedeactiveerd door het eruit te halen of een ander object er in
te steken

TODO: 2 states maken

Het path wordt berekend dmv AStar
in TeleportCard.Tiles(Tile playerTile, Tile cardTile)

Het path wordt weergeven door de pathtiles (die we uit TeleportCard.Tiles krijgen)
mee te geven aan _board.Highlight in de PlayerGameState

Ik heb dit gekoppeld door de originele Tiles() methode te vervangen door de nieuwe
