aspnetcore-cloud-refresh/        <-- GitHub repo root
│
├── README.md
├── docs/
│   ├── architecture.md
│   └── learning-notes.md
│
├── backend/                     <-- API solution folder
│   ├── ProductCatalog.sln       <-- .NET solution
│   ├── ProductCatalog.Api/      <-- ASP.NET Core API (Controllers, minimal APIs)
│   ├── ProductCatalog.Domain/   <-- Business logic (services, entities)
│   ├── ProductCatalog.Application/ <-- Use cases, MediatR handlers
│   └── ProductCatalog.Infrastructure/ <-- EF Core, messaging, external services
│
├── worker/
│   └── ImageProcessing.Worker/  <-- Worker service project
│       ├── Services/            <-- Business logic for worker
│       └── Infrastructure/      <-- Blob storage, queues
│
├── frontend/
│   ├── ReactAdmin/              <-- React project
│   └── AngularAdmin/            <-- Angular project (optional)
│
└── infrastructure/
    ├── github-actions/
    └── azure-deployment/
