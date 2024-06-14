CREATE TABLE [dbo].[tblStaff] (
    [StaffId]   INT          NOT NULL,
    [Address]   VARCHAR (50) NULL,
    [DateHired] DATE         NULL,
    [Email]     VARCHAR (50) NULL,
    [FirstName] VARCHAR (50) NULL,
    [LastName]  VARCHAR (50) NULL,
    [Gender]    VARCHAR (50) NULL,
    [Position]  VARCHAR (50) NULL,
    [IsActive ] BIT NULL, 
    PRIMARY KEY CLUSTERED ([StaffId] ASC)
);

