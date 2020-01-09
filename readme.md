# BillShare(Domainname: BillShare)
Beschreibung vom Projekt.  
Das ist eine neue Zeile.  
Eine Auflistung kann wie folgt erstellt werden.:  
+ **Schritt 1:**  
+ **Schritt 2:**
+ *Schritt 3:*

Ein Programmabschnitt kann auch eingefügt werden. Dazu verwendet man folgende Syntax:

```csharp
public class Perosn{
    public string Name { get; set; }
}
```

## Projektstruktur erstellen

+ **Schritt 1**  
ProjektName Überlegen und mit diesen eine BlankSolution anlegen

+ **Schritt 2**  
Eine Klassenbibliothek 'CommonBase' erstellen. In dieser Bibleothek werden alle Algorithmen, welche unabhängig vom Domainbereich sind gesammelt.

+ **Schritt 3**  
Eine Klassenbibliothek für die Schnittstellen(Interfaces) anglegen. Der Projektname wird wie folgt definiert: [Domainname].Contracts. 

+ **Schritt 4**  
Eine Klassenbibleothek für die Geschäftslogik. In diesem Projekt werden alle Geschäftsprozesse gesammelt. Projektname wird wie folgt definiert: [Domainname].Logic   
+ **Schritt 5**  
Erstellen einer Konsolenapplikation zum Testen der Struktur. Projektname wird wie folgt definiert: [Domainname].ConApp   

**Hinweis!!!**  Im weiteren Ausbau werden noch weitere Projekte hinugefügt(z.B. Rest-Service)

+ **Schritt 6**  
Abhängigkeiten definieren.