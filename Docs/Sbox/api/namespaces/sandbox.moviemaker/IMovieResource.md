# Sandbox.MovieMaker.IMovieResource

A container for a `Sandbox.MovieMaker.Compiled.MovieClip`, including optional `Sandbox.MovieMaker.IMovieResource.EditorData`.

- **Kind:** interface
- **Namespace:** `Sandbox.MovieMaker`
- **Assembly:** `Sandbox.Engine`

## Properties

- `Sandbox.MovieMaker.Compiled.MovieClip Compiled`
  - Compiled movie clip.
- `System.Text.Json.Nodes.JsonNode EditorData`
  - Editor-only data used to generate `Sandbox.MovieMaker.IMovieResource.Compiled`.

## Methods

### Instance methods

- `virtual System.Void StateHasChanged(Sandbox.MovieMaker.IMovieProject project)`
  - Mark this resource as modified, with changes coming from the given `project`.
