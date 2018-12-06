using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesiones_Unitam
{
    public static class Consultas
    {
        public static string Roman(int value)
        {
            if (value == 1) return "I";
            if (value == 2) return "II";
            if (value == 3) return "III";
            if (value == 4) return "IV";
            if (value == 5) return "v";
            if (value == 6) return "VI";
            if (value == 7) return "VII";
            if (value == 8) return "VIII";
            if (value == 9) return "IX";
            if (value == 10) return "X";
            return "";

        }
        public static string MOSTRAR_CLASES = "";

        /// <summary>
        /// Hacer una consulta en la que devuelva la especialidad de los grupos y su nivel.
        /// En la que las columnas se llamen:
        ///     - Id
        ///     - Especialidad
        ///     - Nivel
        /// </summary>
        public static string LISTAR_GRUPOS = "";

        /// <summary>
        /// Hacer una consulta en la que devuelva el id del docente, su nombre y apellidos.
        /// En la que las columnas se llamen:
        ///     - Id
        ///     - Nombre
        ///     - Apellidos
        /// </summary>
        public static string LISTAR_DOCENTES = "";


        /// <summary>
        /// Realizar una consulta que me arroje toda la informacion de la tabla Grupos
        /// En la que las columnas se llamen:
        ///     - Id
        ///     - Especialidad
        ///     - Nivel
        ///     - Periodo
        /// </summary>
        public static string LISTAR_INFO_GRUPOS = "";

        /// <summary>
        /// Realizar una consulta que me arroje toda la informacion de la tabla Docentes
        /// En la que las columnas se llamen:
        ///     - Id
        ///     - Nombre
        ///     - Apellido
        ///     - Edad
        ///     - Sexo
        /// </summary>
        public static string LISTAR_INFO_DOCENTES = "";

        /// <summary>
        /// Realizar una consulta que me arroje toda la informacion de la tabla Materias
        /// En la que las columnas se llamen:
        ///     - Id
        ///     - Nombre
        ///     - IdGrupo
        ///     - IdDocente
        /// </summary>
        public static string LISTAR_INFO_MATERIAS = "";

        /// <summary>
        /// Hacer la base de una consulta para insertar un grupo nuevo a la base de datos
        /// Ej: INSERT .... VALUES   «- Hasta values, de ahi en adelante no.
        /// El cual tenga el orden de (Especialidad, Nivel, Periodo)
        /// </summary>
        public static string INSERTAR_GRUPO = "";

        /// <summary>
        /// Hacer la base de una consulta para insertar una materia nueva a la base de datos
        /// Ej: INSERT .... VALUES   «- Hasta values, de ahi en adelante no.
        /// El cual tenga el orden de (Nombre, IdGrupo, IdDocente)
        /// </summary>
        public static string INSERTAR_MATERIA = "";

        /// <summary>
        /// Hacer la base de una consulta para insertar un docente nuevo a la base de datos
        /// Ej: INSERT .... VALUES   «- Hasta values, de ahi en adelante no.
        /// El cual tenga el orden de (Nombre, Apellido, Edad, Sexo)
        /// </summary>
        public static string INSERTAR_DOCENTE = "";

        /// <summary>
        /// Hacer una consulta que actualize los valores de la tabla Grupo: Especialidad, Nivel, Periodo
        /// Donde el Id sea :id (En lugar de un numero poner dos puntos i d)
        /// </summary>
        public static string ACTUALIZAR_GRUPO = "";
    }
}
