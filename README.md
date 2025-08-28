# Incidentes.Web

Aplicación web desarrollada en **Blazor WebAssembly (.NET 8)** para el registro y gestión de solicitudes de incidentes. Utiliza **MudBlazor** como framework de componentes UI para una experiencia moderna y responsiva.

## Características

- Registro de incidentes mediante formulario interactivo.
- Selección de tipo de incidente, impacto y prioridad.
- Confirmación y visualización de ticket tras el registro.
- Navegación sencilla con menú lateral.
- Integración con servicios backend vía API REST.
- Interfaz moderna basada en MudBlazor.

## Tecnologías

- [.NET 8](https://dotnet.microsoft.com/)
- [Blazor WebAssembly](https://learn.microsoft.com/aspnet/core/blazor/)
- [MudBlazor](https://mudblazor.com/)

## Estructura principal

- `Pages/RegistroIncidente/RegistroIncidente.razor`: Formulario de registro de incidentes.
- `Pages/RegistroIncidente/Confirmacion.razor`: Página de confirmación tras registrar un incidente.
- `Layout/MyNavMenu.razor`: Menú de navegación lateral.
- `Program.cs`: Configuración de servicios, HttpClient y MudBlazor.
- `wwwroot/index.html`: Página principal y recursos estáticos.

## Configuración y ejecución

1. **Clona el repositorio** y abre la solución en Visual Studio o VS Code.
2. Asegúrate de tener instalado .NET 8 SDK.
3. Configura la URL base de la API en `appsettings.json` si es necesario.
4. Restaura los paquetes y ejecuta el proyecto:

```bash
dotnet restore
dotnet run --project Incidentes.Web
```

5. Accede a la aplicación en tu navegador en `https://localhost:puerto/`.

## Personalización

- Puedes modificar los servicios de API en la carpeta `Services`.
- Los componentes de UI pueden personalizarse en la carpeta `Pages`.

## Créditos

- Basado en Blazor WebAssembly y MudBlazor.