FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR p1/
COPY . .
RUN dotnet build
RUN dotnet publish --configuration Release -o out PizzaBox.Client/PizzaBox.Client.csproj
ENV ASPNETCORE_URLS="http://*:5000"
CMD ["dotnet", "out/PizzaBox.Client.dll"]

