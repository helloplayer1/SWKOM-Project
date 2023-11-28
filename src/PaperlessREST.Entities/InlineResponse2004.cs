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
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs
    public partial class InlineResponse2004 : IEquatable<InlineResponse2004>
========
    public partial class UpdateDocument200Response : IEquatable<UpdateDocument200Response>
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "id")]
        public int? Id { get; set; }
========
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int Id { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs

        /// <summary>
        /// Gets or Sets Correspondent
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "correspondent")]
        public int? Correspondent { get; set; }
========
        [DataMember(Name = "correspondent", EmitDefaultValue = true)]
        public int Correspondent { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs

        /// <summary>
        /// Gets or Sets DocumentType
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "document_type")]
        public int? DocumentType { get; set; }
========
        [DataMember(Name = "document_type", EmitDefaultValue = true)]
        public int DocumentType { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs

        /// <summary>
        /// Gets or Sets StoragePath
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "storage_path")]
        public int? StoragePath { get; set; }
========
        [DataMember(Name = "storage_path", EmitDefaultValue = true)]
        public int StoragePath { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "title")]
========
        [DataMember(Name = "title", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "content")]
========
        [DataMember(Name = "content", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "tags")]
        public List<int?> Tags { get; set; }
========
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<int> Tags { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "created")]
========
        [DataMember(Name = "created", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "created_date")]
========
        [DataMember(Name = "created_date", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs
        public string CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "modified")]
========
        [DataMember(Name = "modified", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs
        public string Modified { get; set; }

        /// <summary>
        /// Gets or Sets Added
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "added")]
========
        [DataMember(Name = "added", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs
        public string Added { get; set; }

        /// <summary>
        /// Gets or Sets ArchiveSerialNumber
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "archive_serial_number")]
        public int? ArchiveSerialNumber { get; set; }
========
        [DataMember(Name = "archive_serial_number", EmitDefaultValue = true)]
        public int ArchiveSerialNumber { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs

        /// <summary>
        /// Gets or Sets OriginalFileName
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "original_file_name")]
========
        [DataMember(Name = "original_file_name", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Gets or Sets ArchivedFileName
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "archived_file_name")]
========
        [DataMember(Name = "archived_file_name", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs
        public string ArchivedFileName { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "owner")]
        public int? Owner { get; set; }
========
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public int Owner { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs

        /// <summary>
        /// Gets or Sets UserCanChange
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "user_can_change")]
        public bool? UserCanChange { get; set; }
========
        [DataMember(Name = "user_can_change", EmitDefaultValue = true)]
        public bool UserCanChange { get; set; }
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [Required]
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs

        [DataMember(Name = "notes")]
