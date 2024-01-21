/**
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech) (7.3.0-SNAPSHOT).
* https://openapi-generator.tech
* Do not edit the class manually.
*/
package org.openapitools.mockserver.api;

import static com.github.tomakehurst.wiremock.client.WireMock.*;
import com.github.tomakehurst.wiremock.client.MappingBuilder;
import com.github.tomakehurst.wiremock.http.Fault;

public class StoreApiMockServer {

    public static MappingBuilder stubDeleteOrder400(@javax.annotation.Nonnull String orderId) {
        MappingBuilder stub = delete(urlPathTemplate("/store/order/{order_id}"))
            .willReturn(aResponse()
                .withStatus(400)
            );

        stub = stub.withPathParam("orderId", equalTo(orderId));

        return stub;
    }

    public static MappingBuilder stubDeleteOrder404(@javax.annotation.Nonnull String orderId) {
        MappingBuilder stub = delete(urlPathTemplate("/store/order/{order_id}"))
            .willReturn(aResponse()
                .withStatus(404)
            );

        stub = stub.withPathParam("orderId", equalTo(orderId));

        return stub;
    }

    public static MappingBuilder stubDeleteOrderFault(@javax.annotation.Nonnull String orderId, Fault fault) {
        MappingBuilder stub = delete(urlPathTemplate("/store/order/{order_id}"))
            .willReturn(aResponse()
                .withFault(fault)
            );

        stub = stub.withPathParam("orderId", equalTo(orderId));

        return stub;
    }




    public static MappingBuilder stubGetInventory200(String response) {
        MappingBuilder stub = get(urlPathEqualTo("/store/inventory"))
            .withHeader("Accept", havingExactly("application/json"))
            .withHeader("Authorization", matching(".*"))
            .willReturn(aResponse()
                .withStatus(200)
                .withHeader("Content-Type", "application/json")
                .withBody(response)
            );


        return stub;
    }

    public static MappingBuilder stubGetInventoryFault(Fault fault) {
        MappingBuilder stub = get(urlPathEqualTo("/store/inventory"))
            .withHeader("Accept", havingExactly("application/json"))
            .withHeader("Authorization", matching(".*"))
            .willReturn(aResponse()
                .withFault(fault)
            );


        return stub;
    }




    public static MappingBuilder stubGetOrderById200(@javax.annotation.Nonnull String orderId, String response) {
        MappingBuilder stub = get(urlPathTemplate("/store/order/{order_id}"))
            .withHeader("Accept", havingExactly("application/xml", "application/json"))
            .willReturn(aResponse()
                .withStatus(200)
                .withHeader("Content-Type", "application/xml")
                .withBody(response)
            );

        stub = stub.withPathParam("orderId", equalTo(orderId));

        return stub;
    }

    public static MappingBuilder stubGetOrderById400(@javax.annotation.Nonnull String orderId, String response) {
        MappingBuilder stub = get(urlPathTemplate("/store/order/{order_id}"))
            .withHeader("Accept", havingExactly("application/xml", "application/json"))
            .willReturn(aResponse()
                .withStatus(400)
                .withHeader("Content-Type", "application/xml")
                .withBody(response)
            );

        stub = stub.withPathParam("orderId", equalTo(orderId));

        return stub;
    }

    public static MappingBuilder stubGetOrderById404(@javax.annotation.Nonnull String orderId, String response) {
        MappingBuilder stub = get(urlPathTemplate("/store/order/{order_id}"))
            .withHeader("Accept", havingExactly("application/xml", "application/json"))
            .willReturn(aResponse()
                .withStatus(404)
                .withHeader("Content-Type", "application/xml")
                .withBody(response)
            );

        stub = stub.withPathParam("orderId", equalTo(orderId));

        return stub;
    }

    public static MappingBuilder stubGetOrderByIdFault(@javax.annotation.Nonnull String orderId, Fault fault) {
        MappingBuilder stub = get(urlPathTemplate("/store/order/{order_id}"))
            .withHeader("Accept", havingExactly("application/xml", "application/json"))
            .willReturn(aResponse()
                .withFault(fault)
            );

        stub = stub.withPathParam("orderId", equalTo(orderId));

        return stub;
    }

    public static String getOrderById200ResponseSample1() {
        return "{ \"petId\" : 6, \"quantity\" : 1, \"id\" : 0, \"shipDate\" : \"2000-01-23T04:56:07.000+00:00\", \"complete\" : false, \"status\" : \"placed\" }";
    }
    public static String getOrderById200ResponseSample2() {
        return "<Order> <id>123456789</id> <petId>123456789</petId> <quantity>123</quantity> <shipDate>2000-01-23T04:56:07.000Z</shipDate> <status>aeiou</status> <complete>true</complete> </Order>";
    }



    public static MappingBuilder stubPlaceOrder200(@javax.annotation.Nonnull String body, String response) {
        MappingBuilder stub = post(urlPathEqualTo("/store/order"))
            .withHeader("Accept", havingExactly("application/xml", "application/json"))
            .withRequestBody(equalToJson(body))
            .willReturn(aResponse()
                .withStatus(200)
                .withHeader("Content-Type", "application/xml")
                .withBody(response)
            );


        return stub;
    }

    public static MappingBuilder stubPlaceOrder400(@javax.annotation.Nonnull String body, String response) {
        MappingBuilder stub = post(urlPathEqualTo("/store/order"))
            .withHeader("Accept", havingExactly("application/xml", "application/json"))
            .withRequestBody(equalToJson(body))
            .willReturn(aResponse()
                .withStatus(400)
                .withHeader("Content-Type", "application/xml")
                .withBody(response)
            );


        return stub;
    }

    public static MappingBuilder stubPlaceOrderFault(@javax.annotation.Nonnull String body, Fault fault) {
        MappingBuilder stub = post(urlPathEqualTo("/store/order"))
            .withHeader("Accept", havingExactly("application/xml", "application/json"))
            .withRequestBody(equalToJson(body))
            .willReturn(aResponse()
                .withFault(fault)
            );


        return stub;
    }

    public static String placeOrder200ResponseSample1() {
        return "{ \"petId\" : 6, \"quantity\" : 1, \"id\" : 0, \"shipDate\" : \"2000-01-23T04:56:07.000+00:00\", \"complete\" : false, \"status\" : \"placed\" }";
    }
    public static String placeOrder200ResponseSample2() {
        return "<Order> <id>123456789</id> <petId>123456789</petId> <quantity>123</quantity> <shipDate>2000-01-23T04:56:07.000Z</shipDate> <status>aeiou</status> <complete>true</complete> </Order>";
    }

    public static String placeOrderRequestSample1() {
        return "{ \"petId\" : 6, \"quantity\" : 1, \"id\" : 0, \"shipDate\" : \"2000-01-23T04:56:07.000+00:00\", \"complete\" : false, \"status\" : \"placed\" }";
    }


}
