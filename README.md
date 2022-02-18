# Blog

Source code for my personal blog.


## Todo  
[] Reading indicator line (scroll and update how much article is left to read)  
[x] When making narrower - logo height must become smaller (along with img)  
[] footer sticky at bottom  
[] navbar sticky at top  
[] TinyMCE needs a separate tab. Like github editor.  
[] Mark article as private (change visibility) - useful for WIP articles  


EF commands:  
* dotnet ef migrations add Init --context Context --startup-project ..\Blog.Web  
* dotnet ef database update --context Context --startup-project ..\Blog.Web  
* dotnet ef migrations remove --context Context --startup-project ..\Blog.Web  