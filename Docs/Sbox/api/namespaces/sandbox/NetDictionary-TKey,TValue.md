# Sandbox.NetDictionary<TKey,TValue>

A networkable dictionary for use with the `Sandbox.SyncAttribute` and `Sandbox.HostSyncAttribute`. Only changes will be
networked instead of sending the whole dictionary every time, so it's more efficient.
<br />

<b>Example usage:</b>

```

public class MyComponent : Component
{
	[Sync] public NetDictionary&lt;string,bool&gt; MyBoolTable { get; set; } = new();
	<br />
	public void SetBoolState( string key, bool state )
	{
		if ( IsProxy ) return;
		MyBoolTable[key] = state;
	}
}

```

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `NetDictionary<TKey,TValue>()`

## Properties

- `System.Collections.Generic.ICollection<TValue> Values`
- `System.Collections.Generic.ICollection<TKey> Keys`
- `System.Int32 Count`
- `TValue Item`

## Fields

- `System.Action<Sandbox.NetDictionaryChangeEvent<TKey,TValue>> OnChanged`
  - Get notified when the dictionary is changed.

## Methods

### Instance methods

- `virtual System.Void Dispose()`
- `virtual System.Void Add(TKey key, TValue value)`
- `virtual System.Void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item)`
- `virtual System.Void Clear()`
- `virtual System.Boolean ContainsKey(TKey key)`
- `virtual System.Boolean Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item)`
- `virtual System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex)`
- `virtual System.Boolean Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item)`
- `virtual System.Boolean Remove(TKey key)`
- `virtual System.Boolean TryGetValue(TKey key, TValue value)`
- `virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator()`
