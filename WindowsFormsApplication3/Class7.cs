using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3
{//Clase que posee todos los metodos que interactuan con la base de datos utilizando el framework Entity como intermediario.
    public partial class Controlador
    {
        /*
        /// <summary>
        /// Incorpora una fuente RSS al sistema, esta luego puede ser reutilizada por otros banners.
        /// </summary>
        /// <param name="rss1"></param>
        public static void agregarRss(RSS rss1)
        {
            Repositorio.agregarRssSQL(rss1);
        }

        /// <summary>
        /// Obtiene la lista de todos los RSS cargados actualmente.
        /// </summary>
        /// <returns></returns>
        public static List<RSS> obtenerRss()
        {
            return Repositorio.obtenerRssSQL();
        }

        /// <summary>
        /// Modifica un RSS en particular.
        /// </summary>
        /// <param name="unaUrl"></param>
        /// <param name="unaDescripcion"></param>
        /// <param name="nuevaDescripcion"></param>
        /// <param name="nuevaURL"></param>
        public static void modificarRss(string unaUrl, string unaDescripcion, string nuevaDescripcion, string nuevaURL)
        {
            Repositorio.modificarRssSQL(unaUrl, unaDescripcion, nuevaDescripcion, nuevaURL);
        }

        /// <summary>
        /// Eliminar un RSS en particular.
        /// </summary>
        /// <param name="unaUrl"></param>
        /// <param name="unaDescripcion"></param>
        public static void eliminarRss(string unaUrl, string unaDescripcion)
        {
            Repositorio.eliminarRssSQL(unaUrl, unaDescripcion);
        }
        */
        public static bool verificarRss(String unRss)
        {
            return Repositorio.verificarRssSQL(unRss);
        }
    }
}

