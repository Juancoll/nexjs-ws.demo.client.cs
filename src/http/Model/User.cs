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
    /// User
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected User() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="password">password.</param>
        /// <param name="roles">roles (required).</param>
        /// <param name="name">name.</param>
        /// <param name="surname">surname.</param>
        public User(string email = default(string), string password = default(string), List<string> roles = default(List<string>), string name = default(string), string surname = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for User and cannot be null");
            }
            else
            {
                this.email = email;
            }
            
            // to ensure "roles" is required (not null)
            if (roles == null)
            {
                throw new InvalidDataException("roles is a required property for User and cannot be null");
            }
            else
            {
                this.roles = roles;
            }
            
            this.password = password;
            this.name = name;
            this.surname = surname;
        }
        
        /// <summary>
        /// Gets or Sets email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string email { get; set; }

        /// <summary>
        /// Gets or Sets password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string password { get; set; }

        /// <summary>
        /// Gets or Sets roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=true)]
        public List<string> roles { get; set; }

        /// <summary>
        /// Gets or Sets name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string name { get; set; }

        /// <summary>
        /// Gets or Sets surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=false)]
        public string surname { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  email: ").Append(email).Append("\n");
            sb.Append("  password: ").Append(password).Append("\n");
            sb.Append("  roles: ").Append(roles).Append("\n");
            sb.Append("  name: ").Append(name).Append("\n");
            sb.Append("  surname: ").Append(surname).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
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
                    this.password == input.password ||
                    (this.password != null &&
                    this.password.Equals(input.password))
                ) && 
                (
                    this.roles == input.roles ||
                    this.roles != null &&
                    input.roles != null &&
                    this.roles.SequenceEqual(input.roles)
                ) && 
                (
                    this.name == input.name ||
                    (this.name != null &&
                    this.name.Equals(input.name))
                ) && 
                (
                    this.surname == input.surname ||
                    (this.surname != null &&
                    this.surname.Equals(input.surname))
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
                if (this.password != null)
                    hashCode = hashCode * 59 + this.password.GetHashCode();
                if (this.roles != null)
                    hashCode = hashCode * 59 + this.roles.GetHashCode();
                if (this.name != null)
                    hashCode = hashCode * 59 + this.name.GetHashCode();
                if (this.surname != null)
                    hashCode = hashCode * 59 + this.surname.GetHashCode();
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
