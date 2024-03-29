FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build
WORKDIR /app
COPY . .
RUN dotnet build
RUN dotnet publish --configuration Release --output out Webflix.API.csproj

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /www
COPY --from=build /app/out .
CMD [ "dotnet", "Webflix.API.dll" ]
