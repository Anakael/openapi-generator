/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI-Generator 7.3.0-SNAPSHOT.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

/*
 * TestInlineFreeformAdditionalProperties_request.h
 *
 * 
 */

#ifndef TestInlineFreeformAdditionalProperties_request_H_
#define TestInlineFreeformAdditionalProperties_request_H_



#include <string>
#include <map>
#include "AnyType.h"
#include <memory>
#include <vector>
#include <boost/property_tree/ptree.hpp>
#include "helpers.h"

namespace org {
namespace openapitools {
namespace server {
namespace model {

/// <summary>
/// 
/// </summary>
class  TestInlineFreeformAdditionalProperties_request 
{
public:
    TestInlineFreeformAdditionalProperties_request() = default;
    explicit TestInlineFreeformAdditionalProperties_request(boost::property_tree::ptree const& pt);
    virtual ~TestInlineFreeformAdditionalProperties_request() = default;

    TestInlineFreeformAdditionalProperties_request(const TestInlineFreeformAdditionalProperties_request& other) = default; // copy constructor
    TestInlineFreeformAdditionalProperties_request(TestInlineFreeformAdditionalProperties_request&& other) noexcept = default; // move constructor

    TestInlineFreeformAdditionalProperties_request& operator=(const TestInlineFreeformAdditionalProperties_request& other) = default; // copy assignment
    TestInlineFreeformAdditionalProperties_request& operator=(TestInlineFreeformAdditionalProperties_request&& other) noexcept = default; // move assignment

    std::string toJsonString(bool prettyJson = false) const;
    void fromJsonString(std::string const& jsonString);
    boost::property_tree::ptree toPropertyTree() const;
    void fromPropertyTree(boost::property_tree::ptree const& pt);


    /////////////////////////////////////////////
    /// TestInlineFreeformAdditionalProperties_request members

    /// <summary>
    /// 
    /// </summary>
    std::string getSomeProperty() const;
    void setSomeProperty(std::string value);

protected:
    std::string m_SomeProperty = "";
};

std::vector<TestInlineFreeformAdditionalProperties_request> createTestInlineFreeformAdditionalProperties_requestVectorFromJsonString(const std::string& json);

template<>
inline boost::property_tree::ptree toPt<TestInlineFreeformAdditionalProperties_request>(const TestInlineFreeformAdditionalProperties_request& val) {
    return val.toPropertyTree();
}

template<>
inline TestInlineFreeformAdditionalProperties_request fromPt<TestInlineFreeformAdditionalProperties_request>(const boost::property_tree::ptree& pt) {
    TestInlineFreeformAdditionalProperties_request ret;
    ret.fromPropertyTree(pt);
    return ret;
}

}
}
}
}

#endif /* TestInlineFreeformAdditionalProperties_request_H_ */
