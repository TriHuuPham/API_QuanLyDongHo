-------- Tạo Migration
dotnet ef migrations add AddInitTable
---------- Update Database
dotnet ef database update


------------ Cấu trúc source API (Design Partern)
- Controllers: Xử lý HTTP request/response, gọi Service
- Services: Xử lý business logic / rule nghiệp vụ
- Repositories: Data access layer, thao tác với database (CRUD, query)
- Data: Chứa DbContext và cấu hình liên quan đến database
- Entities: Model ánh xạ với database (table)
- DTOs: Data transfer object, dùng để request/response, tránh expose Entity và ẩn field nhạy cảm