========
        [DataMember(Name = "notes", EmitDefaultValue = false)]
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs
        public List<object> Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDocument200Response {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Correspondent: ").Append(Correspondent).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  StoragePath: ").Append(StoragePath).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Added: ").Append(Added).Append("\n");
            sb.Append("  ArchiveSerialNumber: ").Append(ArchiveSerialNumber).Append("\n");
            sb.Append("  OriginalFileName: ").Append(OriginalFileName).Append("\n");
            sb.Append("  ArchivedFileName: ").Append(ArchivedFileName).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  UserCanChange: ").Append(UserCanChange).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UpdateDocument200Response)obj);
        }

        /// <summary>
        /// Returns true if UpdateDocument200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateDocument200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateDocument200Response other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Id == other.Id ||

                    Id.Equals(other.Id)
                ) &&
                (
                    Correspondent == other.Correspondent ||

                    Correspondent.Equals(other.Correspondent)
                ) &&
                (
                    DocumentType == other.DocumentType ||

                    DocumentType.Equals(other.DocumentType)
                ) &&
                (
                    StoragePath == other.StoragePath ||

                    StoragePath.Equals(other.StoragePath)
                ) &&
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) &&
                (
                    Content == other.Content ||
                    Content != null &&
                    Content.Equals(other.Content)
                ) &&
                (
                    Tags == other.Tags ||
                    Tags != null &&
                    other.Tags != null &&
                    Tags.SequenceEqual(other.Tags)
                ) &&
                (
                    Created == other.Created ||
                    Created != null &&
                    Created.Equals(other.Created)
                ) &&
                (
                    CreatedDate == other.CreatedDate ||
                    CreatedDate != null &&
                    CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    Modified == other.Modified ||
                    Modified != null &&
                    Modified.Equals(other.Modified)
                ) &&
                (
                    Added == other.Added ||
                    Added != null &&
                    Added.Equals(other.Added)
                ) &&
                (
                    ArchiveSerialNumber == other.ArchiveSerialNumber ||

                    ArchiveSerialNumber.Equals(other.ArchiveSerialNumber)
                ) &&
                (
                    OriginalFileName == other.OriginalFileName ||
                    OriginalFileName != null &&
                    OriginalFileName.Equals(other.OriginalFileName)
                ) &&
                (
                    ArchivedFileName == other.ArchivedFileName ||
                    ArchivedFileName != null &&
                    ArchivedFileName.Equals(other.ArchivedFileName)
                ) &&
                (
                    Owner == other.Owner ||

                    Owner.Equals(other.Owner)
                ) &&
                (
                    UserCanChange == other.UserCanChange ||

                    UserCanChange.Equals(other.UserCanChange)
                ) &&
                (
                    Notes == other.Notes ||
                    Notes != null &&
                    other.Notes != null &&
                    Notes.SequenceEqual(other.Notes)
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
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Correspondent != null)
                    hashCode = hashCode * 59 + Correspondent.GetHashCode();
                if (DocumentType != null)
                    hashCode = hashCode * 59 + DocumentType.GetHashCode();
                if (StoragePath != null)
                    hashCode = hashCode * 59 + StoragePath.GetHashCode();
========

                hashCode = hashCode * 59 + Id.GetHashCode();

                hashCode = hashCode * 59 + Correspondent.GetHashCode();

                hashCode = hashCode * 59 + DocumentType.GetHashCode();

                hashCode = hashCode * 59 + StoragePath.GetHashCode();
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (Content != null)
                    hashCode = hashCode * 59 + Content.GetHashCode();
                if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                if (Created != null)
                    hashCode = hashCode * 59 + Created.GetHashCode();
                if (CreatedDate != null)
                    hashCode = hashCode * 59 + CreatedDate.GetHashCode();
                if (Modified != null)
                    hashCode = hashCode * 59 + Modified.GetHashCode();
                if (Added != null)
                    hashCode = hashCode * 59 + Added.GetHashCode();
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs
                if (ArchiveSerialNumber != null)
                    hashCode = hashCode * 59 + ArchiveSerialNumber.GetHashCode();
========

                hashCode = hashCode * 59 + ArchiveSerialNumber.GetHashCode();
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs
                if (OriginalFileName != null)
                    hashCode = hashCode * 59 + OriginalFileName.GetHashCode();
                if (ArchivedFileName != null)
                    hashCode = hashCode * 59 + ArchivedFileName.GetHashCode();
<<<<<<<< HEAD:src/PaperlessREST.Entities/InlineResponse2004.cs
                if (Owner != null)
                    hashCode = hashCode * 59 + Owner.GetHashCode();
                if (UserCanChange != null)
                    hashCode = hashCode * 59 + UserCanChange.GetHashCode();
========

                hashCode = hashCode * 59 + Owner.GetHashCode();

                hashCode = hashCode * 59 + UserCanChange.GetHashCode();
>>>>>>>> dev:src/PaperlessREST.Entities/UpdateDocument200Response.cs
                if (Notes != null)
                    hashCode = hashCode * 59 + Notes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(UpdateDocument200Response left, UpdateDocument200Response right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UpdateDocument200Response left, UpdateDocument200Response right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
