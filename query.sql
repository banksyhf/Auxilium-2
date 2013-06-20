CREATE TABLE [dbo].[Channel] (
    [Id]   TINYINT       IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Users] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [Username] NVARCHAR (24)   NOT NULL,
    [Password] NVARCHAR (40)   NOT NULL,
    [Email]    NVARCHAR (256)  NOT NULL,
    [Bio]      NVARCHAR (2048) NULL,
    [Avatar]   NVARCHAR (MAX)  NULL,
    [Forum]    NVARCHAR (256)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);