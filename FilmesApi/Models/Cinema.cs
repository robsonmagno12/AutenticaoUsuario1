﻿using FilmesApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilmesAPI.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        //tera qu e explicitar que são  Lazy para trazer dados do BD colocando a palavra vitual
        public  virtual Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }
        public virtual Gerente Gerente { get; set; }
        public int  GerenteId { get; set; }
        [JsonIgnore]
        public virtual List<Sessao> Sessaos { get; set; }

    }
}