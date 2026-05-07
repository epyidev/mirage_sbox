# Sandbox.Bind.Builder

A helper to create binds between two properties (or whatever you want)


Example usage: set "BoolValue" from value of "StringValue"


```
BindSystem.Build.Set( this, "BoolValue" ).From( this, "StringValue" );
```

- **Kind:** struct
- **Namespace:** `Sandbox.Bind`
- **Assembly:** `Sandbox.Bind`

## Methods

### Instance methods

- `Sandbox.Bind.Builder ReadOnly(System.Boolean makeReadOnly)`
  - Makes the bind link one way. The system will not try to write to the target/right hand property. (The one you set via "From" methods)
- `Sandbox.Bind.Builder Set(T obj, System.String targetName, System.Action onChanged)`
- `Sandbox.Bind.Builder Set(T obj, System.Func<U> read, System.Action<U> write)`
- `Sandbox.Bind.Builder Set(Sandbox.Bind.Proxy binding)`
- `Sandbox.Bind.Link From(T obj, System.Reflection.PropertyInfo target)`
- `Sandbox.Bind.Link From(T obj, System.String targetName)`
- `Sandbox.Bind.Link From(System.Func<T> read, System.Action<T> write)`
- `Sandbox.Bind.Link From(System.Object sourceObject, System.Func<T> read, System.Action<T> write)`
- `Sandbox.Bind.Link From(T obj, System.Linq.Expressions.Expression<System.Func<T,V>> propertyName)`
- `Sandbox.Bind.Link From(Sandbox.Bind.Proxy source)`
- `Sandbox.Bind.Link FromObject(System.Object obj)`
- `Sandbox.Bind.Link FromDictionary(System.Collections.Generic.Dictionary<K,V> dict, K key)`
