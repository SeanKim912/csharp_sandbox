using System.Collections.Generic;
using System.Linq;

/*
List is a class in a group of classes called generic collections. Don't exist in default set of System classes, so have
to be referenced. Formal class name of lists is List<T>, with T being a type parameter. Since it's part of Generic, you
don't need to know type to use members like Add() or Remove() with lists.
*/

/*
LISTS

Arrays have limtied length, number of elements have to be tracked in a separate index,
and elements can only be edited one at a time.

Lists are effectively unlimited in length, automatically track number of elements, and have
methods to work with multiple elements at once.
*/

List<string> cities = new List<string>();

cities.Add("Chicago");
cities.Add("London");

Console.WriteLine($"{cities[0]}, {cities[1]}");

List<double> times = new List<double> { 8.7, 9.1, 9.0, 8.9 };
Console.WriteLine(times.Count);
bool hasParis = cities.Contains("Paris");
Console.WriteLine(hasParis);

bool removed = times.Remove(8.3); // Remove returns a boolean based on if element was removed successfully.
Console.WriteLine(removed);
// List.Clear() will remove all items in the list.

times.AddRange(new double[] {9.2, 8.8});
times.InsertRange(1, new double[] { 10.0, 10.0 });
times.RemoveRange(1, 1);
Console.WriteLine(times.GetRange(0, 5));

/*
LINQ

Alternative to lists/arrays for databases. Works for complex selections and transformations, local and remote
data sources. Each selection/transfromation is a query.

Query syntax has three parts:
from declares a variable to iterate through sequence
where picks elements from the sequence if given condition is satisfied
select determines what is returned for each element in sequence

in method syntax
select takes a lambda expression and applies it to every element in sequence.
*/

List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

    var shortHeroes = from h in heroes
    where h.Length < 8
    select h;

    foreach(string hero in shortHeroes)
    {
        Console.WriteLine(hero);
    }

    var longHeroes = heroes.Where(n => n.Length > 8);
    var longLoudHeroes = longHeroes.Select(h => h.ToUpper());
    foreach(string hero in longLoudHeroes)
    {
        Console.WriteLine(hero);
    }

    var lowerHeroesWithC = heroes
    .Select(h => h.ToLower())
    .Where(h => h.Contains("c"));

    foreach(string hero in lowerHeroesWithC)
    {
        Console.WriteLine(hero);
    }
