# Level
## Definition
* Nur sidescrolling, links nach rechts
* In Abschnitte aufgeteilt
* Kamera Bewegung abhängig von Raumgröße
* Ein normaler Raum ist abgeschlossen wenn alle Gegner besiegt sind
* Eine Lange Map
* Man kann immer zurück Laufen
* Loot direkt verteilen

## Attirbutes
### Level
* Liste - Räumen

### Rooms
* Liste - Gegner Prefab -  Was im raum sein kann
* Size - physikalische Größe des Raums
* Int EnemysToSpawn - Wie viele gesamt im raum sind
* Int MaxEnemys - Wie viele Gegner maximal gleichzeitig aktiv sein dürfen
* float SpawnDelay - mindest delay zwischen enemy spawns

## Ablauf
1. Level wird geladen
2. Intro Sequenz
3. Start Gameplay
4. Starting Room: keine Gegner
5. N Räume:
5.1 Event - Spieler laufen auf die Map
5.2 Event - Raum Intro - ggf. einführung für iwas
5.3 Start Gameplay
5.4 Solange noch Gegner im Pool, werden welche gespawned
5.5 Wenn gegner tot sind gehts weiter
5.6 Room ist geschafft, progression zum nächsten wird ermöglicht
6. wenn Alle Räume geschafft sind ist level eigenschaft
7. Event - Level Done
8. Nächstes Level freigeschaltet
9. Zurück ins Menü
