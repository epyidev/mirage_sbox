# Sandbox.UI.TransitionDesc

Describes transition of a single CSS property, a.k.a. the values of a `transition` CSS property.


Utility to create a transition by comparing the
panel style before and after the scope.

- **Kind:** struct
- **Namespace:** `Sandbox.UI`
- **Assembly:** `Sandbox.Engine`

## Fields

- `System.String Property`
  - The CSS property to transition.
- `System.Nullable<System.Single> Duration`
  - Duration of the transition between old value and new value.
- `System.Nullable<System.Single> Delay`
  - If set, delay before starting the transition after the property was changed.
- `System.String TimingFunction`
  - The timing or "easing" function. `transition-timing-function` CSS property.
Example values would be `ease`,  `ease-in`,  `ease-out` and  `ease-in-out`.
