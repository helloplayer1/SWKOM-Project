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
    public partial class GetDocumentTypes200Response : IEquatable<GetDocumentTypes200Response>
    {
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [Required]
        [DataMember(Name = "count", EmitDefaultValue = true)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [Required]
        [DataMember(Name = "next", EmitDefaultValue = true)]
        public int Next { get; set; }

        /// <summary>
        /// Gets or Sets Previous
        /// </summary>
        [Required]
        [DataMember(Name = "previous", EmitDefaultValue = true)]
        public int Previous { get; set; }

        /// <summary>
        /// Gets or Sets All
        /// </summary>
        [Required]
        [DataMember(Name = "all", EmitDefaultValue = false)]
        public List<int> All { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [Required]
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<GetDocumentTypes200ResponseResultsInner> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocumentTypes200Response {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Previous: ").Append(Previous).Append("\n");
            sb.Append("  All: ").Append(All).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GetDocumentTypes200Response)obj);
        }

        /// <summary>
        /// Returns true if GetDocumentTypes200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of GetDocumentTypes200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocumentTypes200Response other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Count == other.Count ||

                    Count.Equals(other.Count)
                ) &&
                (
                    Next == other.Next ||

                    Next.Equals(other.Next)
                ) &&
                (
                    Previous == other.Previous ||

                    Previous.Equals(other.Previous)
                ) &&
                (
                    All == other.All ||
                    All != null &&
                    other.All != null &&
                    All.SequenceEqual(other.All)
                ) &&
                (
                    Results == other.Results ||
                    Results != null &&
                    other.Results != null &&
                    Results.SequenceEqual(other.Results)
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

                hashCode = hashCode * 59 + Count.GetHashCode();

                hashCode = hashCode * 59 + Next.GetHashCode();

                hashCode = hashCode * 59 + Previous.GetHashCode();
                if (All != null)
                    hashCode = hashCode * 59 + All.GetHashCode();
                if (Results != null)
                    hashCode = hashCode * 59 + Results.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(GetDocumentTypes200Response left, GetDocumentTypes200Response right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GetDocumentTypes200Response left, GetDocumentTypes200Response right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
