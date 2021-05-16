﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Pmat_PI.Models
{
    public partial class Competicao
    {
        public Competicao()
        {
            Treinos = new HashSet<Treino>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string Etiqueta { get; set; }

        public virtual ICollection<Treino> Treinos { get; set; }
    }
}
