/*
 * Paperless Rest Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using PaperlessREST.Attributes;
using PaperlessREST.BusinessLogic.Interfaces;
using System.Threading.Tasks;

namespace PaperlessREST.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class SearchApiController : ControllerBase
    {
        private readonly IDocumentLogic _documentLogic;
        public SearchApiController(IDocumentLogic documentLogic)
        {
            _documentLogic = documentLogic;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="term"></param>
        /// <param name="limit"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/search/autocomplete")]
        [ValidateModelState]
        [SwaggerOperation("AutoComplete")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<string>), description: "Success")]
        public async virtual Task<IActionResult> AutoComplete([FromQuery(Name = "term")] string term, [FromQuery(Name = "limit")] int? limit)
        {
            var results = await _documentLogic.SearchDocumentsAsync(term);
            var serializedResults = JsonConvert.SerializeObject(results);
            return new ObjectResult(serializedResults);
        }
    }
}
