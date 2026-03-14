# Technical Design Document (TDD)  
**Project Name:** ASP.NET Core Cloud Refresh  
**Goal:** Define the technical architecture, data flows, and implementation details for building the scalable product catalog system with background processing.

---

## 1. Solution & Project Structure

**Solution Name:** `AspNetCoreCloudRefresh.sln`

**Projects:**

| Project | Purpose |
|---------|---------|
| ProductCatalog.Api | ASP.NET Core API project (Controllers, Minimal APIs) |
| ProductCatalog.Domain | Core business logic (entities, domain services) |
| ProductCatalog.Application | Commands, Queries, MediatR handlers (orchestrates domain logic) |
| ProductCatalog.Infrastructure | EF Core, DB access, messaging, external services |
| ImageProcessing.Worker | Background worker for async image processing |
| Frontend.ReactAdmin | React Admin Dashboard |
| Frontend.AngularAdmin | Angular Admin Dashboard (optional) |
| Docs | Architecture diagrams, ADRs, learning notes |

**Folder Layout Example:**

