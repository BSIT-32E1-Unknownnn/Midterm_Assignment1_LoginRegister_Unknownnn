This project uses Onion Architecture.

Login and Register

User enters login credentials in the view.
Controller receives the login request and calls the login service.
Login service validates the credentials against the user repository.
The repository interface is used to access and verify user data in the in-memory database.
If valid, the login service returns a successful login response to the controller.
The controller can then redirect the user to the appropriate dashboard or profile page.
If invalid, the login service returns an error response to the controller.
The controller can display an error message to the user.

Registration Process

User enters registration details in the view.
Controller receives the registration request and calls the registration service.
Registration service validates the user data and checks for existing users.
If valid, the registration service creates a new user entity.
The repository interface is used to save the new user data in the in-memory database.
Registration service returns a successful registration response to the controller.
The controller can redirect the user to a confirmation page or login page.
If invalid, the registration service returns an error response with specific reasons like username already exists.
The controller can display the error messages to the user.
