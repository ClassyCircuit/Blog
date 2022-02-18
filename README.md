# Blog

Source code for my personal blog.


# Todo
* Reading indicator line (scroll and update how much article is left to read)
* When making narrower - logo height must become smaller (along with img)
* footer sticky at bottom
* navbar sticky at top
* TinyMCE needs a separate row which is wider than article itself, but article stays within its own bounds to have correct preview.
* Mark article as private (change visibility) - useful for WIP articles

Text editor summary:

DO NOT USE:
CKEditor - shitty documentation, toolbar config sucks, no blazor support at all, hacky.

USE:
TinyMCE self hosted version, integrates nicely with Blazor out of the box.

EF commands:
dotnet ef migrations add InitialStructure --context Context --startup-project ..\Blog.Web