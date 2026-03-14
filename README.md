# ASP.NET Core + Angular/React + Azure Refresh Plan

This repository documents my **6-week technical refresh plan** to regain strong proficiency in:

- ASP.NET Core (MVC / Web API)
- Angular / React
- Azure Cloud
- CI/CD with GitHub Actions
- Scalable backend architecture

The goal is to rebuild confidence and sharpen skills for **Senior Backend / Cloud Engineering roles**.

---

# Tech Stack

Backend
- ASP.NET Core Web API
- Entity Framework Core
- FluentValidation
- MassTransit / Messaging

Frontend
- React or Angular

Database
- PostgreSQL or SQL Server

Cloud
- Azure App Service
- Azure Service Bus
- Azure Blob Storage

DevOps
- GitHub Actions
- Azure CLI

---

# Architecture Goal

By the end of this plan, the system architecture should resemble:

Frontend (React / Angular)
↓
ASP.NET Core API
↓
Azure Service Bus
↓
Worker Service
↓
PostgreSQL Database
↓
Azure Blob Storage


This architecture demonstrates **scalable backend patterns** such as:

- asynchronous processing
- message queues
- background workers
- cloud deployment

---

# Week 1 – ASP.NET Core API Fundamentals

Goal: Rebuild confidence creating APIs quickly.

### Tasks

- Create ASP.NET Core Web API project
- Setup EF Core
- Configure database migrations
- Implement CRUD endpoints

### Project

**Product Catalog API**

Endpoints:

```
GET /products
GET /products/{id}
POST /products
PUT /products/{id}
DELETE /products/{id}
```

### Concepts

- Dependency Injection
- DTOs
- Swagger
- EF Core migrations

---

# Week 2 – Production API Patterns

Goal: Move from tutorial code to **production-ready APIs**.

### Add

Validation
- FluentValidation

Error Handling
- Global exception middleware

Logging
- Built-in logging
- Structured logs

Pagination

```
GET /products?page=1&pageSize=20
```

Caching
- In-memory caching

### Concepts

- API error responses
- middleware pipelines
- API performance basics

---

# Week 3 – Background Jobs & Async Processing

Goal: Practice **scalable backend patterns**.

### Feature

Product Image Processing

Flow:

```
Client uploads image
↓
API stores metadata
↓
Message sent to queue
↓
Worker service processes image
↓
Result stored in database
```

### Tools

- MassTransit
- Azure Service Bus
- ASP.NET Core Worker Service

### Concepts

- message queues
- async workflows
- eventual consistency
- retry policies

---

# Week 4 – Frontend Integration (React or Angular)

Goal: Refresh fullstack integration.

Build a simple **Admin Dashboard**.

### Features

- list products
- create product
- edit product
- upload product image

### React Concepts

- hooks
- API calls
- state management

### Angular Concepts

- services
- HttpClient
- reactive forms

Goal: Connect frontend to the API.

---

# Week 5 – Azure Deployment

Goal: Deploy the system to Azure.

### Deploy

API → Azure App Service  
Database → Azure PostgreSQL or Azure SQL  
Images → Azure Blob Storage  

### Tasks

- configure environment variables
- secure connection strings
- test production deployment

### Concepts

- cloud configuration
- secrets management
- Azure CLI usage

---

# Week 6 – CI/CD Pipeline

Goal: Automate build and deployment.

Use **GitHub Actions**.

Pipeline:

```
Build API
Run Tests
Publish Artifacts
Deploy to Azure
```

Example flow:

```
git push
↓
GitHub Actions runs
↓
build project
↓
run tests
↓
deploy to Azure
```

### Concepts

- CI/CD pipelines
- automated deployments
- DevOps workflows

---

# Skills Strengthened

Backend

- ASP.NET Core API design
- EF Core data access
- scalable backend architecture

Cloud

- Azure services
- cloud deployments
- cloud configuration

DevOps

- CI/CD pipelines
- automated builds

Architecture

- async processing
- message queues
- distributed systems patterns

---

# Learning Principles

Avoid tutorial-only learning.

Instead follow this workflow:

```
Idea → Build → Debug → Improve
```

Focus on understanding **how systems scale**, not just how features work.

---

# Long-Term Goal

Position myself as a:

**Senior Backend / Cloud Engineer**

Core strengths:

- scalable API systems
- distributed architectures
- cloud infrastructure
- DevOps automation

---

# Progress Tracker

Week | Status
---- | ------
Week 1 – API Fundamentals | ☐
Week 2 – Production Patterns | ☐
Week 3 – Async Processing | ☐
Week 4 – Frontend Integration | ☐
Week 5 – Azure Deployment | ☐
Week 6 – CI/CD | ☐



