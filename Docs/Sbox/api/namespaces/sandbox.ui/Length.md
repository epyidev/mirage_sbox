# Sandbox.UI.Length

A variable unit based length. ie, could be a percentage or a pixel length. This is commonly used to express the size of things in UI space, usually coming from style sheets.

- **Kind:** struct
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.System`

## Properties

- `static Sandbox.UI.Length Auto`
  - Quickly create a Length with Unit set to LengthUnit.Auto
- `static Sandbox.UI.Length Contain`
  - Quickly create a Length with Unit set to LengthUnit.Contain
- `static Sandbox.UI.Length Cover`
  - Quickly create a Length with Unit set to LengthUnit.Cover
- `static Sandbox.UI.Length Undefined`

## Fields

- `System.Single Value`
  - The meaning of the value is dependent on `Sandbox.UI.Length.Unit`.
- `Sandbox.UI.LengthUnit Unit`
  - How to determine the final length. Commonly used with Pixel or Percentage.

## Methods

### Static methods

- `static System.Nullable<Sandbox.UI.Length> Pixels(System.Single pixels)`
  - Create a length in pixels
  - `pixels`: The amount of pixels for this length
  - returns: A new length
- `static System.Nullable<Sandbox.UI.Length> Percent(System.Single percent)`
  - Create a length in percents
  - `percent`: The amount of percent for this (0-100)
  - returns: A new length
- `static System.Nullable<Sandbox.UI.Length> ViewHeight(System.Single percentage)`
  - Create a length based on the view height
  - `percentage`: The amount of percent for this (0-100)
  - returns: A new length
- `static System.Nullable<Sandbox.UI.Length> ViewWidth(System.Single percentage)`
  - Create a length based on the view width
  - `percentage`: The amount of percent for this (0-100)
  - returns: A new length
- `static System.Nullable<Sandbox.UI.Length> ViewMax(System.Single percentage)`
  - Create a length based on the longest edge of the screen size
  - `percentage`: The amount of percent for this (0-100)
  - returns: A new length
- `static System.Nullable<Sandbox.UI.Length> ViewMin(System.Single percentage)`
  - Create a length based on the shortest edge of the screen size
  - `percentage`: The amount of percent for this (0-100)
  - returns: A new length
- `static System.Nullable<Sandbox.UI.Length> Fraction(System.Single fraction)`
  - Create a length in percents
  - `fraction`: The fraction of a percent (0 = 0%, 1 = 100%)
  - returns: A new length
- `static System.Nullable<Sandbox.UI.Length> Calc(System.String expression)`
  - Create a length based on a css calc expression
- `static Sandbox.UI.Length Rem(System.Single value)`
  - Create a length based on the font size of the root element.
  - `value`: Value in rem
  - returns: A new length
- `static Sandbox.UI.Length Em(System.Single value)`
  - Create a length based on the font size of the current element.
  - `value`: Value in em
  - returns: A new length
- `static System.Nullable<Sandbox.UI.Length> Parse(System.String value)`
  - Parse a length. This is used by the stylesheet parsing system.
  - `value`: A length represented by a string

### Instance methods

- `System.Single GetPixels(System.Single dimension)`
  - Convert to a pixel value. Use the dimension to work out percentage values.
- `System.Single GetPixels(System.Single dimension, System.Single contentSize)`
  - Get the pixel size but also evaluate content size to support use Start, End, Center
