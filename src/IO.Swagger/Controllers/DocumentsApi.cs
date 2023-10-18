/*
 * Mock Server
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DocumentsApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Success</response>
        [HttpDelete]
        [Route("/api/documents/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteDocument")]
        public virtual IActionResult DeleteDocument([FromRoute][Required]int? id)
        {
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="original"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/documents/{id}/download")]
        [ValidateModelState]
        [SwaggerOperation("DownloadDocument")]
        public virtual IActionResult DownloadDocument([FromRoute][Required]int? id, [FromQuery]bool? original)
        {
            return Ok("document");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/documents/{id}/metadata")]
        [ValidateModelState]
        [SwaggerOperation("GetDocumentMetadata")]
        public virtual IActionResult GetDocumentMetadata([FromRoute][Required]int? id)
        {
            return Ok("metadata");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/documents/{id}/preview")]
        [ValidateModelState]
        [SwaggerOperation("GetDocumentPreview")]
        public virtual IActionResult GetDocumentPreview([FromRoute][Required]int? id)
        { 
            return Ok("document preview");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/documents/{id}/thumb")]
        [ValidateModelState]
        [SwaggerOperation("GetDocumentThumb")]
        public virtual IActionResult GetDocumentThumb([FromRoute][Required]int? id)
        {
            return Ok("thumb");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="query"></param>
        /// <param name="ordering"></param>
        /// <param name="tagsIdAll"></param>
        /// <param name="documentTypeId"></param>
        /// <param name="correspondentId"></param>
        /// <param name="truncateContent"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/documents")]
        [ValidateModelState]
        [SwaggerOperation("GetDocuments")]
        public virtual IActionResult GetDocuments([FromQuery]int? page, [FromQuery]int? pageSize, [FromQuery]string query, [FromQuery]string ordering, [FromQuery]List<int?> tagsIdAll, [FromQuery]int? documentTypeId, [FromQuery]int? correspondentId, [FromQuery]bool? truncateContent)
        {
            return Ok("documents");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        [HttpPut]
        [Route("/api/documents/{id}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateDocument")]
        public virtual IActionResult UpdateDocument([FromRoute][Required]int? id, [FromBody]Document body)
        {
            return Ok();
        }

    }
}
