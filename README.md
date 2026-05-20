# QueueArray

A **.NET Framework 4.8 C# console app** that implements a Queue data structure backed by a fixed-size array.

---

## Data Structure Implemented

### Queue (Array-based)

A FIFO (First-In, First-Out) queue implemented on top of a statically allocated `int[]` array.

| Operation | Description | Time Complexity |
|---|---|---|
| `Enqueue(int e)` | Adds an element to the rear of the queue | O(1) |
| `Dequeue()` | Removes and returns the element at the front | O(1) |
| `First()` | Returns the front element without removing it | O(1) |
| `IsEmpty()` | Returns `true` if the queue has no elements | O(1) |
| `IsFull()` | Returns `true` if the queue has reached capacity | O(1) |
| `Lenght()` | Returns the current number of elements | O(1) |

**Limitations:** Fixed capacity set at construction time. Does not wrap around (non-circular).

---

## Project Structure

```
QueueArray/
├── QueueArray.cs   — Queue implementation backed by an int array
├── Helper.cs       — Static helper class with Display utility method
├── Program.cs      — Entry point; demonstrates Enqueue, Dequeue, and First
├── App.config      — Application configuration file
└── Properties/
	└── AssemblyInfo.cs — Assembly metadata
```

---

## Design Patterns / Architecture

- **Separation of Concerns** — Display logic is decoupled from the data structure and lives in the static `Helper` class, keeping `QueueArray` focused on queue operations only.
- **Encapsulation with Controlled Access** — Internal state (`data`, `front`, `rear`, `size`) is kept private. Public surface is limited to read-only properties (`Front`, `Rear`) and a read-only indexer (`this[int index]`), preventing external mutation of raw array data.

---

## How It Works

A `QueueArray` is created with a fixed capacity. Elements are added via `Enqueue` at the `rear` pointer and removed via `Dequeue` from the `front` pointer; both pointers advance forward as operations occur. `Helper.Display` iterates the live range using the read-only indexer to print current queue contents.

```csharp
QueueArray q = new QueueArray(10);

q.Enqueue(1);
q.Enqueue(2);
q.Enqueue(3);

Helper.Display(q);           // prints queue contents
Console.WriteLine(q.First()); // 1

q.Dequeue();                 // removes 1
Console.WriteLine(q.First()); // 2
```

---

## Getting Started

**Prerequisites**
- Visual Studio 2019 or later (or MSBuild)
- .NET Framework 4.8

**Clone**
```bash
git clone https://github.com/Jorgeaapaz/QueueArray.git
cd QueueArray
```

**Build & Run**
```powershell
# Using Visual Studio
# Open QueueArray.sln and press F5

# Using MSBuild
msbuild QueueArray.sln /p:Configuration=Release
.\bin\Release\QueueArray.exe
```

---

## Example Output

**Normal operation — enqueue then dequeue:**
```
Add elements 1,2,3
Queue Size: 3
Front: 0, Rear: 3
1, 2, 3,

First :1

Dequeue two elements
Queue Size: 1
Front: 2, Rear: 3
3,

First :3
```

**Edge case — dequeue from empty queue:**
```
Queue is empty
```

**Edge case — enqueue to full queue:**
```
Queue is full
```
