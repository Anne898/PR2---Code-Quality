using System;
using System.Collections.Generic;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Clase Student, contiene atributos del estudiante: Nombre del estudiante y calificadcion por materia
    /// </summary>

    class Student
    {

        /// <summary>
        /// Nombre completo del estudiante
        /// </summary>
        string nameStudent { get; set; }

        /// <summary>
        /// Calificacion materia 1 en la unidad 1
        /// </summary>
        double subject1Unit1 { get; set; }

        /// <summary>
        /// Calificacion materia 1 en la unidad 2
        /// </summary>
        double subject1Unit2 { get; set; }

        /// <summary>
        /// Calificacion materia 1 en la unidad 3
        /// </summary>
        double subject1Unit3 { get; set; }

        /// <summary>
        /// Calificacion materia 2 en la unidad 1
        /// </summary>
        double subject2Unit1 { get; set; }

        /// <summary>
        /// Calificacion materia 2 en la unidad 2
        /// </summary>
        double subject2Unit2 { get; set; }

        /// <summary>
        /// Calificacion materia 2 en la unidad 3
        /// </summary>
        double subject2Unit3 { get; set; }

        public Student(string nameStudent, double subject1Unit1, double subject1Unit2, double subject1Unit3, double subject2Unit1, double subject2Unit2, double subject2Unit3)
        {
            this.nameStudent = nameStudent;

            this.subject1Unit1 = subject1Unit1;
            this.subject1Unit2 = subject1Unit2;
            this.subject1Unit3 = subject1Unit3;

            this.subject2Unit1 = subject2Unit1;
            this.subject2Unit2 = subject2Unit2;
            this.subject2Unit3 = subject2Unit3;

        }

        public string GetNameStudent()
        {
            return nameStudent;
        }

        /// <summary>
        /// Optener materia 1 en la unidad 1
        /// </summary>
        public double GetSubject1Unit1()
        {
            return subject1Unit1;
        }

        /// <summary>
        /// Optener materia 1 en la unidad 2
        /// </summary>
        public double GetSubject1Unit2()
        {
            return subject1Unit2;
        }

        /// <summary>
        /// Optener materia 1 en la unidad 3
        /// </summary>
        public double GetSubject1Unit3()
        {
            return subject1Unit3;
        }

        /// <summary>
        /// Optener materia 2 en la unidad 1
        /// </summary>
        public double GetSubject2Unit1()
        {
            return subject2Unit1;
        }

        /// <summary>
        /// Optener materia 2 en la unidad 2
        /// </summary>
        public double GetSubject2Unit2()
        {
            return subject2Unit2;
        }

        /// <summary>
        /// Optener materia 2 en la unidad 3
        /// </summary>
        public double GetSubject2Unit3()
        {
            return subject2Unit3;
        }

    }
}
