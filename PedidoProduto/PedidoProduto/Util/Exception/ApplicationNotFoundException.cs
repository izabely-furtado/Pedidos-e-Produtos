using System.Globalization;
using System;

namespace PedidoProduto.Util
{
    public class ApplicationNotFoundException : Exception
    {
        #region Mensagens
        public static readonly string CLIENTE_NAO_ENCONTRADO = "Município não encontrado.";
        public static readonly string PEDIDO_NAO_ENCONTRADO = "Município não encontrado.";
        public static readonly string PRODUTO_NAO_ENCONTRADO = "Município não encontrado.";
        public static readonly string SEM_RESULTADO_PELO_FILTRO = "Nenhum resultado foi encontrado passando estes filtros.";

        #endregion

        public string ContentType { get; set; } = @"text/plain";

        public ApplicationNotFoundException() : base()
        {
        }

        public ApplicationNotFoundException(string message) : base(message) { }

        public ApplicationNotFoundException(string message, params object[] args)
            : base(string.Format(CultureInfo.CurrentCulture, message, args))
        {
        }

        public ApplicationNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
