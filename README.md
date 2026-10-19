# Garage 1.0

En konsollapplikation i C# som simulerar ett parkeringsgarage. Projektet byggs med tanke på att kunna byggas vidare på i senare versioner i framtiden.

> **Status:** Under utveckling. Fordonsmodell, garage och tester är klara. Hanteringslager och menysystem är på gång.

## Funktioner

- Garage med fast storlek som sätts när det skapas
- Parkera och ta bort fordon via registreringsnummer
- Sökning på registreringsnummer är skiftlägesokänslig 
- Dubbletter av registreringsnummer nekas
- Fem fordonstyper: bil, buss, motorcykel, båt och flygplan

## Teknik och upplägg

- **.NET 10 / C#**
- **xUnit** för enhetstester
- `Garage<T>` är en generisk klass begränsad till `IVehicle`
- Fordonen lagras i en array (inte `List<T>`), enligt uppgiftens krav
- Garaget använder `IEnumerable<T>`, så det går att använda `foreach` och LINQ utan att den interna arrayen exponeras
- Delade egenskaper ligger i den abstrakta basklassen `Vehicle`, varje fordonstyp har sina egna egenskaper
- Fordonstyper som sport/touring och sedan/kombi är enums

## Struktur (just nu)

```
Garaget/
├── Ovning_5_Garaget/          Konsollapplikationen
│   ├── Vehicles/              IVehicle, Vehicle och fordonsklasserna
│   ├── Garages/               Garage<T>
│   └── UI/                    Menysystem (kommer)
└── Ovning_5_Garaget.Tests/    Enhetstester
```

## Kom igång

```bash
git clone https://github.com/irlmonster/Garaget.git
cd Garaget
dotnet run --project Ovning_5_Garaget
```

Köra testerna:

```bash
dotnet test
```

## Planerat

- `GarageHandler` som mellanlager mellan UI och garage
- Konsollmeny för att parkera, ta bort och lista fordon
- Sökning på flera egenskaper (färg, märke, antal hjul m.m.)
- Lista fordonstyper och antal av varje
- Mer idéer kan komma under uppbyggnad