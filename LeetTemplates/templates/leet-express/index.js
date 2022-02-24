//#if needHelp
// Creates a default express application and requires additional services.
//#endif
const express = require("express");
const leet = require("./leet");
const app = express();
const port = 3000;

//#if needHelp
// Maps the default route (similar to http://example.com/) to return some cool content
//#endif
app.get("/", (req, res) => {
  const values = 
//#if needHelp
    // Repeats the value '@@value' 100 times
//#endif
    Array.from({ length: 100 }, () => "@@value")
//#if needHelp
    // Adds custom font weights
//#endif
    .map(leet.addLeetWeights)
//#if needHelp
    // Adds custom font sizes
//#endif
    .map(leet.addLeetSizes)
//#if needHelp
    // Adds custom font colors
//#endif
    .map(leet.addLeetColors)
//#if needHelp
    // Creates a string from the values above
//#endif
    .join(" ");

//#if needHelp
    // Returns HTML content to the browser
//#endif
  res.send(values);
});

//#if needHelp
// Starts the express web application that will listen on port 3000
//#endif
app.listen(port, () => {
  console.log(`Leet express app listening on http://localhost:${port}`);
});
