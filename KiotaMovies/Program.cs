
using KiotaMovies.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var authProvider = new AnonymousAuthenticationProvider();
// Create request adapter using the HttpClient-based implementation
var adapter = new HttpClientRequestAdapter(authProvider);
// Create the API client
var client = new MoviesClient(adapter);

try
{
    var moviesresponse = await client.Movies.GetAsync();

    Console.WriteLine(moviesresponse.MovieDtos.First().Title); 

} catch(Exception ex)
{ Console.WriteLine(ex.ToString()); }