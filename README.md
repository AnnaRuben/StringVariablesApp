## Core C# Concepts & Under the Hood Mechanics

This repository reflects a deep dive into C# fundamentals, focusing not just on syntax, but on memory management, clean code architecture, and modern industry standards.

### 1. Memory Management & String Immutability
In .NET, `string` types are strictly **immutable**. 
* **Memory Allocation:** Reassigning a value to an existing string variable (e.g., changing `firstName` from `"Tim"` to `"123"`) does not overwrite the original data. 
* <br>Instead, it destroys the original reference and allocates a completely new string object in the heap memory.
* **Garbage Collection (GC):** The orphaned value (`"Tim"`) is left in memory until the .NET Garbage Collector reclaims it. 
* **Performance Impact:** Excessive string concatenation (using `+`) creates multiple redundant copies in memory, which is computationally expensive. 
* <br>This is mitigated by using modern memory efficient practices.

### 2. Clean Code & Naming Conventions
Code is read far more often than it is written. 
<br>Readability is prioritized over brevity.
* **Context is King:** Single letter variables (`a`, `b`) or obscure acronyms (`fName`) are avoided. 
* <br>Names must explicitly describe their data (e.g., `firstName`).
* **Camel Casing:** Strict adherence to `camelCase` for local variables. 
* <br>Proper casing is critical to prevent catastrophic contextual misunderstandings (e.g., the infamous `expertsexchange` vs. `experts exchange` naming disaster).
* **Declarative Initialization:** Prefer `string.Empty` over `""`. 
* <br>It explicitly signals the developer's intent to initialize an empty state, rather than an accidental blank keystroke.

### 3. Advanced String Operations
* **String Interpolation (`$`):** Modern syntax (`$"Hello {firstName}"`) that evaluates C# expressions inline, producing cleaner and more maintainable code than traditional concatenation.
* **Verbatim Literals (`@`):** Used to ignore escape sequences (like `\n`). 
* <br>Essential for hardcoded file paths (e.g., `@"C:\Temp\Demo"`), preventing the need for double escaping (`\\`).
* **Combined Usage:** Seamlessly mixing both (`$@""`) to inject variables directly into verbatim paths.

### 4. Deprecated Anti Patterns (What NOT to do)
* **Hungarian Notation:** Prefixing variables with their data type (e.g., `strFirstName`) is an obsolete practice. 
* <br>It adds unnecessary cognitive load, slows down mental parsing, and is rendered useless by modern IDEs.