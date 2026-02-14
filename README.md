# CSharp Data Algorithms

This project contains a set of generic search and sorting algorithms implemented in C#.

The goal of the project is to demonstrate understanding of:
- basic algorithms
- generics
- separation of concerns
- clean project structure

## Project Structure
```text
DataAlgorithms/
├── Comparers/
│   └── PersonLastNameComparer.cs
├── Models/
│   └── Person.cs
├── Searching/
│   ├── BinarySearch.cs
│   └── LinearSearch.cs
├── Sorting/
│   ├── BubbleSort.cs
│   ├── MergeSort.cs
│   └── QuickSort.cs
├── Program.cs
├── DataAlgorythms.csproj
└── DataAlgorithms.sln
```

## Implemented Algorithms

### Searching
- Linear Search
- Binary Search (requires sorted collection)

### Sorting
- Bubble Sort
- Quick Sort
- Merge Sort

## Design Principles

- All algorithms are implemented using generics
- Comparison logic is separated via `IComparer<T>`
- No UI or console logic is included
- Algorithms are reusable in WPF or ASP.NET projects

## Example Usage

```csharp
var people = new List<Person>
{
    new Person { LastName = "Ivanov", Age = 30 },
    new Person { LastName = "Petrov", Age = 25 }
};

var comparer = new PersonLastNameComparer();

QuickSort.Sort(people, comparer);

int index = BinarySearch.Search(
    people,
    new Person { LastName = "Petrov" },
    comparer
);
```


### Future Improvements
- Add unit tests
- Add more comparers
- Use algorithms in a WPF application
