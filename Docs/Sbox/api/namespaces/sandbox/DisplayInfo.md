# Sandbox.DisplayInfo

Collects all the relevant info (such as description, name, icon, etc) from attributes and other sources about a type or type member.

- **Kind:** struct
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Reflection`

## Fields

- `System.String ClassName`
  - "Internal" class name of this type or member. This typically should be all lowercase and without weird symbols or whitespace.
- `System.String Namespace`
  - Namespace of this type
- `System.String Fullname`
  - Namespace.ParentClass.Class.Member
- `System.String Name`
  - The name of this type or member.
- `System.String Description`
  - The summary or description of this type or member.
- `System.String Group`
  - Group or category of this type or member. (`CategoryAttribute`)
- `System.Boolean ReadOnly`
  - This is marked as ReadOnly
- `System.String Icon`
  - Material icon of this type or member. (`IconAttribute`)
- `System.Int32 Order`
  - Order of this member for UI ordering purposes. (`OrderAttribute`)
- `System.Boolean Browsable`
  - Whether this member should be visible in a properties sheet (`HideInEditorAttribute`)
- `System.String Placeholder`
  - Placeholder text for string type properties. (`PlaceholderAttribute`)
Placeholder text is displayed in UI when input text field is empty.
- `System.String[] Alias`
  - Possible aliases for this type or member, if any. (`AliasAttribute`)
- `System.String[] Tags`
  - Tags of this type or member. (`TagAttribute`)

## Methods

### Static methods

- `static Sandbox.DisplayInfo ForType(System.Type t, System.Boolean inherit)`
  - Retrieves display info about a given type.
  - `t`: The type to look up display info for.
  - `inherit`: Whether to load in base type's display info first, then overrides all possible fields with given type's information.
  - returns: The display info. Will contain empty fields on failure.
- `static Sandbox.DisplayInfo For(System.Object t, System.Boolean inherit)`
  - Retrieves display info about a given objects type.
  - `t`: The type to look up display info for.
  - `inherit`: Whether to load in base type's display info first, then overrides all possible fields with given type's information.
  - returns: The display info. Will contain empty fields on failure.
- `static Sandbox.DisplayInfo ForMember(System.Reflection.MemberInfo t, System.Boolean inherit)`
  - Retrieves display info about a given member or type.
  - `t`: The member to look up display info for.
  - `inherit`: If member given is a `System.Type`, loads in base type's display info first, then overrides all possible fields with given type's information.
  - returns: The display info. Will contain empty fields on failure.
- `static Sandbox.DisplayInfo[] ForEnumValues(System.Type t)`
  - Returns display info for each member of an enumeration type.
- `static System.ValueTuple<T,Sandbox.DisplayInfo>[] ForEnumValues()`
  - Returns display info for each member of an enumeration type.

### Instance methods

- `System.Boolean HasTag(System.String t)`
  - Returns whether this type or member has given tag. (`TagAttribute`)
  - `t`: The tag to test.
  - returns: Whether the tag is present or not
