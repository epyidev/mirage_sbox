# Sandbox.Rendering.SamplerState

Represents a sampler state used to control how textures are sampled in shaders.
Example usage: 


```

SamplerState mySampler &lt; Attribute("sampler"); &gt;;

```



C# binding:


```

var sampler = new SamplerState
{
    Filter = FilterMode.Trilinear,
    AddressModeU = TextureAddressMode.Wrap,
    AddressModeV = TextureAddressMode.Wrap,
    AddressModeW = TextureAddressMode.Clamp,
    MaxAnisotropy = 4
};
            
Graphics.Attributes.Set("sampler", sampler);

```

- **Kind:** struct
- **Namespace:** `Sandbox.Rendering`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `SamplerState()`

## Properties

- `Sandbox.Rendering.FilterMode Filter`
  - The texture filtering mode used for sampling (e.g., point, bilinear, trilinear).
- `Sandbox.Rendering.TextureAddressMode AddressModeU`
  - The addressing mode used for the U (X) texture coordinate.
- `Sandbox.Rendering.TextureAddressMode AddressModeV`
  - The addressing mode used for the V texture coordinate.
- `Sandbox.Rendering.TextureAddressMode AddressModeW`
  - The addressing mode used for the W texture coordinate.
- `System.Single MipLodBias`
  - The bias applied to the calculated mip level during texture sampling.
Positive values make textures appear blurrier; negative values sharpen.
- `System.Int32 MaxAnisotropy`
  - The maximum anisotropy level used for anisotropic filtering.
Higher values improve texture quality at oblique viewing angles.
- `Color BorderColor`
  - Border color to use if `Sandbox.Rendering.TextureAddressMode.Border` is specified for AddressU, AddressV, or AddressW.
