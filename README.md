# Hello World API

A simple proof of concept MVC app that displays "Hello, world!" in a web browser. The string is pulled from an API that has been set up with a factory pattern for future extensibility.

# Why an enum for the factory's switch statement?
## Why not string constants?

This is a personal experiment: I've been curious about the benefits and drawbacks of using an `enum` as an intermediary for parsing settings for a switch statement. A set of `const string`s will accomplish the same thing, and is typically what is used.

### Benefits
* A whitelist of options for a single setting. 
* Invalid enumerators in code are flagged at compile time.

### Drawbacks
* `Enum.TryParse` is not foolproof; there are some gotchas where `Enum.IsDefined` must be used as a follow-up.
    * I was given the default enumerator when I supplied an invalid string to `Enum.TryParse`; I was expecting an exception.
* Enumerators cannot have spaces in their names.
* Very awkward code for parsing a string into an enum: `var paradigmName = (ParadigmName)Enum.Parse(typeof(ParadigmName), paradigm, true);`
* Apparently there are performance penalties associated with parsing strings to enums in this fashion.

### Conclusion
This was an interesting experiment for but I'll stick with constant strings in the future.
