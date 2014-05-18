using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using uniTunes.Models;

namespace uniTunes.UI
{
    public class UserContext
    {
        /// <summary>
        /// Retorna o Contexto do Usuário
        /// </summary>
        public static UserContext Current
        {
            get { return HttpContext.Current.Session["CurrentUserContext"] as UserContext; }
        }

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="user"></param>
        private UserContext(Academic user)
        {
            User = user;
        }

        /// <summary>
        /// Inicializa e autentica a sessão do usuário
        /// </summary>
        /// <param name="user"></param>
        public static void Initialize(Academic user)
        {
            HttpContext.Current.Session["CurrentUserContext"] = new UserContext(user);
        }

        /// <summary>
        /// Fecha a sessão
        /// </summary>
        public static void Abandon()
        {
            HttpContext.Current.Session.Abandon();
        }

        /// <summary>
        /// Verifica se o usuário está autenticado
        /// </summary>
        public static bool IsAuthenticated
        {
            get { return Current != null; }
        }

        public readonly Academic User;
    }
}