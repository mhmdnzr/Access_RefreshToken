
# Access & Refresh Token
In most of the applications that are written today, authorization is the first word.
The audience of this repository is people who just started asp.net web Api.
## Acknowledgements

 - [What is authorization?](https://www.ibm.com/support/pages/understanding-application-authentication-and-authorization-security#:~:text=Authorization%20%2D%20Where%20someone%20is%20given,disallow%20access%20to%20the%20application.)
 - [What is token?](https://www.devopsschool.com/blog/what-is-bearer-token-and-how-it-works/)

## API Reference

#### Login User

```http
  POST /api/Users/login
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `Email` | `string` | **Required**. |
| `Password` | `string` | **Required**. |

#### Get new refresh token

```http
  POST /api/Users/refresh_token
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `UserId`      | `integer($int32)` | **Required**. |
| `RefreshToken`      | `string` | **Required**. |


#### Create new user

```http
  POST /api/Users/signup
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `Email`      | `integer($int32)` | **Required**. |
| `Password`      | `string` | **Required**. |
| `ConfirmPassword`      | `string` | **Required**. |
| `FirstName`      | `string` | **Required**. |
| `LastName`      | `string` | **Required**. |


#### User logout

```http
  POST /api/Users/logout
```




## Authors

- [@mhmdnzr](https://www.github.com/mhmdnzr)


## License

[MIT](https://choosealicense.com/licenses/mit/)


## Screenshots

![App Screenshot](./Screenshot.png)



## Tech Stack

**Server:** Asp.net, SQL server, Swagger

