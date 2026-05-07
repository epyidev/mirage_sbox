# ColorHsv

A color in <a href="https://upload.wikimedia.org/wikipedia/commons/a/a0/Hsl-hsv_models.svg">Hue-Saturation-Value/Brightness</a> format.

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.System`

## Constructors

- `ColorHsv(System.Single h, System.Single s, System.Single v, System.Single a)`
  - Initializes a new HSV/HSB color. Hue is in the range of [0-360] and all other values are in range [0,1]
  - `h`: The hue color component.
  - `s`: Saturation of the color.
  - `v`: Brightness of the color.
  - `a`: Alpha of the color.

## Properties

- `System.Single Hue`
  - Hue component of this color in range 0 to 360.
- `System.Single Saturation`
  - Saturation of this color in range 0 (white) to 1 (full color).
- `System.Single Value`
  - Brightness of this color in range 0 (black) to 1 (full color).
- `System.Single Alpha`
  - Transparency of this color in range 0 (fully transparent) to 1 (fully opaque).

## Methods

### Instance methods

- `Color ToColor()`
  - Convert this object to `Color`.
  - returns: The converted color struct.
- `ColorHsv WithHue(System.Single hue)`
  - Returns a copy of this color with given Hue value.
  - `hue`: The Hue override.
  - returns: The new color.
- `ColorHsv WithSaturation(System.Single saturation)`
  - Returns a copy of this color with given Saturation value.
  - `saturation`: The Saturation override.
  - returns: The new color.
- `ColorHsv WithValue(System.Single value)`
  - Returns a copy of this color with given Brightness value.
  - `value`: The Brightness override.
  - returns: The new color.
- `ColorHsv WithAlpha(System.Single alpha)`
  - Returns a copy of this color with given alpha value.
  - `alpha`: The alpha override.
  - returns: The new color.
