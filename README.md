# Clean Architecture Template

  Clean Architecture template for ASP.NET Core projects.

- SharedKernel project with common Domain-Driven Design abstractions.
- Domain layer with sample entities.
- Application layer with abstractions for:
  - CQRS
  - Example use cases
  - Cross-cutting concerns (logging, validation)
- Infrastructure layer with:
  - Authentication
  - Permission authorization
  - EF Core, PostgreSQL
  - Serilog
- Seq for searching and analyzing structured logs
  - Seq is available at http://localhost:8081 by default
- Testing projects
  - Architecture testing

## Container Support (Docker & Podman)

This project supports both Docker and Podman for containerization. You can use either tool to build and run the application.

### Using Docker

```bash
# Build and run with Docker Compose
docker-compose build
docker-compose up -d

# Stop containers
docker-compose down
```
### Using Podman

```bash
# Build and run with Podman Compose
podman-compose -f podman-compose.yml build
podman-compose -f podman-compose.yml up -d

# Stop containers
podman-compose -f podman-compose.yml down
```
The application will be available at:
- API: http://localhost:5000
- Seq Dashboard: http://localhost:5341
- MySQL: localhost:3307

<!-- 
I'm open to hearing your feedback about the template and what you'd like to see in future iterations.

If you're ready to learn more, check out [**Pragmatic Clean Architecture**](https://www.milanjovanovic.tech/pragmatic-clean-architecture?utm_source=ca-template):

- Domain-Driven Design
- Role-based authorization
- Permission-based authorization
- Distributed caching with Redis
- OpenTelemetry
- Outbox pattern
- API Versioning
- Unit testing
- Functional testing
- Integration testing

Stay awesome! -->
