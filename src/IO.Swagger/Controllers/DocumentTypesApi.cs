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
    public class DocumentTypesApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/api/document_types")]
        [ValidateModelState]
        [SwaggerOperation("CreateDocumentType")]
        public virtual IActionResult CreateDocumentType([FromBody]NewDocumentType body)
        {
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Success</response>
        [HttpDelete]
        [Route("/api/document_types/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteDocumentType")]
        public virtual IActionResult DeleteDocumentType([FromRoute][Required]int? id)
        {
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/document_types")]
        [ValidateModelState]
        [SwaggerOperation("GetDocumentTypes")]
        public virtual IActionResult GetDocumentTypes()
        {
            return Ok("document types");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        [HttpPut]
        [Route("/api/document_types/{id}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateDocumentType")]
        public virtual IActionResult UpdateDocumentType([FromRoute][Required]int? id, [FromBody]DocumentType body)
        {
            return Ok();
        }
    }
}
