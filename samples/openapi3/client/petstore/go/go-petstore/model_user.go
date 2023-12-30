/*
OpenAPI Petstore

This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\

API version: 1.0.0
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package petstore

import (
	"encoding/json"
)

// checks if the User type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &User{}

// User struct for User
type User struct {
	Id *int64 `json:"id,omitempty"`
	Username *string `json:"username,omitempty"`
	FirstName *string `json:"firstName,omitempty"`
	LastName *string `json:"lastName,omitempty"`
	Email *string `json:"email,omitempty"`
	Password *string `json:"password,omitempty"`
	Phone *string `json:"phone,omitempty"`
	// User Status
	UserStatus *int32 `json:"userStatus,omitempty"`
	// test code generation for objects Value must be a map of strings to values. It cannot be the 'null' value.
	ArbitraryObject map[string]interface{} `json:"arbitraryObject,omitempty"`
	// test code generation for nullable objects. Value must be a map of strings to values or the 'null' value.
	ArbitraryNullableObject map[string]interface{} `json:"arbitraryNullableObject,omitempty"`
	// test code generation for any type Value can be any type - string, number, boolean, array or object.
	ArbitraryTypeValue interface{} `json:"arbitraryTypeValue,omitempty"`
	// test code generation for any type Value can be any type - string, number, boolean, array, object or the 'null' value.
	ArbitraryNullableTypeValue interface{} `json:"arbitraryNullableTypeValue,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _User User

// NewUser instantiates a new User object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewUser() *User {
	this := User{}
	return &this
}

// NewUserWithDefaults instantiates a new User object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewUserWithDefaults() *User {
	this := User{}
	return &this
}

// GetId returns the Id field value if set, zero value otherwise.
func (o *User) GetId() int64 {
	if o == nil || IsNil(o.Id) {
		var ret int64
		return ret
	}
	return *o.Id
}

// GetIdOk returns a tuple with the Id field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *User) GetIdOk() (*int64, bool) {
	if o == nil || IsNil(o.Id) {
		return nil, false
	}
	return o.Id, true
}

// HasId returns a boolean if a field has been set.
func (o *User) HasId() bool {
	if o != nil && !IsNil(o.Id) {
		return true
	}

	return false
}

// SetId gets a reference to the given int64 and assigns it to the Id field.
func (o *User) SetId(v int64) {
	o.Id = &v
}

// GetUsername returns the Username field value if set, zero value otherwise.
func (o *User) GetUsername() string {
	if o == nil || IsNil(o.Username) {
		var ret string
		return ret
	}
	return *o.Username
}

// GetUsernameOk returns a tuple with the Username field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *User) GetUsernameOk() (*string, bool) {
	if o == nil || IsNil(o.Username) {
		return nil, false
	}
	return o.Username, true
}

// HasUsername returns a boolean if a field has been set.
func (o *User) HasUsername() bool {
	if o != nil && !IsNil(o.Username) {
		return true
	}

	return false
}

// SetUsername gets a reference to the given string and assigns it to the Username field.
func (o *User) SetUsername(v string) {
	o.Username = &v
}

// GetFirstName returns the FirstName field value if set, zero value otherwise.
func (o *User) GetFirstName() string {
	if o == nil || IsNil(o.FirstName) {
		var ret string
		return ret
	}
	return *o.FirstName
}

// GetFirstNameOk returns a tuple with the FirstName field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *User) GetFirstNameOk() (*string, bool) {
	if o == nil || IsNil(o.FirstName) {
		return nil, false
	}
	return o.FirstName, true
}

// HasFirstName returns a boolean if a field has been set.
func (o *User) HasFirstName() bool {
	if o != nil && !IsNil(o.FirstName) {
		return true
	}

	return false
}

// SetFirstName gets a reference to the given string and assigns it to the FirstName field.
func (o *User) SetFirstName(v string) {
	o.FirstName = &v
}

// GetLastName returns the LastName field value if set, zero value otherwise.
func (o *User) GetLastName() string {
	if o == nil || IsNil(o.LastName) {
		var ret string
		return ret
	}
	return *o.LastName
}

// GetLastNameOk returns a tuple with the LastName field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *User) GetLastNameOk() (*string, bool) {
	if o == nil || IsNil(o.LastName) {
		return nil, false
	}
	return o.LastName, true
}

// HasLastName returns a boolean if a field has been set.
func (o *User) HasLastName() bool {
	if o != nil && !IsNil(o.LastName) {
		return true
	}

	return false
}

// SetLastName gets a reference to the given string and assigns it to the LastName field.
func (o *User) SetLastName(v string) {
	o.LastName = &v
}

// GetEmail returns the Email field value if set, zero value otherwise.
func (o *User) GetEmail() string {
	if o == nil || IsNil(o.Email) {
		var ret string
		return ret
	}
	return *o.Email
}

// GetEmailOk returns a tuple with the Email field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *User) GetEmailOk() (*string, bool) {
	if o == nil || IsNil(o.Email) {
		return nil, false
	}
	return o.Email, true
}

// HasEmail returns a boolean if a field has been set.
func (o *User) HasEmail() bool {
	if o != nil && !IsNil(o.Email) {
		return true
	}

	return false
}

// SetEmail gets a reference to the given string and assigns it to the Email field.
func (o *User) SetEmail(v string) {
	o.Email = &v
}

// GetPassword returns the Password field value if set, zero value otherwise.
func (o *User) GetPassword() string {
	if o == nil || IsNil(o.Password) {
		var ret string
		return ret
	}
	return *o.Password
}

// GetPasswordOk returns a tuple with the Password field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *User) GetPasswordOk() (*string, bool) {
	if o == nil || IsNil(o.Password) {
		return nil, false
	}
	return o.Password, true
}

// HasPassword returns a boolean if a field has been set.
func (o *User) HasPassword() bool {
	if o != nil && !IsNil(o.Password) {
		return true
	}

	return false
}

// SetPassword gets a reference to the given string and assigns it to the Password field.
func (o *User) SetPassword(v string) {
	o.Password = &v
}

// GetPhone returns the Phone field value if set, zero value otherwise.
func (o *User) GetPhone() string {
	if o == nil || IsNil(o.Phone) {
		var ret string
		return ret
	}
	return *o.Phone
}

// GetPhoneOk returns a tuple with the Phone field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *User) GetPhoneOk() (*string, bool) {
	if o == nil || IsNil(o.Phone) {
		return nil, false
	}
	return o.Phone, true
}

// HasPhone returns a boolean if a field has been set.
func (o *User) HasPhone() bool {
	if o != nil && !IsNil(o.Phone) {
		return true
	}

	return false
}

// SetPhone gets a reference to the given string and assigns it to the Phone field.
func (o *User) SetPhone(v string) {
	o.Phone = &v
}

// GetUserStatus returns the UserStatus field value if set, zero value otherwise.
func (o *User) GetUserStatus() int32 {
	if o == nil || IsNil(o.UserStatus) {
		var ret int32
		return ret
	}
	return *o.UserStatus
}

// GetUserStatusOk returns a tuple with the UserStatus field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *User) GetUserStatusOk() (*int32, bool) {
	if o == nil || IsNil(o.UserStatus) {
		return nil, false
	}
	return o.UserStatus, true
}

// HasUserStatus returns a boolean if a field has been set.
func (o *User) HasUserStatus() bool {
	if o != nil && !IsNil(o.UserStatus) {
		return true
	}

	return false
}

// SetUserStatus gets a reference to the given int32 and assigns it to the UserStatus field.
func (o *User) SetUserStatus(v int32) {
	o.UserStatus = &v
}

// GetArbitraryObject returns the ArbitraryObject field value if set, zero value otherwise.
func (o *User) GetArbitraryObject() map[string]interface{} {
	if o == nil || IsNil(o.ArbitraryObject) {
		var ret map[string]interface{}
		return ret
	}
	return o.ArbitraryObject
}

// GetArbitraryObjectOk returns a tuple with the ArbitraryObject field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *User) GetArbitraryObjectOk() (map[string]interface{}, bool) {
	if o == nil || IsNil(o.ArbitraryObject) {
		return map[string]interface{}{}, false
	}
	return o.ArbitraryObject, true
}

// HasArbitraryObject returns a boolean if a field has been set.
func (o *User) HasArbitraryObject() bool {
	if o != nil && !IsNil(o.ArbitraryObject) {
		return true
	}

	return false
}

// SetArbitraryObject gets a reference to the given map[string]interface{} and assigns it to the ArbitraryObject field.
func (o *User) SetArbitraryObject(v map[string]interface{}) {
	o.ArbitraryObject = v
}

// GetArbitraryNullableObject returns the ArbitraryNullableObject field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *User) GetArbitraryNullableObject() map[string]interface{} {
	if o == nil {
		var ret map[string]interface{}
		return ret
	}
	return o.ArbitraryNullableObject
}

// GetArbitraryNullableObjectOk returns a tuple with the ArbitraryNullableObject field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *User) GetArbitraryNullableObjectOk() (map[string]interface{}, bool) {
	if o == nil || IsNil(o.ArbitraryNullableObject) {
		return map[string]interface{}{}, false
	}
	return o.ArbitraryNullableObject, true
}

// HasArbitraryNullableObject returns a boolean if a field has been set.
func (o *User) HasArbitraryNullableObject() bool {
	if o != nil && IsNil(o.ArbitraryNullableObject) {
		return true
	}

	return false
}

// SetArbitraryNullableObject gets a reference to the given map[string]interface{} and assigns it to the ArbitraryNullableObject field.
func (o *User) SetArbitraryNullableObject(v map[string]interface{}) {
	o.ArbitraryNullableObject = v
}

// GetArbitraryTypeValue returns the ArbitraryTypeValue field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *User) GetArbitraryTypeValue() interface{} {
	if o == nil {
		var ret interface{}
		return ret
	}
	return o.ArbitraryTypeValue
}

// GetArbitraryTypeValueOk returns a tuple with the ArbitraryTypeValue field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *User) GetArbitraryTypeValueOk() (*interface{}, bool) {
	if o == nil || IsNil(o.ArbitraryTypeValue) {
		return nil, false
	}
	return &o.ArbitraryTypeValue, true
}

// HasArbitraryTypeValue returns a boolean if a field has been set.
func (o *User) HasArbitraryTypeValue() bool {
	if o != nil && IsNil(o.ArbitraryTypeValue) {
		return true
	}

	return false
}

// SetArbitraryTypeValue gets a reference to the given interface{} and assigns it to the ArbitraryTypeValue field.
func (o *User) SetArbitraryTypeValue(v interface{}) {
	o.ArbitraryTypeValue = v
}

// GetArbitraryNullableTypeValue returns the ArbitraryNullableTypeValue field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *User) GetArbitraryNullableTypeValue() interface{} {
	if o == nil {
		var ret interface{}
		return ret
	}
	return o.ArbitraryNullableTypeValue
}

// GetArbitraryNullableTypeValueOk returns a tuple with the ArbitraryNullableTypeValue field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *User) GetArbitraryNullableTypeValueOk() (*interface{}, bool) {
	if o == nil || IsNil(o.ArbitraryNullableTypeValue) {
		return nil, false
	}
	return &o.ArbitraryNullableTypeValue, true
}

// HasArbitraryNullableTypeValue returns a boolean if a field has been set.
func (o *User) HasArbitraryNullableTypeValue() bool {
	if o != nil && IsNil(o.ArbitraryNullableTypeValue) {
		return true
	}

	return false
}

// SetArbitraryNullableTypeValue gets a reference to the given interface{} and assigns it to the ArbitraryNullableTypeValue field.
func (o *User) SetArbitraryNullableTypeValue(v interface{}) {
	o.ArbitraryNullableTypeValue = v
}

func (o User) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o User) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.Id) {
		toSerialize["id"] = o.Id
	}
	if !IsNil(o.Username) {
		toSerialize["username"] = o.Username
	}
	if !IsNil(o.FirstName) {
		toSerialize["firstName"] = o.FirstName
	}
	if !IsNil(o.LastName) {
		toSerialize["lastName"] = o.LastName
	}
	if !IsNil(o.Email) {
		toSerialize["email"] = o.Email
	}
	if !IsNil(o.Password) {
		toSerialize["password"] = o.Password
	}
	if !IsNil(o.Phone) {
		toSerialize["phone"] = o.Phone
	}
	if !IsNil(o.UserStatus) {
		toSerialize["userStatus"] = o.UserStatus
	}
	if !IsNil(o.ArbitraryObject) {
		toSerialize["arbitraryObject"] = o.ArbitraryObject
	}
	if o.ArbitraryNullableObject != nil {
		toSerialize["arbitraryNullableObject"] = o.ArbitraryNullableObject
	}
	if o.ArbitraryTypeValue != nil {
		toSerialize["arbitraryTypeValue"] = o.ArbitraryTypeValue
	}
	if o.ArbitraryNullableTypeValue != nil {
		toSerialize["arbitraryNullableTypeValue"] = o.ArbitraryNullableTypeValue
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *User) UnmarshalJSON(data []byte) (err error) {
	varUser := _User{}

	err = json.Unmarshal(data, &varUser)

	if err != nil {
		return err
	}

	*o = User(varUser)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "id")
		delete(additionalProperties, "username")
		delete(additionalProperties, "firstName")
		delete(additionalProperties, "lastName")
		delete(additionalProperties, "email")
		delete(additionalProperties, "password")
		delete(additionalProperties, "phone")
		delete(additionalProperties, "userStatus")
		delete(additionalProperties, "arbitraryObject")
		delete(additionalProperties, "arbitraryNullableObject")
		delete(additionalProperties, "arbitraryTypeValue")
		delete(additionalProperties, "arbitraryNullableTypeValue")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableUser struct {
	value *User
	isSet bool
}

func (v NullableUser) Get() *User {
	return v.value
}

func (v *NullableUser) Set(val *User) {
	v.value = val
	v.isSet = true
}

func (v NullableUser) IsSet() bool {
	return v.isSet
}

func (v *NullableUser) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableUser(val *User) *NullableUser {
	return &NullableUser{value: val, isSet: true}
}

func (v NullableUser) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableUser) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


