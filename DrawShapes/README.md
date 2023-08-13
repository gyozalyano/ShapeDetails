# DrawShapes
DrawShapes is a console app which takes user inputs for a few geometric shapes and prints these details. 
It does not draw actual shapes. The solution features Factory Method Design Pattern and DI for user input. 
This design is selected to provide a later of abstraction and DI is used for making the solution testable. 
A potential alternative design, where circle inherits from ellipse or square inherits from rectangle was 
considered but not taken as that would have violated Liskov Substitution from SOLID principles. 

Extensions: Currently, the constructors of each Shape take only one parameter for simplicity. 
We can instead allow them to take several IUserInput parameters. This could make the tests more robust. 
Current tests provide an example, but more extensive testing can be added for Shape classes as well as for 
user inputs in Program class. 
