# Editor.Pixmap

A pixel map, or just a simple image.

- **Kind:** class
- **Namespace:** `Editor`
- **Assembly:** `Sandbox.Tools`

## Constructors

- `Pixmap(System.Int32 width, System.Int32 height)`
  - Create a new empty pixel map. It can then be drawn to via the `Editor.Paint` class, like so:


```

var myPixMap = new Pixmap( 16, 16 );
            
Paint.Target( myPixMap );
 Paint.Antialiasing = true;
 Paint.ClearPen();
 Paint.SetBrush( Color.Red );
 Paint.DrawRect( new Rect( 0, myPixMap.Size ), 2 );
Paint.Target( null );

```
- `Pixmap(Vector2 size)`

## Properties

- `System.Int32 Width`
  - Width of the pixel map.
- `System.Int32 Height`
  - Height of the pixel map.
- `System.Boolean HasAlpha`
  - Whether this pixel map supports the alpha channel.
- `Vector2 Size`
  - THe size of this pixel map.

## Methods

### Static methods

- `static Editor.Pixmap FromFile(System.String filename)`
  - Load an image from a file on disk, specifically from "core/tools/images".
- `static Editor.Pixmap FromBitmap(Sandbox.Bitmap bitmap)`
  - Create a pixmap from a bitmap
- `static Editor.Pixmap FromTexture(Sandbox.Texture texture, System.Boolean withAlpha)`
  - Create a pixmap from a texture.

### Instance methods

- `virtual System.Void Finalize()`
- `System.Void Clear(Color color)`
  - Fill the pixel map with given color.
- `System.Void Scroll(System.Int32 x, System.Int32 y, Sandbox.Rect r)`
  - Duplicate a sub-rectangle of the image at re-draw it at given coordinates.
  - `x`: Position to re-draw the duplicated image at on the X axis, from the left edge.
  - `y`: Position to re-draw the duplicated image at on the Y axis, from the top edge.
  - `r`: The area on the image to duplicate.
- `System.Void Scroll(System.Int32 x, System.Int32 y)`
  - Duplicate the entire image and re-draw it at given coordinates.
  - `x`: Position to re-draw the duplicated image at on the X axis, from the left edge.
  - `y`: Position to re-draw the duplicated image at on the Y axis, from the top edge.
- `Editor.Pixmap Resize(Vector2 size)`
  - Returns a new pixel map that contains resized version of this image with given dimensions.
Will try to preserve aspect ratio.
- `Editor.Pixmap Resize(System.Int32 x, System.Int32 y)`
- `System.Boolean UpdateFromPixels(System.ReadOnlySpan<System.Byte> data, System.Int32 width, System.Int32 height, Sandbox.ImageFormat format)`
- `System.Boolean UpdateFromPixels(Sandbox.Bitmap bitmap)`
  - Copy from a bitmap
- `System.Boolean UpdateFromPixels(System.ReadOnlySpan<System.Byte> data, Vector2 size, Sandbox.ImageFormat format)`
- `System.Byte[] GetPng()`
  - Returns the raw bytes of a PNG file that contains this pixel maps image.
Internally writes and deletes a file, so be careful using it often.
- `System.Boolean SavePng(System.String filename)`
  - Save the pixel map as a PNG file at given location.
  - `filename`: A full, valid absolute target path. Will not create directories on its own.
  - returns: Whether the file was created or not.
- `System.Boolean SaveJpg(System.String filename, System.Int32 quality)`
  - Save the pixel map as a JPEG file at given location.
  - `filename`: A full, valid absolute target path. Will not create directories on its own.
  - `quality`: JPEG quality, 0 to 100.
  - returns: Whether the file was created or not.
- `System.Byte[] GetJpeg(System.Int32 quality)`
  - Returns the raw bytes of a JPEG file that contains this pixel maps image.
Internally writes and deletes a file, so be careful using it often.
  - `quality`: JPEG quality, 0 to 100.
- `System.Byte[] GetBmp(System.Int32 quality)`
  - Returns the raw bytes of a BMP file that contains this pixel maps image.
Internally writes and deletes a file, so be careful using it often.
- `Color GetPixel(System.Int32 x, System.Int32 y)`
