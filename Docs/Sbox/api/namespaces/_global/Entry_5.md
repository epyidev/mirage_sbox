# Sandbox.UI.Transitions.Entry

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.UI.Transitions`

## Constructors

- `Entry(System.String property, System.Double startTime, System.Double length, System.Int32 target, Sandbox.UI.Transitions.TransitionFunction action, Sandbox.Utility.Easing.Function easingFunction)`

## Properties

- `System.String Property`
- `System.Double StartTime`
- `System.Double Length`
- `System.Int32 Target`
- `Sandbox.Utility.Easing.Function EasingFunction`
- `System.Boolean IsKilled`
- `Sandbox.UI.Transitions.TransitionFunction Action`

## Methods

### Instance methods

- `System.Single Ease(System.Single delta)`
- `System.Void Invoke(Sandbox.UI.Styles style, System.Single delta)`
