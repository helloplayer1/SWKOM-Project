/*
 * Paperless Rest Server
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
using PaperlessREST.Attributes;

using Microsoft.AspNetCore.Authorization;
using PaperlessREST.Entities

namespace PaperlessREST.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class TagsApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/api/tags")]
        [ValidateModelState]
        [SwaggerOperation("CreateTag")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse20017), description: "Success")]
        public virtual IActionResult CreateTag([FromBody]ApiTagsBody body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse20017));
            string exampleJson = null;
            exampleJson = "{\n  \"owner\" : 1,\n  \"matching_algorithm\" : 6,\n  \"user_can_change\" : true,\n  \"color\" : \"color\",\n  \"is_insensitive\" : true,\n  \"name\" : \"name\",\n  \"match\" : \"match\",\n  \"id\" : 0,\n  \"text_color\" : \"text_color\",\n  \"is_inbox_tag\" : true,\n  \"slug\" : \"slug\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<InlineResponse20017>(exampleJson)
                        : default(InlineResponse20017);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="204">Success</response>
        [HttpDelete]
        [Route("/api/tags/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteTag")]
        public virtual IActionResult DeleteTag([FromRoute][Required]int? id)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="fullPerms"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/tags")]
        [ValidateModelState]
        [SwaggerOperation("GetTags")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse20016), description: "Success")]
        public virtual IActionResult GetTags([FromQuery]int? page, [FromQuery]bool? fullPerms)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse20016));
            string exampleJson = null;
            exampleJson = "{\n  \"next\" : 6,\n  \"all\" : [ 5, 5 ],\n  \"previous\" : 1,\n  \"count\" : 0,\n  \"results\" : [ {\n    \"owner\" : 9,\n    \"matching_algorithm\" : 2,\n    \"document_count\" : 7,\n    \"color\" : \"color\",\n    \"is_insensitive\" : true,\n    \"permissions\" : {\n      \"view\" : {\n        \"groups\" : [ \"\", \"\" ],\n        \"users\" : [ \"\", \"\" ]\n      }\n    },\n    \"name\" : \"name\",\n    \"match\" : \"match\",\n    \"id\" : 5,\n    \"text_color\" : \"text_color\",\n    \"is_inbox_tag\" : true,\n    \"slug\" : \"slug\"\n  }, {\n    \"owner\" : 9,\n    \"matching_algorithm\" : 2,\n    \"document_count\" : 7,\n    \"color\" : \"color\",\n    \"is_insensitive\" : true,\n    \"permissions\" : {\n      \"view\" : {\n        \"groups\" : [ \"\", \"\" ],\n        \"users\" : [ \"\", \"\" ]\n      }\n    },\n    \"name\" : \"name\",\n    \"match\" : \"match\",\n    \"id\" : 5,\n    \"text_color\" : \"text_color\",\n    \"is_inbox_tag\" : true,\n    \"slug\" : \"slug\"\n  } ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<InlineResponse20016>(exampleJson)
                        : default(InlineResponse20016);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        [HttpPut]
        [Route("/api/tags/{id}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateTag")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse20018), description: "Success")]
        public virtual IActionResult UpdateTag([FromRoute][Required]int? id, [FromBody]TagsIdBody body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse20018));
            string exampleJson = null;
            exampleJson = "{\n  \"owner\" : 5,\n  \"matching_algorithm\" : 6,\n  \"user_can_change\" : true,\n  \"document_count\" : 1,\n  \"color\" : \"color\",\n  \"is_insensitive\" : true,\n  \"name\" : \"name\",\n  \"match\" : \"match\",\n  \"id\" : 0,\n  \"text_color\" : \"text_color\",\n  \"is_inbox_tag\" : true,\n  \"slug\" : \"slug\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<InlineResponse20018>(exampleJson)
                        : default(InlineResponse20018);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
