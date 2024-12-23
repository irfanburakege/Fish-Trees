# Fish Data Management System

## Description
This project models a system for managing and storing fish data from the Aegean Sea (`EgeDeniziB`). Each fish is associated with a keyword tree (`BilgiKelimeAğacı`) that stores related words in an alphabetical order. The system allows you to add fish with their corresponding keyword trees, traverse the trees, and manipulate fish data.

---

## Features
- **Fish Data Management**: Store fish names and related keywords in binary trees.
- **Keyword Tree Operations**: Insert, search, and print keywords in alphabetical order.
- **Heap Operations**: Manage fish data with a Max Heap, allowing easy access to the highest fish (based on name).
- **Inorder Traversal**: View fish data and their associated keywords in alphabetical order.
- **Balanced Tree Depth Calculation**: Calculate balanced tree depths for fish keyword trees.
- **Search by Range**: Search fish names starting with a specific range of letters.

---

## Classes
### `EgeDeniziB`
Represents a fish from the Aegean Sea with a name and associated keyword tree (`BilgiKelimeAğacı`).

- **Properties**:
  - `BalıkAdı`: The name of the fish.
  - `BilgiKelimeAğacı`: A binary tree holding related keywords for the fish.
  
- **Methods**:
  - `ToString()`: Provides a string representation of the fish and its keyword tree.

### `BinaryTree`
Represents a binary tree that stores strings (keywords) for each fish.

- **Methods**:
  - `Insert()`: Adds a keyword to the tree.
  - `PrintInOrder()`: Prints the keywords in alphabetical order.
  - `toStringInOrder()`: Converts the tree to a string, displaying keywords in order.
  - `GetDepth()`: Computes the depth of the tree.

### `MaxHeap`
Represents a Max Heap used for managing fish data.

- **Methods**:
  - `Ekle()`: Adds a fish to the heap.
  - `Sil()`: Removes and returns the fish at the root of the heap (the fish with the highest name).
  - `Peek()`: Returns the fish at the root without removing it.
  - `Yazdır()`: Prints all fish in the heap.

---

## Getting Started
1. **Clone the Repository:**
   ```bash
   git clone https://github.com/yourusername/fish-data-management.git
Build the Project: You can build the project using Visual Studio or any other IDE that supports C#.

Run the Application: Execute the main program to start interacting with the fish data management system.
