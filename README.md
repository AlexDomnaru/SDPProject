# SDPProject
## Description

## Architecture
Architecturally speaking, the project's structure follows the Onion Architecture, meaning that there a 4 main projects in a solution.
The projects are as follows: 
- **Data.Domain**
- **Data.Persistence**
- **Business**
- **Presentation**

------------------------------
### 1. Data.Domain  
The domain layer contains all the entities used in the database.

### 2. Data.Persistence
The persistence layer contains the database contexts for the forms, as well as other content (in this case, other content would be a list of possible addresses that belong to a postcode)

### 3. Business
Given that this project makes use of the repository pattern, the business layer holds the repositories required to 
interact with the database context from the previous layer, and their respective interfaces.

### 4. Presentation  
The presentation layer contains all that's required to manage the interaction between the user and the database. 
That is, the views, the models that are used by the views, the controllers, and other classes that are used by them.

#### 4.1 Models  
Models used in this project are contained here, as well as any model helper class
(such as the profiles used to map the model to its respective entity in the database).
There are also custom validators, used in the AboutYouModel (UkNumber, used to validate the phone number that the user inputs, and MinYear, used to prevent
years lower than 1919 from being used in the form <--not working)

#### 4.2 Controllers
There's only one controller, QuoteController, which handles all the requests from the users, and it features 4 main methods (2 get methods, and 2 post methods, 1 for each page).
The [HttpGet] methods return the respective views, after they check whether the current session already contains the ID of a form completed in the last 30 minutes.
If there is such a form, it is retrieved from the database, and the view is returned with the fields prepopulated.

The [HttpPost] methods handle the forms posted from the views. If the form posted is valid, then a new ID is generated for that form, which is stored in the current session, and the form is stored in the database.
If the form contains errors, then the same view with the errors is returned.

#### 4.3 Views
------------------------------
##### 4.3.1 PersonalInformation1
This view uses the AboutYouModel as model, and it features client side validation for the required fields, as well as custom phone number validation.
There's also the "Find My Address" button, which takes the postcode input by the user and checks whether it is a valid postcode (theoretically, this function
should validate the postcode against a database, but in this case, the postcode **NN16 0RZ** is hardcoded). If is valid, then a dropdown containing (again, hardcoded) addresses that belong to that postcode.
If it is invalid, then a warning is displayed, and it gives the user the possibility to manually input the address.

##### 4.3.2 PersonalInformation2
This view uses the RiderDetailsModels as model. It is incomplete, but it should have featured a way to display different dropdown lists, according to the occupation type chosen (same dropdown for Employed and Self Employed, different dropdown for In Education).
It should also have been possible to add claims, and convictions.

------------------------------
**DISCLAIMER: THE PROJECT IS INCOMPLETE**
