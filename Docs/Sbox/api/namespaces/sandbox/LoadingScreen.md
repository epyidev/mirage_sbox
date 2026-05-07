# Sandbox.LoadingScreen

Holds metadata and raw data relating to a Saved Game.

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static System.Boolean IsVisible`
- `static System.String Title`
  - A title to show
- `static System.String Subtitle`
  - A subtitle to show
- `static System.String Media`
  - A URL or filepath to show as the background image.
- `static System.Collections.Generic.List<Sandbox.LoadingContext> Tasks`
  - A list of tasks that are currently being awaited during loading.
