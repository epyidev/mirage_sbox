# Sandbox.ThreadSafe

Provides utilities for working with threads, particularly for identifying
and asserting code is running on the main thread.

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Properties

- `static System.Int32 CurrentThreadId`
  - Gets the current thread's managed thread ID.
- `static System.String CurrentThreadName`
  - Gets the current thread's name, or null if unnamed.
- `static System.Boolean IsMainThread`
  - Returns true if currently executing on the main thread.

## Methods

### Static methods

- `static System.Void AssertIsMainThread(System.String memberName)`
  - Throws an exception if not called from the main thread.
Useful for enforcing thread safety on main-thread-only APIs.
  - `memberName`: Automatically filled with the calling method name
- `static System.Void AssertIsNotMainThread()`
  - Throws an exception if called from the main thread.
Useful for enforcing that blocking operations don't run on the main thread.
