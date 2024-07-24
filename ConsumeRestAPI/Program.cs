
using ConsumeRestAPI;
using Spectre.Console;
using Spectre.Console.Json;

ApiClient apiClient = new ApiClient();
// fetch random name from the internet
var response = await apiClient.Get("https://randomuser.me/api/");
var json = new JsonText(response.ToString());
AnsiConsole.Write(
    new Panel(json)
        .Header("Random user")
        .Collapse()
        .RoundedBorder()
        .BorderColor(Color.Yellow));