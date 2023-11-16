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
    public partial class InlineResponse2002Notes : IEquatable<InlineResponse2002Notes>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]

        [DataMember(Name="id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [Required]

        [DataMember(Name="note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [Required]

        [DataMember(Name="created")]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [Required]

        [DataMember(Name="document")]
        public int? Document { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [Required]

        [DataMember(Name="user")]
        public int? User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2002Notes {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponse2002Notes)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse2002Notes instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2002Notes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2002Notes other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Note == other.Note ||
                    Note != null &&
                    Note.Equals(other.Note)
                ) && 
                (
                    Created == other.Created ||
                    Created != null &&
                    Created.Equals(other.Created)
                ) && 
                (
                    Document == other.Document ||
                    Document != null &&
                    Document.Equals(other.Document)
                ) && 
                (
                    User == other.User ||
                    User != null &&
                    User.Equals(other.User)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Note != null)
                    hashCode = hashCode * 59 + Note.GetHashCode();
                    if (Created != null)
                    hashCode = hashCode * 59 + Created.GetHashCode();
                    if (Document != null)
                    hashCode = hashCode * 59 + Document.GetHashCode();
                    if (User != null)
                    hashCode = hashCode * 59 + User.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponse2002Notes left, InlineResponse2002Notes right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse2002Notes left, InlineResponse2002Notes right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
