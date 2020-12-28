/* POPULATING TABLES */

USE GoldenShoe

TRUNCATE TABLE Voucher;
/*------------- DISCOUNTTYPE -------------*/
DELETE FROM DiscountType WHERE ID > 0;
DBCC CHECKIDENT (DiscountType, RESEED, 0);

INSERT INTO DiscountType (DiscountDesc, PercentageOrSet, DiscountValue, Threshold)
VALUES ('£10 off your purchase', 1, 10, NULL),
	   ('10% off your purchase', 0, 10, NULL),
	   ('£10 off orders above £50', 1, 10, 50),
	   ('20% off your purchase', 0, 20, NULL);

SELECT * FROM DiscountType;

/*------------- VOUCHER -------------*/

INSERT INTO Voucher(ID, DiscountTypeID, DiscountAvailableUntil, OneTimeUse)
VALUES ('£10OFFPLEASE', 1, NULL, 0),
	   ('ABCDEFG', 1, NULL, 1),
	   ('10%OFF', 2, NULL, 0),
	   ('£10OFF', 1, '2015-05-30 23:59:59', 0);

SELECT * FROM Voucher;


