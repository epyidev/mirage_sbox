# Sandbox.RenderAttributes

RenderAttributes are a set of values that are passed to the renderer.
They can be a variety of primitive types, textures, samplers or buffers.
You can access attributes in the shader by binding them to a variable:


```

float4 CornerRadius &lt; Attribute( "BorderRadius" ); &gt;;
Texture2D g_tColor 	&lt; Attribute( "Texture" ); SrgbRead( false ); &gt;;

```

<seealso cref="P:Sandbox.Renderer.Attributes" /><seealso cref="M:Sandbox.Graphics.DrawModel(Sandbox.Model,Transform,Sandbox.RenderAttributes)" /><seealso cref="M:Sandbox.ComputeShader.DispatchWithAttributes(Sandbox.RenderAttributes,System.Int32,System.Int32,System.Int32)" />

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `RenderAttributes()`

## Methods

### Instance methods

- `virtual System.Void Finalize()`
- `System.Void Clear()`
- `System.Void SetCombo(Sandbox.StringToken k, System.Int32 value)`
- `System.Void SetCombo(System.String k, System.Enum value)`
- `System.Void SetComboEnum(Sandbox.StringToken k, T value)`
- `System.Void SetCombo(Sandbox.StringToken k, System.Boolean value)`
- `T GetComboEnum(Sandbox.StringToken k, T defaultValue)`
- `System.Boolean GetComboBool(Sandbox.StringToken k, System.Boolean defaultValue)`
- `System.Int32 GetComboInt(Sandbox.StringToken k, System.Int32 defaultValue)`
- `System.Void Set(Sandbox.StringToken k, System.Int32 value)`
- `System.Void Set(Sandbox.StringToken k, Vector2Int value)`
- `System.Void Set(Sandbox.StringToken k, Vector3Int value)`
- `System.Void Set(Sandbox.StringToken k, Sandbox.Texture value, System.Int32 mip)`
- `System.Void Set(Sandbox.StringToken k, Sandbox.Rendering.SamplerState value)`
- `System.Void Set(Sandbox.StringToken k, System.Single value)`
- `System.Void Set(Sandbox.StringToken k, System.Double value)`
- `System.Void Set(Sandbox.StringToken k, System.String value)`
- `System.Void Set(Sandbox.StringToken k, System.Boolean value)`
- `System.Void Set(Sandbox.StringToken k, Vector4 value)`
- `System.Void Set(Sandbox.StringToken k, Angles value)`
- `System.Void Set(Sandbox.StringToken k, Vector3 value)`
- `System.Void Set(Sandbox.StringToken k, Vector2 value)`
- `System.Void Set(Sandbox.StringToken k, Sandbox.GpuBuffer value)`
- `System.Void SetData(Sandbox.StringToken k, System.Span<T> value)`
- `System.Void SetData(Sandbox.StringToken k, T value)`
  - Set a constant buffer to a specific value
- `System.Void SetData(Sandbox.StringToken k, T[] value)`
  - Set a constant buffer to a specific value
- `System.Void SetData(Sandbox.StringToken k, System.Collections.Generic.List<T> value)`
- `System.Boolean GetBool(Sandbox.StringToken name, System.Boolean defaultValue)`
  - Get a bool value - else defaultValue if missing
- `Vector3 GetVector(Sandbox.StringToken name, Vector3 defaultValue)`
  - Get a vector3 value - else defaultValue if missing
- `Vector4 GetVector4(Sandbox.StringToken name, Vector4 defaultValue)`
  - Get a vector4 value - else defaultValue if missing
- `Angles GetAngles(Sandbox.StringToken name, Angles defaultValue)`
  - Get a vector4 value - else defaultValue if missing
- `System.Single GetFloat(Sandbox.StringToken name, System.Single defaultValue)`
  - Get a float value - else defaultValue if missing
- `System.Int32 GetInt(Sandbox.StringToken name, System.Int32 defaultValue)`
  - Get a int value - else defaultValue if missing
- `Matrix GetMatrix(Sandbox.StringToken name, Matrix defaultValue)`
  - Get a matrix value - else defaultValue if missing
- `Sandbox.Texture GetTexture(Sandbox.StringToken name, Sandbox.Texture defaultValue)`
  - Get a texture value - else defaultValue if missing
- `System.Void Set(Sandbox.StringToken k, Matrix value)`
- `System.Void SetCombo(System.String k, System.Int32 value)`
- `System.Void SetCombo(System.String k, System.Boolean value)`
- `System.Void Set(System.String k, System.Boolean value)`
- `System.Void Set(System.String k, System.Int32 value)`
- `System.Void Set(System.String k, Vector2Int value)`
- `System.Void Set(System.String k, Vector3Int value)`
- `System.Void Set(System.String k, Vector4 value)`
- `System.Void Set(System.String k, Vector3 value)`
- `System.Void Set(System.String k, Vector2 value)`
- `System.Void Set(System.String k, Matrix value)`
- `System.Void Set(System.String k, Angles value)`
- `System.Void Set(System.String k, System.String value)`
- `System.Void Set(System.String k, Sandbox.Texture value, System.Int32 mip)`
- `System.Void Set(System.String k, System.Single value)`
- `System.Void Set(System.String k, System.Double value)`
- `Sandbox.Texture GetTexture(System.String name, Sandbox.Texture defaultValue)`
