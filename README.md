# Blog

Source code for my personal blog.


## Todo  
- [x] When resizing browser - logo height must become smaller (along with img)  
- [ ] Reading indicator line (scroll and update how much article is left to read)  
- [ ] footer sticky at bottom  
- [ ] navbar sticky at top  
- [ ] TinyMCE needs a separate tab. Like github editor.  
- [ ] Mark article as private (change visibility) - useful for WIP articles  
- [ ] Authentication, admin actions
- [ ] Github, gmail integration for comments section
- [ ] Tags, categories
- [ ] Edit card (title, description, image)


EF commands:  
* dotnet ef migrations add Init --context Context --startup-project ..\Blog.Web  
* dotnet ef database update --context Context --startup-project ..\Blog.Web  
* dotnet ef migrations remove --context Context --startup-project ..\Blog.Web  