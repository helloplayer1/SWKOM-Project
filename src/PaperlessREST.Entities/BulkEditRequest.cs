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
    public partial class BulkEditRequest : IEquatable<BulkEditRequest>
    {
        /// <summary>
        /// Gets or Sets Documents
        /// </summary>
        [Required]
        [DataMember(Name = "documents", EmitDefaultValue = false)]
        public List<int> Documents { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [Required]
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [Required]
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public object Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkEditRequest {\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BulkEditRequest)obj);
        }

        /// <summary>
        /// Returns true if BulkEditRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkEditRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkEditRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Documents == other.Documents ||
                    Documents != null &&
                    other.Documents != null &&
                    Documents.SequenceEqual(other.Documents)
                ) &&
                (
                    Method == other.Method ||
                    Method != null &&
                    Method.Equals(other.Method)
                ) &&
                (
                    Parameters == other.Parameters ||
                    Parameters != null &&
                    Parameters.Equals(other.Parameters)
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
                if (Documents != null)
                    hashCode = hashCode * 59 + Documents.GetHashCode();
                if (Method != null)
                    hashCode = hashCode * 59 + Method.GetHashCode();
                if (Parameters != null)
                    hashCode = hashCode * 59 + Parameters.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(BulkEditRequest left, BulkEditRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BulkEditRequest left, BulkEditRequest right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
