# Sandbox.Input.Keyboard

Keyboard related glyph methods.

- **Kind:** static class
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Input`

## Methods

### Static methods

- `static Sandbox.Texture GetGlyph(System.String key, Sandbox.InputGlyphSize size, System.Boolean outline)`
  - Get a glyph texture from a specific key name.
- `static System.Boolean Down(System.String keyName)`
  - Keyboard key is held down
- `static System.Boolean Pressed(System.String keyName)`
  - Keyboard key wasn't pressed but now it is
- `static System.Boolean Released(System.String keyName)`
  - Keyboard key was pressed but now it isn't
