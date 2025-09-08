﻿# Uppgift: “Mini-äventyr” – textbaserat konsolspel

## Översikt (vad du ska bygga)
Du ska bygga ett litet, textbaserat äventyrsspel i konsolen. Spelet börjar med att spelaren
väljer ett **användarnamn** och en **klass** (t.ex. _Warrior_ eller _Mage_). Valet påverkar startvärden
som HP, skada och ev. mana. Spelaren kan sedan:

- Gå på **äventyr** och möta slumpade **fiender**,
- **Vila** för att återfå lite HP,
- Visa **status**,
- Eller **avsluta** spelet.

Striderna är enkla turordningsstrider: spelaren väljer en handling (t.ex. Attack, Heal, Run),
fienden slår tillbaka om den lever. Om spelaren vinner får hen lite **guld**; om HP tar slut är
spelet över.
## Krav för Godkänd
För att bli godkänd ska ditt program uppfylla alla punkter nedan:
1. **Variabler**
    - Använd variabler för spelarens data: användarnamn, klass, HP/MaxHP,
   skada, guld (och ev. mana). 
    - Använd variabler för fiendernas värden (HP, skada, guldbelöning).
2. **Villkor (conditions)**
   - Använd if/else eller switch för beslut (t.ex. klassval, menyval, stridsval
      och resultat).
3. **Loopar**
   - En huvudloop för spelet (kör tills spelaren dör eller väljer att avsluta). 
   - En loop för strider (fortsätter tills fienden eller spelaren har 0 HP).
4. **Arrayer**
   - Minst en array som används i spelet (t.ex. lista på fiendenamn eller möjliga
      handlingar/loot).
   - Använd arrayen i logiken (t.ex. slumpa fiende från arrayen eller iterera för att skriva ut val).
5. **Metoder**
   - Minst tre egna metoder med tydliga namn och ett syfte, t.ex.:
     -  Metod som skriver ut status,
     - Metod som skapar/slumpar en fiende,
     - Metod som hanterar spelarens tur,
     - Metod som hanterar fiendens tur.
6. **Enkla klasser**
   - Skapa en enkel Player-klass med fält/egenskaper för namn, klass,
      HP/MaxHP, skada, guld.
   - Skapa en enkel Enemy-klass med namn, HP, skada, guldbelöning.
7. **In-/utdata i konsolen**
   - Skriv tydliga instruktioner och läs in spelarens val.
   - Visa resultat efter val (t.ex. skada, återstående HP, vinst/förlust).
8. **Struktur** & läsbarhet
   - Tydliga metodnamn, rimliga variabelnamn, enkel indentering, korta kommentarer vid behov.
   - ## Rekommenderade byggsteg (gör i ordning)
1. [ ] **Start & spelardata:** Läs in användarnamn. Låt spelaren välja klass 
   (t.ex. _Warrior/Mage_) och sätt startvärden (HP/MaxHP/skada/guld) beroende på valet. 
2. [ ] Array för fiender: Skapa en array med fiendenamn (t.ex. _Rat, Goblin, 
   Skeleton, Bandit_). 
3. [ ] **Huvudmeny (loop):** Visa valen _Äventyr, Vila, Status, Avsluta_. Fortsätt loopen tills spelaren dör eller väljer att avsluta. 
4. [ ] **Äventyr:** Slumpa fram en fiende baserat på fiende-arrayen. Ge fienden rimliga stats (HP, skada, guldbelöning).
6. [ ] **Stridsloop:** Låt spelaren välja handling (t.ex. _Attack, Heal, Run_). Efter spelarens tur slår fienden om den lever. Avsluta striden när någon når 0 HP. 
7. [ ] **Belöning eller nederlag:** Vid vinst öka spelarens guld. Vid nederlag 
8. [ ] avsluta spelet med _Game Over_. 
9. [ ] **Vila:** Återställ en liten mängd HP upp till MaxHP. 
10. [ ] **Status:** Skriv ut spelarens namn, klass, HP/MaxHP, skada och guld. 
11. [ ] **Metoder:** Flytta tydliga delmoment till metoder (status, skapa fiende, spelares tur, fiendens tur).
12. [ ] **Finjustering:** Testa, skriv tydliga texter, se till att alla krav uppfylls.

## Bedömningsmatris (snabb)
- **Godkänd:** Samtliga krav under “Krav för Godkänd” uppfyllda. Programmet körs 
  utan krasch, flödet är begripligt. 
- **Underkänd:** Ett eller flera krav saknas, programmet kraschar direkt, eller spelets flöde går inte att följa.

## Inlämning
- Ladda upp din kod på github och lägg upp länken

## Tips (frivilligt, påverkar inte betyg)
- Öka svårighet stegvis efter varje vinst (lite starkare fiender).
- Lägg till en enkel “heal”-begränsning (t.ex. får användas varannan runda).
- Lägg in en liten array med loot-meddelanden för variation i vinsterna.