# Sandbox.MemberDescription

Wraps <see cref="F:Sandbox.MemberDescription.MemberInfo">MemberInfo</see> but with caching and sandboxing.
            
Returned by `Sandbox.Internal.TypeLibrary` and `Sandbox.TypeDescription`.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Reflection`

## Properties

- `Sandbox.TypeDescription TypeDescription`
  - The type that we're a member of
- `Sandbox.TypeDescription DeclaringType`
  - The type that actually defined this member. This may be different from `Sandbox.MemberDescription.TypeDescription` if this member is inherited from a base class.
- `System.String Name`
  - Name of this type member.
- `System.Int32 Identity`
  - An integer that represents this member. Based off its type and name.
- `System.String Title`
  - Display name or title of this type member.
- `System.String Description`
  - Description of this type member. This usually provided from the summary XML comment above the definition.
- `System.String Icon`
  - The icon for this, if provided via the [Icon] attribute
- `System.String Group`
  - The group - usually provided via the [Group] attribute
- `System.Boolean ReadOnly`
  - If this is marked as [ReadOnly]
- `System.Int32 Order`
  - The display order - usually provided via the [Order] attribute
- `System.String[] Tags`
  - Tags are usually provided via the [Tags] attribute
- `System.String[] Aliases`
  - Aliases allow this to be found by alternative names.
- `System.Attribute[] Attributes`
  - Attributes on this member
- `System.Boolean IsStatic`
  - True if static
- `System.Boolean IsPublic`
  - True if publicly accessible
- `System.Boolean IsFamily`
- `System.Boolean IsMethod`
  - True if we're a method
- `System.Boolean IsProperty`
  - True if we're a property
- `System.Boolean IsField`
  - True if we're a field
- `System.Int32 SourceLine`
  - The line number of this member
- `System.String SourceFile`
  - The file containing this member

## Methods

### Instance methods

- `Sandbox.DisplayInfo GetDisplayInfo()`
  - Access the full DisplayInfo for this type. This is faster than creating the DisplayInfo every time we need it.
- `System.Void Init(System.Reflection.MemberInfo x)`
- `virtual System.Int32 GetIdentityHash()`
  - Generate a unique hash to identity this member.
- `System.Void CaptureAttributes(System.Reflection.MemberInfo member)`
- `System.Boolean IsNamed(System.String name)`
  - Utility function to check whether this string matches this type. Will search name and classname.
- `System.Boolean HasTag(System.String tag)`
  - Returns true if Tags contains this tag
- `System.Boolean HasAttribute()`
  - Whether or not this has at least one of the specified attribute.
- `System.Boolean HasAttribute(System.Type t)`
  - Whether or not this has at least one of the specified attribute.
- `T GetCustomAttribute()`
  - Returns the first of Attributes of the passed in type. Or null.
