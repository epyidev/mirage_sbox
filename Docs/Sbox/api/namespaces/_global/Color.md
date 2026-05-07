# Color

Represents a color using 4 floats (rgba), with 0-1 range.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `Color(System.Single r, System.Single g, System.Single b, System.Single a)`
  - Initialize a color with each component set to given values, in range [0,1]
- `Color(System.Single rgb, System.Single a)`
  - Initialize a color with the same value for each color, but a different value for alpha
- `Color(System.Single all)`
  - Initialize a color with each component set to given value, even alpha.
  - `all`: A number in range [0-1]
- `Color(System.UInt32 raw)`
  - Initialize from an integer of the form 0xAABBGGRR.
  - `raw`: Packed integer of the form 0xAABBGGRR.
- `Color(System.Int32 raw)`
  - Initialize from an integer of the form 0xAABBGGRR.
  - `raw`: Packed integer of the form 0xAABBGGRR.

## Properties

- `System.Single Luminance`
  - Returns the luminance of the color, basically it's grayscale value or "black and white version".
- `System.Boolean IsRepresentableInHex`
  - Returns true if this color can be represented in hexadecimal format (#RRGGBB[AA]).
This may not be the case if the color components are outside of [0,1] range.
- `System.Boolean IsSdr`
  - Returns true if all components are between 0 and 1
- `System.Boolean IsHdr`
  - Returns true if any component exceeds 1
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
- `static Color Random`
  - Returns a random color out of 8 preset colors.
- `System.Single Item`

## Fields

- `System.Single r`
  - The red color component, in range of 0-1, which <b>can be exceeded</b>.
- `System.Single g`
  - The green color component, in range of 0-1, which <b>can be exceeded</b>.
- `System.Single b`
  - The blue color component, in range of 0-1, which <b>can be exceeded</b>.
- `System.Single a`
  - The alpha/transparency color component, in range of 0 (fully transparent) to 1 (fully opaque), which <b>can be exceeded</b>.
- `static Color White`
  - Fully opaque white color.
- `static Color Gray`
  - Fully opaque gray color, right between white and black.
- `static Color Black`
  - Fully opaque black color.
- `static Color Red`
  - Fully opaque pure red color.
- `static Color Green`
  - Fully opaque pure green color.
- `static Color Blue`
  - Fully opaque pure blue color.
- `static Color Yellow`
  - Fully opaque yellow color.
- `static Color Orange`
  - Fully opaque orange color.
- `static Color Cyan`
  - Fully opaque cyan color.
- `static Color Magenta`
  - Fully opaque magenta color.
- `static Color Transparent`
  - Fully transparent color.

## Methods

### Static methods

- `static Color Min(Color a, Color b)`
  - Returns a new color with each component being the minimum of the 2 given colors.
  - `a`: Color A
  - `b`: Color B
  - returns: The new color with minimum values.
- `static Color Max(Color a, Color b)`
  - Returns a new color with each component being the maximum of the 2 given colors.
  - `a`: Color A
  - `b`: Color B
  - returns: The new color with maximum values.
- `static Color Average(Color[] values)`
  - Returns a color whose components are averaged of all given colors.
  - `values`: The colors to get average of.
  - returns: The average color.
- `static Color Lerp(Color a, Color b, System.Single frac, System.Boolean clamped)`
  - Performs linear interpolation between two colors.
  - `a`: The source color.
  - `b`: The target color.
  - `frac`: Fraction to the target color. 0 will return source color, 1 will return target color, 0.5 will "mix" the 2 colors equally.
  - `clamped`: Clamp fraction to range of [0,1]. If not clamped, the color will be extrapolated.
  - returns: The interpolated color.
- `static Color FromBytes(System.Int32 r, System.Int32 g, System.Int32 b, System.Int32 a)`
  - Creates a color from 0-255 range inputs, converting them to 0-1 range.
  - `r`: The red component.
  - `g`: The green component.
  - `b`: The blue component.
  - `a`: The alpha/transparency component.
- `static Color FromRgb(System.UInt32 rgb)`
  - Converts an integer of the form 0xRRGGBB into the color #RRGGBB with 100% alpha.
  - `rgb`: Integer between 0x000000 and 0xffffff representing a color.
- `static Color FromRgba(System.UInt32 rgba)`
  - Converts an integer of the form 0xRRGGBBAA into the color #RRGGBBAA.
  - `rgba`: Integer between 0x00000000 and 0xffffffff representing a color with alpha.
- `static System.Nullable<Color> Parse(System.String value)`
  - Parse the color from a string. Many common formats are supported.
  - `value`: The string to parse.
  - returns: The parsed color if operation completed successfully.
- `static System.Boolean TryParse(System.String value, Color color)`
  - Try to parse the color. Returns true on success

### Instance methods

- `Color WithAlpha(System.Single alpha)`
  - Returns this color with its alpha value changed
  - `alpha`: The required alpha value, usually between 0-1
- `Color WithAlphaMultiplied(System.Single alpha)`
  - Similar to `Color.WithAlpha(System.Single)` but multiplies the alpha instead of replacing.
- `Color WithColorMultiplied(System.Single amount)`
  - Returns a new version with only the red, green, blue components multiplied
- `Color WithRed(System.Single red)`
  - Returns this color with its red value changed
- `Color WithGreen(System.Single green)`
  - Returns this color with its green value changed
- `Color WithBlue(System.Single blue)`
  - Returns this color with its blue value changed
- `ColorHsv ToHsv()`
  - Converts this color to a HSV format.
  - returns: The HSV color.
- `Color32 ToColor32(System.Boolean srgb)`
  - Convert to a Color32 (a 32 bit color value)
  - `srgb`: If true we'll convert to the srgb color space
- `Color LerpTo(Color target, System.Single frac, System.Boolean clamp)`
  - Performs linear interpolation between this and given colors.
  - `target`: Color B
  - `frac`: Fraction, where 0 would return this, 0.5 would return a point between this and given colors, and 1 would return the given color.
  - `clamp`: Whether to clamp the fraction argument between [0,1]
- `Color AdjustHue(System.Single amount)`
  - Increases or decreases this color's hue
  - `amount`: A number between -360 and 360 to add to the color's hue
  - returns: The adjusted color
- `Color Darken(System.Single fraction)`
  - Darkens the color by given amount.
  - `fraction`: How much to darken the color by, in range of 0 (not at all) to 1 (fully black). Negative values will lighten the color.
  - returns: The darkened color.
- `Color Lighten(System.Single fraction)`
  - Lightens the color by given amount.
  - `fraction`: How much to lighten the color by, in range of 0 (not at all) to 1 (double the color). Negative values will darken the color.
  - returns: The lightened color.
- `Color Invert()`
  - Returns inverted color. Alpha is unchanged.
  - returns: The inverted color.
- `Color Desaturate(System.Single fraction)`
  - Desaturates the color by given amount.
  - `fraction`: How much to desaturate the color by, in range of 0 (not at all) to 1 (no saturation, i.e. fully white). Negative values will saturate the color.
  - returns: The desaturated color.
- `Color Saturate(System.Single fraction)`
  - Saturates the color by given amount.
  - `fraction`: How much to saturate the color by, in range of 0 (not at all) to 1 (double the saturation). Negative values will desaturate the color.
  - returns: The saturated color.
- `System.Int32 ComponentCountChangedBetweenColors(Color b)`
  - Returns how many color components would be changed between this color and another color
