# Sandbox.WebSurface

Enables rendering and interacting with a webpage

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `System.Boolean IsLimited`
- `Sandbox.WebSurface.TextureChangedDelegate OnTexture`
  - Called when the texture has changed and should be updated
- `System.String PageTitle`
- `System.String Url`
  - The current Url
- `Vector2 Size`
  - The size of the browser
- `System.String Cursor`
- `System.Boolean HasKeyFocus`
  - Tell the html control if it has key focus currently, controls showing the I-beam cursor in text controls amongst other things
- `System.Single ScaleFactor`
  - DPI Scaling factor
- `System.Boolean InBackgroundMode`
  - Enable/disable low-resource background mode, where javascript and repaint timers are throttled, resources are
more aggressively purged from memory, and audio/video elements are paused. When background mode is enabled,
all HTML5 video and audio objects will execute ".pause()" and gain the property "._steam_background_paused = 1".
When background mode is disabled, any video or audio objects with that property will resume with ".play()".

## Methods

### Instance methods

- `virtual System.Void Dispose()`
- `System.Void TellMouseMove(Vector2 position)`
  - Tell the browser the mouse has moved
- `System.Void TellMouseWheel(System.Int32 delta)`
  - Tell the browser the mouse wheel has moved
- `System.Void TellMouseButton(Sandbox.MouseButtons button, System.Boolean state)`
  - Tell the browser a mouse button has been pressed
- `System.Void TellChar(System.UInt32 unicodeKey, Sandbox.KeyboardModifiers modifiers)`
  - Tell the browser a unicode key has been pressed
- `System.Void TellKey(System.UInt32 virtualKeyCode, Sandbox.KeyboardModifiers modifiers, System.Boolean state)`
  - Tell the browser a key has been pressed or released
