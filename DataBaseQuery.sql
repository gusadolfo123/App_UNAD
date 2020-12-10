CREATE DATABASE UnadApp;
Go
USE UnadApp;
Go
CREATE TABLE Student(
	StudentId	INT IDENTITY PRIMARY KEY NOT NULL,
	Email		VARCHAR(100) NOT NULL,
	Document	VARCHAR(100) NOT NULL,
	Password	VARCHAR(100) NOT NULL
);
Go 
INSERT INTO Student(Email, Document, Password) 
VALUES('morenoga@unadvirtual.com','1022961238','wgc0A35tNuVdWHjYGbj9+A==');

