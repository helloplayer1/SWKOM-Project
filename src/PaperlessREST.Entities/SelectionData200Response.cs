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
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PaperlessREST.Entities.Converters;

namespace PaperlessREST.Entities
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2005.cs
    public partial class InlineResponse2005 : IEquatable<InlineResponse2005>
========
    public partial class SelectionData200Response : IEquatable<SelectionData200Response>
>>>>>>>> dev:src/PaperlessREST.Entities/SelectionData200Response.cs
    {
        /// <summary>
        /// Gets or Sets SelectedCorrespondents
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2005.cs

        [DataMember(Name = "selected_correspondents")]
        public List<InlineResponse2005SelectedCorrespondents> SelectedCorrespondents { get; set; }
========
        [DataMember(Name = "selected_correspondents", EmitDefaultValue = false)]
        public List<SelectionData200ResponseSelectedCorrespondentsInner> SelectedCorrespondents { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/SelectionData200Response.cs

        /// <summary>
        /// Gets or Sets SelectedTags
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2005.cs

        [DataMember(Name = "selected_tags")]
        public List<InlineResponse2005SelectedCorrespondents> SelectedTags { get; set; }
========
        [DataMember(Name = "selected_tags", EmitDefaultValue = false)]
        public List<SelectionData200ResponseSelectedCorrespondentsInner> SelectedTags { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/SelectionData200Response.cs

        /// <summary>
        /// Gets or Sets SelectedDocumentTypes
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2005.cs

        [DataMember(Name = "selected_document_types")]
        public List<InlineResponse2005SelectedCorrespondents> SelectedDocumentTypes { get; set; }
========
        [DataMember(Name = "selected_document_types", EmitDefaultValue = false)]
        public List<SelectionData200ResponseSelectedCorrespondentsInner> SelectedDocumentTypes { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/SelectionData200Response.cs

        /// <summary>
        /// Gets or Sets SelectedStoragePaths
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2005.cs

        [DataMember(Name = "selected_storage_paths")]
        public List<InlineResponse2005SelectedCorrespondents> SelectedStoragePaths { get; set; }
========
        [DataMember(Name = "selected_storage_paths", EmitDefaultValue = false)]
        public List<SelectionData200ResponseSelectedCorrespondentsInner> SelectedStoragePaths { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/SelectionData200Response.cs

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectionData200Response {\n");
            sb.Append("  SelectedCorrespondents: ").Append(SelectedCorrespondents).Append("\n");
            sb.Append("  SelectedTags: ").Append(SelectedTags).Append("\n");
            sb.Append("  SelectedDocumentTypes: ").Append(SelectedDocumentTypes).Append("\n");
            sb.Append("  SelectedStoragePaths: ").Append(SelectedStoragePaths).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((SelectionData200Response)obj);
        }

        /// <summary>
        /// Returns true if SelectionData200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of SelectionData200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectionData200Response other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    SelectedCorrespondents == other.SelectedCorrespondents ||
                    SelectedCorrespondents != null &&
                    other.SelectedCorrespondents != null &&
                    SelectedCorrespondents.SequenceEqual(other.SelectedCorrespondents)
                ) &&
                (
                    SelectedTags == other.SelectedTags ||
                    SelectedTags != null &&
                    other.SelectedTags != null &&
                    SelectedTags.SequenceEqual(other.SelectedTags)
                ) &&
                (
                    SelectedDocumentTypes == other.SelectedDocumentTypes ||
                    SelectedDocumentTypes != null &&
                    other.SelectedDocumentTypes != null &&
                    SelectedDocumentTypes.SequenceEqual(other.SelectedDocumentTypes)
                ) &&
                (
                    SelectedStoragePaths == other.SelectedStoragePaths ||
                    SelectedStoragePaths != null &&
                    other.SelectedStoragePaths != null &&
                    SelectedStoragePaths.SequenceEqual(other.SelectedStoragePaths)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (SelectedCorrespondents != null)
                    hashCode = hashCode * 59 + SelectedCorrespondents.GetHashCode();
                if (SelectedTags != null)
                    hashCode = hashCode * 59 + SelectedTags.GetHashCode();
                if (SelectedDocumentTypes != null)
                    hashCode = hashCode * 59 + SelectedDocumentTypes.GetHashCode();
                if (SelectedStoragePaths != null)
                    hashCode = hashCode * 59 + SelectedStoragePaths.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(SelectionData200Response left, SelectionData200Response right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SelectionData200Response left, SelectionData200Response right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}