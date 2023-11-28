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
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2008Results.cs
    public partial class InlineResponse2008Results : IEquatable<InlineResponse2008Results>
========
    public partial class GetDocumentTypes200ResponseResultsInner : IEquatable<GetDocumentTypes200ResponseResultsInner>
>>>>>>>> dev:src/PaperlessREST.Entities/GetDocumentTypes200ResponseResultsInner.cs
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2008Results.cs

        [DataMember(Name = "id")]
        public int? Id { get; set; }
========
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int Id { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/GetDocumentTypes200ResponseResultsInner.cs

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2008Results.cs

        [DataMember(Name = "slug")]
========
        [DataMember(Name = "slug", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/GetDocumentTypes200ResponseResultsInner.cs
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2008Results.cs

        [DataMember(Name = "name")]
========
        [DataMember(Name = "name", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/GetDocumentTypes200ResponseResultsInner.cs
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Match
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2008Results.cs

        [DataMember(Name = "match")]
========
        [DataMember(Name = "match", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/GetDocumentTypes200ResponseResultsInner.cs
        public string Match { get; set; }

        /// <summary>
        /// Gets or Sets MatchingAlgorithm
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2008Results.cs

        [DataMember(Name = "matching_algorithm")]
        public int? MatchingAlgorithm { get; set; }
========
        [DataMember(Name = "matching_algorithm", EmitDefaultValue = true)]
        public int MatchingAlgorithm { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/GetDocumentTypes200ResponseResultsInner.cs

        /// <summary>
        /// Gets or Sets IsInsensitive
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2008Results.cs

        [DataMember(Name = "is_insensitive")]
        public bool? IsInsensitive { get; set; }
========
        [DataMember(Name = "is_insensitive", EmitDefaultValue = true)]
        public bool IsInsensitive { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/GetDocumentTypes200ResponseResultsInner.cs

        /// <summary>
        /// Gets or Sets DocumentCount
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2008Results.cs

        [DataMember(Name = "document_count")]
        public int? DocumentCount { get; set; }
========
        [DataMember(Name = "document_count", EmitDefaultValue = true)]
        public int DocumentCount { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/GetDocumentTypes200ResponseResultsInner.cs

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2008Results.cs

        [DataMember(Name = "owner")]
        public int? Owner { get; set; }
========
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public int Owner { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/GetDocumentTypes200ResponseResultsInner.cs

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2008Results.cs

        [DataMember(Name = "permissions")]
        public ApicorrespondentsidPermissions Permissions { get; set; }
========
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public GetCorrespondents200ResponseResultsInnerPermissions Permissions { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/GetDocumentTypes200ResponseResultsInner.cs

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocumentTypes200ResponseResultsInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Match: ").Append(Match).Append("\n");
            sb.Append("  MatchingAlgorithm: ").Append(MatchingAlgorithm).Append("\n");
            sb.Append("  IsInsensitive: ").Append(IsInsensitive).Append("\n");
            sb.Append("  DocumentCount: ").Append(DocumentCount).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GetDocumentTypes200ResponseResultsInner)obj);
        }

        /// <summary>
        /// Returns true if GetDocumentTypes200ResponseResultsInner instances are equal
        /// </summary>
        /// <param name="other">Instance of GetDocumentTypes200ResponseResultsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocumentTypes200ResponseResultsInner other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Id == other.Id ||

                    Id.Equals(other.Id)
                ) &&
                (
                    Slug == other.Slug ||
                    Slug != null &&
                    Slug.Equals(other.Slug)
                ) &&
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) &&
                (
                    Match == other.Match ||
                    Match != null &&
                    Match.Equals(other.Match)
                ) &&
                (
                    MatchingAlgorithm == other.MatchingAlgorithm ||

                    MatchingAlgorithm.Equals(other.MatchingAlgorithm)
                ) &&
                (
                    IsInsensitive == other.IsInsensitive ||

                    IsInsensitive.Equals(other.IsInsensitive)
                ) &&
                (
                    DocumentCount == other.DocumentCount ||

                    DocumentCount.Equals(other.DocumentCount)
                ) &&
                (
                    Owner == other.Owner ||

                    Owner.Equals(other.Owner)
                ) &&
                (
                    Permissions == other.Permissions ||
                    Permissions != null &&
                    Permissions.Equals(other.Permissions)
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
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2008Results.cs
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
========

                hashCode = hashCode * 59 + Id.GetHashCode();
>>>>>>>> dev:src/PaperlessREST.Entities/GetDocumentTypes200ResponseResultsInner.cs
                if (Slug != null)
                    hashCode = hashCode * 59 + Slug.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Match != null)
                    hashCode = hashCode * 59 + Match.GetHashCode();
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2008Results.cs
                if (MatchingAlgorithm != null)
                    hashCode = hashCode * 59 + MatchingAlgorithm.GetHashCode();
                if (IsInsensitive != null)
                    hashCode = hashCode * 59 + IsInsensitive.GetHashCode();
                if (DocumentCount != null)
                    hashCode = hashCode * 59 + DocumentCount.GetHashCode();
                if (Owner != null)
                    hashCode = hashCode * 59 + Owner.GetHashCode();
========

                hashCode = hashCode * 59 + MatchingAlgorithm.GetHashCode();

                hashCode = hashCode * 59 + IsInsensitive.GetHashCode();

                hashCode = hashCode * 59 + DocumentCount.GetHashCode();

                hashCode = hashCode * 59 + Owner.GetHashCode();
>>>>>>>> dev:src/PaperlessREST.Entities/GetDocumentTypes200ResponseResultsInner.cs
                if (Permissions != null)
                    hashCode = hashCode * 59 + Permissions.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(GetDocumentTypes200ResponseResultsInner left, GetDocumentTypes200ResponseResultsInner right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GetDocumentTypes200ResponseResultsInner left, GetDocumentTypes200ResponseResultsInner right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
