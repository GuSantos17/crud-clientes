using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TesteBRQ.CrudUsers.Domain.Models
{
    [Table("USERS")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_USER")]
        public int IdUser { get; set; }

        [Column("NOME")]
        public string Nome { get; set; }

        [Column("CPF")]
        public string Cpf { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("TELEFONE")]
        public string Telefone { get; set; }

        [Column("SEXO")]
        public string Sexo { get; set; }
        
        [Column("DATANASC")]
        public string DataNascimento { get; set; }


    }
}
