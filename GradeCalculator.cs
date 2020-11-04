using System;
using System.Collections.Generic;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Clase GradeCalculator se encarga de calcular las calificaciones de cada materia (dependiendo de los valores del examen, tareas y participación)
    /// calcula el promedio de cada unidad
    /// y el promedio final
    /// </summary>
    class GradeCalculator
    {
        /// <summary>
        /// Promedio del primer parcial
        /// </summary>
        double grade1;

        /// <summary>
        /// Promedio del segundo parcial
        /// </summary>
        double grade2;

        /// <summary>
        /// Promedio del tercer parcial
        /// </summary>
        double grade3;

        /// <summary>
        /// GradeSubject: se encarga de calcular la calificacion de cada materia (tomando en cuenta los criterios de evaluación)
        /// </summary>
        /// <returns>Calificación de la materia </returns>
        public double GradeSubject(Subject subject, double gradeTest, double gradeHomework, double gradeParticipation)
        {
            double gradeSubject = (gradeTest * subject.test) + (gradeHomework * subject.homework) + (gradeParticipation * subject.participation);
            gradeSubject = gradeSubject / 10;
            return (Math.Round(gradeSubject, 2));
        }

        /// <summary>
        /// Calcula el promedio en el primer parcial
        /// </summary>
        /// <returns>Promedio unidad 1 </returns>
        public double Grade1(Student student) //Promedio parcial 1
        {
            grade1 = (student.GetSubject1Unit1() + student.GetSubject2Unit1()) / 2;
            return (Math.Round(grade1, 2));
        }

        /// <summary>
        /// Calcula el promedio en el segundo parcial
        /// </summary>
        /// <returns>Promedio unidad 2</returns>
        public double Grade2(Student student) //Promedio parcial 2
        {
            grade2 = (student.GetSubject1Unit2() + student.GetSubject2Unit2()) / 2;
            return (Math.Round(grade2, 2));
        }

        /// <summary>
        /// Calcula el promedio en el tercer parcial
        /// </summary>
        /// <returns>Promedio unidad 3 </returns>
        public double Grade3(Student student) //Promedio parcial 2
        {
            grade3 = (student.GetSubject1Unit3() + student.GetSubject2Unit3()) / 2;
            return (Math.Round(grade3, 2));
        }

        /// <summary>
        /// Calcula el promedio Final con Grade1, Grade2 y Grade3
        /// </summary>
        /// <returns>Promedio final</returns>
        public double FinalGrade(Student student) //Promedio Final
        {
            double grade;
            grade = (grade1 + grade2 + grade3) / 3;
            return (Math.Round(grade, 2));
        }

    }
}