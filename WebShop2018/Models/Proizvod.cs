﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop2018.Models
{
    public enum StanjeProizvoda
    {
        NaStanju,
        Akcija,
        Rasprodato
    }

    public class Proizvod
    {
        public int Id { get; set; }

        public StanjeProizvoda Stanje { get; set; }

        [Required(ErrorMessage = "Naziv mora da se navede")]
        [StringLength(50)]
        [DisplayName("Ime")]
        public string Naziv { get; set; }

        [DisplayName("Vrednost proizvoda")]
        [Range(0.00, 10000.00)]
        [DisplayFormat(DataFormatString = "{0:#.##}", ApplyFormatInEditMode = true)]
        public decimal Cena { get; set; }

        [Required(ErrorMessage = "Opis mora da se navede")]
        [StringLength(100)]
        [DisplayName("Opis")]
        public string Opis { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual ICollection<Dobavljac> Dobavljaci { get; set; }
        public virtual ICollection<Slika> Slike { get; set; }
        
       

        public int? SlikaZaPrikazId { get; set; }
    }
}