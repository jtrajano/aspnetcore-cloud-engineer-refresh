
# Learning Project References

## Api project references Application, 
```
cd ProductCatalog.Api
dotnet add reference ../ProductCatalog.Application
```


## Application references Domain
```
cd ../ProductCatalog.Application
dotnet add reference ../ProductCatalog.Domain
```

## Worker references Domain and Infrastructure
```
cd ../ImageProcessing.Worker
dotnet add reference ../ProductCatalog.Domain/ProductCatalog.Domain.csproj
dotnet add reference ../ProductCatalog.Infrastructure/ProductCatalog.Infrastructure.csproj
```

## Infrastructure references Domain
```
cd ../ProductCatalog.Infrastructure
dotnet add reference ../ProductCatalog.Domain/ProductCatalog.Domain.csproj
```

