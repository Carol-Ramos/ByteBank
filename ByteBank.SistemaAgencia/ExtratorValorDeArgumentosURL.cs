﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos; /*somente leitura*/
        public string URL { get; }
        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))      /*IsNullOrEmpty: o texto é nulo ou vazio*/

            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio.", nameof(url));
            }

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

            URL = url;
        }

        //moedaOrigem=IReadOnlyList&moedaDestino=dolar
        public string GetValor(string nomeParametro)
        {
            string argumentoEmCaixaAlta = _argumentos.ToUpper();    /*ToUpper: caixa alta*/
            nomeParametro = nomeParametro.ToUpper();

            string termo = nomeParametro + "=";
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);   /*Length: Tamanho*/
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial); 

        }
    }
}