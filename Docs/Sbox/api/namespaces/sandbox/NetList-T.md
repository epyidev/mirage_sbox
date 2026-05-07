# Sandbox.NetList<T>

A networkable list for use with the `Sandbox.SyncAttribute` and `Sandbox.HostSyncAttribute`. Only changes will be
networked instead of sending the whole list every time, so it's more efficient.
<br />

<b>Example usage:</b>

```

public class MyComponent : Component
{
	[Sync] public NetList&lt;int&gt; MyIntegerList { get; set; } = new();
	<br />
	public void AddNumber( int number )
	{
		if ( IsProxy ) return;
		MyIntegerList.Add( number );
	}
}

```

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `NetList<T>()`

## Properties

- `System.Int32 Count`
- `T Item`

## Fields

- `System.Action<Sandbox.NetListChangeEvent<T>> OnChanged`
  - Get notified when the list has changed.

## Methods

### Instance methods

- `virtual System.Void Dispose()`
- `virtual System.Void Clear()`
- `virtual System.Boolean Contains(T item)`
- `virtual System.Void CopyTo(T[] array, System.Int32 arrayIndex)`
- `virtual System.Void Add(T value)`
- `System.Void AddRange(System.Collections.Generic.IEnumerable<T> collection)`
- `System.Boolean Remove(T value)`
- `virtual System.Int32 IndexOf(T item)`
- `virtual System.Void Insert(System.Int32 index, T value)`
- `virtual System.Void RemoveAt(System.Int32 index)`
- `virtual System.Collections.Generic.IEnumerator<T> GetEnumerator()`
