# Sandbox.SerializedObject.PropertyPreChangeDelegate

- **Kind:** sealed class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`
- **Base:** `System.MulticastDelegate`
- **Declaring type:** `Sandbox.SerializedObject`

## Constructors

- `PropertyPreChangeDelegate(System.Object object, System.IntPtr method)`

## Methods

### Instance methods

- `virtual System.Void Invoke(Sandbox.SerializedProperty property)`
- `virtual System.IAsyncResult BeginInvoke(Sandbox.SerializedProperty property, System.AsyncCallback callback, System.Object object)`
- `virtual System.Void EndInvoke(System.IAsyncResult result)`
