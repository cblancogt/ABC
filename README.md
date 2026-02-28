# ABC Project Management System

A web-based project management platform built with ASP.NET Core MVC and SQL Server.
Designed to manage projects, teams, tasks, and productivity metrics for internal operations.

---

## Context

This system was designed and built as a complete full-stack project, covering everything
from database modeling to frontend implementation. It represents an early but deliberate
exercise in system design — including data modeling, architecture decisions, and
end-to-end implementation.

---

## Architecture

Pattern: MVC (Model-View-Controller) using ASP.NET Core  
Database: Microsoft SQL Server 2019  
ORM: Entity Framework Core 5  
Frontend: Razor Pages, Bulma CSS, JavaScript  

The architecture separates concerns across three layers:
- Controllers handle HTTP requests and business logic coordination
- Models represent the domain entities and database schema
- Views handle presentation using Razor templating

Database schema was designed from scratch using a conceptual → logical → relational
modeling process, documented in Draw.io, Enterprise Architect, and Lucidchart.

---

## Data Model

The system manages the following core entities:

- **Usuario** — system users with role-based access
- **Proyecto** — projects with cost tracking and status
- **Tarea** — tasks assigned to team members with time tracking
- **Tarea_Log** — audit trail of task actions
- **CargaTrabajo_Productividad** — workload and productivity metrics per user
- **Proyecto_Presupuesto / Proyecto_Costo** — budget and cost breakdown per project

Full conceptual, logical, and relational diagrams are included in `/docs`.

---

## Key Decisions

**Why MVC over a separated API + frontend?**  
At the time, MVC was the right trade-off for a single-team project with no need for
a separate client. It reduced complexity and allowed faster delivery.

**Why Entity Framework Core?**  
Code-first migrations allowed the schema to evolve with the domain model without
manual SQL scripts. For a project of this size and team, the productivity gain
outweighed the performance overhead.

**Why SQL Server?**  
Familiarity with the engine and existing infrastructure. For this workload — internal
project management with moderate concurrency — SQL Server was a solid, low-risk choice.

---

## What I Would Do Differently Today

**Password security.**  
The current implementation stores credentials without proper hashing. Today I would
use BCrypt or ASP.NET Core Identity with proper salted hashing from day one.
Security is not a feature to add later — it belongs in the initial design.

**Less generic data model.**  
Some entities are too broad and would benefit from clearer domain boundaries.
Applying bounded context thinking (DDD) would produce a cleaner separation between
the project management domain and the financial/payroll domain.

---

## Stack

| Layer | Technology |
|---|---|
| Backend | ASP.NET Core MVC (.NET Core 3.1) |
| ORM | Entity Framework Core 5.0.14 |
| Database | Microsoft SQL Server 2019 |
| Frontend | Razor Pages, Bulma CSS, SweetAlert |
| IDE | Visual Studio 2019 |
| Modeling | Draw.io, Enterprise Architect, Lucidchart |

---

## Setup

1. Clone the repository
2. Update connection string in `appsettings.json`
3. Run migrations:
```
PM> add-migration MigracionInicialCB
PM> update-database
```
4. Run the project from Visual Studio

---

*Built by Carlos Blanco — Guatemala*  
