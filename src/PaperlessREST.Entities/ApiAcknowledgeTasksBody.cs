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
<<<<<<<< HEAD:src/PaperlessREST.Entities/ApiAcknowledgeTasksBody.cs
    public partial class ApiAcknowledgeTasksBody : IEquatable<ApiAcknowledgeTasksBody>
========
    public partial class AckTasksRequest : IEquatable<AckTasksRequest>
>>>>>>>> dev:src/PaperlessREST.Entities/AckTasksRequest.cs
    {
        /// <summary>
        /// Gets or Sets Tasks
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/ApiAcknowledgeTasksBody.cs

        [DataMember(Name = "tasks")]
        public List<int?> Tasks { get; set; }
========
        [DataMember(Name = "tasks", EmitDefaultValue = false)]
        public List<int> Tasks { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/AckTasksRequest.cs

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AckTasksRequest {\n");
            sb.Append("  Tasks: ").Append(Tasks).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AckTasksRequest)obj);
        }

        /// <summary>
        /// Returns true if AckTasksRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AckTasksRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AckTasksRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                
                    Tasks == other.Tasks ||
                    Tasks != null &&
                    other.Tasks != null &&
                    Tasks.SequenceEqual(other.Tasks)
                ;
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
                if (Tasks != null)
                    hashCode = hashCode * 59 + Tasks.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(AckTasksRequest left, AckTasksRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AckTasksRequest left, AckTasksRequest right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
