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
