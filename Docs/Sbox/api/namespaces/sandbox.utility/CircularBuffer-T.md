# Sandbox.Utility.CircularBuffer<T>

Circular buffer, push pop and index access is always O(1).

- **Kind:** class
- **Namespace:** `Sandbox.Utility`
- **Assembly:** `Sandbox.System`

## Constructors

- `CircularBuffer<T>(System.Int32 capacity)`
  - Initializes a new instance of the `Sandbox.Utility.CircularBuffer`1` class.
  - `capacity`: Buffer capacity. Must be positive.
- `CircularBuffer<T>(System.Int32 capacity, T[] items)`

## Properties

- `System.Int32 Capacity`
  - Maximum capacity of the buffer. Elements pushed into the buffer after
maximum capacity is reached (IsFull = true), will remove an element.
- `System.Boolean IsFull`
  - Boolean indicating if Circular is at full capacity.
Adding more elements when the buffer is full will
cause elements to be removed from the other end
of the buffer.
- `System.Boolean IsEmpty`
  - True if has no elements.
- `System.Int32 Size`
  - Current buffer size (the number of elements that the buffer has).
- `T Item`

## Methods

### Instance methods

- `T Front()`
  - Element at the front of the buffer - this[0].
  - returns: The value of the element of type T at the front of the buffer.
- `T Back()`
  - Element at the back of the buffer - this[Size - 1].
  - returns: The value of the element of type T at the back of the buffer.
- `System.Void PushBack(T item)`
- `System.Void PushFront(T item)`
- `System.Void PopBack()`
  - Removes the element at the back of the buffer. Decreasing the 
Buffer size by 1.
- `System.Void PopFront()`
  - Removes the element at the front of the buffer. Decreasing the 
Buffer size by 1.
- `System.Void Clear()`
  - Clears the contents of the array. Size = 0, Capacity is unchanged.
- `T[] ToArray()`
  - Copies the buffer contents to an array, according to the logical
contents of the buffer (i.e. independent of the internal 
order/contents)
  - returns: A new array with a copy of the buffer contents.
- `System.Collections.Generic.IEnumerable<System.ArraySegment<T>> ToArraySegments()`
  - Get the contents of the buffer as 2 ArraySegments.
Respects the logical contents of the buffer, where
each segment and items in each segment are ordered
according to insertion.
            
Fast: does not copy the array elements.
Useful for methods like `Send(IList&lt;ArraySegment&lt;Byte&gt;&gt;)`.

<remarks>Segments may be empty.</remarks>
  - returns: An IList with 2 segments corresponding to the buffer content.
- `Sandbox.Utility.CircularBuffer.Enumerator<T> GetEnumerator()`
  - Returns a struct-based enumerator that iterates through this buffer without any heap allocation.
The compiler's duck-typing for `foreach` will prefer this overload over the interface
methods, so `foreach (var x in buffer)` is zero-alloc.
