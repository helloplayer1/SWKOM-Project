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
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse20013.cs
    public partial class InlineResponse20013 : IEquatable<InlineResponse20013>
========
    public partial class UpdateGroup200Response : IEquatable<UpdateGroup200Response>
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateGroup200Response.cs
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse20013.cs

        [DataMember(Name = "id")]
        public int? Id { get; set; }
========
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int Id { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateGroup200Response.cs

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse20013.cs

        [DataMember(Name = "name")]
========
        [DataMember(Name = "name", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateGroup200Response.cs
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse20013.cs

        [DataMember(Name = "permissions")]
========
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateGroup200Response.cs
        public List<string> Permissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateGroup200Response {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UpdateGroup200Response)obj);
        }

        /// <summary>
        /// Returns true if UpdateGroup200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateGroup200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateGroup200Response other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Id == other.Id ||

                    Id.Equals(other.Id)
                ) &&
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) &&
                (
                    Permissions == other.Permissions ||
                    Permissions != null &&
                    other.Permissions != null &&
                    Permissions.SequenceEqual(other.Permissions)
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
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse20013.cs
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
========

                hashCode = hashCode * 59 + Id.GetHashCode();
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateGroup200Response.cs
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Permissions != null)
                    hashCode = hashCode * 59 + Permissions.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(UpdateGroup200Response left, UpdateGroup200Response right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UpdateGroup200Response left, UpdateGroup200Response right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
