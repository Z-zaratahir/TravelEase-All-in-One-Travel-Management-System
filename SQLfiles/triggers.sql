-------------------------Triggers
CREATE TRIGGER trigger_UpdateTripStatus
ON Trip
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @TripID INT, @DepartureDate DATE;

    SELECT @TripID = TripID, @DepartureDate = DepartureDate FROM INSERTED;

    IF (@DepartureDate < GETDATE())
    BEGIN
        UPDATE Trip
        SET TripStatus = 'Completed'
        WHERE TripID = @TripID;
    END
    ELSE
    BEGIN
        UPDATE Trip
        SET TripStatus = 'Upcoming'
        WHERE TripID = @TripID;
    END
END;
INSERT INTO Trip (TripID, TotalSlots, AvailableSlots, ReturnDate, Price, DepartureDate, CategoryID, ProviderID, OperatorID)
VALUES (101, 30, 25, '2025-07-15', 250.00, '2025-07-10', 2, 1, 2);


SELECT TripID, TripStatus
FROM Trip
WHERE TripID = 101;  
----------------------------------------------------------------------------------------------------------------------------
drop trigger trigger_DeleteBookingOnAttemptDelete

CREATE TRIGGER trigger_DeleteBookingOnAttemptDelete
ON BookingAttempt
AFTER DELETE
AS
BEGIN
    DECLARE @AttemptID INT;

    SELECT @AttemptID = AttemptID FROM DELETED;

    DELETE FROM Booking WHERE AttemptID = @AttemptID;
END;
-----------------------------------------------------------
CREATE TRIGGER trg_SetDateAdded
ON TripDestinations
AFTER INSERT
AS
BEGIN
    UPDATE TripDestinations
    SET DateAdded = GETDATE()
    WHERE DestinationID IN (SELECT DestinationID FROM INSERTED);
END;

SELECT * FROM TripDestinations;
INSERT INTO TripDestinations (DestinationID, TripID, Destination)
VALUES (51, 1, 'Paris'), 
       (52, 2, 'New York');

	   -----------------------------------------------------------
CREATE TRIGGER trigger_UpdateAvailableSlots
ON Booking
AFTER INSERT
AS
BEGIN
    DECLARE @BookingID INT, @NumberOfPeople INT, @TripID INT;

    SELECT @BookingID = BookingID, @NumberOfPeople = NumberOfPeople FROM INSERTED;

    SELECT @TripID = TripID FROM BookingAttempt Join Booking ON Booking.AttemptID=BookingAttempt.AttemptID where Booking.BookingID = @BookingID;

    UPDATE Trip
    SET AvailableSlots = AvailableSlots - @NumberOfPeople
    WHERE TripID = @TripID;
END;
SELECT TripID, AvailableSlots
FROM Trip
WHERE TripID = 2;
INSERT INTO Booking (BookingID, TotalAmount, NumberOfPeople, Date, AdminID, PaymentID, AttemptID)
VALUES (51, 1000.00, 4, '2025-04-25', 1, 1, 2);




-----------------------------------------------------------
select * from Traveler
CREATE TRIGGER triger_UpdateTravelerStatusToActive
ON BookingAttempt
AFTER INSERT
AS
BEGIN
    DECLARE @TravelerID INT;

    SELECT @TravelerID = TravelerID FROM INSERTED;

    UPDATE Traveler
    SET Status = 'Active'
    WHERE TravelerID = @TravelerID and Status='Inactive';
END;

--------------------------------------------------------------------------------------
drop trigger trigger_UpdateTravelerStatusToActiveWishlist
CREATE TRIGGER trigger_UpdateTravelerStatusToActiveWishlist
ON WishList_Contains
AFTER INSERT
AS
BEGIN
    DECLARE @TravelerID INT;

    SELECT @TravelerID = TravelerID FROM WishList_Contains
    INNER JOIN WishList ON WishList_Contains.WishListID = WishList.WishListID
    WHERE WishList_Contains.WishListItemID IN (SELECT WishListItemID FROM INSERTED);

    UPDATE Traveler
    SET Status = 'Active'
    WHERE TravelerID = @TravelerID and Status='Inactive';
END;
--test case
SELECT TravelerID, Status
FROM Traveler
WHERE TravelerID = 25;
select * from Traveler

INSERT INTO BookingAttempt (AttemptID, AttemptDate, IsCompleted, TravelerID, TripID)
VALUES (1, '2025-04-25', 0, 25, 1); 
