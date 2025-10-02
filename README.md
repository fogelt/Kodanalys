# Kodanalys och Refaktorering

## Syfte
Syftet var att analysera befintlig C#-kod, identifiera brister och förbättra läsbarhet, underhållbarhet och struktur.

## Identifierade problem
1. **Dåliga namn**  
   Exempel: `celestialWhispers`, `magicConstant`. Svårt att förstå syftet.  

2. **Duplicerad kod**  
   Samma söklogik fanns i flera metoder → bröt mot DRY-principen.  

3. **Onödigt komplicerade if/else-satser**  
   Långa kedjor för menyval gjorde koden svår att bygga ut.  

4. **Manuell array-hantering**  
   Användare sparades i `string[]` + separat räknare → risk för buggar.

6. **Inkonsekvent stil**  
   Blandade språk och felaktig namngivning (`class program` i stället för `Program`).  

## Förbättringar
- **Tydliga namn**: `UserList`, `UserCount` → ökad läsbarhet.  
- **Extraherad sökmetod**: `FindUserIndex()` → minskad duplicering.  
- **Switch + enum**: ersatte if/else-kedjor → mer strukturerad kod.  
- **List<string>**: ersatte array + räknare → enklare och robustare.  
- **Enhetlig kodstil**: PascalCase för klasser och metoder, konsekvent språk.  

## Reflektion
Refaktoreringen gjorde programmet mer robust, tydligt och lätt att bygga ut.  
Jag har lärt mig vikten av:  
- God namngivning  
- DRY-principen  
- Att använda rätt datastrukturer  
- Konsekvent kodstil  
