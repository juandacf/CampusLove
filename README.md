# CampusLove 💖

CampusLove es una aplicación desarrollada en C# que busca facilitar la interacción y conexión entre estudiantes dentro de un entorno universitario. El proyecto está estructurado siguiendo principios de arquitectura limpia, promoviendo una separación clara de responsabilidades y facilitando su mantenimiento y escalabilidad.

## 🧱 Estructura del Proyecto

El repositorio está organizado en las siguientes capas:

- **`application/`**: Contiene la lógica de negocio y los casos de uso de la aplicación.
- **`domain/`**: Define las entidades y las interfaces que representan el núcleo del dominio.
- **`infrastructure/`**: Implementa los detalles técnicos, como el acceso a datos y servicios externos.
- **`Program.cs`**: Punto de entrada de la aplicación.
- **`campuslove.csproj` y `campuslove.sln`**: Archivos de configuración del proyecto y la solución.

## 🛠️ Tecnologías Utilizadas

- **Lenguaje**: C#
- **Framework**: .NET
- **Base de Datos**: PostgreSQL (utilizando PL/pgSQL)
- **Arquitectura**: Clean Architecture

## 🚀 Cómo Ejecutar el Proyecto

1. **Clonar el repositorio**:

   ```bash
   git clone https://github.com/juandacf/CampusLove.git
   cd CampusLove
   ```

2. **Restaurar dependencias**:

   ```bash
   dotnet restore
   ```

3. **Compilar la solución**:

   ```bash
   dotnet build
   ```

4. **Ejecutar la aplicación**:

   ```bash
   dotnet run
   ```

> **Nota**: Asegúrate de tener una instancia de PostgreSQL en funcionamiento y de configurar las cadenas de conexión adecuadamente en los archivos de configuración correspondientes.

## 📌 Estado del Proyecto

Este proyecto se encuentra en desarrollo terminado. 


## 📄 Licencia

Este proyecto está bajo la licencia MIT. Consulta el archivo [LICENSE](LICENSE) para más información.
