using System;
using System.Collections.Generic;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Clase Subject, contiene atributos para la materia: Nombre y criterios de evaluación (Examen, tarea y participación)
    /// </summary>
    class Subject
    {
        string nameSubject { get; set; }

        //Evaluation criteria 

        /// <summary>
        /// Criterio de evaluación: Examen
        /// </summary>
        public int test { get; set; }

        /// <summary>
        /// Criterio de evaluación: Tarea
        /// </summary>
        public int homework { get; set; }

        /// <summary>
        /// Criterio de evaluación: Participación
        /// </summary>
        public int participation { get; set; }

        public Subject(string nameSubject, int test, int homework, int participation)
        {
            this.nameSubject = nameSubject;
            this.test = test;
            this.homework = homework;
            this.participation = participation;
        }


        public string GetNameSubject()
        {
            return nameSubject;
        }

    }
}
