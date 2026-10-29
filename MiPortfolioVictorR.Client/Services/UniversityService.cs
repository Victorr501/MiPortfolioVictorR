using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public class UniversityService
    {
        public List<UniversitySubject> GetSubjects() => [
            new UniversitySubject
            {
                Name = "Álgebra y Matemática Discreta",
                NameEn = "Algebra and Discrete Mathematics",
                Description = "Estudio de lógica y demostraciones, inducción, matrices y sistemas lineales, optimización, teoría de números y criptografía. También abarca conjuntos, funciones, relaciones, grafos y árboles, con aplicaciones en algoritmos y estructuras de datos.",
                DescriptionEn = "Study of logic and proofs, induction, matrices and linear systems, optimization, number theory and cryptography. It also covers sets, functions, relations, graphs and trees, with applications in algorithms and data structures.",
                Year = 1, Semester = 1, InProgress = true
            },
            new UniversitySubject
            {
                Name = "Fundamentos de Administración",
                NameEn = "Fundamentals of Business Administration",
                Description = "Introducción a la estrategia y organización empresarial, el liderazgo y la gestión de equipos. Incluye formas jurídicas, finanzas y evaluación de inversiones, costes, marketing, operaciones, recursos humanos y sistemas de información para la toma de decisiones.",
                DescriptionEn = "Introduction to business strategy and organization, leadership and team management. It covers legal structures, finance and investment appraisal, costs, marketing, operations, human resources and information systems for decision-making.",
                Year = 1, Semester = 1, InProgress = true
            },
            new UniversitySubject
            {
                Name = "Fundamentos Físicos de la Computación",
                NameEn = "Physical Foundations of Computing",
                Description = "Fundamentos físicos del hardware: cálculo vectorial, electricidad, magnetismo, ondas y análisis de circuitos. Incluye óptica y fibra, almacenamiento magnético, semiconductores, transistores y tecnologías de memoria como DRAM y Flash.",
                DescriptionEn = "Physical foundations of hardware: vector calculus, electricity, magnetism, waves and circuit analysis. It includes optics and fiber optics, magnetic storage, semiconductors, transistors and memory technologies such as DRAM and Flash.",
                Year = 1, Semester = 1, InProgress = true
            },
            new UniversitySubject
            {
                Name = "Tecnología de Computación",
                NameEn = "Computer Technology",
                Description = "Arquitectura y organización de computadores, representación de datos y aritmética digital. Abarca lógica combinacional y secuencial, procesadores, buses, jerarquía de memoria, entrada y salida, ensamblador MIPS y unidades de control microprogramadas.",
                DescriptionEn = "Computer architecture and organization, data representation and digital arithmetic. It covers combinational and sequential logic, processors, buses, memory hierarchy, input and output, MIPS assembly and microprogrammed control units.",
                Year = 1, Semester = 1, InProgress = true
            },
            // Asignaturas convalidadas por el Grado Superior en Desarrollo de Aplicaciones Multiplataforma.
            new UniversitySubject { Name = "Integración de Sistemas", NameEn = "Systems Integration", Grade = "5", IsRecognized = true },
            new UniversitySubject { Name = "Prácticas en Empresa", NameEn = "Company Internship", Grade = "Apto", IsRecognized = true },
            new UniversitySubject { Name = "Fundamentos de Programación", NameEn = "Programming Fundamentals", Grade = "6", IsRecognized = true },
            new UniversitySubject { Name = "Algoritmia y Complejidad", NameEn = "Algorithms and Complexity", Grade = "6", IsRecognized = true },
            new UniversitySubject { Name = "Sistemas Operativos", NameEn = "Operating Systems", Grade = "5", IsRecognized = true },
            new UniversitySubject { Name = "Interacción Persona-Ordenador", NameEn = "Human-Computer Interaction", Grade = "7", IsRecognized = true },
            new UniversitySubject { Name = "Bases de Datos", NameEn = "Databases", Grade = "5", IsRecognized = true },
        ];
    }
}
