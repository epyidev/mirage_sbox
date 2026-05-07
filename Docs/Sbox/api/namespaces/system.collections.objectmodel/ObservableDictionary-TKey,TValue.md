# System.Collections.ObjectModel.ObservableDictionary<TKey,TValue>

A dictionary with callbacks for when changes occur.

- **Kind:** class
- **Namespace:** `System.Collections.ObjectModel`
- **Assembly:** `Sandbox.System`

## Constructors

- `ObservableDictionary<TKey,TValue>()`
- `ObservableDictionary<TKey,TValue>(System.Collections.Generic.IDictionary<TKey,TValue> dictionary)`
- `ObservableDictionary<TKey,TValue>(System.Collections.Generic.IEqualityComparer<TKey> comparer)`
- `ObservableDictionary<TKey,TValue>(System.Int32 capacity)`
- `ObservableDictionary<TKey,TValue>(System.Collections.Generic.IDictionary<TKey,TValue> dictionary, System.Collections.Generic.IEqualityComparer<TKey> comparer)`
- `ObservableDictionary<TKey,TValue>(System.Int32 capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer)`

## Properties

- `System.Collections.Generic.IDictionary<TKey,TValue> Dictionary`
  - The dictionary being observed.
- `System.Collections.Generic.ICollection<TKey> Keys`
- `System.Collections.Generic.ICollection<TValue> Values`
- `TValue Item`
- `System.Int32 Count`
- `System.Boolean IsReadOnly`

## Methods

### Instance methods

- `virtual System.Void Add(TKey key, TValue value)`
- `virtual System.Boolean ContainsKey(TKey key)`
- `virtual System.Boolean Remove(TKey key)`
- `virtual System.Boolean TryGetValue(TKey key, TValue value)`
- `virtual System.Void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item)`
- `virtual System.Void Clear()`
- `virtual System.Boolean Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item)`
- `virtual System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex)`
- `virtual System.Boolean Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item)`
- `virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator()`
- `System.Void AddRange(System.Collections.Generic.IDictionary<TKey,TValue> items)`
- `virtual System.Void OnPropertyChanged(System.String propertyName)`
  - Called when a property (such as element count) of the dictionary has changed.
