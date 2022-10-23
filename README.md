# Quality Assurance in C #

 Quality Assurance in C # is a demonstration
 of quality assurance and C # skills.     
    #3.  UNIT TEST PROJECT:
	    
	    
   
To run the project do the following: Clone github.com/deartc/Quality-Project-Teresa-Hawkins. The extensions used were C# and Net.  The NuGets used were xunit.  


Requirements of classes completion: 
1. On the Vehicle class, add unit tests  and refactor where necessary.
2. On the SemiTruck class, implement all methods and write unit tests. 
3. Add the car class, implement it, and add unit tests for it.
4. Add the cargo class, and add unit tests for it. 




Unit tests requirements:
1.	parameterless constructor -object of type Vehicle, 
2.	Vehicle, -public properties to the provided values.

3.	 parameterless AddGas method fills the gas tank to 100% of its capacity
4.	 AddGas method with a parameter adds the supplied amount of gas to the gas tank.
5.	AddGas GasOverfillException – how much add and what the capacity was.
6.	 GasLevel -a  0%, 25%, 50%, 75%, and 100%..  (theory test)
7.	Drive method: without gas returns the status string “Cannot drive, out of gas.”
8.	 drive a car - flat tire returns the status string “Cannot drive due to flat tire.”.
9.	Drive the car 10 miles. GasLevel MilesRemaining mileage correct.
10.	Drive the car 100 miles. GasLevel MilesRemaining mileage correct.
11.	Out of gas. GasLevel MilesRemaining mileage correct.






12.	ChangeTireAsync will throw a NoTireToChangeException 
13.	ChangeTireAsync can successfully be used to change a flat tire
14.	 GotFlatTire method Refactor GotFlatTire can be both true and false. 
15.	 SemiTruck object which is also a Vehicle and has 18 wheels







16.	Cargo property -CargoItems which is empty, but not null.
17.	LoadCargo: correctly adds the passed object to the Cargo.
18.	UnloadCargo Positive Test: remove  from the Cargo and return cargo 
19.	CargoIUnloadCargo Negative Test: Verify that attempting to unload a CargoItem that does not appear in the Cargo throws a System.ArgumentException.
20.	GetCargoItemsByName Positive Test: item that exist returns all items wit exactly that name. 
21.	GetCargoItemsByName Negative Test: does not exist returns an empty list.
22.	GetCargoItemsByPartialDescription Positive Test: contain that Description.
23.	GetCargoItemsByPartialDescription Negative Test does not exist returns an empty list.
24.	GetTotalNumberOfItems: sum of all quantities of all items in the Cargo List.







25.	Car instances are also Vehicles and have 4 tires.




26.	IsValidModelForMakeAsync test: 
27.	WasModelMadeInYearAsync Negative Test: before 1995 System.ArgumentException.
28.	WasModelMadeInYearAsync Positive Tests:  Make that does not exist at all returns false
29.	Make Honda, Model Camry returns false (regardless of year).
30.	Make Subaru, Model WRX returns true for year 2020.
31.	Make Subaru, Model WRX returns false for year 2000.







32.	AddPassengers test: reduces the fuel economy of the car by .2 per passenger.
33.	RemovePassengers test:  Car with 5 passengers that gets 21 MPG.
34.	RemovePassengers  2 passengers and gets 20.6 MPG.
35.	RemovePassengers 0 passengers and gets 21 MPG
36.	RemovePassengers 0 passengers and gets 21 MPG.










 