using System;
using System.Collections.Generic;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Clase ReportCard, se encarga de imprimir nombre, grupo, carrera y calificaciones
    /// </summary>
    class ReportCard
    {
        /// <summary>
        /// Calculadora de calificaciones
        /// </summary>
        GradeCalculator gradeCalculator = new GradeCalculator();

        /// <summary>
        /// Lista de estudiantes
        /// </summary>
        List<Student> studentsList = new List<Student>();

        /// <summary>
        /// Metodo para imprimir nombre, grupo carrera y calificaciones
        /// </summary>
        public void Print(Career career)
        {
            studentsList = career.GetStudentsList();

            foreach (Student student in studentsList)
            {

                System.Console.WriteLine("");
                System.Console.WriteLine("Boleta: ");
                System.Console.WriteLine("Nombre del estudiante: " + student.GetNameStudent() + " - Grupo: " + career.GetIdGroup() + " - Carrera: " + career.GetNameCareer());

                System.Console.WriteLine("");

                System.Console.WriteLine("Parcial 1");
                System.Console.WriteLine(career.GetNameSubject1() + " " + student.GetSubject1Unit1());
                System.Console.WriteLine(career.GetNameSubject2() + " " + student.GetSubject2Unit1());
                System.Console.WriteLine("Promedio: " + gradeCalculator.Grade1(student));
                System.Console.WriteLine("");


                System.Console.WriteLine("Parcial 2");
                System.Console.WriteLine(career.GetNameSubject1() + " " + student.GetSubject1Unit2());
                System.Console.WriteLine(career.GetNameSubject2() + " " + student.GetSubject2Unit2());
                System.Console.WriteLine("Promedio: " + gradeCalculator.Grade2(student));
                System.Console.WriteLine("");

                System.Console.WriteLine("Parcial 3");
                System.Console.WriteLine(career.GetNameSubject1() + " " + student.GetSubject1Unit3());
                System.Console.WriteLine(career.GetNameSubject2() + " " + student.GetSubject2Unit3());
                System.Console.WriteLine("Promedio: " + gradeCalculator.Grade3(student));
                System.Console.WriteLine("");


                System.Console.WriteLine("Promedio Final: " + gradeCalculator.FinalGrade(student));
            }
        }


    }
}

