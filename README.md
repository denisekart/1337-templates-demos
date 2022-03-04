# 1337-templates-demos - Show and tell - dotnet templating

This is a repository containing sample dotnet templates used in a presentation.

## How to install

These templates are publicly hosted. You can install them by executing the following script

```powershell
dotnet new --install DenisEkart.Demo.Templates
```

you should see an output similar to the following

```text
Success: DenisEkart.Demo.Templates::0.1.0 installed the following templates:
Template Name              Short Name    Language  Tags
-------------------------  ------------  --------  ---------------------
LeetApi Demo Template      leet-api      [C#]      1337/api/demo
LeetApi Demo Template      license                 1337/license/demo
LeetExpress Demo Template  leet-express  js        1337/api/demo/express
```

You can now call `dotnet new` using the newly installed templates.

> Note: You can always run `dotnet new <short name> --help` to see how to use the template.

## `leet-api`

This template will scaffold a dotnet web application. The application will run on a randomly generated port and will display a text that you configure.

Example:

```powershell
dotnet new leet-api -o myOutputFolder --content "random content to display" --help-me
```

The configured script will create a project in `myOutputFolder`, configure the content to be `random content to display` and will add a ridiculous number of comments to the code because `--help-me` was specified.

## `license`

This template will add a license to any existing project of folder.

```powershell
dotnet new license --license-type MIT --license-author "Denis Ekart"
```

> Note: Only `MIT` and `CUSTOM` license can be generated at this point - this is a demo after all.

## `leet-express`

To demonstrate the ability of dotnet templating engine to push templating beyond just `dotnet`, the following command will scaffold an exact replica of the [leet-api](#leet-api) - only it will be an [express.js](https://expressjs.com/) application.

```powershell
dotnet new leet-express -o myOutputFolder --content "dotnet > express" --help-me
```

> Note: You will be prompted to run the `npm install`. You can always select N(no) and do it manually later. ...or just append an `--allow-scripts yes` and watch the world burn.

## What's next?

Dotnet templating is a huge subject. Here are a few useful resources that might get you started.

- [dotnet/templating Wiki](https://github.com/dotnet/templating/wiki) - dotnet template engine Wiki (for developers)
- [dotnet new](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new) - dotnet CLI article (the `new` command)
- [How to guide](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new) - How to create your own templates for dotnet new
