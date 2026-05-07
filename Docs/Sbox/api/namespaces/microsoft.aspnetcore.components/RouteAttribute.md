# Microsoft.AspNetCore.Components.RouteAttribute

- **Kind:** attribute
- **Namespace:** `Microsoft.AspNetCore.Components`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Attribute`

## Constructors

- `RouteAttribute(System.String url)`

## Properties

- `System.String Url`
  - The full url of this route (ie "/home/section/page")
- `System.String[] Parts`
  - The url split into parts (ie "home" "section" "page" )

## Methods

### Static methods

- `static System.Nullable<System.ValueTuple<Sandbox.TypeDescription,Microsoft.AspNetCore.Components.RouteAttribute>> FindValidTarget(System.String url, System.String parentUrl)`
  - Given a URL, check out TypeLibrary and find a valid target

### Instance methods

- `System.Boolean IsUrl(System.String url)`
  - True if this matches the passed in url.
Queries are trimmed and ignored `( ?query=fff )`
Variables are tested (but not type matched or anything)
- `System.Collections.Generic.IEnumerable<System.ValueTuple<System.String,System.String>> ExtractProperties(System.String url)`
  - Given a Url, check for {properties} and convert them to key values
