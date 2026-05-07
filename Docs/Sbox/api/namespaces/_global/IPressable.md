# Sandbox.Component.IPressable

A component that can be pressed. Like a button. This could be by 
a player USE'ing it, or by a player walking on it, or by an NPC.
A call to Press should ALWAYS call release afterwards. Generally
this is done by the player, where holding E presses the button, and
releasing E stops pressing it. You need to handle edge cases where
the player dies while holding etc.

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Component`

## Methods

### Instance methods

- `virtual System.Void Hover(Sandbox.Component.IPressable.Event e)`
  - A player has started looking at this
- `virtual System.Void Look(Sandbox.Component.IPressable.Event e)`
  - A player is still looking at this. Called every frame.
- `virtual System.Void Blur(Sandbox.Component.IPressable.Event e)`
  - A player has stopped looking at this
- `virtual System.Boolean Press(Sandbox.Component.IPressable.Event e)`
  - Pressed. Returns true on success, else false.
If it returns true then you should call Release when the
press finishes. Not everything expects it, but some stuff will.
- `virtual System.Boolean Pressing(Sandbox.Component.IPressable.Event e)`
  - Still being pressed. Return true to allow the press to continue, false cancel the press
- `virtual System.Void Release(Sandbox.Component.IPressable.Event e)`
  - To be called when the press finishes. You should only call this
after a successful press - ie when Press hass returned true.
- `virtual System.Boolean CanPress(Sandbox.Component.IPressable.Event e)`
  - Return true if the press is possible right now
- `virtual System.Nullable<Sandbox.Component.IPressable.Tooltip> GetTooltip(Sandbox.Component.IPressable.Event e)`
  - Get a tooltip to show when looking at this pressable
