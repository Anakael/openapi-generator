// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

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
    /// test map of maps
    /// </summary>
    public partial class Activity : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        /// <param name="activityOutputs">activityOutputs</param>
        [JsonConstructor]
        public Activity(Option<Dictionary<string, List<ActivityOutputElementRepresentation>>> activityOutputs = default)
        {
            ActivityOutputsOption = activityOutputs;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ActivityOutputs
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Dictionary<string, List<ActivityOutputElementRepresentation>>> ActivityOutputsOption { get; private set; }

        /// <summary>
        /// Gets or Sets ActivityOutputs
        /// </summary>
        [JsonPropertyName("activity_outputs")]
        public Dictionary<string, List<ActivityOutputElementRepresentation>> ActivityOutputs { get { return this. ActivityOutputsOption; } set { this.ActivityOutputsOption = new(value); } }

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
            sb.Append("class Activity {\n");
            sb.Append("  ActivityOutputs: ").Append(ActivityOutputs).Append("\n");
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
    /// A Json converter for type <see cref="Activity" />
    /// </summary>
    public class ActivityJsonConverter : JsonConverter<Activity>
    {
        /// <summary>
        /// Deserializes json to <see cref="Activity" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Activity Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Dictionary<string, List<ActivityOutputElementRepresentation>>> activityOutputs = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "activity_outputs":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                activityOutputs = new Option<Dictionary<string, List<ActivityOutputElementRepresentation>>>(JsonSerializer.Deserialize<Dictionary<string, List<ActivityOutputElementRepresentation>>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (activityOutputs.IsSet && activityOutputs.Value == null)
                throw new ArgumentNullException(nameof(activityOutputs), "Property is not nullable for class Activity.");

            return new Activity(activityOutputs);
        }

        /// <summary>
        /// Serializes a <see cref="Activity" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="activity"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Activity activity, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, activity, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Activity" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="activity"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, Activity activity, JsonSerializerOptions jsonSerializerOptions)
        {
            if (activity.ActivityOutputsOption.IsSet && activity.ActivityOutputs == null)
                throw new ArgumentNullException(nameof(activity.ActivityOutputs), "Property is required for class Activity.");

            if (activity.ActivityOutputsOption.IsSet)
            {
                writer.WritePropertyName("activity_outputs");
                JsonSerializer.Serialize(writer, activity.ActivityOutputs, jsonSerializerOptions);
            }
        }
    }
}
