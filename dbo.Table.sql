CREATE TABLE [dbo].[tblAddress] (
    [AddressId]  INT         IDENTITY (1, 1) NOT NULL,
    [HouseNo]    VARCHAR (6) NULL,
    [Street]     NCHAR (50)  NULL,
    [Town]       NCHAR (50)  NULL,
    [PostCode]   NCHAR (9)   NULL,
    [CountyCode] INT         NULL,
    [DateAdded]  DATE        NULL,
    [Active]     BIT         NULL,
    PRIMARY KEY CLUSTERED ([AddressId] ASC)
);

