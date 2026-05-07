# Sandbox.SerializedObject

An object (or data) that can be accessed as an object

- **Kind:** abstract class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`

## Constructors

- `SerializedObject()`

## Properties

- `Sandbox.SerializedProperty ParentProperty`
- `System.String TypeIcon`
- `System.String TypeName`
- `System.String TypeTitle`
- `System.Boolean IsValid`
  - Does the target object still exist?
- `Sandbox.SerializedObject.PropertyPreChangeDelegate OnPropertyPreChange`
- `Sandbox.SerializedObject.PropertyChangedDelegate OnPropertyChanged`
- `Sandbox.SerializedObject.PropertyStartEditDelegate OnPropertyStartEdit`
- `Sandbox.SerializedObject.PropertyFinishEditDelegate OnPropertyFinishEdit`
- `System.Boolean IsMultipleTargets`
  - True if the target is multiple objects
- `System.Collections.Generic.IEnumerable<System.Object> Targets`
  - A list of actual target objects - if applicable

## Fields

- `System.Collections.Generic.List<Sandbox.SerializedProperty> PropertyList`

## Methods

### Instance methods

- `virtual Sandbox.SerializedProperty GetProperty(System.String v)`
- `virtual System.Boolean TryGetProperty(System.String v, Sandbox.SerializedProperty prop)`
- `virtual System.Collections.Generic.IEnumerator<Sandbox.SerializedProperty> GetEnumerator()`
- `virtual System.Void NoteChanged(Sandbox.SerializedProperty childProperty)`
  - It's good manners for a changed SerializedProperty to tell its parent
on set. That way the parent can cascade changes up the tree. This is 
particularly important if the tree includes struct types - because those
values will need to be re-set on any ParentProperty's.
- `virtual System.Void NotePreChange(Sandbox.SerializedProperty childProperty)`
- `virtual System.Void NoteStartEdit(Sandbox.SerializedProperty childProperty)`
- `virtual System.Void NoteFinishEdit(Sandbox.SerializedProperty childProperty)`
- `virtual System.Void PrepareEnumerator()`
  - Called right before enumeration, to allow derivitives react to changes
