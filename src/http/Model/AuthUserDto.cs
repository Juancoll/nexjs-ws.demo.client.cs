/* 
 * nexjs-ws.demo-project.server-nestjs
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = demo.httpclient.Client.OpenAPIDateConverter;

namespace demo.httpclient.Model
{
    /// <summary>
    /// AuthUserDto
    /// </summary>
    [DataContract]
    public partial class AuthUserDto :  IEquatable<AuthUserDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthUserDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserDto" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="roles">roles (required).</param>
        public AuthUserDto(string email = default(string), List<string> roles = default(List<string>))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for AuthUserDto and cannot be null");
            }
            else
            {
                this.email = email;
            }
            
            // to ensure "roles" is required (not null)
            if (roles == null)
            {
                throw new InvalidDataException("roles is a required property for AuthUserDto and cannot be null");
            }
            else
            {
                this.roles = roles;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string email { get; set; }

        /// <summary>
        /// Gets or Sets roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=true)]
        public List<string> roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthUserDto {\n");
            sb.Append("  email: ").Append(email).Append("\n");
            sb.Append("  roles: ").Append(roles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthUserDto);
        }

        /// <summary>
        /// Returns true if AuthUserDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthUserDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthUserDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.email == input.email ||
                    (this.email != null &&
                    this.email.Equals(input.email))
                ) && 
                (
                    this.roles == input.roles ||
                    this.roles != null &&
                    input.roles != null &&
                    this.roles.SequenceEqual(input.roles)
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
                int hashCode = 41;
                if (this.email != null)
                    hashCode = hashCode * 59 + this.email.GetHashCode();
                if (this.roles != null)
                    hashCode = hashCode * 59 + this.roles.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
