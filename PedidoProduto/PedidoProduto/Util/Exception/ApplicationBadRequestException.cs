using System;
using System.Globalization;

namespace PedidoProduto.Util
{
    public class ApplicationBadRequestException : Exception
    {
        #region Mensagens
        public static readonly string IDENTIFICADOR_INVALIDO = "Identificador inválido.";
        public static readonly string NOME_INVALIDO = "Nome inválido.";
        public static readonly string DATA_INVALIDA = "Data inválida.";
        public static readonly string TOTAL_INVALIDO = "Total inválido.";
        public static readonly string CLIENTE_INVALIDO = "Cliente inválido.";
        public static readonly string PEDIDO_INVALIDO = "Pedido inválido.";
        public static readonly string PRODUTO_INVALIDO = "Produto inválido.";
        public static readonly string DATA_INICIAL_INVALIDA = "Data inicial inválida.";
        public static readonly string DATA_FINAL_INVALIDA = "Data final inválida.";
        public static readonly string ERRO_AO_CADASTRAR_CLIENTE = "Erro ao cadastrar cliente";
        public static readonly string ERRO_AO_CADASTRAR_PRODUTO = "Erro ao cadastrar produto";
        public static readonly string ERRO_AO_CADASTRAR_PEDIDO = "Erro ao cadastrar pedido";


        #endregion
        public string ContentType { get; set; } = @"application/json";

        public ApplicationBadRequestException() : base()
        {
        }

        public ApplicationBadRequestException(string message) : base(message) { }

        public ApplicationBadRequestException(string message, params object[] args)
            : base(string.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
        public ApplicationBadRequestException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
