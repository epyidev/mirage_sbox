# Sandbox.Surface.ScrapeEffectData

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Surface`

## Constructors

- `ScrapeEffectData()`

## Properties

- `System.Single RoughnessFactor`
  - Similar to friction but only affects whether a scrape is rough or smooth.
- `System.Single RoughThreshold`
  - Surface roughness greater than this results in rough scrapes.
- `System.Collections.Generic.List<System.String> SmoothParticles`
  - Spawn one of these particle effects during a smooth scrape.
- `System.Collections.Generic.List<System.String> RoughParticles`
  - Spawn one of these particle effects during a rough scrape.
- `System.Collections.Generic.List<System.String> SmoothDecal`
  - Use one of these particles during a smooth scrape.
- `System.Collections.Generic.List<System.String> RoughDecal`
  - Use one of these particles during a rough scrape.
