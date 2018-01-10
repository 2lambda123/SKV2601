﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKV260.Kontrolluppgifter;
using System.Xml.Linq;

namespace SKV260
{
    public class Uppgiftslamnare
    {
        /// <summary>
        /// Pers/orgnr för uppgiftslämnare, kan finnas flera
        /// </summary>
        [Required, Identitet]
        public string UppgiftslamnarePersOrgnr { get; set; }

        public List<Kontaktperson> Kontaktperson { get; set; } = new List<Kontaktperson>();

        public XElement Accept(KUGenerateVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}