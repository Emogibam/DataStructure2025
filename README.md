
### **1. Arrays**
- **Description**: A collection of elements of the same type stored in contiguous memory locations.
- **Use Cases**: Fast access using an index, suitable for situations where the size of the data is fixed.
- **Operations**:
  - Access: \( O(1) \)
  - Search: \( O(n) \)
  - Insert/Delete: \( O(n) \) (requires shifting elements).

---

### **2. Linked List**
- **Description**: A sequence of nodes where each node contains data and a reference (or pointer) to the next node (and sometimes the previous node in doubly linked lists).
- **Types**:
  - Singly Linked List
  - Doubly Linked List
  - Circular Linked List
- **Use Cases**: Dynamic memory allocation, insertion, and deletion at arbitrary positions.
- **Operations**:
  - Search: \( O(n) \)
  - Insert/Delete: \( O(1) \) at the head or tail (if pointers are known).

---

### **3. Stack**
- **Description**: A collection of elements following the **LIFO (Last In, First Out)** principle. Elements are added and removed only at the top.
- **Use Cases**:
  - Function call stack
  - Undo operations in text editors
  - Balancing parentheses
- **Operations**:
  - Push: \( O(1) \)
  - Pop: \( O(1) \)
  - Peek/Top: \( O(1) \)

---

### **4. Queue**
- **Description**: A collection of elements following the **FIFO (First In, First Out)** principle.
- **Variants**:
  - Circular Queue
  - Priority Queue
  - Deque (Double-Ended Queue)
- **Use Cases**:
  - Scheduling processes in operating systems
  - Handling requests in a server
- **Operations**:
  - Enqueue: \( O(1) \)
  - Dequeue: \( O(1) \)
  - Peek/Front: \( O(1) \)

---

### **5. Hash Table**
- **Description**: A collection of key-value pairs where a hash function computes the index for storing values.
- **Use Cases**:
  - Implementing dictionaries
  - Storing data for fast retrieval
- **Operations**:
  - Insert/Search/Delete: \( O(1) \) (on average, with a good hash function)

---

### **6. Trees**
- **Description**: A hierarchical data structure consisting of nodes, where each node has a parent node and potentially many child nodes.
- **Types**:
  - Binary Tree
  - Binary Search Tree (BST)
  - AVL Tree (self-balancing BST)
  - Red-Black Tree
  - B-Tree and B+ Tree (used in databases)
- **Use Cases**:
  - Representing hierarchical data (e.g., file systems)
  - Searching and sorting (e.g., BST)
- **Operations**:
  - Insert/Search/Delete: \( O(\log n) \) (in balanced trees)

---

### **7. Heap**
- **Description**: A special tree-based data structure satisfying the heap property (max-heap or min-heap).
- **Use Cases**:
  - Priority queues
  - Efficient sorting algorithms (e.g., HeapSort)
- **Operations**:
  - Insert: \( O(\log n) \)
  - Get Min/Max: \( O(1) \)
  - Delete Min/Max: \( O(\log n) \)

---

### **8. Graphs**
- **Description**: A collection of nodes (vertices) and edges connecting pairs of nodes. Can be directed or undirected.
- **Types**:
  - Directed Graph
  - Undirected Graph
  - Weighted Graph
  - Unweighted Graph
- **Use Cases**:
  - Social networks
  - Routing algorithms (e.g., Dijkstra’s, A*)
- **Operations**:
  - Add/Delete Vertex/Edge: \( O(1) - O(n) \)
  - Search (DFS, BFS): \( O(V + E) \)

---

### **9. Trie**
- **Description**: A tree-like data structure used for storing strings, where each node represents a prefix.
- **Use Cases**:
  - Implementing dictionaries
  - Autocomplete features
- **Operations**:
  - Insert/Search: \( O(m) \), where \( m \) is the length of the string.

---

### **10. Set**
- **Description**: A collection of unique elements.
- **Variants**:
  - HashSet (based on hashing)
  - TreeSet (based on BST)
- **Use Cases**:
  - Removing duplicates
  - Checking membership efficiently
- **Operations**:
  - Insert/Delete/Lookup: \( O(1) \) for HashSet, \( O(\log n) \) for TreeSet.

---

### **11. Matrix**
- **Description**: A two-dimensional array often used to represent grids or mathematical matrices.
- **Use Cases**:
  - Image processing
  - Graph adjacency matrix representation
- **Operations**:
  - Access: \( O(1) \)
  - Search: \( O(n^2) \) (for \( n \times n \) matrix)

---

### **12. Union-Find (Disjoint Set)**
- **Description**: A structure that tracks a set of elements partitioned into disjoint subsets.
- **Use Cases**:
  - Network connectivity
  - Kruskal’s algorithm in Minimum Spanning Trees
- **Operations**:
  - Union/Find: \( O(\alpha(n)) \), where \( \alpha \) is the inverse Ackermann function.

---

### **13. Priority Queue**
- **Description**: Similar to a queue but with priority levels for each element, often implemented with a heap.
- **Use Cases**:
  - Task scheduling
  - Dijkstra’s shortest path algorithm
- **Operations**:
  - Insert/Extract Min/Max: \( O(\log n) \)

---

### **14. Deque**
- **Description**: A double-ended queue that allows insertion and deletion from both ends.
- **Use Cases**:
  - Sliding window problems
  - Implementing stacks and queues
- **Operations**:
  - Enqueue/Dequeue (front or rear): \( O(1) \)

---

### **15. Bloom Filter**
- **Description**: A probabilistic data structure used to test whether an element is a member of a set.
- **Use Cases**:
  - Caching
  - Spam detection
- **Operations**:
  - Insert/Test Membership: \( O(k) \), where \( k \) is the number of hash functions.

---

### Summary Table

| **Data Structure** | **Best For**                    | **Average Time Complexity**        |
|---------------------|----------------------------------|-------------------------------------|
| Array               | Fast indexed access             | \( O(1) \) for access, \( O(n) \) for insert/delete |
| Linked List         | Dynamic memory                  | \( O(n) \) search, \( O(1) \) insert at head/tail |
| Stack               | LIFO operations                | \( O(1) \) for push/pop |
| Queue               | FIFO operations                | \( O(1) \) for enqueue/dequeue |
| Hash Table          | Fast key-value access          | \( O(1) \) (average) |
| Tree                | Hierarchical data              | \( O(\log n) \) (balanced) |
| Graph               | Network/relationships          | \( O(V + E) \) traversal |
| Trie                | String prefix matching         | \( O(m) \) for search |
| Set                 | Unique elements                | \( O(1) \) (HashSet), \( O(\log n) \) (TreeSet) |
| Matrix              | Grid-like data                 | \( O(1) \) access, \( O(n^2) \) search |
| Union-Find          | Disjoint sets                  | \( O(\alpha(n)) \) |
| Priority Queue      | Priority-based tasks           | \( O(\log n) \) |
| Deque               | Flexible queues                | \( O(1) \) |
| Bloom Filter        | Probabilistic membership check | \( O(k) \) |

