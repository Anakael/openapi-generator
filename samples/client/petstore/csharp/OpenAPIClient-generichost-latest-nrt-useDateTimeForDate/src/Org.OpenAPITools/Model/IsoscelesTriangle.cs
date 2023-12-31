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
    /// IsoscelesTriangle
    /// </summary>
    public partial class IsoscelesTriangle : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsoscelesTriangle" /> class.
        /// </summary>
        /// <param name="shapeType">shapeType</param>
        /// <param name="triangleType">triangleType</param>
        [JsonConstructor]
        public IsoscelesTriangle(string shapeType, string triangleType)
        {
            ShapeType = shapeType;
            TriangleType = triangleType;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets ShapeType
        /// </summary>
        [JsonPropertyName("shapeType")]
        public string ShapeType { get; set; }

        /// <summary>
        /// Gets or Sets TriangleType
        /// </summary>
        [JsonPropertyName("triangleType")]
        public string TriangleType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IsoscelesTriangle {\n");
            sb.Append("  ShapeType: ").Append(ShapeType).Append("\n");
            sb.Append("  TriangleType: ").Append(TriangleType).Append("\n");
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
    /// A Json converter for type <see cref="IsoscelesTriangle" />
    /// </summary>
    public class IsoscelesTriangleJsonConverter : JsonConverter<IsoscelesTriangle>
    {
        /// <summary>
        /// Deserializes json to <see cref="IsoscelesTriangle" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override IsoscelesTriangle Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> shapeType = default;
            Option<string?> triangleType = default;

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
                        case "shapeType":
                            shapeType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "triangleType":
                            triangleType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!shapeType.IsSet)
                throw new ArgumentException("Property is required for class IsoscelesTriangle.", nameof(shapeType));

            if (!triangleType.IsSet)
                throw new ArgumentException("Property is required for class IsoscelesTriangle.", nameof(triangleType));

            if (shapeType.IsSet && shapeType.Value == null)
                throw new ArgumentNullException(nameof(shapeType), "Property is not nullable for class IsoscelesTriangle.");

            if (triangleType.IsSet && triangleType.Value == null)
                throw new ArgumentNullException(nameof(triangleType), "Property is not nullable for class IsoscelesTriangle.");

            return new IsoscelesTriangle(shapeType.Value!, triangleType.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="IsoscelesTriangle" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="isoscelesTriangle"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, IsoscelesTriangle isoscelesTriangle, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, isoscelesTriangle, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="IsoscelesTriangle" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="isoscelesTriangle"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, IsoscelesTriangle isoscelesTriangle, JsonSerializerOptions jsonSerializerOptions)
        {
            if (isoscelesTriangle.ShapeType == null)
                throw new ArgumentNullException(nameof(isoscelesTriangle.ShapeType), "Property is required for class IsoscelesTriangle.");

            if (isoscelesTriangle.TriangleType == null)
                throw new ArgumentNullException(nameof(isoscelesTriangle.TriangleType), "Property is required for class IsoscelesTriangle.");

            writer.WriteString("shapeType", isoscelesTriangle.ShapeType);

            writer.WriteString("triangleType", isoscelesTriangle.TriangleType);
        }
    }
}
