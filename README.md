## Wechselgeldautomat

nimmt einen vom Benutzer eingegebenen Geldbetrag und zerlegt ihn in die minimale Anzahl von Euro-Münzen

#### Sie verarbeitet:

- Benutzereingabe des Geldbetrags
- Validierung der eingegebenen Daten
- Umwandlung von Euro in Cent
- Berechnung der Münzen
- Ausgabe der benötigten Münzanzahl.

#### Unterstützte Münzwerte:
2 Euro, 1 Euro, 0,50 Euro, 0,20 Euro, 0,10 Euro, 0,05 Euro, 0,02 Euro, 0,01 Euro

### Wie funktioniert 
Beim Start fordert das Programm den Benutzer auf, einen Geldbetrag einzugeben.

#### Die Eingabe wird überprüft:
- das Feld darf nicht leer sein,
- die Eingabe muss eine gültige Dezimalzahl sein
 - der Wert muss größer als 0 sein.

#### Nach der Validierung:
- wird der Euro-Betrag in Cent umgewandelt
- durchläuft das Programm alle verfügbaren Münzwerte
- berechnet, wie viele Münzen jeder Sorte benötigt werden
- gibt nur die tatsächlich verwendeten Münzen aus.

  
