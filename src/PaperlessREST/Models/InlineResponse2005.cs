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
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PaperlessREST.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class InlineResponse2005 : IEquatable<InlineResponse2005>
    { 
        /// <summary>
        /// Gets or Sets SelectedCorrespondents
        /// </summary>
        [Required]

        [DataMember(Name="selected_correspondents")]
        public List<InlineResponse2005SelectedCorrespondents> SelectedCorrespondents { get; set; }

        /// <summary>
        /// Gets or Sets SelectedTags
        /// </summary>
        [Required]

        [DataMember(Name="selected_tags")]
        public List<InlineResponse2005SelectedCorrespondents> SelectedTags { get; set; }

        /// <summary>
        /// Gets or Sets SelectedDocumentTypes
        /// </summary>
        [Required]

        [DataMember(Name="selected_document_types")]
        public List<InlineResponse2005SelectedCorrespondents> SelectedDocumentTypes { get; set; }

        /// <summary>
        /// Gets or Sets SelectedStoragePaths
        /// </summary>
        [Required]

        [DataMember(Name="selected_storage_paths")]
        public List<InlineResponse2005SelectedCorrespondents> SelectedStoragePaths { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2005 {\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((InlineResponse2005)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse2005 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2005 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2005 other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SelectedCorrespondents == other.SelectedCorrespondents ||
                    SelectedCorrespondents != null &&
                    SelectedCorrespondents.SequenceEqual(other.SelectedCorrespondents)
                ) && 
                (
                    SelectedTags == other.SelectedTags ||
                    SelectedTags != null &&
                    SelectedTags.SequenceEqual(other.SelectedTags)
                ) && 
                (
                    SelectedDocumentTypes == other.SelectedDocumentTypes ||
                    SelectedDocumentTypes != null &&
                    SelectedDocumentTypes.SequenceEqual(other.SelectedDocumentTypes)
                ) && 
                (
                    SelectedStoragePaths == other.SelectedStoragePaths ||
                    SelectedStoragePaths != null &&
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

        public static bool operator ==(InlineResponse2005 left, InlineResponse2005 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse2005 left, InlineResponse2005 right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
