﻿# Ćwiczenia z NUnit dla testerów automatyzujących
Pełna dokumentacja NUnit jest tutaj: https://docs.nunit.org/articles/nunit/intro.html

#### Wstęp
Wszystkie atrybuty: https://docs.nunit.org/articles/nunit/writing-tests/attributes.html

Ważne atrybuty:
* `[TestFixture]`
* `[Test]`
* `[Random]`
* `[Range]`
* `[Repeat]`
* `[Retry]`
* `[Setup]` oraz `[TearDown]`
* `[Values]`


#### Zadanie 1 - Assert
Klasyczne asercje: https://docs.nunit.org/articles/nunit/writing-tests/assertions/classic-assertions/Assert.True.html
1. Obejrzyj klasę `CalculatorService.cs`
2. Napisz dla niej testy które pokryją 100% kodu
3. Spróbuj użyć parametryzacji testów
4. Pamiętaj o asercjach.


#### Zadanie 2 - StringAssert
Dokumentacja klasy StringAssert: https://docs.nunit.org/articles/nunit/writing-tests/assertions/classic-assertions/String-Assert.html

1. Obejrzyj klasę `HtmlTextFormatter.cs`
2. Napisz dla niej testy które pokryją 100% kodu
3. Spróbuj użyć parametryzacji testów
4. Użyj do porównania klasy StringAssert
5. Odpal testy równolegle, żeby było lepiej widać różnicę dodaj w klasie testowej metodę która wymusi pauzę
```csharp
[TearDown]
public void TearDown()
{
    Thread.Sleep(1500);
}
```

#### Zadanie 3 - Range
1. Obejrzyj klasę `NumberService.cs`
2. Napisz dla niej testy które sprawdzą dla jakich wartości dostajemy niespodziewany efekt.
3. Użyj funkcji Range jeżeli nie chcesz wypisywać wszystkich wartości


#### Zadanie 4 - Timeouty
1. Obejrzyj klasę `WeirdService.cs`
2. Napisz test który przetestuje metodę `ThisMethodWillTimeout()` i ustaw mu Timeout na 2 sekundy
3. Popraw kod tak żeby test przeszedł.
4. Uruchom test jeszcze raz.


#### Zadanie 5 - Testowanie wyjątków
1. Napisz dla metody `ThisMethodWillThrowExceptionIfParameterIsZero(int parameter)` w klasie `WeirdService.cs` test, który sprawdzi czy funkcja rzucą wyjątkiem


#### Zadane 6 - Retry
1. Napisz test, który sprawdzi metodę `ThisMethodWillPassSometimes()`
2. Jako przechodzącą asercję ustaw rezultat mniejszy od 1000
3. Uruchom go parę razy (sprawdź czy przechodzi).
4. Ustaw automatyczne powtarzanie testu w przypadku failu na 5 razy.


#### Zadanie 7 - CollectionAssert
Dokumentacja klasy: https://docs.nunit.org/articles/nunit/writing-tests/assertions/classic-assertions/Collection-Assert.html
1. Napisz test dla klasy `CollectionService`;
2. Przetestuj utworzenie nowego obiektu konstruktorem bezparametrowym.
3. Sprawdź czy property `Names` zawiera unikalne elementy.
4. Sprawdź czy property `Names` nie jest puste (i nie zawiera nulli)


#### Zadanie 8 - Multiple Asserts
1. Utwórz nowy obiekt konstruktorem `CollectionService` i jako parametr przekaż listę ze swoim imieniem i nazwiskiem.
2. Sprawdź czy metoda `GetInitialsFromNames()` zwraca poprawne inicjały
3. Dodaj kolejny element do listy nazwisk (np. kolegi)
4. Sprawdź rozmiar listy imion oraz listy inicjałów są takie same.
5. Złap wszystkie asercje w `Assert.Multiple()`