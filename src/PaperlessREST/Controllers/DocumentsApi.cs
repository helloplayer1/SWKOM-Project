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
using PaperlessREST.Entities;
using PaperlessREST.BusinessLogic.Entities;
using System.IO;
using PaperlessREST.BusinessLogic.Interfaces;
using EasyNetQ;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace PaperlessREST.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DocumentsApiController : ControllerBase
    {
        private IDocumentLogic _documentLogic;

        public DocumentsApiController(IDocumentLogic documentLogic)
        {
            _documentLogic = documentLogic;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bulkEditRequest"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/api/documents/bulk_edit")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("BulkEdit")]
        public virtual IActionResult BulkEdit([FromBody] BulkEditRequest bulkEditRequest)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="204">Success</response>
        [HttpDelete]
        [Route("/api/documents/{id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteDocument")]
        public virtual IActionResult DeleteDocument([FromRoute(Name = "id")][Required] int id)
        {

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            throw new NotImplementedException();
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
        [SwaggerResponse(statusCode: 200, type: typeof(System.IO.Stream), description: "Success")]
        public virtual IActionResult DownloadDocument([FromRoute(Name = "id")][Required] int id, [FromQuery(Name = "original")] bool? original)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(System.IO.Stream));
            string exampleJson = null;

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<System.IO.Stream>(exampleJson)
            : default(System.IO.Stream);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="fullPerms"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/documents/{id}")]
        [ValidateModelState]
        [SwaggerOperation("GetDocument")]
        [SwaggerResponse(statusCode: 200, type: typeof(GetDocument200Response), description: "Success")]
        public virtual IActionResult GetDocument([FromRoute(Name = "id")][Required] int id, [FromQuery(Name = "page")] int? page, [FromQuery(Name = "full_perms")] bool? fullPerms)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GetDocument200Response));
            string exampleJson = null;
            exampleJson = "{\r\n  \"owner\" : 7,\r\n  \"archive_serial_number\" : 2,\r\n  \"notes\" : [ {\r\n    \"note\" : \"note\",\r\n    \"created\" : \"created\",\r\n    \"document\" : 1,\r\n    \"id\" : 7,\r\n    \"user\" : 1\r\n  }, {\r\n    \"note\" : \"note\",\r\n    \"created\" : \"created\",\r\n    \"document\" : 1,\r\n    \"id\" : 7,\r\n    \"user\" : 1\r\n  } ],\r\n  \"added\" : \"added\",\r\n  \"created\" : \"created\",\r\n  \"title\" : \"title\",\r\n  \"content\" : \"content\",\r\n  \"tags\" : [ 5, 5 ],\r\n  \"storage_path\" : 5,\r\n  \"permissions\" : {\r\n    \"view\" : {\r\n      \"groups\" : [ 3, 3 ],\r\n      \"users\" : [ 9, 9 ]\r\n    },\r\n    \"change\" : {\r\n      \"groups\" : [ 3, 3 ],\r\n      \"users\" : [ 9, 9 ]\r\n    }\r\n  },\r\n  \"archived_file_name\" : \"archived_file_name\",\r\n  \"modified\" : \"modified\",\r\n  \"correspondent\" : 6,\r\n  \"original_file_name\" : \"original_file_name\",\r\n  \"id\" : 0,\r\n  \"created_date\" : \"created_date\",\r\n  \"document_type\" : 1\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<GetDocument200Response>(exampleJson)
            : default(GetDocument200Response);
            //TODO: Change the data returned
            return new ObjectResult(example);
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
        [SwaggerResponse(statusCode: 200, type: typeof(GetDocumentMetadata200Response), description: "Success")]
        public virtual IActionResult GetDocumentMetadata([FromRoute(Name = "id")][Required] int id)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GetDocumentMetadata200Response));
            string exampleJson = null;
            exampleJson = "{\r\n  \"archive_size\" : 6,\r\n  \"archive_metadata\" : [ {\r\n    \"prefix\" : \"prefix\",\r\n    \"namespace\" : \"namespace\",\r\n    \"value\" : \"value\",\r\n    \"key\" : \"key\"\r\n  }, {\r\n    \"prefix\" : \"prefix\",\r\n    \"namespace\" : \"namespace\",\r\n    \"value\" : \"value\",\r\n    \"key\" : \"key\"\r\n  } ],\r\n  \"original_metadata\" : [ \"\", \"\" ],\r\n  \"original_filename\" : \"original_filename\",\r\n  \"original_mime_type\" : \"original_mime_type\",\r\n  \"archive_checksum\" : \"archive_checksum\",\r\n  \"original_checksum\" : \"original_checksum\",\r\n  \"lang\" : \"lang\",\r\n  \"media_filename\" : \"media_filename\",\r\n  \"has_archive_version\" : true,\r\n  \"archive_media_filename\" : \"archive_media_filename\",\r\n  \"original_size\" : 0\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<GetDocumentMetadata200Response>(exampleJson)
            : default(GetDocumentMetadata200Response);
            //TODO: Change the data returned
            return new ObjectResult(example);
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
        [SwaggerResponse(statusCode: 200, type: typeof(System.IO.Stream), description: "Success")]
        public virtual IActionResult GetDocumentPreview([FromRoute(Name = "id")][Required] int id)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(System.IO.Stream));
            string exampleJson = null;

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<System.IO.Stream>(exampleJson)
            : default(System.IO.Stream);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/documents/{id}/suggestions")]
        [ValidateModelState]
        [SwaggerOperation("GetDocumentSuggestions")]
        [SwaggerResponse(statusCode: 200, type: typeof(GetDocumentSuggestions200Response), description: "Success")]
        public virtual IActionResult GetDocumentSuggestions([FromRoute(Name = "id")][Required] int id)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GetDocumentSuggestions200Response));
            string exampleJson = null;
            exampleJson = "{\r\n  \"storage_paths\" : [ \"\", \"\" ],\r\n  \"document_types\" : [ \"\", \"\" ],\r\n  \"dates\" : [ \"\", \"\" ],\r\n  \"correspondents\" : [ \"\", \"\" ],\r\n  \"tags\" : [ \"\", \"\" ]\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<GetDocumentSuggestions200Response>(exampleJson)
            : default(GetDocumentSuggestions200Response);
            //TODO: Change the data returned
            return new ObjectResult(example);
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
        [SwaggerResponse(statusCode: 200, type: typeof(System.IO.Stream), description: "Success")]
        public virtual IActionResult GetDocumentThumb([FromRoute(Name = "id")][Required] int id)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(System.IO.Stream));
            string exampleJson = null;

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<System.IO.Stream>(exampleJson)
            : default(System.IO.Stream);
            //TODO: Change the data returned
            return new ObjectResult(example);
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
        /// <param name="storagePathIdIn"></param>
        /// <param name="correspondentId"></param>
        /// <param name="truncateContent"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/documents")]
        [ValidateModelState]
        [SwaggerOperation("GetDocuments")]
        [SwaggerResponse(statusCode: 200, type: typeof(GetDocuments200Response), description: "Success")]
        public virtual IActionResult GetDocuments([FromQuery(Name = "Page")] int? page, [FromQuery(Name = "page_size")] int? pageSize, [FromQuery(Name = "query")] string query, [FromQuery(Name = "ordering")] string ordering, [FromQuery(Name = "tags__id__all")] List<int> tagsIdAll, [FromQuery(Name = "document_type__id")] int? documentTypeId, [FromQuery(Name = "storage_path__id__in")] int? storagePathIdIn, [FromQuery(Name = "correspondent__id")] int? correspondentId, [FromQuery(Name = "truncate_content")] bool? truncateContent)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GetDocuments200Response));
            string exampleJson = null;
            exampleJson = "{\r\n  \"next\" : 6,\r\n  \"all\" : [ 5, 5 ],\r\n  \"previous\" : 1,\r\n  \"count\" : 0,\r\n  \"results\" : [ {\r\n    \"owner\" : 4,\r\n    \"user_can_change\" : true,\r\n    \"archive_serial_number\" : 2,\r\n    \"notes\" : [ {\r\n      \"note\" : \"note\",\r\n      \"created\" : \"created\",\r\n      \"document\" : 1,\r\n      \"id\" : 7,\r\n      \"user\" : 1\r\n    }, {\r\n      \"note\" : \"note\",\r\n      \"created\" : \"created\",\r\n      \"document\" : 1,\r\n      \"id\" : 7,\r\n      \"user\" : 1\r\n    } ],\r\n    \"added\" : \"added\",\r\n    \"created\" : \"created\",\r\n    \"title\" : \"title\",\r\n    \"content\" : \"content\",\r\n    \"tags\" : [ 3, 3 ],\r\n    \"storage_path\" : 9,\r\n    \"archived_file_name\" : \"archived_file_name\",\r\n    \"modified\" : \"modified\",\r\n    \"correspondent\" : 2,\r\n    \"original_file_name\" : \"original_file_name\",\r\n    \"id\" : 5,\r\n    \"created_date\" : \"created_date\",\r\n    \"document_type\" : 7\r\n  }, {\r\n    \"owner\" : 4,\r\n    \"user_can_change\" : true,\r\n    \"archive_serial_number\" : 2,\r\n    \"notes\" : [ {\r\n      \"note\" : \"note\",\r\n      \"created\" : \"created\",\r\n      \"document\" : 1,\r\n      \"id\" : 7,\r\n      \"user\" : 1\r\n    }, {\r\n      \"note\" : \"note\",\r\n      \"created\" : \"created\",\r\n      \"document\" : 1,\r\n      \"id\" : 7,\r\n      \"user\" : 1\r\n    } ],\r\n    \"added\" : \"added\",\r\n    \"created\" : \"created\",\r\n    \"title\" : \"title\",\r\n    \"content\" : \"content\",\r\n    \"tags\" : [ 3, 3 ],\r\n    \"storage_path\" : 9,\r\n    \"archived_file_name\" : \"archived_file_name\",\r\n    \"modified\" : \"modified\",\r\n    \"correspondent\" : 2,\r\n    \"original_file_name\" : \"original_file_name\",\r\n    \"id\" : 5,\r\n    \"created_date\" : \"created_date\",\r\n    \"document_type\" : 7\r\n  } ]\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<GetDocuments200Response>(exampleJson)
            : default(GetDocuments200Response);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectionDataRequest"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/api/documents/selection_data")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("SelectionData")]
        [SwaggerResponse(statusCode: 200, type: typeof(SelectionData200Response), description: "Success")]
        public virtual IActionResult SelectionData([FromBody] SelectionDataRequest selectionDataRequest)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SelectionData200Response));
            string exampleJson = null;
            exampleJson = "{\r\n  \"selected_storage_paths\" : [ {\r\n    \"document_count\" : 6,\r\n    \"id\" : 0\r\n  }, {\r\n    \"document_count\" : 6,\r\n    \"id\" : 0\r\n  } ],\r\n  \"selected_document_types\" : [ {\r\n    \"document_count\" : 6,\r\n    \"id\" : 0\r\n  }, {\r\n    \"document_count\" : 6,\r\n    \"id\" : 0\r\n  } ],\r\n  \"selected_correspondents\" : [ {\r\n    \"document_count\" : 6,\r\n    \"id\" : 0\r\n  }, {\r\n    \"document_count\" : 6,\r\n    \"id\" : 0\r\n  } ],\r\n  \"selected_tags\" : [ {\r\n    \"document_count\" : 6,\r\n    \"id\" : 0\r\n  }, {\r\n    \"document_count\" : 6,\r\n    \"id\" : 0\r\n  } ]\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SelectionData200Response>(exampleJson)
            : default(SelectionData200Response);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateDocumentRequest"></param>
        /// <response code="200">Success</response>
        [HttpPut]
        [Route("/api/documents/{id}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("UpdateDocument")]
        [SwaggerResponse(statusCode: 200, type: typeof(UpdateDocument200Response), description: "Success")]
        public virtual IActionResult UpdateDocument([FromRoute(Name = "id")][Required] int id, [FromBody] UpdateDocumentRequest updateDocumentRequest)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(UpdateDocument200Response));
            string exampleJson = null;
            exampleJson = "{\r\n  \"owner\" : 7,\r\n  \"user_can_change\" : true,\r\n  \"archive_serial_number\" : 2,\r\n  \"notes\" : [ \"\", \"\" ],\r\n  \"added\" : \"added\",\r\n  \"created\" : \"created\",\r\n  \"title\" : \"title\",\r\n  \"content\" : \"content\",\r\n  \"tags\" : [ 5, 5 ],\r\n  \"storage_path\" : 5,\r\n  \"archived_file_name\" : \"archived_file_name\",\r\n  \"modified\" : \"modified\",\r\n  \"correspondent\" : 6,\r\n  \"original_file_name\" : \"original_file_name\",\r\n  \"id\" : 0,\r\n  \"created_date\" : \"created_date\",\r\n  \"document_type\" : 1\r\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<UpdateDocument200Response>(exampleJson)
            : default(UpdateDocument200Response);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="created"></param>
        /// <param name="documentType"></param>
        /// <param name="tags"></param>
        /// <param name="correspondent"></param>
        /// <param name="document"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/api/documents/post_document")]
        [Consumes("multipart/form-data")]
        [ValidateModelState]
        [SwaggerOperation("UploadDocument")]
        public virtual async Task<IActionResult> UploadDocument([FromForm(Name = "title")] string title, [FromForm(Name = "created")] DateTime? created, [FromForm(Name = "document_type")] int? documentType, [FromForm(Name = "tags")] List<int> tags, [FromForm(Name = "correspondent")] int? correspondent, [FromForm(Name = "document")] IFormFile documentData)
        {
            Document document = new Document()
            {
                Title = title,
                Created = created,
                DocumentType = documentType,
                Tags = tags,
                Correspondent = correspondent,
                OriginalFileName = documentData.FileName
            };

            using Stream documentStream = documentData.OpenReadStream();

            await _documentLogic.IndexDocument(document, documentStream);

            //publish mssg that document has been uploaded using EasyNetQ

            return Ok();
        }
    }
}
