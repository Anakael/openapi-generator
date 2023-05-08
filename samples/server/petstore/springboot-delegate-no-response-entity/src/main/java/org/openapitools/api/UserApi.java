/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech) (6.6.0-SNAPSHOT).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */
package org.openapitools.api;

import java.util.List;
import java.time.OffsetDateTime;
import org.openapitools.model.User;
import io.swagger.annotations.*;
import org.springframework.http.HttpStatus;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.multipart.MultipartFile;

import javax.validation.Valid;
import javax.validation.constraints.*;
import java.util.List;
import java.util.Map;
import javax.annotation.Generated;

@Generated(value = "org.openapitools.codegen.languages.SpringCodegen")
@Validated
@Api(value = "user", description = "Operations about user")
public interface UserApi {

    default UserApiDelegate getDelegate() {
        return new UserApiDelegate() {};
    }

    /**
     * POST /user : Create user
     * This can only be done by the logged in user.
     *
     * @param user Created user object (required)
     * @return successful operation (status code 200)
     */
    @ApiOperation(
        tags = { "user" },
        value = "Create user",
        nickname = "createUser",
        notes = "This can only be done by the logged in user.",
        authorizations = {
            @Authorization(value = "api_key")
         }
    )
    @ApiResponses({
        @ApiResponse(code = 200, message = "successful operation")
    })
    @RequestMapping(
        method = RequestMethod.POST,
        value = "/user",
        consumes = { "application/json" }
    )
    @ResponseStatus(HttpStatus.OK)
    default void createUser(
        @ApiParam(value = "Created user object", required = true) @Valid @RequestBody User user
    ) {
        getDelegate().createUser(user);
    }


    /**
     * POST /user/createWithArray : Creates list of users with given input array
     * 
     *
     * @param user List of user object (required)
     * @return successful operation (status code 200)
     */
    @ApiOperation(
        tags = { "user" },
        value = "Creates list of users with given input array",
        nickname = "createUsersWithArrayInput",
        notes = "",
        authorizations = {
            @Authorization(value = "api_key")
         }
    )
    @ApiResponses({
        @ApiResponse(code = 200, message = "successful operation")
    })
    @RequestMapping(
        method = RequestMethod.POST,
        value = "/user/createWithArray",
        consumes = { "application/json" }
    )
    @ResponseStatus(HttpStatus.OK)
    default void createUsersWithArrayInput(
        @ApiParam(value = "List of user object", required = true) @Valid @RequestBody List<User> user
    ) {
        getDelegate().createUsersWithArrayInput(user);
    }


    /**
     * POST /user/createWithList : Creates list of users with given input array
     * 
     *
     * @param user List of user object (required)
     * @return successful operation (status code 200)
     */
    @ApiOperation(
        tags = { "user" },
        value = "Creates list of users with given input array",
        nickname = "createUsersWithListInput",
        notes = "",
        authorizations = {
            @Authorization(value = "api_key")
         }
    )
    @ApiResponses({
        @ApiResponse(code = 200, message = "successful operation")
    })
    @RequestMapping(
        method = RequestMethod.POST,
        value = "/user/createWithList",
        consumes = { "application/json" }
    )
    @ResponseStatus(HttpStatus.OK)
    default void createUsersWithListInput(
        @ApiParam(value = "List of user object", required = true) @Valid @RequestBody List<User> user
    ) {
        getDelegate().createUsersWithListInput(user);
    }


    /**
     * DELETE /user/{username} : Delete user
     * This can only be done by the logged in user.
     *
     * @param username The name that needs to be deleted (required)
     * @return Invalid username supplied (status code 400)
     *         or User not found (status code 404)
     */
    @ApiOperation(
        tags = { "user" },
        value = "Delete user",
        nickname = "deleteUser",
        notes = "This can only be done by the logged in user.",
        authorizations = {
            @Authorization(value = "api_key")
         }
    )
    @ApiResponses({
        @ApiResponse(code = 400, message = "Invalid username supplied"),
        @ApiResponse(code = 404, message = "User not found")
    })
    @RequestMapping(
        method = RequestMethod.DELETE,
        value = "/user/{username}"
    )
    @ResponseStatus(HttpStatus.BAD_REQUEST)
    default void deleteUser(
        @ApiParam(value = "The name that needs to be deleted", required = true) @PathVariable("username") String username
    ) {
        getDelegate().deleteUser(username);
    }


