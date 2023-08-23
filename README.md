# interview-bcgx
## How to setup and Run
    Once you have loned the repo to your local
    Install VS Code, C# extension, and .NET 7.0 SDK.
    To Run: In the terminal "dotnet run" this will do a build for you you can run "dotnet build" for just that part
    Get the port from the output and go to http://localhost:5164/swagger/index.html
    

## Approach
    I use the dotnet  dotnet new webapi command to create a basic web api that I then modified to the correct usage instead of the default weather api that was built in. I replaced the built in controller and model with those specific to the watch catalog and then added the logic to get the price to the controller. 


## Improvements
    The most obviuous imrpovement is that this not using an actual database just an in code temporary catalog, in watch catalog file, this is unsustainable. Also, there is currently no way to add, remvove, or update new watches through the api, since this was not specified in the instructions, that would be a huge improvment towards actual usability. Another piece of potential improvemnt would be to pull most of the logic out of the controller, I left it there since it is pretty simple and there was no real need for a whole other file to handle 1 for loop, but as this is expanded it would no longer be enough.