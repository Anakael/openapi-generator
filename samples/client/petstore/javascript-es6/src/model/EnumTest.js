/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */

import ApiClient from '../ApiClient';
import OuterEnum from './OuterEnum';
import OuterEnumDefaultValue from './OuterEnumDefaultValue';
import OuterEnumInteger from './OuterEnumInteger';
import OuterEnumIntegerDefaultValue from './OuterEnumIntegerDefaultValue';

/**
 * The EnumTest model module.
 * @module model/EnumTest
 * @version 1.0.0
 */
class EnumTest {
    /**
     * Constructs a new <code>EnumTest</code>.
     * @alias module:model/EnumTest
     * @param enumStringRequired {module:model/EnumTest.EnumStringRequiredEnum} 
     */
    constructor(enumStringRequired) { 
        
        EnumTest.initialize(this, enumStringRequired);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj, enumStringRequired) { 
        obj['enum_string_required'] = enumStringRequired;
    }

    /**
     * Constructs a <code>EnumTest</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/EnumTest} obj Optional instance to populate.
     * @return {module:model/EnumTest} The populated <code>EnumTest</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new EnumTest();

            if (data.hasOwnProperty('enum_string')) {
                obj['enum_string'] = ApiClient.convertToType(data['enum_string'], 'String');
            }
            if (data.hasOwnProperty('enum_string_required')) {
                obj['enum_string_required'] = ApiClient.convertToType(data['enum_string_required'], 'String');
            }
            if (data.hasOwnProperty('enum_integer')) {
                obj['enum_integer'] = ApiClient.convertToType(data['enum_integer'], 'Number');
            }
            if (data.hasOwnProperty('enum_number')) {
                obj['enum_number'] = ApiClient.convertToType(data['enum_number'], 'Number');
            }
            if (data.hasOwnProperty('outerEnum')) {
                obj['outerEnum'] = OuterEnum.constructFromObject(data['outerEnum']);
            }
            if (data.hasOwnProperty('outerEnumInteger')) {
                obj['outerEnumInteger'] = OuterEnumInteger.constructFromObject(data['outerEnumInteger']);
            }
            if (data.hasOwnProperty('outerEnumDefaultValue')) {
                obj['outerEnumDefaultValue'] = OuterEnumDefaultValue.constructFromObject(data['outerEnumDefaultValue']);
            }
            if (data.hasOwnProperty('outerEnumIntegerDefaultValue')) {
                obj['outerEnumIntegerDefaultValue'] = OuterEnumIntegerDefaultValue.constructFromObject(data['outerEnumIntegerDefaultValue']);
            }
        }
        return obj;
    }

    /**
     * Validates the JSON data with respect to <code>EnumTest</code>.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @return {boolean} to indicate whether the JSON data is valid with respect to <code>EnumTest</code>.
     */
    static validateJSON(data) {
        // check to make sure all required properties are present in the JSON string
        for (const property of EnumTest.RequiredProperties) {
            if (!data.hasOwnProperty(property)) {
                throw new Error("The required field `" + property + "` is not found in the JSON data: " + JSON.stringify(data));
            }
        }
        // ensure the json data is a string
        if (data['enum_string'] && !(typeof data['enum_string'] === 'string' || data['enum_string'] instanceof String)) {
            throw new Error("Expected the field `enum_string` to be a primitive type in the JSON string but got " + data['enum_string']);
        }
        // ensure the json data is a string
        if (data['enum_string_required'] && !(typeof data['enum_string_required'] === 'string' || data['enum_string_required'] instanceof String)) {
            throw new Error("Expected the field `enum_string_required` to be a primitive type in the JSON string but got " + data['enum_string_required']);
        }

        return true;
    }


}

EnumTest.RequiredProperties = ["enum_string_required"];

/**
 * @member {module:model/EnumTest.EnumStringEnum} enum_string
 */
EnumTest.prototype['enum_string'] = undefined;

/**
 * @member {module:model/EnumTest.EnumStringRequiredEnum} enum_string_required
 */
EnumTest.prototype['enum_string_required'] = undefined;

/**
 * @member {module:model/EnumTest.EnumIntegerEnum} enum_integer
 */
EnumTest.prototype['enum_integer'] = undefined;

/**
 * @member {module:model/EnumTest.EnumNumberEnum} enum_number
 */
EnumTest.prototype['enum_number'] = undefined;

/**
 * @member {module:model/OuterEnum} outerEnum
 */
EnumTest.prototype['outerEnum'] = undefined;

/**
 * @member {module:model/OuterEnumInteger} outerEnumInteger
 */
EnumTest.prototype['outerEnumInteger'] = undefined;

/**
 * @member {module:model/OuterEnumDefaultValue} outerEnumDefaultValue
 */
EnumTest.prototype['outerEnumDefaultValue'] = undefined;

/**
 * @member {module:model/OuterEnumIntegerDefaultValue} outerEnumIntegerDefaultValue
 */
EnumTest.prototype['outerEnumIntegerDefaultValue'] = undefined;





/**
 * Allowed values for the <code>enum_string</code> property.
 * @enum {String}
 * @readonly
 */
EnumTest['EnumStringEnum'] = {

    /**
     * value: "UPPER"
     * @const
     */
    "UPPER": "UPPER",

    /**
     * value: "lower"
     * @const
     */
    "lower": "lower",

    /**
     * value: ""
     * @const
     */
    "empty": ""
};


/**
 * Allowed values for the <code>enum_string_required</code> property.
 * @enum {String}
 * @readonly
 */
EnumTest['EnumStringRequiredEnum'] = {

    /**
     * value: "UPPER"
     * @const
     */
    "UPPER": "UPPER",

    /**
     * value: "lower"
     * @const
     */
    "lower": "lower",

    /**
     * value: ""
     * @const
     */
    "empty": ""
};


/**
 * Allowed values for the <code>enum_integer</code> property.
 * @enum {Number}
 * @readonly
 */
EnumTest['EnumIntegerEnum'] = {

    /**
     * value: 1
     * @const
     */
    "1": 1,

    /**
     * value: -1
     * @const
     */
    "-1": -1
};


/**
 * Allowed values for the <code>enum_number</code> property.
 * @enum {Number}
 * @readonly
 */
EnumTest['EnumNumberEnum'] = {

    /**
     * value: 1.1
     * @const
     */
    "1.1": 1.1,

    /**
     * value: -1.2
     * @const
     */
    "-1.2": -1.2
};



export default EnumTest;

