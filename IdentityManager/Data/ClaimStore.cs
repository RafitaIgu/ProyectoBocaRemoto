using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityManager.Data
{
    public static class ClaimStore
    {
        public static List<Claim> claimsList = new List<Claim>()
        {
            new Claim("Crear","Create"),
            new Claim("Editar","Edit"),
            new Claim("Eliminar","Delete")
        };
    }
}
