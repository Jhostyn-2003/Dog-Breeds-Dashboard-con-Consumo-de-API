
# 🐕 Dog Breeds Dashboard con Consumo de API

Este proyecto es una aplicación ASP.NET Core MVC que consume la API pública de [Dog CEO](https://dog.ceo/dog-api/) para obtener y mostrar una lista de todas las razas de perros. Los datos de las razas se presentan en una interfaz gráfica, donde se puede visualizar y explorar las razas y sub-razas de perros en un formato amigable.

## 🚀 Funcionalidades

- **Consumo de API**: Utiliza la API pública de Dog CEO para obtener una lista de todas las razas de perros y sus sub-razas.
- **Visualización de datos**: Muestra la información obtenida en la interfaz gráfica, permitiendo una representación clara de las razas de perros.
- **Manejo de errores**: El controlador cuenta con un mecanismo para manejar errores y garantizar una experiencia de usuario fluida.

## 🛠️ Tecnologías Utilizadas

- **ASP.NET Core MVC**: Framework utilizado para crear la aplicación web.
- **C#**: Lenguaje de programación usado en el backend.
- **Dog CEO API**: API pública consumida para obtener los datos de las razas de perros.
- **HttpClient**: Clase usada para hacer las solicitudes HTTP a la API externa.
- **Newtonsoft.Json**: Librería para procesar las respuestas JSON de la API.

## 📋 Estructura del Proyecto

- **Controllers**:
  - `HomeController`: Controlador principal encargado de gestionar las peticiones de las vistas y comunicarse con la API externa para obtener los datos de las razas de perros.
  
- **Views**:
  - `Index`: Página principal.
  - `DogBreedsChart`: Vista que muestra las razas de perros obtenidas desde la API.
  - `Privacy`: Página de políticas de privacidad.
  - `Error`: Página de errores para manejar y mostrar detalles de errores a los usuarios.

## 📡 Consumo de la API

El proyecto realiza una solicitud GET a la siguiente API para obtener los datos de las razas de perros:

- **URL de la API**: `https://dog.ceo/api/breeds/list/all`
- **Respuesta**: Devuelve un JSON con todas las razas de perros y sus sub-razas.

Ejemplo de respuesta de la API:
```json
{
  "message": {
    "affenpinscher": [],
    "african": [],
    "airedale": [],
    "akita": [],
    "beagle": [],
    "bulldog": ["boston", "english", "french"],
    ...
  },
  "status": "success"
}
```

## ⚙️ Instalación y Configuración

1. **Clona este repositorio**:

   ```bash
   git clone https://github.com/usuario/DogBreedsDashboard.git
   cd DogBreedsDashboard
   ```

2. **Restaura las dependencias**:

   ```bash
   dotnet restore
   ```

3. **Compila y ejecuta la aplicación**:

   ```bash
   dotnet run
   ```

4. **Accede a la aplicación** en tu navegador en la dirección `http://localhost:5000`.

## 📑 Endpoints principales

- **/Home/DogBreedsChart**: Endpoint que muestra una lista de todas las razas de perros obtenidas desde la API.

## 🧑‍💻 Contribuciones

Las contribuciones son bienvenidas. Si tienes ideas para mejorar el proyecto, no dudes en hacer un fork y enviar un pull request.

1. Haz un fork del proyecto.
2. Crea una nueva rama (`git checkout -b feature/nueva-funcionalidad`).
3. Realiza tus cambios (`git commit -am 'Agregada nueva funcionalidad'`).
4. Haz push a tu rama (`git push origin feature/nueva-funcionalidad`).
5. Abre un pull request.

## 📜 Licencia

Este proyecto está bajo la Licencia MIT - consulta el archivo [LICENSE](LICENSE) para más detalles.
