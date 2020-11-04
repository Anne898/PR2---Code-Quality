using System;
using System.Collections.Generic;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Clase Grade (Program), se encarga de pedir la calificación de examenes, tareas y participacion de cada unidad
    /// </summary>
    class Grades
    {
        static void Main(string[] args)
        {
            // TODO: agregar un método para pedir datos e implementar un menú de opciones

            /*System.Console.WriteLine("Calificaciones para Ana Paola Acosta");
            System.Console.WriteLine("Matematicas unidad 1");
            System.Console.WriteLine("Examen");
            double mathTest1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Tareas");
            double mathHomework1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Participación");
            double mathParticipation1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Matematicas unidad 2");
            System.Console.WriteLine("Examen");
            double mathTest2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Tareas");
            double mathHomework2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Participación");
            double mathParticipation2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Matematicas unidad 3");
            System.Console.WriteLine("Examen");
            double mathTest3 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Tareas");
            double mathHomework3 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Participación");
            double mathParticipation3 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Programación unidad 1");
            System.Console.WriteLine("Examen");
            double programmingTest1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Tareas");
            double programmingHomework1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Participación");
            double programmingParticipation1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Programación unidad 2");
            System.Console.WriteLine("Examen");
            double programmingTest2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Tareas");
            double programmingHomework2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Participación");
            double programmingParticipation2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Programación unidad 3");
            System.Console.WriteLine("Examen");
            double programmingTest3 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Tareas");
            double programmingHomework3 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Participación");
            double programmingParticipation3 = Convert.ToInt32(Console.ReadLine());*/


            //Calculadora de calificaciones
            GradeCalculator gradeCalculator = new GradeCalculator();

            //Objetos "Subject" se encarga de asignar nombre y valores del examen, tareas y participación 

            //Materias Multimedia

            // math1: materia de matematicas en la unidad uno
            Subject math1 = new Subject("Matematicas", 5, 4, 1);
            // math2: materia de matematicas en la unidad dos
            Subject math2 = new Subject("Matematicas", 6, 3, 1);
            /// math3: materia de matematicas en la unidad tres
            Subject math3 = new Subject("Matematicas", 8, 1, 1);

            // programming1: materia de programación en la unidad uno
            Subject programming1 = new Subject("Programación", 5, 4, 1);
            // programming2: materia de programación en la unidad dos
            Subject programming2 = new Subject("Programación", 7, 2, 1);
            // programming3: materia de programación en la unidad tres
            Subject programming3 = new Subject("Programación", 8, 1, 1);

            //Materias de Artes visules 

            // dibujo1: materia de programación en la unidad uno
            Subject graphicDesign1 = new Subject("Diseño gráfico", 6, 3, 1);

            // programming1: materia de programación en la unidad uno
            Subject graphicDesign2 = new Subject("Diseño gráfico", 7, 2, 1);

            // programming1: materia de programación en la unidad uno
            Subject graphicDesign3 = new Subject("Diseño gráfico", 8, 1, 1);

            // programming1: materia de programación en la unidad uno
            Subject photography1 = new Subject("Fotografía", 5, 3, 2);

            // programming1: materia de programación en la unidad uno
            Subject photography2 = new Subject("Fotografía", 6, 2, 2);

            // programming1: materia de programación en la unidad uno
            Subject photography3 = new Subject("Fotografía", 8, 1, 1);



            //Objeto "Student" se encarga de asignar los atributos del estudiante (nombre y calificaciones de cada unidad)
            Student Ana = new Student("Ana",
            gradeCalculator.GradeSubject(math1, 9, 8, 10),
            gradeCalculator.GradeSubject(math2, 6, 8, 9),
            gradeCalculator.GradeSubject(math3, 6, 8, 9),
            gradeCalculator.GradeSubject(programming1, 8, 8, 10),
            gradeCalculator.GradeSubject(programming2, 9, 9, 9),
            gradeCalculator.GradeSubject(programming3, 10, 10, 8));

            Student Paola = new Student("Hanna",
           gradeCalculator.GradeSubject(math1, 9, 8, 10),
           gradeCalculator.GradeSubject(math2, 10, 6, 9),
           gradeCalculator.GradeSubject(math3, 9, 8, 10),
           gradeCalculator.GradeSubject(programming1, 8, 10, 10),
           gradeCalculator.GradeSubject(programming2, 7, 10, 9),
           gradeCalculator.GradeSubject(programming3, 9, 10, 9));


            //Lista de estudiantes de multimedia
            List<Student> multimedia = new List<Student>();
            multimedia.Add(Ana);

            List<Student> artesVisuales = new List<Student>();
            artesVisuales.Add(Paola);


            //Crea una carrera y agraga los atributos (nombre, id de grupo, materias y lista de estudiantes)
            Career Multimedia = new Career("Multimedia", 'A', math1.GetNameSubject(), programming1.GetNameSubject(), multimedia);
            Career Artes = new Career("Artes visuales", 'A', graphicDesign1.GetNameSubject(), photography1.GetNameSubject(), artesVisuales);

            //Crea una boleta de calificaciones de la carrera de multimedia
            ReportCard reportCardMultimedia = new ReportCard();
            reportCardMultimedia.Print(Multimedia);

            ReportCard reportCardArtes = new ReportCard();
            reportCardArtes.Print(Artes);

        }
    }
}
