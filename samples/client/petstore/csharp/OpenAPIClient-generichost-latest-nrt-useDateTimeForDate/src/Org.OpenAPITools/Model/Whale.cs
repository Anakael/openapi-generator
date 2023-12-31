// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Whale
    /// </summary>
    public partial class Whale : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Whale" /> class.
        /// </summary>
        /// <param name="className">className</param>
        /// <param name="hasBaleen">hasBaleen</param>
        /// <param name="hasTeeth">hasTeeth</param>
        [JsonConstructor]
        public Whale(string className, Option<bool?> hasBaleen = default, Option<bool?> hasTeeth = default)
        {
            ClassName = className;
            HasBaleenOption = hasBaleen;
            HasTeethOption = hasTeeth;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [JsonPropertyName("className")]
        public string ClassName { get; set; }

        /// <summary>
        /// Used to track the state of HasBaleen
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> HasBaleenOption { get; private set; }

        /// <summary>
        /// Gets or Sets HasBaleen
        /// </summary>
        [JsonPropertyName("hasBaleen")]
        public bool? HasBaleen { get { return this. HasBaleenOption; } set { this.HasBaleenOption = new(value); } }

        /// <summary>
        /// Used to track the state of HasTeeth
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> HasTeethOption { get; private set; }

        /// <summary>
        /// Gets or Sets HasTeeth
        /// </summary>
        [JsonPropertyName("hasTeeth")]
        public bool? HasTeeth { get { return this. HasTeethOption; } set { this.HasTeethOption = new(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Whale {\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  HasBaleen: ").Append(HasBaleen).Append("\n");
            sb.Append("  HasTeeth: ").Append(HasTeeth).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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


    /// <summary>
    /// A Json converter for type <see cref="Whale" />
    /// </summary>
    public class WhaleJsonConverter : JsonConverter<Whale>
    {
        /// <summary>
        /// Deserializes json to <see cref="Whale" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Whale Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> className = default;
            Option<bool?> hasBaleen = default;
            Option<bool?> hasTeeth = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "className":
                            className = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "hasBaleen":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                hasBaleen = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "hasTeeth":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                hasTeeth = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!className.IsSet)
                throw new ArgumentException("Property is required for class Whale.", nameof(className));

            if (className.IsSet && className.Value == null)
                throw new ArgumentNullException(nameof(className), "Property is not nullable for class Whale.");

            if (hasBaleen.IsSet && hasBaleen.Value == null)
                throw new ArgumentNullException(nameof(hasBaleen), "Property is not nullable for class Whale.");

            if (hasTeeth.IsSet && hasTeeth.Value == null)
                throw new ArgumentNullException(nameof(hasTeeth), "Property is not nullable for class Whale.");

            return new Whale(className.Value!, hasBaleen, hasTeeth);
        }

        /// <summary>
        /// Serializes a <see cref="Whale" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="whale"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Whale whale, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, whale, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Whale" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="whale"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, Whale whale, JsonSerializerOptions jsonSerializerOptions)
        {
            if (whale.ClassName == null)
                throw new ArgumentNullException(nameof(whale.ClassName), "Property is required for class Whale.");

            writer.WriteString("className", whale.ClassName);

            if (whale.HasBaleenOption.IsSet)
                writer.WriteBoolean("hasBaleen", whale.HasBaleenOption.Value!.Value);

            if (whale.HasTeethOption.IsSet)
                writer.WriteBoolean("hasTeeth", whale.HasTeethOption.Value!.Value);
        }
    }
}
