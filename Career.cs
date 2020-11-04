using System;
using System.Collections.Generic;

namespace PR2___Code_Quality
{
    /// <summary>
    /// Clase Career, contiene atributos de la carrera (nombre de la carrera, grupos, id de grupo y lista de estudiantes)
    /// </summary>
    class Career
    {
        /// <summary>
        /// Id del grupo
        /// </summary>
        char idGroup;

        /// <summary>
        /// Nombre de la carrera
        /// </summary>
        string nameCareer;

        /// <summary>
        /// Nombre de la materia 1
        /// </summary>
        string nameSubject1;

        /// <summary>
        /// Nombre de la materia 2
        /// </summary>
        string nameSubject2;


        /// <summary>
        /// Lista de estudiantes en la carrera
        /// </summary>
        List<Student> studentsList = new List<Student>();

        public Career(string nameCareer, char idGroup, String nameSubject1, String nameSubject2, List<Student> studentsList)
        {
            this.nameCareer = nameCareer;
            this.idGroup = idGroup;
            this.nameSubject1 = nameSubject1;
            this.nameSubject2 = nameSubject2;
            this.studentsList = studentsList;
        }

        public char GetIdGroup()
        {
            return idGroup;
        }

        public string GetNameCareer()
        {
            return nameCareer;
        }

        public string GetNameSubject1()
        {
            return nameSubject1;
        }

        public string GetNameSubject2()
        {
            return nameSubject2;
        }


        public List<Student> GetStudentsList()
        {
            return studentsList;
        }



    }
}

