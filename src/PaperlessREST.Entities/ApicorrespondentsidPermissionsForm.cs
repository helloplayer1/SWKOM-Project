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
<<<<<<<< HEAD:src/PaperlessREST.Entities/ApicorrespondentsidPermissionsForm.cs
    public partial class ApicorrespondentsidPermissionsForm : IEquatable<ApicorrespondentsidPermissionsForm>
========
    public partial class UpdateCorrespondentRequestPermissionsForm : IEquatable<UpdateCorrespondentRequestPermissionsForm>
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateCorrespondentRequestPermissionsForm.cs
    {
        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/ApicorrespondentsidPermissionsForm.cs

        [DataMember(Name = "owner")]
        public int? Owner { get; set; }
========
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public int Owner { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateCorrespondentRequestPermissionsForm.cs

        /// <summary>
        /// Gets or Sets SetPermissions
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/ApicorrespondentsidPermissionsForm.cs

        [DataMember(Name = "set_permissions")]
        public ApicorrespondentsidPermissions SetPermissions { get; set; }
========
        [DataMember(Name = "set_permissions", EmitDefaultValue = false)]
        public GetCorrespondents200ResponseResultsInnerPermissions SetPermissions { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateCorrespondentRequestPermissionsForm.cs

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCorrespondentRequestPermissionsForm {\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  SetPermissions: ").Append(SetPermissions).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UpdateCorrespondentRequestPermissionsForm)obj);
        }

        /// <summary>
        /// Returns true if UpdateCorrespondentRequestPermissionsForm instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateCorrespondentRequestPermissionsForm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCorrespondentRequestPermissionsForm other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Owner == other.Owner ||

                    Owner.Equals(other.Owner)
                ) &&
                (
                    SetPermissions == other.SetPermissions ||
                    SetPermissions != null &&
                    SetPermissions.Equals(other.SetPermissions)
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
<<<<<<<< HEAD:src/PaperlessREST.Entities/ApicorrespondentsidPermissionsForm.cs
                if (Owner != null)
                    hashCode = hashCode * 59 + Owner.GetHashCode();
========

                hashCode = hashCode * 59 + Owner.GetHashCode();
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateCorrespondentRequestPermissionsForm.cs
                if (SetPermissions != null)
                    hashCode = hashCode * 59 + SetPermissions.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(UpdateCorrespondentRequestPermissionsForm left, UpdateCorrespondentRequestPermissionsForm right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UpdateCorrespondentRequestPermissionsForm left, UpdateCorrespondentRequestPermissionsForm right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
