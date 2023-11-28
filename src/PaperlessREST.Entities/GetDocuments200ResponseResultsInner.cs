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
    public partial class GetDocuments200ResponseResultsInner : IEquatable<GetDocuments200ResponseResultsInner>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Correspondent
        /// </summary>
        [Required]
        [DataMember(Name = "correspondent", EmitDefaultValue = true)]
        public int Correspondent { get; set; }

        /// <summary>
        /// Gets or Sets DocumentType
        /// </summary>
        [Required]
        [DataMember(Name = "document_type", EmitDefaultValue = true)]
        public int DocumentType { get; set; }

        /// <summary>
        /// Gets or Sets StoragePath
        /// </summary>
        [Required]
        [DataMember(Name = "storage_path", EmitDefaultValue = true)]
        public int StoragePath { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [Required]
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [Required]
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [Required]
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<int> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [Required]
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [Required]
        [DataMember(Name = "created_date", EmitDefaultValue = false)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [Required]
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        public string Modified { get; set; }

        /// <summary>
        /// Gets or Sets Added
        /// </summary>
        [Required]
        [DataMember(Name = "added", EmitDefaultValue = false)]
        public string Added { get; set; }

        /// <summary>
        /// Gets or Sets ArchiveSerialNumber
        /// </summary>
        [Required]
        [DataMember(Name = "archive_serial_number", EmitDefaultValue = true)]
        public int ArchiveSerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets OriginalFileName
        /// </summary>
        [Required]
        [DataMember(Name = "original_file_name", EmitDefaultValue = false)]
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Gets or Sets ArchivedFileName
        /// </summary>
        [Required]
        [DataMember(Name = "archived_file_name", EmitDefaultValue = false)]
        public string ArchivedFileName { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [Required]
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public int Owner { get; set; }

        /// <summary>
        /// Gets or Sets UserCanChange
        /// </summary>
        [Required]
        [DataMember(Name = "user_can_change", EmitDefaultValue = true)]
        public bool UserCanChange { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [Required]
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public List<GetDocuments200ResponseResultsInnerNotesInner> Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocuments200ResponseResultsInner {\n");
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
            return obj.GetType() == GetType() && Equals((GetDocuments200ResponseResultsInner)obj);
        }

        /// <summary>
        /// Returns true if GetDocuments200ResponseResultsInner instances are equal
        /// </summary>
        /// <param name="other">Instance of GetDocuments200ResponseResultsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocuments200ResponseResultsInner other)
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

                hashCode = hashCode * 59 + Id.GetHashCode();

                hashCode = hashCode * 59 + Correspondent.GetHashCode();

                hashCode = hashCode * 59 + DocumentType.GetHashCode();

                hashCode = hashCode * 59 + StoragePath.GetHashCode();
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

                hashCode = hashCode * 59 + ArchiveSerialNumber.GetHashCode();
                if (OriginalFileName != null)
                    hashCode = hashCode * 59 + OriginalFileName.GetHashCode();
                if (ArchivedFileName != null)
                    hashCode = hashCode * 59 + ArchivedFileName.GetHashCode();

                hashCode = hashCode * 59 + Owner.GetHashCode();

                hashCode = hashCode * 59 + UserCanChange.GetHashCode();
                if (Notes != null)
                    hashCode = hashCode * 59 + Notes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(GetDocuments200ResponseResultsInner left, GetDocuments200ResponseResultsInner right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GetDocuments200ResponseResultsInner left, GetDocuments200ResponseResultsInner right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
