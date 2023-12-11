using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal
{
    class NoetNomAbonnements
    {
        public String idAbonnement { get; private set; }
        public String nomCompletAbonnement{ get; private set; }

        public NoetNomAbonnements(string idAbonnement, String nomCompletAbonnement)
        {
            this.idAbonnement = idAbonnement;
            this.nomCompletAbonnement= nomCompletAbonnement;
        }

    }
}
