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
    public partial class InlineResponse2002 : IEquatable<InlineResponse2002>
    { 
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [Required]

        [DataMember(Name="count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [Required]

        [DataMember(Name="next")]
        public int? Next { get; set; }

        /// <summary>
        /// Gets or Sets Previous
        /// </summary>
        [Required]

        [DataMember(Name="previous")]
        public int? Previous { get; set; }

        /// <summary>
        /// Gets or Sets All
        /// </summary>
        [Required]

        [DataMember(Name="all")]
        public List<int?> All { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [Required]

        [DataMember(Name="results")]
        public List<InlineResponse2002Results> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2002 {\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((InlineResponse2002)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse2002 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2002 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2002 other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Count == other.Count ||
                    Count != null &&
                    Count.Equals(other.Count)
                ) && 
                (
                    Next == other.Next ||
                    Next != null &&
                    Next.Equals(other.Next)
                ) && 
                (
                    Previous == other.Previous ||
                    Previous != null &&
                    Previous.Equals(other.Previous)
                ) && 
                (
                    All == other.All ||
                    All != null &&
                    All.SequenceEqual(other.All)
                ) && 
                (
                    Results == other.Results ||
                    Results != null &&
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
                    if (Count != null)
                    hashCode = hashCode * 59 + Count.GetHashCode();
                    if (Next != null)
                    hashCode = hashCode * 59 + Next.GetHashCode();
                    if (Previous != null)
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

        public static bool operator ==(InlineResponse2002 left, InlineResponse2002 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse2002 left, InlineResponse2002 right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
