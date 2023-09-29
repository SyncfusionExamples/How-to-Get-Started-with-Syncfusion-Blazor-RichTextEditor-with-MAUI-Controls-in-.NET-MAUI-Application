# How-to-Get-Started-with-Syncfusion-Blazor-RichTextEditor-with-MAUI-Controls-in-.NET-MAUI-Application
This sample demonstrate How to Get Started with Syncfusion Blazor RichTextEditor with MAUI Controls in .NET MAUI Application.

This article provides a step-by-step guide on creating a .NET MAUI Blazor application and integrating Syncfusion Blazor components with Syncfusion .NET MAUI components.
### Creating a .NET MAUI Blazor Application: ###
**Step 1: Install Required Software**

 Ensure that you have the necessary software installed, including Visual Studio with the .NET workload and the .NET MAUI workload.
 
*	.NET SDK 6.0 (Latest .NET SDK 6.0.101 or above)
*	The latest Visual Studio 2022 with the required workloads:
*	Mobile development with .NET
*	ASP.NET and web development

**Step 2: Create a New .NET MAUI Project**

 Open Visual Studio, select "Create a new project," and choose ".NET MAUI Blazor App” from the project templates. Set the project name, location, and solution name. Then, create a project with the .NET framework (.NET 6.0 or .NET 7.0).

**Step 3: Build and Run the Default Application**

 Build the project and run it to ensure that it's set up correctly.

### Configuring the Blazor RichTextEditor: ###
**Step 1: Install Required NuGet**

To add the RichTextEditor component to the app, open the NuGet package manager in Visual Studio, search for "Syncfusion.Blazor.RichTextEditor," and install it.

**Step 2: Register Syncfusion Blazor Service**

Open the /Imports.razor file and add the Syncfusion.Blazor namespace. Then, register the Syncfusion Blazor service in the MAUI Blazor App by opening the MauiProgram.Cs file and adding the AddSyncfusionBlazor service method.

```
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        . . .
        builder.Services.AddSyncfusionBlazor();
        . . .
    }
}
```

**Step 3: Add Stylesheet Reference**

To include the theme reference in the Blazor application, follow the Theme reference topic. You can add the theme reference through various approaches, such as Static Web Asset, CDN, CRG, Theme studio, and NPM packages. In this example, we refer to the theme reference through CDN resources. Add the Syncfusion Blazor stylesheet inside the <head> of the wwwroot/index.html file.

```
<head>
. . .
    <link href="https://cdn.syncfusion.com/blazor/23.1.36/styles/material.css" rel="stylesheet" />
</head>
```

Make sure that the version in the URLs matches the version of the Syncfusion Blazor Package you are using.

>Note: 
•	For Blazor WebAssembly application, refer style sheet inside the <head> of wwwroot/index.html file.
•	For Blazor Server application, refer style sheet inside the <head> of
o	~/Pages/_Host.cshtml file for .NET 3, .NET 5 and .NET 7.
o	~/Pages/_Layout.cshtml for .NET 6.

**Step 4: Add Script Reference**

Similarly, add the script reference to the Blazor application. You can add the script reference through various approaches, such as Static Web Asset, CDN, and CRG. In this example, we refer to the scripts through CDN resources. Add the Syncfusion Blazor scripts inside the <head> of the wwwroot/index.html file.

```
<head>
. . .

    <script src="https://cdn.syncfusion.com/blazor/23.1.36/syncfusion-blazor.min.js" type="text/javascript"></script>
</head>
```

>Note: 
•	For Blazor WebAssembly application, refer style sheet inside the <head> of wwwroot/index.html file.
•	For Blazor Server application, refer style sheet inside the <head> of
o	~/Pages/_Host.cshtml file for .NET 3, .NET 5 and .NET 7.
o	~/Pages/_Layout.cshtml for .NET 6.

**Step 5: Add Blazor RichTextEditor**

Now, you can add the RichTextEditor component in any razor file. In this example, we've added the RichTextEditor component to the index.razor page under the ~/Pages folder.

```
@using Syncfusion.Blazor.RichTextEditor

<SfRichTextEditor>
    <p>Rich Text Editor allows to insert images from online source as well as local computer where you want to insert the image in your content.</p>
    <p><b>Get started Quick Toolbar to click on the image</b></p>
    <p>It is possible to add custom style on the selected image inside the Rich Text Editor through quick toolbar.</p>
</SfRichTextEditor>

```

**Step 6: Build and run the application**


Build the project and run it to launch the RichTextEditor component.

If you want to display the RichTextEditor only on the output screen, you can remove the sidebar and top-row in the MainLayout.razor file.

### Integrating the Blazor RichTextEditor Component with MAUI Component: ###
To create a simple mail UI using MAUI AutoComplete and Blazor RichTextEditor components, follow these steps:
Install the Syncfusion.Maui.Inputs NuGet package.
Register the handler for Syncfusion core in the MauiProgram.Cs file.
Add the MAUI AutoComplete component to handle inputs for 'To;, 'Cc', 'Bcc', and the 'Subject' fields of the email.
Incorporate the BlazorRichTextEditor for composing the body.

```
public static class MauiProgram
{
   public static MauiApp CreateMauiApp()
   {
       . . .
       builder.ConfigureSyncfusionCore();
       . . .
   }
}
```

<img width="711" alt="Blazor RichTextEditor with MAUI components" src="https://github.com/SyncfusionExamples/How-to-Get-Started-with-Syncfusion-Blazor-RichTextEditor-with-MAUI-Controls-in-.NET-MAUI-Application/assets/61832185/88cf7f4e-183f-46b5-a457-8fc899baa78c">
