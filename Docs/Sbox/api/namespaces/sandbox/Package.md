# Sandbox.Package

Represents an asset on <a href="https://asset.party/">Asset Party</a>.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Package()`

## Properties

- `System.Boolean IsRemote`
  - Whether this is a remote or a locally installed package.
- `Sandbox.Package.Organization Org`
  - The owner of this package.
- `System.String FullIdent`
  - Full unique identity of this package.
- `System.String Ident`
  - Unique identity of this package within its <see cref="P:Sandbox.Package.Org">organization.</see>.
- `System.String Title`
  - A "nice" name of this package, which will be shown to players in UI.
- `System.String Summary`
  - A short summary of the package.
- `System.String Description`
  - Full description of the package.
- `System.String Thumb`
  - Link to the thumbnail image of this package.
- `System.String ThumbWide`
  - Link to the thumbnail image of this package.
- `System.String ThumbTall`
  - Link to the thumbnail image of this package.
- `System.String VideoThumb`
  - Link to the thumbnail video of this package.
- `System.Int32 EngineVersion`
  - Engine version this package was uploaded with.
This is useful for when the base game undergoes large API changes.
- `System.String[] Tags`
  - List of tags for this package.
- `System.String[] PackageReferences`
  - List of packages that this package depends on. These will be downloaded and installed when
installing this package.
- `System.String[] EditorReferences`
  - List of packages that this package depended on during editing.
- `Sandbox.Package.Type PackageType`
  - What kind of package it is.
- `System.String TypeName`
  - What kind of package it is.
- `System.Boolean Public`
  - Whether this package is public or hidden.
- `System.Boolean Archived`
  - Whether this package is archived or not.
- `System.Single FileSize`
  - The total size of this package in MB. This only applies to packages from Asset Party, the total file size
of local packages are not calculated.
- `Sandbox.Package.PackageUsageStats Usage`
  - Statistics for user interactions with this package
- `System.Int32 Favourited`
  - Number of players who added this package to their favourites.
- `System.Int32 VotesUp`
  - Number of players who voted this package up.
- `System.Int32 VotesDown`
  - Number of players who voted this package down.
- `System.String Source`
  - Link to this package's sources, if set.
- `System.Int32 ApiVersion`
  - For game extension compatibility. Game targeting extensions are only compatible with that game
if the API Versions match.
- `Sandbox.Package.Screenshot[] Screenshots`
  - A list of screenshots
- `System.Boolean IsFavourite`
  - True if this asset is in our favourite list.
- `System.Boolean CanEdit`
  - True if we're a member of this package's organization.
- `System.String Url`
  - A link to this asset on our backend
- `System.DateTimeOffset Updated`
  - When the entry was last updated. If these are different between packages
then something updated on the backend.
- `System.DateTimeOffset Created`
  - When the package was originally created.
- `System.Int32 Collections`
  - How many collections we're in (roughly)
- `System.Int32 Referencing`
  - How many packages we're referencing (roughly)
- `System.Int32 Referenced`
  - How many packages we're referenced by (roughly)
- `Sandbox.Package.ReviewStats Reviews`
  - Stats for the reviews. Gives the number of reviews, and the fraction of the total score.
- `System.Single ErrorRate`
  - What fraction of users got errors from this package in the last day
- `Sandbox.Services.News LatestNewsPost`
  - The latest news post created by this package
- `Sandbox.Package.IRevision Revision`
  - Information about the current package revision/version.
- `Sandbox.Package.PackageInteraction Interaction`
  - Describes the authenticated user's interactions with this package. This is only available
clientside for specific users in order to show things like play history state, favourite
status and whether they have rated the item or not.
- `Sandbox.Package.LoadingScreenSetup LoadingScreen`
  - If this package is a game, it can provide media to show on the loading screen
- `System.String PrimaryAsset`
  - Gets the name of the primary asset path stored in the package metadata. This could be null or empty.

## Methods

### Static methods

- `static System.Boolean TryParseIdent(System.String ident, System.ValueTuple<System.String,System.String,System.Nullable<System.Int32>,System.Boolean> parsed)`
- `static System.String FormatIdent(System.String org, System.String package, System.Nullable<System.Int32> version, System.Boolean local)`
- `static System.Threading.Tasks.Task<Sandbox.Package> FetchAsync(System.String identString, System.Boolean partial)`
  - Find package information
- `static System.Threading.Tasks.Task<Sandbox.Package> FetchAsync(System.String identString, System.Boolean partial, System.Boolean useCache)`
  - Find package information
- `static System.Threading.Tasks.Task<Sandbox.Package> MountAsync(System.String identString, System.Boolean partial)`
  - Mount a package by ident. This is the same as FetchAsync but it also mounts the package, which means it will be available for use right away.
If you just want the package information, use FetchAsync.
- `static System.Boolean TryGetCached(System.String identString, Sandbox.Package package, System.Boolean allowPartial)`
  - Find package information
- `static System.Threading.Tasks.Task<Sandbox.Package> Fetch(System.String identString, System.Boolean partial)`
  - Find package information
- `static System.String GetCachedTitle(System.String ident)`
  - If we have this package information, try to get its name
- `static System.Threading.Tasks.Task<Sandbox.Package.FindResult> FindAsync(System.String query, System.Int32 take, System.Int32 skip, System.Threading.CancellationToken token)`
  - Retrieve a list of packages
- `static System.Threading.Tasks.Task<Sandbox.Package.ListResult> ListAsync(System.String id, System.Threading.CancellationToken token)`
  - Retrieve a list of packages, organised into groups, for discovery
- `static System.Collections.Generic.IEnumerable<Sandbox.Package> SortByReferences(System.Collections.Generic.IEnumerable<Sandbox.Package> unordered)`
- `static System.Collections.Generic.IEnumerable<T> SortByReferences(System.Collections.Generic.IEnumerable<T> unordered, System.Func<T,Sandbox.Package> getPackageFunc)`
- `static System.Threading.Tasks.Task<System.Collections.Generic.List<Sandbox.Package.IRevision>> FetchVersions(System.String identString, System.Threading.CancellationToken token)`
  - Get package version list

### Instance methods

- `System.Threading.Tasks.ValueTask<Sandbox.AchievementCollection> GetAchievements()`
  - Get a list of achievements
- `virtual T GetValue(System.String name, T defaultValue)`
  - Get a data value. These are usually set on the backend, and are package type specific. These are
generally values that are used to configure behaviour in the menu system.
- `System.Threading.Tasks.Task<Sandbox.BaseFileSystem> MountAsync(System.Boolean withCode)`
  - Download and mount this package. If withCode is true we'll try to load the assembly if it exists.
- `virtual T GetMeta(System.String keyName, T defaultValue)`
  - Get metadata value from this package for given key. This will be specific to each `Sandbox.Package.Type`.
  - `keyName`: The name of the key to look up.
  - `defaultValue`: Default value to return when requested key was not present in the package's metadata.
- `T GetCachedMeta(System.String keyName, T defaultValue)`
  - `Sandbox.Package.GetMeta``1(System.String,``0)` but with cache.
- `T GetCachedMeta(System.String keyName, System.Func<T> defaultValue)`
- `System.Boolean IsMounted()`
  - Check if the package is installed and mounted
