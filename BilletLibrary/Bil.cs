﻿using System;

namespace BilletLibrary
{
    public class Bil
    {
        public string Nummerplade { get; set; }

        public DateTime Dato { get; set; }

        public Bil()
        {
            
        }

        public Bil(string nummerplade, DateTime dato)
        {
            Nummerplade = nummerplade;
            Dato = dato;
        }
        /// <summary>
        /// Returnere prisen på en overkørsel
        /// </summary>
        /// <returns></returns>
        public decimal Pris()
        {
            return 240;
        }
        /// <summary>
        /// Retunerer køretøjstypen
        /// </summary>
        /// <returns></returns>
        public string Køretøj()
        {
            return "Bil";
        }
    }
}
