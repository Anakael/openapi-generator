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
    /// ArrayOfNumberOnly
    /// </summary>
    public partial class ArrayOfNumberOnly : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayOfNumberOnly" /> class.
        /// </summary>
        /// <param name="arrayNumber">arrayNumber</param>
        [JsonConstructor]
        public ArrayOfNumberOnly(Option<List<decimal>?> arrayNumber = default)
        {
            ArrayNumberOption = arrayNumber;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ArrayNumber
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<decimal>?> ArrayNumberOption { get; private set; }

        /// <summary>
        /// Gets or Sets ArrayNumber
        /// </summary>
        [JsonPropertyName("ArrayNumber")]
        public List<decimal>? ArrayNumber { get { return this. ArrayNumberOption; } set { this.ArrayNumberOption = new(value); } }

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
            sb.Append("class ArrayOfNumberOnly {\n");
            sb.Append("  ArrayNumber: ").Append(ArrayNumber).Append("\n");
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
    /// A Json converter for type <see cref="ArrayOfNumberOnly" />
    /// </summary>
    public class ArrayOfNumberOnlyJsonConverter : JsonConverter<ArrayOfNumberOnly>
    {
        /// <summary>
        /// Deserializes json to <see cref="ArrayOfNumberOnly" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ArrayOfNumberOnly Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<decimal>?> arrayNumber = default;

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
                        case "ArrayNumber":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                arrayNumber = new Option<List<decimal>?>(JsonSerializer.Deserialize<List<decimal>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (arrayNumber.IsSet && arrayNumber.Value == null)
                throw new ArgumentNullException(nameof(arrayNumber), "Property is not nullable for class ArrayOfNumberOnly.");

            return new ArrayOfNumberOnly(arrayNumber);
        }

        /// <summary>
        /// Serializes a <see cref="ArrayOfNumberOnly" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="arrayOfNumberOnly"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ArrayOfNumberOnly arrayOfNumberOnly, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, arrayOfNumberOnly, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ArrayOfNumberOnly" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="arrayOfNumberOnly"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, ArrayOfNumberOnly arrayOfNumberOnly, JsonSerializerOptions jsonSerializerOptions)
        {
            if (arrayOfNumberOnly.ArrayNumberOption.IsSet && arrayOfNumberOnly.ArrayNumber == null)
                throw new ArgumentNullException(nameof(arrayOfNumberOnly.ArrayNumber), "Property is required for class ArrayOfNumberOnly.");

            if (arrayOfNumberOnly.ArrayNumberOption.IsSet)
            {
                writer.WritePropertyName("ArrayNumber");
                JsonSerializer.Serialize(writer, arrayOfNumberOnly.ArrayNumber, jsonSerializerOptions);
            }
        }
    }
}
