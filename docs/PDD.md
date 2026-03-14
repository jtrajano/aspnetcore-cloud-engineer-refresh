# Product Design Document (PDD)  
**Project Name:** ASP.NET Core Cloud Refresh  
**Goal:** Refresh backend, frontend, and cloud skills by building a scalable product catalog platform with background processing and CI/CD.

---

## 1. Project Overview

This project is a **full-stack demo system** designed to practice:

- ASP.NET Core Web API / MVC  
- Business logic separation (Domain + Application)  
- Background processing with queues (MassTransit / Azure Service Bus)  
- Frontend integration (React or Angular)  
- Cloud deployment on Azure  
- CI/CD automation with GitHub Actions  

**End Goal:** A system capable of handling product management at scale, with asynchronous workflows and proper architecture.

---

## 2. Features / Functional Requirements

### 2.1 Product Management

- **CRUD Products** (Create, Read, Update, Delete)  
- Product fields:  
  - Id  
  - Name  
  - Description  
  - Price  
  - StockQuantity  
  - Images  
- **Pagination** for product listing  
- **Validation**: Required fields, positive price/stock  

### 2.2 Image Processing Workflow

- Users can upload images for products  
- Images are queued for asynchronous processing  
- Worker service resizes/compresses images and stores in **Azure Blob Storage**  
- Product metadata updated after processing  

### 2.3 User Interface

- Admin dashboard (React / Angular)  
- Product list, create, edit, delete  
- Upload images for products  
- Display product details  

### 2.4 API Design

- RESTful endpoints with proper HTTP verbs  
- Swagger documentation for all endpoints  
- Centralized error handling and structured responses  

### 2.5 Cloud Integration

- Deploy API and Worker to **Azure App Service**  
- Use **Azure Service Bus** for queues  
- Store images in **Azure Blob Storage**  
- Database: **Azure SQL / PostgreSQL**  
- Environment variables for configs  

### 2.6 CI/CD Pipeline

- GitHub Actions workflow to:  
  - Build backend API  
  - Run tests  
  - Publish artifacts  
  - Deploy to Azure  

---

## 3. Non-Functional Requirements

- **Scalability**: Handle high volume product uploads asynchronously  
- **Reliability**: Retry failed tasks in the worker service  
- **Maintainability**: Separation of concerns (Controllers / Application / Domain / Infrastructure)  
- **Observability**: Logging, metrics, monitoring for both API and worker  

---

## 4. Architecture

### 4.1 Component Diagram

