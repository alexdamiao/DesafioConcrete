using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace DesafioConcrete.Controllers
{
    /// <summary>
    /// Controller para tratamento de erros gerais da API
    /// </summary>
    public class ErrorController : ApiController
    {

        /// <summary>
        /// Tratamento do Erro 404
        /// </summary>
        /// <returns></returns>
        [HttpGet, HttpPost, HttpPut, HttpDelete, HttpHead, HttpOptions, AcceptVerbs("PATCH")]
        public HttpResponseMessage Handle404()
        {
            var responseMessage = new HttpResponseMessage(HttpStatusCode.NotFound); //Forço o 404
            responseMessage.ReasonPhrase = "O recurso solicitado não foi localizado.";
            return responseMessage;
        }

        /// <summary>
        /// Tratamento do Erro 403
        /// </summary>
        /// <returns></returns>
        [HttpGet, HttpPost, HttpPut, HttpDelete, HttpHead, HttpOptions, AcceptVerbs("PATCH")]
        public HttpResponseMessage Handle403()
        {
            var responseMessage = new HttpResponseMessage(HttpStatusCode.Forbidden); //Forço o 403
            responseMessage.ReasonPhrase = "Acesso não permitido.";
            return responseMessage;
        }
    }
}