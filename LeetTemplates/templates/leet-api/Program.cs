#if needHelp
// Creates a default web application builder and builds it. Produces a WebApplication.
#endif
var app = WebApplication
    .CreateBuilder(args)
    .Build();

#if needHelp
// Maps the default route (similar to http://example.com/) to return some cool content
#endif
app.MapGet("/", () =>
{
    var values =
#if needHelp
    // Repeats the value '@@value' 100 times
#endif
    Enumerable.Repeat("@@value", 100)
#if needHelp
    // Adds custom font weights
#endif
    .AddLeetWeights()
#if needHelp
    // Adds custom font sizes
#endif
    .AddLeetSizes()
#if needHelp
    // Adds custom font colors
#endif
    .AddLeetColors()
#if needHelp
    // Creates a string from the values above
#endif
    .Join();

#if needHelp
    // Returns HTML content to the browser
#endif
    return Results.Content(values, "text/html");
});

#if needHelp
    // Runs the web application and waits
#endif
app.Run();

