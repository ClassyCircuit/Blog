[![Build](https://github.com/janissimsons/Blog/actions/workflows/build.yml/badge.svg)](https://github.com/janissimsons/Blog/actions/workflows/build.yml)  
[![Deploy](https://github.com/janissimsons/Blog/actions/workflows/deploy.yml/badge.svg)](https://github.com/janissimsons/Blog/actions/workflows/deploy.yml)

# [ janis writes code ] - coding blog
Source code for [janiswritescode.com](janiswritescode.com)

## Production Release v1
- [x] Production server is setup
- [ ] Cards content stretches entire row's height
- [ ] Article layout fixed
- [ ] Edit card (title, description, image) - tinymce inline editing
- [ ] Feature switch: admin mode
- [ ] Change article visibility. Mark as draft or published  
- [ ] navbar sticky at top  
- [ ] Authentication
- [ ] CI/CD pipelines are ready

## Backlog  
- [ ] Reading indicator line (scroll and update how much article is left to read)  
- [ ] footer sticky at bottom  
- [ ] TinyMCE needs a separate tab. Like github editor.  
- [ ] Github, gmail integration for comments section
- [ ] Tags, categories
- [ ] Automatic DB backups
- [ ] Save all Linux configs, for disaster recovery
- [ ] Automatic versioning (git tags)

## Done
- [x] When resizing browser - logo height must become smaller (along with img)  



EF commands:  
dotnet ef migrations add Init --context Context --startup-project ..\Blog.Web  
dotnet ef database update --context Context --startup-project ..\Blog.Web  
dotnet ef migrations remove --context Context --startup-project ..\Blog.Web  
dotnet ef migrations script --context Context --startup-project ..\Blog.Web  
dotnet publish -c Release -o "prod" --framework net6.0 --runtime linux-x64 /p:EnvironmentName=Production --no-self-contained
