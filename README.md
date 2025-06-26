# 🧠 AdminTareasAPI

API RESTful para gestión de tareas, construida con **ASP.NET Core 8**, **Entity Framework Core 9** y el patrón **Repository**.

Este backend forma parte de una solución full stack junto a un frontend Angular, y fue desarrollado como parte de una prueba técnica.

---

## ⚙️ Tecnologías usadas

- ✅ ASP.NET Core 8 (Web API)
- ✅ Entity Framework Core 9 (Code First)
- ✅ SQL Server
- ✅ Patrón Repository
- ✅ CORS habilitado para frontend en `http://localhost:4200`
- ✅ Swagger para documentación y pruebas

---
## 📁 Estructura del proyecto

```plaintext
AdminTareasAPI/
├── Controllers/
│   └── TareasController.cs       # Endpoints REST
├── Models/
│   └── Tarea.cs                  # Modelo de datos
├── Data/
│   └── TaskDbContext.cs          # DbContext EF Core
├── Repositories/
│   ├── ITareaRepository.cs       # Interfaz del repositorio
│   └── TareaRepository.cs        # Implementación
├── appsettings.json              # Configuración + cadena de conexión
└── Program.cs                    # Configuración del pipeline
```

---

## 🚀 Cómo correr el proyecto

### 1. Clona el repositorio

git clone https://github.com/tuusuario/AdminTareasAPI.git
cd AdminTareasAPI
2. Verifica la cadena de conexión

Edita appsettings.json:
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=TaskManagerDB;Trusted_Connection=True;TrustServerCertificate=True;" }
Ajusta Server y autenticación según tu entorno.

3. Ejecuta las migraciones (Code First)
Desde la consola del Administrador de paquetes:

Add-Migration InitialCreate
Update-Database
Esto creará la base de datos y la tabla Tareas.

4. Levanta el servidor
Desde Visual Studio o con:
dotnet run
API disponible en:

🧪 Endpoints principales
Todos documentados con Swagger en: http://localhost:<port>/swagger

```
| Método | Ruta             | Descripción              |
| ------ | ---------------- | ------------------------ |
| GET    | /api/tareas      | Obtener todas las tareas |
| GET    | /api/tareas/{id} | Obtener tarea por ID     |
| POST   | /api/tareas      | Crear nueva tarea        |
| PUT    | /api/tareas/{id} | Editar tarea existente   |
| DELETE | /api/tareas/{id} | Eliminar tarea           |
```

✅ Validaciones aplicadas
Titulo y Descripcion son obligatorios

El Estado es un número entero

Se controla que el id coincida en PUT y DELETE

Manejo básico de errores con códigos HTTP apropiados

🧠 Extras
Se aplicó patrón Repository para una separación clara de responsabilidades

CORS configurado para permitir llamadas desde Angular (http://localhost:4200)

Swagger activo por defecto en entorno de desarrollo


🧑‍💻 Autor
Desarrollado por Alfredo Cano
Contacto: alfredo10396.c@gmail.com