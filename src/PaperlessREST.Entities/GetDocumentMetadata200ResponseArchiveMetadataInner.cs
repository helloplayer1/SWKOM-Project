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
    public partial class GetDocumentMetadata200ResponseArchiveMetadataInner : IEquatable<GetDocumentMetadata200ResponseArchiveMetadataInner>
    {
        /// <summary>
        /// Gets or Sets VarNamespace
        /// </summary>
        [Required]
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string VarNamespace { get; set; }

        /// <summary>
        /// Gets or Sets Prefix
        /// </summary>
        [Required]
        [DataMember(Name = "prefix", EmitDefaultValue = false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [Required]
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [Required]
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocumentMetadata200ResponseArchiveMetadataInner {\n");
            sb.Append("  VarNamespace: ").Append(VarNamespace).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GetDocumentMetadata200ResponseArchiveMetadataInner)obj);
        }

        /// <summary>
        /// Returns true if GetDocumentMetadata200ResponseArchiveMetadataInner instances are equal
        /// </summary>
        /// <param name="other">Instance of GetDocumentMetadata200ResponseArchiveMetadataInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocumentMetadata200ResponseArchiveMetadataInner other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    VarNamespace == other.VarNamespace ||
                    VarNamespace != null &&
                    VarNamespace.Equals(other.VarNamespace)
                ) &&
                (
                    Prefix == other.Prefix ||
                    Prefix != null &&
                    Prefix.Equals(other.Prefix)
                ) &&
                (
                    Key == other.Key ||
                    Key != null &&
                    Key.Equals(other.Key)
                ) &&
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
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
                if (VarNamespace != null)
                    hashCode = hashCode * 59 + VarNamespace.GetHashCode();
                if (Prefix != null)
                    hashCode = hashCode * 59 + Prefix.GetHashCode();
                if (Key != null)
                    hashCode = hashCode * 59 + Key.GetHashCode();
                if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(GetDocumentMetadata200ResponseArchiveMetadataInner left, GetDocumentMetadata200ResponseArchiveMetadataInner right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GetDocumentMetadata200ResponseArchiveMetadataInner left, GetDocumentMetadata200ResponseArchiveMetadataInner right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
