using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public class TrackifyService
    {

        public List<PfcUpdate> GetUpdates() =>
        [
            new PfcUpdate
            {
                Date        = new DateOnly(2025, 11, 12),
                Title       = "Proyecto finalizado y próximos pasos",
                Description = "Desarrollo de Trackify finalizado. La aplicación incluye todas las funcionalidades principales: registro de usuarios, creación de hábitos, seguimiento del progreso y gestor de racha completamente funcional. Las notificaciones automáticas no se implementaron por incompatibilidades técnicas."
            },
            new PfcUpdate
            {
                Date        = new DateOnly(2025, 11, 8),
                Title       = "Gestor de racha completamente funcional",
                Description = "El gestor de racha ya funciona a la perfección. Ahora la aplicación calcula y muestra de forma precisa las rachas de hábitos cumplidos, ayudando a los usuarios a mantener su motivación y constancia día tras día."
            },
            new PfcUpdate
            {
                Date        = new DateOnly(2025, 11, 1),
                Title       = "Creación dinámica de hábitos e inicio de sesión persistente",
                Description = "Los usuarios pueden crear y completar hábitos de forma dinámica, asegurando que cada hábito solo pueda marcarse como completado una vez al día o semana. El inicio de sesión ahora es persistente al abrir la aplicación."
            },
            new PfcUpdate
            {
                Date        = new DateOnly(2025, 10, 26),
                Title       = "Implementación de la pestaña de racha",
                Description = "Pestaña de racha completada: racha actual, racha más larga y calendario interactivo donde se marcan los días en los que se han completado los hábitos."
            },
            new PfcUpdate
            {
                Date        = new DateOnly(2025, 10, 24),
                Title       = "Finalización de la pestaña de creación de hábitos",
                Description = "El usuario puede personalizar sus hábitos eligiendo color, emoticono representativo y días de la semana o frecuencia semanal."
            },
            new PfcUpdate
            {
                Date        = new DateOnly(2025, 10, 18),
                Title       = "Desarrollo completo del perfil de usuario",
                Description = "El usuario puede editar su información personal, cambiar la contraseña y eliminar su cuenta de forma segura. Se han implementado diálogos de confirmación para todas las acciones sensibles."
            },
            new PfcUpdate
            {
                Date        = new DateOnly(2025, 10, 13),
                Title       = "Avances en el login y diseño de pantallas",
                Description = "Sistema de login completado y diseño de pantalla general y perfil iniciado. Corregido un bug en el backend con FastAPI que impedía cargar correctamente el usuario."
            },
            new PfcUpdate
            {
                Date        = new DateOnly(2025, 10, 11),
                Title       = "Conexión frontend-backend y autenticación funcional",
                Description = "Hito clave: conexión correcta entre el frontend en React Native y el backend en FastAPI. Registro y autenticación de usuarios funcionando correctamente."
            },
            new PfcUpdate
            {
                Date        = new DateOnly(2025, 10, 9),
                Title       = "Levantar frontend y backend",
                Description = "Backend configurado con FastAPI con todos los endpoints de tablas y sistema completo de registro, login y autenticación. Frontend levantado en React Native con pantallas básicas de inicio de sesión y registro."
            },
            new PfcUpdate
            {
                Date        = new DateOnly(2025, 10, 8),
                Title       = "Creación del proyecto y la base de datos",
                Description = "Estructura del backend con FastAPI y SQLAlchemy, creando los modelos Habit y HabitLog con sus relaciones y restricciones. Sistema de autenticación con tokens. Proyecto React Native iniciado."
            }
        ];


    }
}
