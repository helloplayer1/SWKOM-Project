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
<<<<<<<< HEAD:src/PaperlessREST.Entities/ApiUsersBody.cs
    public partial class ApiUsersBody : IEquatable<ApiUsersBody>
========
    public partial class CreateUserRequest : IEquatable<CreateUserRequest>
>>>>>>>> dev:src/PaperlessREST.Entities/CreateUserRequest.cs
    {
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/ApiUsersBody.cs

        [DataMember(Name = "username")]
========
        [DataMember(Name = "username", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/CreateUserRequest.cs
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/ApiUsersBody.cs

        [DataMember(Name = "email")]
========
        [DataMember(Name = "email", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/CreateUserRequest.cs
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/ApiUsersBody.cs

        [DataMember(Name = "password")]
========
        [DataMember(Name = "password", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/CreateUserRequest.cs
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/ApiUsersBody.cs

        [DataMember(Name = "first_name")]
========
        [DataMember(Name = "first_name", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/CreateUserRequest.cs
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/ApiUsersBody.cs

        [DataMember(Name = "last_name")]
========
        [DataMember(Name = "last_name", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/CreateUserRequest.cs
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/ApiUsersBody.cs

        [DataMember(Name = "is_active")]
        public bool? IsActive { get; set; }
========
        [DataMember(Name = "is_active", EmitDefaultValue = true)]
        public bool IsActive { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/CreateUserRequest.cs

        /// <summary>
        /// Gets or Sets IsSuperuser
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/ApiUsersBody.cs

        [DataMember(Name = "is_superuser")]
        public bool? IsSuperuser { get; set; }
========
        [DataMember(Name = "is_superuser", EmitDefaultValue = true)]
        public bool IsSuperuser { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/CreateUserRequest.cs

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/ApiUsersBody.cs

        [DataMember(Name = "groups")]
========
        [DataMember(Name = "groups", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/CreateUserRequest.cs
        public List<object> Groups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUserRequest {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsSuperuser: ").Append(IsSuperuser).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreateUserRequest)obj);
        }

        /// <summary>
        /// Returns true if CreateUserRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUserRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Username == other.Username ||
                    Username != null &&
                    Username.Equals(other.Username)
                ) &&
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) &&
                (
                    Password == other.Password ||
                    Password != null &&
                    Password.Equals(other.Password)
                ) &&
                (
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) &&
                (
                    LastName == other.LastName ||
                    LastName != null &&
                    LastName.Equals(other.LastName)
                ) &&
                (
                    IsActive == other.IsActive ||

                    IsActive.Equals(other.IsActive)
                ) &&
                (
                    IsSuperuser == other.IsSuperuser ||

                    IsSuperuser.Equals(other.IsSuperuser)
                ) &&
                (
                    Groups == other.Groups ||
                    Groups != null &&
                    other.Groups != null &&
                    Groups.SequenceEqual(other.Groups)
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
                if (Username != null)
                    hashCode = hashCode * 59 + Username.GetHashCode();
                if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                if (Password != null)
                    hashCode = hashCode * 59 + Password.GetHashCode();
                if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                if (LastName != null)
                    hashCode = hashCode * 59 + LastName.GetHashCode();
<<<<<<<< HEAD:src/PaperlessREST.Entities/ApiUsersBody.cs
                if (IsActive != null)
                    hashCode = hashCode * 59 + IsActive.GetHashCode();
                if (IsSuperuser != null)
                    hashCode = hashCode * 59 + IsSuperuser.GetHashCode();
========

                hashCode = hashCode * 59 + IsActive.GetHashCode();

                hashCode = hashCode * 59 + IsSuperuser.GetHashCode();
>>>>>>>> dev:src/PaperlessREST.Entities/CreateUserRequest.cs
                if (Groups != null)
                    hashCode = hashCode * 59 + Groups.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(CreateUserRequest left, CreateUserRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreateUserRequest left, CreateUserRequest right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
