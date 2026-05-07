# Color32

A 32bit color, commonly used by things like vertex buffers.
            
The functionality on this is purposely left minimal so we're encouraged to use the regular `Color` struct.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `Color32(System.Byte r, System.Byte g, System.Byte b, System.Byte a)`
  - Initialize a color with each component set to given values, in range [0,255]
- `Color32(System.Byte all)`
  - Initialize a color with each component set to given value, even alpha.
  - `all`: A number in range [0-255]
- `Color32(System.UInt32 raw)`
  - Initialize from an integer of the form 0xAABBGGRR.
  - `raw`: Packed integer of the form 0xAABBGGRR.
- `Color32(System.Int32 raw)`
  - Initialize from an integer of the form 0xAABBGGRR.
  - `raw`: Packed integer of the form 0xAABBGGRR.

## Properties

- `static Color32 White`
  - A constant representing a fully opaque color white.
- `static Color32 Black`
  - A constant representing a fully opaque color black.
- `static Color32 Transparent`
  - A constant representing a fully transparent color.
- `System.String Hex`
  - String representation of the form "#RRGGBB[AA]".
- `System.String Rgba`
  - String representation in the form of <see href="https://developer.mozilla.org/en-US/docs/Web/CSS/color_value/rgba">rgba</see>( r, g, b, a )
css function notation.
- `System.String Rgb`
  - String representation in the form of <see href="https://developer.mozilla.org/en-US/docs/Web/CSS/color_value/rgb">rgb</see>( r, g, b )
css function notation.
- `System.UInt32 RgbaInt`
  - Integer representation of the form 0xRRGGBBAA.
- `System.UInt32 RgbInt`
  - Integer representation of the form 0xRRGGBB.
- `System.UInt32 RawInt`
  - Integer representation of the form 0xAABBGGRR as used by native code.

## Fields

- `System.Byte r`
  - The red color component, in range of 0-255.
- `System.Byte g`
  - The green color component, in range of 0-255.
- `System.Byte b`
  - The blue color component, in range of 0-255.
- `System.Byte a`
  - The alpha/transparency color component, in range of 0 (fully transparent) to 255 (fully opaque).

## Methods

### Static methods

- `static Color32 FromRgb(System.UInt32 rgb)`
  - Converts an integer of the form 0xRRGGBB into the color #RRGGBB with 100% alpha.
  - `rgb`: Integer between 0x000000 and 0xffffff representing a color.
- `static Color32 FromRgba(System.UInt32 rgba)`
  - Converts an integer of the form 0xRRGGBBAA into the color #RRGGBBAA.
  - `rgba`: Integer between 0x00000000 and 0xffffffff representing a color with alpha.
- `static Color32 Min(Color32 a, Color32 b)`
  - Returns a new color with each component being the minimum of the 2 given colors.
  - `a`: Color A
  - `b`: Color B
  - returns: The new color with minimum values.
- `static Color32 Max(Color32 a, Color32 b)`
  - Returns a new color with each component being the maximum of the 2 given colors.
  - `a`: Color A
  - `b`: Color B
  - returns: The new color with maximum values.
- `static Color32 Read(System.IO.BinaryReader reader)`
  - Read a color from binary reader.
  - `reader`: Reader to read from.
  - returns: The read color.
- `static System.Nullable<Color32> Parse(System.String value)`
  - Parse a string to a color, in format "255 255 255 255" or "255,255,255". Alpha is optional.
  - `value`: The value to parse.
  - returns: The color parsed from the string, or null if we failed to do so.

### Instance methods

- `Color ToColor()`
  - Convert this object to `Color`.
  - returns: The converted color struct.
- `Color ToColor(System.Boolean srgb)`
  - Convert this object to `Color`.
  - `srgb`: If true we'll convert from the srgb color space to linear
  - returns: The converted color struct.
- `System.Void Write(System.IO.BinaryWriter writer)`
  - Write this color to a binary writer.
  - `writer`: Writer to write to.
