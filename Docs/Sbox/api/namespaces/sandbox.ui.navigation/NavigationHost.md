# Sandbox.UI.Navigation.NavigationHost

- **Kind:** class
- **Namespace:** `Sandbox.UI.Navigation`
- **Assembly:** `Base Library`
- **Base:** `Sandbox.UI.Panel`

## Constructors

- `NavigationHost()`

## Properties

- `Sandbox.UI.Panel CurrentPanel`
- `System.String CurrentUrl`
- `System.String DefaultUrl`
- `Sandbox.UI.Panel NavigatorCanvas`

## Fields

- `System.String CurrentQuery`
- `System.Collections.Generic.List<Sandbox.UI.Navigation.NavigationHost.HistoryItem> Cache`

## Methods

### Instance methods

- `virtual System.Void OnParametersSet()`
- `virtual System.Void OnTemplateSlot(Sandbox.Html.INode element, System.String slotName, Sandbox.UI.Panel panel)`
- `System.Void AddDestination(System.String url, System.Type type)`
- `Sandbox.UI.Panel Navigate(System.String url, System.Boolean redirectToDefault)`
- `System.Collections.Generic.IEnumerable<System.ValueTuple<System.String,System.String>> ExtractProperties(System.String[] parts, System.String url)`
- `virtual System.Void NotFound(System.String url)`
- `System.Boolean CurrentUrlMatches(System.String url)`
- `virtual System.Void SetProperty(System.String name, System.String value)`
- `virtual System.Void OnBack(Sandbox.UI.PanelEvent e)`
- `virtual System.Void OnForward(Sandbox.UI.PanelEvent e)`
- `virtual System.Boolean GoBackUntilNot(System.String wildcard)`
- `virtual System.Boolean GoBack()`
- `virtual System.Boolean GoForward()`