    /**
     * GET /user/{username} : Get user by user name
     * 
     *
     * @param username The name that needs to be fetched. Use user1 for testing. (required)
     * @return successful operation (status code 200)
     *         or Invalid username supplied (status code 400)
     *         or User not found (status code 404)
     */
    @ApiOperation(
        tags = { "user" },
        value = "Get user by user name",
        nickname = "getUserByName",
        notes = "",
        response = User.class
    )
    @ApiResponses({
        @ApiResponse(code = 200, message = "successful operation", response = User.class),
        @ApiResponse(code = 400, message = "Invalid username supplied"),
        @ApiResponse(code = 404, message = "User not found")
    })
    @RequestMapping(
        method = RequestMethod.GET,
        value = "/user/{username}",
        produces = { "application/xml", "application/json" }
    )
    @ResponseStatus(HttpStatus.OK)
    default User getUserByName(
        @ApiParam(value = "The name that needs to be fetched. Use user1 for testing.", required = true) @PathVariable("username") String username
    ) {
        return getDelegate().getUserByName(username);
    }


    /**
     * GET /user/login : Logs user into the system
     * 
     *
     * @param username The user name for login (required)
     * @param password The password for login in clear text (required)
     * @return successful operation (status code 200)
     *         or Invalid username/password supplied (status code 400)
     */
    @ApiOperation(
        tags = { "user" },
        value = "Logs user into the system",
        nickname = "loginUser",
        notes = "",
        response = String.class
    )
    @ApiResponses({
        @ApiResponse(code = 200, message = "successful operation", response = String.class),
        @ApiResponse(code = 400, message = "Invalid username/password supplied")
    })
    @RequestMapping(
        method = RequestMethod.GET,
        value = "/user/login",
        produces = { "application/xml", "application/json" }
    )
    @ResponseStatus(HttpStatus.OK)
    default String loginUser(
        @NotNull @Pattern(regexp = "^[a-zA-Z0-9]+[a-zA-Z0-9\\.\\-_]*[a-zA-Z0-9]+$") @ApiParam(value = "The user name for login", required = true) @Valid @RequestParam(value = "username", required = true) String username,
        @NotNull @ApiParam(value = "The password for login in clear text", required = true) @Valid @RequestParam(value = "password", required = true) String password
    ) {
        return getDelegate().loginUser(username, password);
    }


    /**
     * GET /user/logout : Logs out current logged in user session
     * 
     *
     * @return successful operation (status code 200)
     */
    @ApiOperation(
        tags = { "user" },
        value = "Logs out current logged in user session",
        nickname = "logoutUser",
        notes = "",
        authorizations = {
            @Authorization(value = "api_key")
         }
    )
    @ApiResponses({
        @ApiResponse(code = 200, message = "successful operation")
    })
    @RequestMapping(
        method = RequestMethod.GET,
        value = "/user/logout"
    )
    @ResponseStatus(HttpStatus.OK)
    default void logoutUser(
        
    ) {
        getDelegate().logoutUser();
    }


    /**
     * PUT /user/{username} : Updated user
     * This can only be done by the logged in user.
     *
     * @param username name that need to be deleted (required)
     * @param user Updated user object (required)
     * @return Invalid user supplied (status code 400)
     *         or User not found (status code 404)
     */
    @ApiOperation(
        tags = { "user" },
        value = "Updated user",
        nickname = "updateUser",
        notes = "This can only be done by the logged in user.",
        authorizations = {
            @Authorization(value = "api_key")
         }
    )
    @ApiResponses({
        @ApiResponse(code = 400, message = "Invalid user supplied"),
        @ApiResponse(code = 404, message = "User not found")
    })
    @RequestMapping(
        method = RequestMethod.PUT,
        value = "/user/{username}",
        consumes = { "application/json" }
    )
    @ResponseStatus(HttpStatus.BAD_REQUEST)
    default void updateUser(
        @ApiParam(value = "name that need to be deleted", required = true) @PathVariable("username") String username,
        @ApiParam(value = "Updated user object", required = true) @Valid @RequestBody User user
    ) {
        getDelegate().updateUser(username, user);
    }

}