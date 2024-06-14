
CREATE PROCEDURE sproc_tblStaff_Insert 

@FirstName varchar (50),
@LastName  varchar (50),
@Position varchar (50),
@Gender varchar (50),
@Address varchar (50),
@Email varchar (30),
@IsActive bit,
@DateHired date


AS
	INSERT INTO tblStaff (FirstName, LastName, Gender, Position, DateHired, Address, Email, IsActive)
	values (@FirstName, @LastName, @Gender, @Position, @DateHired, @Address, @Email, @IsActive)

RETURN @@Identity 
