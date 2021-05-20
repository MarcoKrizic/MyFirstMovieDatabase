USE "Assignment2DB"
GO

CREATE TABLE "Movies" (
	"MovieName" nvarchar(35) NOT NULL,
	"ISBNNumber" numeric(20) NULL,
	"ReleaseYear" numeric(6) NOT NULL,
	"Location" nvarchar(10) NOT NULL,
	"Genre" nvarchar(12) NOT NULL,
	"Rating" numeric (3) NULL,
	"Duration" numeric(5) NOT NULL,
	"Price" decimal(5, 2) NOT NULL,
)

INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('ERASERHEAD', 111222333444555, 1977, 'USA', 'art', 4, 89, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('PI', 111211333444555, 1998, 'USA', 'art', 4, 85, 29.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('PINK FLOYD THE WALL', 222111333444555, 1982, 'UK', 'art', 5, 99, 29.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('FANTASIA', 211344211455533, 1940, 'USA', 'art', 5, 126, 39.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('THE THREE CABALLEROS', 111122322333455, 1944, 'USA', 'art', 4, 71, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('SONIC THE HEDGEHOG', 122111333444355, 2019, 'USA', 'action', 3, 100, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('THE MATRIX', 111111222333455, 1999, 'USA', 'action', 5, 150, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('DICK TRACY', 123123333422555, 1990, 'USA', 'action', 3, 107, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('PIRATES OF THE CARIBBEAN', 223123123444555, 2003, 'USA', 'action', 4, 143, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('SPIDER MAN', 112223334555555, 2002, 'USA', 'action', 5, 121, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('WALK HARD', 123543543111255, 2007, 'USA', 'comedy', 4, 120, 29.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('JOHNNY DANGEROUSLY', 123333444222555, 1984, 'USA', 'comedy', 5, 90, 39.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('THE HANGOVER', 111222333555444, 2009, 'USA', 'comedy', 4, 108, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('STEPBROTHERS', 123123123124145, 2008, 'USA', 'comedy', 4, 106, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('LIAR LIAR', 123124444333555, 1997, 'USA', 'comedy', 5, 87, 29.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('BOWLING FOR COLUMBINE', 111222344244155, 2002, 'USA', 'documentary', 4, 120, 29.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('INDIE GAME THE MOVIE', 123123123123555, 2012, 'USA', 'documentary', 2, 103, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('IMAGINE JOHN LENNON', 111333555222122, 1988, 'UK', 'documentary', 5, 106, 39.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('WALMART THE HIGH COST OF LOW PRICE', 133144155222555, 2005, 'USA', 'documentary', 4, 100, 29.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('SUPERSIZE ME', 123455355155555, 2004, 'USA', 'documentary', 4, 100, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('REQUIEM FOR A DREAM', 123355123344255, 2000, 'USA', 'drama', 5, 110, 39.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('A BEAUTIFUL MIND', 255233144413355, 2001, 'USA', 'drama', 4, 140, 29.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('WALK THE LINE', 213255355455155, 2005, 'USA', 'drama', 4, 153, 29.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('FORREST GUMP', 144133255133455, 1994, 'USA', 'drama', 4, 142, 39.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('THE TRUMAN SHOW', 333153244355155, 1998, 'USA', 'drama', 5, 107, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('A TROLL IN CENTRAL PARK', 124444555222333, 1994, 'USA', 'fantasy', 1, 76, 9.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('PANS LABYRINTH', 124455133544255, 2006, 'SPAIN', 'fantasy', 5, 119, 39.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('SHARK BOY AND LAVA GIRL', 124455155255555, 2005, 'USA', 'fantasy', 2, 95, 9.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('STAR WARS A NEW HOPE', 125125333444122, 1977, 'USA', 'fantasy', 5, 125, 29.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('THE PRINCESS BRIDE', 233244155355455, 1987, 'USA', 'fantasy', 4, 98, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('THE EVIL DEAD', 15424413335251, 1983, 'USA', 'horror', 3, 117, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('THE THING', 152152456244361, 1982, 'USA', 'horror', 5, 109, 29.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('THE MIST', 154111233412455, 2007, 'USA', 'horror', 4, 126, 29.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('MARTYRS', 224154355655411, 2008, 'FRANCE', 'horror', 3, 87, 39.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('THE RING', 224332124125455, 2002, 'USA', 'horror', 5, 145, 39.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('INCEPTION', 152266433155224, 2010, 'USA', 'mystery', 4, 162, 39.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('DONNIE DARKO', 333444123123555, 2001, 'USA', 'mystery', 4, 108, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('ANNIHILATION', 133144522135235, 2018, 'USA', 'mystery', 3, 120, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('SILENCE OF THE LAMBS', 133134255257135, 1991, 'USA', 'mystery', 4, 138, 29.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('THE ISLAND', 123144155156234, 2005, 'USA', 'mystery', 3, 138, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('GATTACA', 137175164222155, 1997, 'USA', 'scifi', 5, 121, 29.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('INTERSTELLAR', 111122124135245, 2014, 'USA', 'scifi', 5, 169, 29.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('CONTACT', 124147135455255, 1997, 'USA', 'scifi', 4, 150, 29.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('AVATAR', 111122133144167, 2009, 'USA', 'scifi', 2, 162, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('ALIEN', 135154163122345, 1979, 'USA', 'scifi', 3, 117, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('THE SHINING', 235144235244135, 1980, 'USA', 'thriller', 5, 146, 39.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('BLACK SWAN', 234134255466123, 2010, 'USA', 'thriller', 4, 108, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('MOTHER', 234235147176355, 2017, 'USA', 'thriller', 4, 121, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('CAPE FEAR', 237154233166455, 1991, 'USA', 'thriller', 4, 128, 19.99);
INSERT INTO "Movies" ("MovieName", "ISBNNumber", "ReleaseYear", "Location", "Genre", "Rating", "Duration", "Price")
VALUES('THE BABADOOK', 23314325534445, 2014, 'AUSTRALIA', 'thriller', 5, 95, 19.99);