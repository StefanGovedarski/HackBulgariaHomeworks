CREATE TABLE Books
(
BookID int NOT NULL PRIMARY KEY,
BookResume ntext NULL,
DatePublised smalldatetime NOT NULL,
Publisher nvarchar(40) NOT NULL,
Pages int NULL,
ISBN nvarchar(4) NOT NULL,
Quantity Bit NOT NULL,

);

CREATE TABLE Authors
(
AuthorID int NOT NULL PRIMARY KEY,
FirstName nvarchar(25) NOT NULL,
LastName nvarchar(25) NOT NULL,
YearBorn int NOT NULL,
YearDied int NULL,
BooksWritten int NULL,
);

CREATE TABLE Genres
(
GenreID int NOT NULL PRIMARY KEY,
Name nvarchar(20) NOT NULL,
);

CREATE TABLE Users
(
UserID int NOT NULL PRIMARY KEY,
FirstName nvarchar(25) NOT NULL,
LastName nvarchar(25) NOT NULL,
Pseudonim nvarchar(25) NULL,
Email nvarchar(25) NOT NULL,
Phone  BIGINT NULL,
BookTaken BIT NOT NULL,
BookID int NULL REFERENCES Books(BookID),
);

CREATE TABLE BooksAuthors
(
BookID int NOT NULL ,
AuthorID int NOT NULL,
);
CREATE TABLE BooksGenres
(
BookID int NOT NULL,
GenreID int NOT NULL,
);


ALTER TABLE BooksAuthors
ADD CONSTRAINT pk_ PRIMARY KEY(BookID,AuthorID)

ALTER TABLE BooksGenres
ADD CONSTRAINT pk__ PRIMARY KEY(BookID,GenreID)

ALTER TABLE BooksAuthors
ADD FOREIGN KEY (BookID) REFERENCES Books(BookID)

ALTER TABLE BooksAuthors
ADD FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID)

ALTER TABLE BooksGenres
ADD FOREIGN KEY (BookID) REFERENCES Books(BookID)

ALTER TABLE BooksGenres
ADD FOREIGN KEY (GenreID) REFERENCES Genres(GenreID)