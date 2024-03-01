# Install Kiota as a tool

dotnet tool install --global Microsoft.OpenApi.Kiota

# Kiota depedencies

Bash
`
dotnet add package Microsoft.Kiota.Abstractions
dotnet add package Microsoft.Kiota.Http.HttpClientLibrary
dotnet add package Microsoft.Kiota.Serialization.Form
dotnet add package Microsoft.Kiota.Serialization.Json
dotnet add package Microsoft.Kiota.Serialization.Text
dotnet add package Microsoft.Kiota.Serialization.Multipart
`

# To create Client Application 

kiota generate -l CSharp -c MoviesClient -n KiotaMovies.Client -d ./OAS/Movies-OpenApi.yaml -o ./MovieClient

kiota generate -l CSharp -c PostsClient -n KiotaPosts.Client -d ./OAS/Posts-OpenApi.yaml -o ./PostsClient