
<p align="center">
    <h3 align="center">Juan David Leon Barrera</h3>
	<p align="center">
		<img src="https://img.shields.io/badge/.NET-5C2D91?logo=.net&logoColor=white" alt="template repository">
		<img src="https://img.shields.io/static/v1?label=proyecto&message=Api Rest&color=white" alt="v1.0.0">
		<img src="https://img.shields.io/static/v1?label=version&message=1.0.0&color=red" alt="v1.2">
		<img src="https://img.shields.io/static/v1?label=licencia&message=wilmilcard&color=green" alt="no tiene">
	</p>
  <p align="center">
      <a href="https://nevergate.com.co/"><img src="https://nevergate.com.co/otros/portafolio/images/logo.png" width="200"></a>
  </p>
</p>


# 🚩 Objetivo

Este proyecto esta desarrollado C# NET 6 utilizando CodeFirst y MySql; con el fin de resolver prueba tecnica de Smart Talent, se utilizaron buenas practicas de codigo limpio.

🍂Se uso la libreria para llenar los seeder: **[Bogus](https://github.com/bchavez/Bogus)** 🍂

# 📄 Descripción del proyecto

El proyecto esta divido en dos:
- **SmartTalent**: Es el proyecto principal donde se almacenan los controllers, los modelos personalizados para las request, las interfaces, los servicios, las clases que sirven de apoyo como los generadores de codigos, JWTHelpers,
  Encrypt, la injeccion de dependencias y las configuraciones de Startup
- **SmartTalent.Domain**: Donde se realiza exclusivamente las configuraciones de bases de datos, las migraciones, seeders, informacion fake para llenar tablas, los repositorios con los querys, relacion de tablas por medio de modelos.

De acuerdo al documento hay dos historias de usuario, con base a esas dos se crearon 3 Controllers que puedan suplir la necesidad asi:

- **AuthController**: Es el que nos permite logearnos, para poder generar el token de acceso a los endpoints.
- **HotelController**: Resuelve los casos de uso de la historia de administracion del hotel.
- **UserController**: Que permite resolver la historia con sus casos de uso de los usuarios.

Se puede manejar otro orden en produccion, pero es una organizacion parcial que realice asi, mas adelante explicare los EndPoints a detalle. Tambien existe otro controller pero lo uso para realizar un ajuste de la 
informacion de reservas, ya que se genero de forma aleatoria por medio de librerias en los seeder

- **ToolsController**: Se utiliza de apoyo para ajustar valores aleatorios en las reservas.

## 🗃️ Diagrama de Base de Datos

<p align="center">
  <a href="https://nevergate.com.co/"><img src="https://nevergate.com.co/otros/images/git/smart_talent/smart_talent_diagram.png" width="600"></a>
</p>

Todas las tablas tienen unos campos de auditorias o logs, que permiten saber Cuando y Quien actualizo o creo el registro.

- **RolType**: Almacena los roles de las personas registradas en el sistema.
- **DocType**: Almacena los tipos de identificacion de los usuarios.
- **City**: El registro de las ciudades donde existen hoteles.
- **RoomType**: Centraliza los tipos de habitación que se guardan, lo que unifica el valor por noche de cada habitacion, en caso de actualizar el valor, solo es necesario cambiarlo en el tipo de habitacion a la
  cual esta registrada la habitación.
- **Hotel**: Almacena los hoteles, y se define un campo de disponibilidad.
- **Favorites**: la tabla almacena la relacion entre los usuarios y las habitaciones favoritas.
- **Room**: se guardan todas las habitaciones del sistema, guarda relacion con el hotel y por consiguiente con la ciudad, una relacion con su tipo de habitacion y una cantidad maxima de huespedes que puede alojar.
- **Booking**: Almacena las reservaciones, fechas, costos, codigo de reserva y persona que realizo la reserva.
- **PersonBooking**: Almacena la relacion de los huespedes alojados en esa reserva (y la habitacion).
- **Person**: La informacion de las personas, huespedes y usuarios de la plataforma.
- **User**: el usuario al que le pertenece la persona registrada, se usa para loggearse y para guardar los registros de log.
- **Session**: Verifica y almacena los usuarios registrados y los tokens de acceso.
- **__efmigrationshistory**: la utiliza EntityFramewors para llevar un registro de migraciones

## ✔ Reto

<p align="center">
  <a href="https://nevergate.com.co/"><img src="https://nevergate.com.co/otros/images/git/smart_talent/swagger.png" width="800"></a>
</p>

*Para ambas historias de usuario el personal debera loggearse primero* 🧪

### Historia de usuario 'Administracion de alojamiento hoteles locales':

- El sistema deberá permitir crear un nuevo hotel: **POST** https://localhost:7105/api/Hotel/CreateHotel
- El sistema deberá permitir asignar al hotel cada una de las habitaciones disponibles para reserva: **PUT** https://localhost:7105/api/Hotel/UpdateHotel/25
- El sistema deberá permitir modificar los valores de de cada habitación: **POST** https://localhost:7105/api/Hotel/UpdateRoomValues
- El sistema deberá permitir modificar los valores de cada hotel: **POST** https://localhost:7105/api/Hotel/UpdateRoomValues
- El sistema me deberá permitir habilitar o deshabilitar cada uno de los hoteles: **PUT** https://localhost:7105/api/Hotel/UpdateHotel/25
- El sistema me deberá permitir habilitar o deshabilitar cada una de las habitaciones del hotel: **PUT** https://localhost:7105/api/Hotel/UpdateHotel/25
- El sistema deberá listar cada una de las reservas realizadas en mis hoteles: **GET** https://localhost:7105/api/Hotel/GetAllHotel
- El sistema deberá permitir ver el detalle de cada una de las reservas realizadas: **GET** https://localhost:7105/api/Hotel/GetHotelById/25

### Historia de usuario 'Reserva de hoteles':

- El sistema me deberá dar la opción de buscar por: fecha de entrada al alojamiento, fecha de salida del alojamiento, cantidad de personas que se alojarán y ciudad de destino: **POST** https://localhost:7105/api/User/GetBooking
- El sistema me deberá permitir elegir una habitación del hotel de mi preferencia: **POST** https://localhost:7105/api/User/Book
- El sistema me deberá desplegar un formulario de reserva para ingresar los datos de los huéspedes: **POST** https://localhost:7105/api/User/Book
- El sistema deberá permitir realizar la reserva de la habitación: **POST** https://localhost:7105/api/User/Book
- El sistema me deberá notificar la reserva por medio de correo electrónico: Al momento de realizar la reservacion, dentro del endpoint *Book* hay una subconsulta que define cual es el email del usuario de la reserva y usa
  el metodo de la clase *EmailTools.cs* para enviar un correo personalizado

## ❌ Supuestos y restricciones

- Cada habitación deberá permitir registrar el costo base, impuestos y tipo de habitación.
- Cada habitación deberá permitir registrar la ubicación en que se encuentra.
- Los datos de cada pasajero deben ser: Nombres y apellidos, Fecha de nacimiento, Género, Tipo de documento, Número de documento, Email, Teléfono de contacto.
- La reserva deberá asociar un contacto de emergencia, el cual debe contener: Nombres completos, Teléfono de contacto.

# 🔥 Ejecucion de proyecto

Para que el proyecto funcione correctamente se debe de tener instalado: 

- IDE de desarrollo (Visual Studio 2022)
- MySql
- Postman

🛴 Una vez se tengan las herramientas instaladas:

1. Clonar el repositorio
2. Crear en Sql Server una base de datos llamada "smart_talent"
    - 💡 Si desea cambiarle el nombre es tan facil como ir al proyecto ApiNet6 y en el `appsetting.json` cambiar la propiedad **Initial Catalog = Nombre_Base_Datos** 
    en la cadena de conexion.
3. Abrir la consola de "Administrador de paquetes" y en el proyecto donde se ejecutara la consola ponerlo en SmartTalent.Domain. Ejecutar el comando `update-database`; 
esto creara las tablas y las llenara con el *sedder*
4. **Opcional** ejecutar el endpoint https://localhost:7105/api/Tools/FixValuesBooking que corregira errores de seeder.
5. Luego ejecutar el proyecto con **IIS Express**.
6. Ya estara corriendo la aplicacion desde en endpoint de swagger en la ruta estandar https://localhost:7105/swagger/index.html

