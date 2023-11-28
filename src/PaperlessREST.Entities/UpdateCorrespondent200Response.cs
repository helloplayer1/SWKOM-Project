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
    public partial class UpdateCorrespondent200Response : IEquatable<UpdateCorrespondent200Response>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [Required]
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Match
        /// </summary>
        [Required]
        [DataMember(Name = "match", EmitDefaultValue = false)]
        public string Match { get; set; }

        /// <summary>
        /// Gets or Sets MatchingAlgorithm
        /// </summary>
        [Required]
        [DataMember(Name = "matching_algorithm", EmitDefaultValue = true)]
        public int MatchingAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets IsInsensitive
        /// </summary>
        [Required]
        [DataMember(Name = "is_insensitive", EmitDefaultValue = true)]
        public bool IsInsensitive { get; set; }

        /// <summary>
        /// Gets or Sets DocumentCount
        /// </summary>
        [Required]
        [DataMember(Name = "document_count", EmitDefaultValue = true)]
        public int DocumentCount { get; set; }

        /// <summary>
        /// Gets or Sets LastCorrespondence
        /// </summary>
        [Required]
        [DataMember(Name = "last_correspondence", EmitDefaultValue = true)]
        public int LastCorrespondence { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [Required]
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public int Owner { get; set; }

        /// <summary>
        /// Gets or Sets UserCanChange
        /// </summary>
        [Required]
        [DataMember(Name = "user_can_change", EmitDefaultValue = true)]
        public bool UserCanChange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCorrespondent200Response {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Match: ").Append(Match).Append("\n");
            sb.Append("  MatchingAlgorithm: ").Append(MatchingAlgorithm).Append("\n");
            sb.Append("  IsInsensitive: ").Append(IsInsensitive).Append("\n");
            sb.Append("  DocumentCount: ").Append(DocumentCount).Append("\n");
            sb.Append("  LastCorrespondence: ").Append(LastCorrespondence).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  UserCanChange: ").Append(UserCanChange).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UpdateCorrespondent200Response)obj);
        }

        /// <summary>
        /// Returns true if UpdateCorrespondent200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateCorrespondent200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCorrespondent200Response other)
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
                    LastCorrespondence == other.LastCorrespondence ||

                    LastCorrespondence.Equals(other.LastCorrespondence)
                ) &&
                (
                    Owner == other.Owner ||

                    Owner.Equals(other.Owner)
                ) &&
                (
                    UserCanChange == other.UserCanChange ||

                    UserCanChange.Equals(other.UserCanChange)
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

                hashCode = hashCode * 59 + Id.GetHashCode();
                if (Slug != null)
                    hashCode = hashCode * 59 + Slug.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Match != null)
                    hashCode = hashCode * 59 + Match.GetHashCode();

                hashCode = hashCode * 59 + MatchingAlgorithm.GetHashCode();

                hashCode = hashCode * 59 + IsInsensitive.GetHashCode();

                hashCode = hashCode * 59 + DocumentCount.GetHashCode();

                hashCode = hashCode * 59 + LastCorrespondence.GetHashCode();

                hashCode = hashCode * 59 + Owner.GetHashCode();

                hashCode = hashCode * 59 + UserCanChange.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(UpdateCorrespondent200Response left, UpdateCorrespondent200Response right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UpdateCorrespondent200Response left, UpdateCorrespondent200Response right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
