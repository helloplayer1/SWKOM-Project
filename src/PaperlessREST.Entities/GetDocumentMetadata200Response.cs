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
    public partial class GetDocumentMetadata200Response : IEquatable<GetDocumentMetadata200Response>
    {
        /// <summary>
        /// Gets or Sets OriginalChecksum
        /// </summary>
        [Required]
        [DataMember(Name = "original_checksum", EmitDefaultValue = false)]
        public string OriginalChecksum { get; set; }

        /// <summary>
        /// Gets or Sets OriginalSize
        /// </summary>
        [Required]
        [DataMember(Name = "original_size", EmitDefaultValue = true)]
        public int OriginalSize { get; set; }

        /// <summary>
        /// Gets or Sets OriginalMimeType
        /// </summary>
        [Required]
        [DataMember(Name = "original_mime_type", EmitDefaultValue = false)]
        public string OriginalMimeType { get; set; }

        /// <summary>
        /// Gets or Sets MediaFilename
        /// </summary>
        [Required]
        [DataMember(Name = "media_filename", EmitDefaultValue = false)]
        public string MediaFilename { get; set; }

        /// <summary>
        /// Gets or Sets HasArchiveVersion
        /// </summary>
        [Required]
        [DataMember(Name = "has_archive_version", EmitDefaultValue = true)]
        public bool HasArchiveVersion { get; set; }

        /// <summary>
        /// Gets or Sets OriginalMetadata
        /// </summary>
        [Required]
        [DataMember(Name = "original_metadata", EmitDefaultValue = false)]
        public List<object> OriginalMetadata { get; set; }

        /// <summary>
        /// Gets or Sets ArchiveChecksum
        /// </summary>
        [Required]
        [DataMember(Name = "archive_checksum", EmitDefaultValue = false)]
        public string ArchiveChecksum { get; set; }

        /// <summary>
        /// Gets or Sets ArchiveMediaFilename
        /// </summary>
        [Required]
        [DataMember(Name = "archive_media_filename", EmitDefaultValue = false)]
        public string ArchiveMediaFilename { get; set; }

        /// <summary>
        /// Gets or Sets OriginalFilename
        /// </summary>
        [Required]
        [DataMember(Name = "original_filename", EmitDefaultValue = false)]
        public string OriginalFilename { get; set; }

        /// <summary>
        /// Gets or Sets Lang
        /// </summary>
        [Required]
        [DataMember(Name = "lang", EmitDefaultValue = false)]
        public string Lang { get; set; }

        /// <summary>
        /// Gets or Sets ArchiveSize
        /// </summary>
        [Required]
        [DataMember(Name = "archive_size", EmitDefaultValue = true)]
        public int ArchiveSize { get; set; }

        /// <summary>
        /// Gets or Sets ArchiveMetadata
        /// </summary>
        [Required]
        [DataMember(Name = "archive_metadata", EmitDefaultValue = false)]
        public List<GetDocumentMetadata200ResponseArchiveMetadataInner> ArchiveMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocumentMetadata200Response {\n");
            sb.Append("  OriginalChecksum: ").Append(OriginalChecksum).Append("\n");
            sb.Append("  OriginalSize: ").Append(OriginalSize).Append("\n");
            sb.Append("  OriginalMimeType: ").Append(OriginalMimeType).Append("\n");
            sb.Append("  MediaFilename: ").Append(MediaFilename).Append("\n");
            sb.Append("  HasArchiveVersion: ").Append(HasArchiveVersion).Append("\n");
            sb.Append("  OriginalMetadata: ").Append(OriginalMetadata).Append("\n");
            sb.Append("  ArchiveChecksum: ").Append(ArchiveChecksum).Append("\n");
            sb.Append("  ArchiveMediaFilename: ").Append(ArchiveMediaFilename).Append("\n");
            sb.Append("  OriginalFilename: ").Append(OriginalFilename).Append("\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
            sb.Append("  ArchiveSize: ").Append(ArchiveSize).Append("\n");
            sb.Append("  ArchiveMetadata: ").Append(ArchiveMetadata).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GetDocumentMetadata200Response)obj);
        }

        /// <summary>
        /// Returns true if GetDocumentMetadata200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of GetDocumentMetadata200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocumentMetadata200Response other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    OriginalChecksum == other.OriginalChecksum ||
                    OriginalChecksum != null &&
                    OriginalChecksum.Equals(other.OriginalChecksum)
                ) &&
                (
                    OriginalSize == other.OriginalSize ||

                    OriginalSize.Equals(other.OriginalSize)
                ) &&
                (
                    OriginalMimeType == other.OriginalMimeType ||
                    OriginalMimeType != null &&
                    OriginalMimeType.Equals(other.OriginalMimeType)
                ) &&
                (
                    MediaFilename == other.MediaFilename ||
                    MediaFilename != null &&
                    MediaFilename.Equals(other.MediaFilename)
                ) &&
                (
                    HasArchiveVersion == other.HasArchiveVersion ||

                    HasArchiveVersion.Equals(other.HasArchiveVersion)
                ) &&
                (
                    OriginalMetadata == other.OriginalMetadata ||
                    OriginalMetadata != null &&
                    other.OriginalMetadata != null &&
                    OriginalMetadata.SequenceEqual(other.OriginalMetadata)
                ) &&
                (
                    ArchiveChecksum == other.ArchiveChecksum ||
                    ArchiveChecksum != null &&
                    ArchiveChecksum.Equals(other.ArchiveChecksum)
                ) &&
                (
                    ArchiveMediaFilename == other.ArchiveMediaFilename ||
                    ArchiveMediaFilename != null &&
                    ArchiveMediaFilename.Equals(other.ArchiveMediaFilename)
                ) &&
                (
                    OriginalFilename == other.OriginalFilename ||
                    OriginalFilename != null &&
                    OriginalFilename.Equals(other.OriginalFilename)
                ) &&
                (
                    Lang == other.Lang ||
                    Lang != null &&
                    Lang.Equals(other.Lang)
                ) &&
                (
                    ArchiveSize == other.ArchiveSize ||

                    ArchiveSize.Equals(other.ArchiveSize)
                ) &&
                (
                    ArchiveMetadata == other.ArchiveMetadata ||
                    ArchiveMetadata != null &&
                    other.ArchiveMetadata != null &&
                    ArchiveMetadata.SequenceEqual(other.ArchiveMetadata)
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
                if (OriginalChecksum != null)
                    hashCode = hashCode * 59 + OriginalChecksum.GetHashCode();

                hashCode = hashCode * 59 + OriginalSize.GetHashCode();
                if (OriginalMimeType != null)
                    hashCode = hashCode * 59 + OriginalMimeType.GetHashCode();
                if (MediaFilename != null)
                    hashCode = hashCode * 59 + MediaFilename.GetHashCode();

                hashCode = hashCode * 59 + HasArchiveVersion.GetHashCode();
                if (OriginalMetadata != null)
                    hashCode = hashCode * 59 + OriginalMetadata.GetHashCode();
                if (ArchiveChecksum != null)
                    hashCode = hashCode * 59 + ArchiveChecksum.GetHashCode();
                if (ArchiveMediaFilename != null)
                    hashCode = hashCode * 59 + ArchiveMediaFilename.GetHashCode();
                if (OriginalFilename != null)
                    hashCode = hashCode * 59 + OriginalFilename.GetHashCode();
                if (Lang != null)
                    hashCode = hashCode * 59 + Lang.GetHashCode();

                hashCode = hashCode * 59 + ArchiveSize.GetHashCode();
                if (ArchiveMetadata != null)
                    hashCode = hashCode * 59 + ArchiveMetadata.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(GetDocumentMetadata200Response left, GetDocumentMetadata200Response right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GetDocumentMetadata200Response left, GetDocumentMetadata200Response right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
