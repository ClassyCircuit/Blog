# [ janis writes code ] - coding blog
Source code for janiswritescode.com

## Production Release v1
- [ ] Cards content stretches entire row's height
- [ ] Article layout fixed
- [ ] Edit card (title, description, image) - tinymce inline editing
- [ ] Feature switch: admin mode
- [ ] Change article visibility. Mark as draft or published  
- [ ] navbar sticky at top  
- [ ] Authentication

## Backlog  
- [ ] Reading indicator line (scroll and update how much article is left to read)  
- [ ] footer sticky at bottom  
- [ ] TinyMCE needs a separate tab. Like github editor.  
- [ ] Github, gmail integration for comments section
- [ ] Tags, categories

## Done
- [x] When resizing browser - logo height must become smaller (along with img)  



EF commands:  
dotnet ef migrations add Init --context Context --startup-project ..\Blog.Web  
dotnet ef database update --context Context --startup-project ..\Blog.Web  
dotnet ef migrations remove --context Context --startup-project ..\Blog.Web  
dotnet ef migrations script --context Context --startup-project ..\Blog.Web  
dotnet publish --configuration Release /p:EnvironmentName=Production --output ./prod
