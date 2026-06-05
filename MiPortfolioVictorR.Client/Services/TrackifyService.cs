using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public class TrackifyService
    {

        public List<PfcUpdate> GetUpdates() =>
        [
            new PfcUpdate
            {
                Date           = new DateOnly(2025, 11, 12),
                Title          = "Proyecto finalizado y próximos pasos",
                TitleEn        = "Project completed and next steps",
                Description    = "Desarrollo de Trackify finalizado. La aplicación incluye todas las funcionalidades principales: registro de usuarios, creación de hábitos, seguimiento del progreso y gestor de racha completamente funcional. Las notificaciones automáticas no se implementaron por incompatibilidades técnicas.",
                DescriptionEn  = "Trackify development completed. The app includes all main features: user registration, habit creation, progress tracking and a fully functional streak manager. Automatic notifications were not implemented due to technical incompatibilities."
            },
            new PfcUpdate
            {
                Date           = new DateOnly(2025, 11, 8),
                Title          = "Gestor de racha completamente funcional",
                TitleEn        = "Fully functional streak manager",
                Description    = "El gestor de racha ya funciona a la perfección. Ahora la aplicación calcula y muestra de forma precisa las rachas de hábitos cumplidos, ayudando a los usuarios a mantener su motivación y constancia día tras día.",
                DescriptionEn  = "The streak manager now works perfectly. The app accurately calculates and displays habit completion streaks, helping users maintain their motivation and consistency day after day."
            },
            new PfcUpdate
            {
                Date           = new DateOnly(2025, 11, 1),
                Title          = "Creación dinámica de hábitos e inicio de sesión persistente",
                TitleEn        = "Dynamic habit creation and persistent login",
                Description    = "Los usuarios pueden crear y completar hábitos de forma dinámica, asegurando que cada hábito solo pueda marcarse como completado una vez al día o semana. El inicio de sesión ahora es persistente al abrir la aplicación.",
                DescriptionEn  = "Users can dynamically create and complete habits, ensuring each habit can only be marked as completed once per day or week. Login is now persistent when opening the app."
            },
            new PfcUpdate
            {
                Date           = new DateOnly(2025, 10, 26),
                Title          = "Implementación de la pestaña de racha",
                TitleEn        = "Streak tab implementation",
                Description    = "Pestaña de racha completada: racha actual, racha más larga y calendario interactivo donde se marcan los días en los que se han completado los hábitos.",
                DescriptionEn  = "Streak tab completed: current streak, longest streak and an interactive calendar marking the days habits were completed."
            },
            new PfcUpdate
            {
                Date           = new DateOnly(2025, 10, 24),
                Title          = "Finalización de la pestaña de creación de hábitos",
                TitleEn        = "Habit creation tab finalized",
                Description    = "El usuario puede personalizar sus hábitos eligiendo color, emoticono representativo y días de la semana o frecuencia semanal.",
                DescriptionEn  = "The user can customize their habits by choosing a color, a representative emoji and days of the week or weekly frequency."
            },
            new PfcUpdate
            {
                Date           = new DateOnly(2025, 10, 18),
                Title          = "Desarrollo completo del perfil de usuario",
                TitleEn        = "Full user profile development",
                Description    = "El usuario puede editar su información personal, cambiar la contraseña y eliminar su cuenta de forma segura. Se han implementado diálogos de confirmación para todas las acciones sensibles.",
                DescriptionEn  = "The user can edit their personal information, change their password and delete their account securely. Confirmation dialogs have been implemented for all sensitive actions."
            },
            new PfcUpdate
            {
                Date           = new DateOnly(2025, 10, 13),
                Title          = "Avances en el login y diseño de pantallas",
                TitleEn        = "Login progress and screen design",
                Description    = "Sistema de login completado y diseño de pantalla general y perfil iniciado. Corregido un bug en el backend con FastAPI que impedía cargar correctamente el usuario.",
                DescriptionEn  = "Login system completed and general screen and profile design started. Fixed a backend bug in FastAPI that prevented loading the user correctly."
            },
            new PfcUpdate
            {
                Date           = new DateOnly(2025, 10, 11),
                Title          = "Conexión frontend-backend y autenticación funcional",
                TitleEn        = "Frontend-backend connection and working authentication",
                Description    = "Hito clave: conexión correcta entre el frontend en React Native y el backend en FastAPI. Registro y autenticación de usuarios funcionando correctamente.",
                DescriptionEn  = "Key milestone: successful connection between the React Native frontend and the FastAPI backend. User registration and authentication working correctly."
            },
            new PfcUpdate
            {
                Date           = new DateOnly(2025, 10, 9),
                Title          = "Levantar frontend y backend",
                TitleEn        = "Setting up frontend and backend",
                Description    = "Backend configurado con FastAPI con todos los endpoints de tablas y sistema completo de registro, login y autenticación. Frontend levantado en React Native con pantallas básicas de inicio de sesión y registro.",
                DescriptionEn  = "Backend configured with FastAPI with all table endpoints and a complete registration, login and authentication system. Frontend set up in React Native with basic login and registration screens."
            },
            new PfcUpdate
            {
                Date           = new DateOnly(2025, 10, 8),
                Title          = "Creación del proyecto y la base de datos",
                TitleEn        = "Project and database creation",
                Description    = "Estructura del backend con FastAPI y SQLAlchemy, creando los modelos Habit y HabitLog con sus relaciones y restricciones. Sistema de autenticación con tokens. Proyecto React Native iniciado.",
                DescriptionEn  = "Backend structure with FastAPI and SQLAlchemy, creating Habit and HabitLog models with their relationships and constraints. Token-based authentication system. React Native project initialized."
            }
        ];


    }
}
