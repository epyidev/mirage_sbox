# Sandbox.Services.Review

Package Reviews

- **Kind:** sealed class
- **Namespace:** `Sandbox.Services`
- **Assembly:** `Sandbox.Engine`

## Constructors

- `Review()`

## Properties

- `Sandbox.Services.Players.Profile Player`
  - The player who made the review
- `System.String Content`
  - The actual content (text only right now)
- `Sandbox.Services.Review.ReviewScore Score`
  - The score of the review
- `System.TimeSpan PlayTime`
  - How many seconds this user played
- `System.DateTimeOffset Updated`
  - Date this review was updated
- `Sandbox.Services.Review.NegativeTags Negatives`
- `Sandbox.Services.Review.PositiveTags Positives`

## Methods

### Static methods

- `static System.Threading.Tasks.Task<Sandbox.Services.Review[]> Fetch(System.String packageIdent, System.Int32 take, System.Int32 skip)`
- `static System.Threading.Tasks.Task<Sandbox.Services.Review.ReviewPage> FetchEx(System.String packageIdent, System.Int32 take, System.Int32 skip, System.Nullable<Sandbox.Services.Review.ReviewScore> score, System.Nullable<Sandbox.Services.Review.PositiveTags> positive, System.Nullable<Sandbox.Services.Review.NegativeTags> negatives)`
- `static System.Threading.Tasks.Task<Sandbox.Services.Review> Get(System.String packageIdent, Sandbox.SteamId steamid)`
