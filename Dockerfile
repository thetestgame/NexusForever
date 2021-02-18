FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
ARG ServerExecutable
RUN echo "Building NexusForever executable: ${ServerExecutable}"

WORKDIR /src
COPY ["Source/", "Source/"]
RUN dotnet restore "Source/NexusForever.${ServerExecutable}/NexusForever.${ServerExecutable}.csproj"

COPY . .
WORKDIR "/src/Source/NexusForever.${ServerExecutable}"
RUN dotnet build "NexusForever.${ServerExecutable}.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NexusForever.${ServerExecutable}.csproj" -c Release -o /app/publish

FROM base AS final
ARG ServerExecutable

WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=publish /app/publish/${ServerExecutable}.example.json ./${ServerExecutable}.json

RUN if [ "$ServerExecutable" = "WorldServer"]; then mkdir -p ./tbl ; else echo "Ignoring tlb folder"; fi
RUN if [ "$ServerExecutable" = "WorldServer"]; then mkdir -p ./map ; else echo "Ignoring map folder"; fi

ENV ServerDLLName=$ServerExecutable
ENTRYPOINT dotnet NexusForever.$ServerDLLName.dll
