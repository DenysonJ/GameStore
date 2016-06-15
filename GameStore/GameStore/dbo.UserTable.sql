CREATE TABLE [dbo].[UserTable] (
    [UserID]    INT            NOT NULL,
    [UserName]  NVARCHAR (50)  NOT NULL,
    [BirthDate] DATE           NOT NULL,
    [Password]  NVARCHAR(50)     NOT NULL,
    [email]     NVARCHAR (50)  NULL,
    [Phone]     INT            NULL,
    [List]      NVARCHAR (MAX) NULL,
    [Rented]    INT            NULL,
    [History]   NVARCHAR (MAX) NULL,
    [Login]     NCHAR (10)     NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC)
);

