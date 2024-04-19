using Generic;

ComparablePair<int, string> pair1 = new ComparablePair<int, string>(1, "one");
ComparablePair<int, string> pair2 = new ComparablePair<int, string>(1, "two");
ComparablePair<int, string> pair3 = new ComparablePair<int, string>(1, "one");

Console.WriteLine(pair1.CompareTo(pair2));
Console.WriteLine(pair2.CompareTo(pair1));
Console.WriteLine(pair1.CompareTo(pair3));




