# Sandbox.Package.ReviewStats

- **Kind:** struct
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.Package`

## Properties

- `System.Int32 Total`
  - Gets the total number of ratings, including positive, negative, and promise ratings.

## Fields

- `System.Single Score`
  - A normalized score from 0 to 1, where 1 means all ratings are positive.
- `System.Int32 PositiveRatings`
  - Gets the number of positive ratings associated with the item.
- `System.Int32 NegativeRatings`
  - Gets the number of negative ratings associated with the item.
- `System.Int32 PromiseRatings`
  - Represents the number of promise ratings associated with the current instance.
- `System.Collections.Immutable.ImmutableDictionary<Sandbox.Services.Review.PositiveTags,System.Int32> PositiveTags`
  - Gets a read-only dictionary containing the count of each positive review tag associated with the item.
- `System.Collections.Immutable.ImmutableDictionary<Sandbox.Services.Review.NegativeTags,System.Int32> NegativeTags`
  - Gets a read-only dictionary containing the negative review tags and their corresponding counts.
