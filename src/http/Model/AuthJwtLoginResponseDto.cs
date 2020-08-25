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
    /// AuthJwtLoginResponseDto
    /// </summary>
    [DataContract]
    public partial class AuthJwtLoginResponseDto :  IEquatable<AuthJwtLoginResponseDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthJwtLoginResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthJwtLoginResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthJwtLoginResponseDto" /> class.
        /// </summary>
        /// <param name="token">token (required).</param>
        /// <param name="user">user (required).</param>
        public AuthJwtLoginResponseDto(string token = default(string), AuthUserDto user = default(AuthUserDto))
        {
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new InvalidDataException("token is a required property for AuthJwtLoginResponseDto and cannot be null");
            }
            else
            {
                this.token = token;
            }
            
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for AuthJwtLoginResponseDto and cannot be null");
            }
            else
            {
                this.user = user;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=true)]
        public string token { get; set; }

        /// <summary>
        /// Gets or Sets user
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=true)]
        public AuthUserDto user { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthJwtLoginResponseDto {\n");
            sb.Append("  token: ").Append(token).Append("\n");
            sb.Append("  user: ").Append(user).Append("\n");
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
            return this.Equals(input as AuthJwtLoginResponseDto);
        }

        /// <summary>
        /// Returns true if AuthJwtLoginResponseDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthJwtLoginResponseDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthJwtLoginResponseDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.token == input.token ||
                    (this.token != null &&
                    this.token.Equals(input.token))
                ) && 
                (
                    this.user == input.user ||
                    (this.user != null &&
                    this.user.Equals(input.user))
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
                if (this.token != null)
                    hashCode = hashCode * 59 + this.token.GetHashCode();
                if (this.user != null)
                    hashCode = hashCode * 59 + this.user.GetHashCode();
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
