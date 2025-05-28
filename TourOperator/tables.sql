CREATE DATABASE TravelEase
USE TravelEase

CREATE TABLE Person (
    Registration INT PRIMARY KEY,
    FName VARCHAR(100),
    LName VARCHAR(100),
    City VARCHAR(100),
    State VARCHAR(100),
    ZipCode VARCHAR(20),
    Role VARCHAR(50),
    RDate DATE,
    CNIC VARCHAR(20),
    DOB DATE
);

CREATE TABLE Admin (
    AdminID INT PRIMARY KEY FOREIGN KEY REFERENCES Person(Registration),
   ReviewID INT,
    -- FOREIGN KEY will be added after creating Review table
);

Create Table [User](
	UserID int primary key REFERENCES Person(Registration),
	UserName VARCHAR(100),
    Password VARCHAR(100),
	AdminID INT FOREIGN KEY REFERENCES Admin(AdminID),
    isApproved bit DEFAULT 0

);


CREATE TABLE Operator (
    OperatorID INT PRIMARY KEY FOREIGN KEY REFERENCES [User](UserID),
   
    Companyname VARCHAR(100),
    
);

CREATE TABLE Traveler (
    TravelerID INT PRIMARY KEY FOREIGN KEY REFERENCES [User](UserID),
    Status VARCHAR(50),
);

CREATE TABLE TourCategories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(100),
    AdminID INT FOREIGN KEY REFERENCES Admin(AdminID)
);

CREATE TABLE TourCategoryActivities (
    ActivityID INT PRIMARY KEY,
    CategoryID INT FOREIGN KEY REFERENCES TourCategories(CategoryID),
    Activity VARCHAR(100)
);

CREATE TABLE ServiceProvider (
    ProviderID INT PRIMARY KEY,
    Name VARCHAR(100),
    PhoneNumber VARCHAR(20),
    Type VARCHAR(50),
    VehicleType VARCHAR(50),
    Language VARCHAR(50),
    Experience INT
);

CREATE TABLE Trip (
    TripID INT PRIMARY KEY,
    TotalSlots INT,
    AvailableSlots INT,
    ReturnDate DATE,
    Price DECIMAL(10, 2),
    DepartureDate DATE,
    CategoryID INT FOREIGN KEY REFERENCES TourCategories(CategoryID),
    ProviderID INT FOREIGN KEY REFERENCES ServiceProvider(ProviderID),
    OperatorID INT FOREIGN KEY REFERENCES Operator(OperatorID),
    TripStatus VARCHAR(20)
);

CREATE TABLE TripDestinations (
    DestinationID INT PRIMARY KEY,
    TripID INT FOREIGN KEY REFERENCES Trip(TripID),
    Destination VARCHAR(100)
);

CREATE TABLE Payment (
    PaymentID INT PRIMARY KEY,
    Date DATE,
    PaymentMethod VARCHAR(50),
    Status VARCHAR(50),
    TravelerID INT FOREIGN KEY REFERENCES Traveler(TravelerID)
);

CREATE TABLE BookingAttempt (
    AttemptID INT PRIMARY KEY,
    AttemptDate DATE,
    IsCompleted BIT,
    TravelerID INT FOREIGN KEY REFERENCES Traveler(TravelerID),
    TripID INT FOREIGN KEY REFERENCES Trip(TripID)
);

CREATE TABLE Booking (
    BookingID INT PRIMARY KEY,
    TotalAmount DECIMAL(10, 2),
    NumberOfPeople INT,
    Date DATE,
    AdminID INT FOREIGN KEY REFERENCES Admin(AdminID),
    PaymentID INT FOREIGN KEY REFERENCES Payment(PaymentID),
    AttemptID INT FOREIGN KEY REFERENCES BookingAttempt(AttemptID)
);

CREATE TABLE Itinerary (
    ItineraryID INT PRIMARY KEY,
    DayNumber INT,
    Title VARCHAR(100),
    Location VARCHAR(100),
    StartTime TIME,
    EndTime TIME,
    TripID INT FOREIGN KEY REFERENCES Trip(TripID)
);

CREATE TABLE TravelPass (
    PassID INT PRIMARY KEY,
    Type VARCHAR(50),
    GeneratedDate DATE,
    BookingID INT FOREIGN KEY REFERENCES Booking(BookingID)
);

CREATE TABLE Preferences (
    PreferenceID INT PRIMARY KEY,
    BudgetRange VARCHAR(50)
);

CREATE TABLE Traveler_Preference(
	
	
	PreferenceID INT FOREIGN KEY REFERENCES Preferences(PreferenceID),
	TravelerID INT FOREIGN KEY REFERENCES Traveler(TravelerID),
	PRIMARY KEY(PreferenceID,TravelerID)
	
);

CREATE TABLE WishList (
    WishListID INT PRIMARY KEY,
    TravelerID INT FOREIGN KEY REFERENCES Traveler(TravelerID)
);

CREATE TABLE WishList_Contains (
    WishListItemID INT PRIMARY KEY,
    WishListID INT FOREIGN KEY REFERENCES WishList(WishListID),
    TripID INT FOREIGN KEY REFERENCES Trip(TripID),
    DateAdded DATE,
    IsNotified BIT
);

CREATE TABLE Hotel (
    HotelID INT PRIMARY KEY,
    HotelName VARCHAR(100),
    Rooms INT,
    AvailabilityStatus VARCHAR(50),
    Location VARCHAR(100),
    Stars INT,
    ProviderID INT FOREIGN KEY REFERENCES ServiceProvider(ProviderID)
);

CREATE TABLE ServiceAssignment (
    AssignmentID INT PRIMARY KEY,
    ProviderID INT FOREIGN KEY REFERENCES ServiceProvider(ProviderID),
    OperatorID INT FOREIGN KEY REFERENCES Operator(OperatorID)
);

CREATE TABLE Review (
    ReviewID INT PRIMARY KEY,
    Rating INT,
    ReviewDate DATE,
    Comment VARCHAR(255),
    OperatorID INT FOREIGN KEY REFERENCES Operator(OperatorID),
    TravelerID INT FOREIGN KEY REFERENCES Traveler(TravelerID),
    TripID INT FOREIGN KEY REFERENCES Trip(TripID),
	AdminID INT FOREIGN KEY REFERENCES Admin(AdminID)
);
select * from Review
-- Add ReviewID foreign key to Admin table now that Review exists
ALTER TABLE Admin
ADD CONSTRAINT FK_Admin_Review FOREIGN KEY (ReviewID) REFERENCES Review(ReviewID);

INSERT INTO Person (Registration, FName, LName, City, State, ZipCode, Role, RDate, CNIC, DOB) VALUES
(1, 'Ali', 'Khan', 'Lahore', 'Punjab', '54000', 'Admin', '2023-03-15', '35201-1234567-1', '1990-07-12'),
(2, 'Ayesha', 'Malik', 'Karachi', 'Sindh', '74000', 'Operator', '2022-06-20', '42101-9876543-2', '1995-04-10'),
(3, 'Usman', 'Ahmed', 'Islamabad', 'ICT', '44000', 'Traveler', '2021-11-05', '61101-4567891-3', '1992-09-03'),
(4, 'Fatima', 'Saeed', 'Multan', 'Punjab', '60000', 'Traveler', '2023-01-17', '35102-1111222-4', '1996-12-25'),
(5, 'Zain', 'Raza', 'Rawalpindi', 'Punjab', '46000', 'Admin', '2023-08-08', '37406-2222333-5', '1989-05-30'),
(6, 'Hassan', 'Ali', 'Peshawar', 'KPK', '25000', 'Operator', '2024-01-10', '17301-4444555-6', '1993-03-15'),
(7, 'Maham', 'Iqbal', 'Faisalabad', 'Punjab', '38000', 'Traveler', '2022-09-25', '33100-5555666-7', '1997-08-21'),
(8, 'Bilal', 'Sheikh', 'Quetta', 'Balochistan', '87300', 'Admin', '2022-04-14', '54301-7777888-8', '1991-10-18'),
(9, 'Sarah', 'Hussain', 'Hyderabad', 'Sindh', '71000', 'Traveler', '2023-05-28', '42201-6666777-9', '1994-06-07'),
(10, 'Imran', 'Farooq', 'Sialkot', 'Punjab', '51310', 'Operator', '2023-02-12', '34503-9999000-0', '1988-11-11'),
(11, 'John', 'Smith', 'London', 'England', 'EC1A1BB', 'Admin', '2023-04-01', '12345-6789012-1', '1987-01-01'),
(12, 'Emily', 'Clark', 'New York', 'NY', '10001', 'Operator', '2023-04-02', '23456-7890123-2', '1990-05-12'),
(13, 'Michael', 'Brown', 'Chicago', 'IL', '60601', 'Traveler', '2023-04-03', '34567-8901234-3', '1992-08-14'),
(14, 'Emma', 'Davis', 'Toronto', 'Ontario', 'M5H2N2', 'Traveler', '2023-04-04', '45678-9012345-4', '1991-09-25'),
(15, 'David', 'Wilson', 'Sydney', 'NSW', '2000', 'Admin', '2023-04-05', '56789-0123456-5', '1985-03-22'),
(16, 'Olivia', 'Moore', 'Melbourne', 'VIC', '3000', 'Operator', '2023-04-06', '67890-1234567-6', '1993-07-30'),
(17, 'James', 'Taylor', 'Auckland', 'NZ', '1010', 'Traveler', '2023-04-07', '78901-2345678-7', '1994-12-12'),
(18, 'Sophia', 'Anderson', 'Dublin', 'Leinster', 'D02', 'Admin', '2023-04-08', '89012-3456789-8', '1996-10-10'),
(19, 'Daniel', 'Lee', 'Vancouver', 'BC', 'V5K0A1', 'Traveler', '2023-04-09', '90123-4567890-9', '1995-06-18'),
(20, 'Grace', 'Martin', 'Manchester', 'England', 'M11AE', 'Operator', '2023-04-10', '01234-5678901-0', '1991-04-04'),
(21, 'Ali', 'Raza', 'Lahore', 'Punjab', '54000', 'Traveler', '2023-05-01', '35201-1234567-1', '1992-01-01'),
(22, 'Sana', 'Khan', 'Karachi', 'Sindh', '74000', 'Operator', '2023-05-02', '42101-2345678-2', '1995-06-15'),
(23, 'Hamza', 'Ali', 'Islamabad', 'Capital', '44000', 'Admin', '2023-05-03', '61101-3456789-3', '1990-11-20'),
(24, 'Ayesha', 'Iqbal', 'Rawalpindi', 'Punjab', '46000', 'Traveler', '2023-05-04', '37401-4567890-4', '1998-03-30'),
(25, 'Bilal', 'Ahmed', 'Faisalabad', 'Punjab', '38000', 'Traveler', '2023-05-05', '33102-5678901-5', '1994-07-09'),
(26, 'Fatima', 'Zahid', 'Multan', 'Punjab', '60000', 'Operator', '2023-05-06', '38401-6789012-6', '1997-12-12'),
(27, 'Zain', 'Shah', 'Gujranwala', 'Punjab', '52250', 'Traveler', '2023-05-07', '34101-7890123-7', '1993-04-18'),
(28, 'Mahnoor', 'Yousaf', 'Hyderabad', 'Sindh', '71000', 'Admin', '2023-05-08', '41201-8901234-8', '1991-02-22'),
(29, 'Usman', 'Khalid', 'Peshawar', 'KPK', '25000', 'Traveler', '2023-05-09', '16101-9012345-9', '1996-09-29'),
(30, 'Hira', 'Nadeem', 'Sialkot', 'Punjab', '51310', 'Operator', '2023-05-10', '33202-0123456-0', '1999-08-08'),
(31, 'Imran', 'Qureshi', 'Bahawalpur', 'Punjab', '63100', 'Admin', '2023-06-01', '31304-1234567-1', '1989-04-05'),
(32, 'Nida', 'Anwar', 'Sargodha', 'Punjab', '40100', 'Traveler', '2023-06-02', '33201-2345678-2', '1995-11-19'),
(33, 'Waqas', 'Mir', 'Quetta', 'Balochistan', '87300', 'Traveler', '2023-06-03', '54401-3456789-3', '1992-12-01'),
(34, 'Areeba', 'Saleem', 'Abbottabad', 'KPK', '22010', 'Operator', '2023-06-04', '17201-4567890-4', '1997-01-17'),
(35, 'Hassan', 'Bukhari', 'Sahiwal', 'Punjab', '57000', 'Admin', '2023-06-05', '35202-5678901-5', '1993-07-23'),
(36, 'Mehwish', 'Amin', 'Rahim Yar Khan', 'Punjab', '64200', 'Traveler', '2023-06-06', '31303-6789012-6', '1996-03-12'),
(37, 'Kashif', 'Rana', 'Mardan', 'KPK', '23200', 'Operator', '2023-06-07', '17101-7890123-7', '1990-06-29'),
(38, 'Hiba', 'Murtaza', 'Dera Ghazi Khan', 'Punjab', '32200', 'Traveler', '2023-06-08', '31101-8901234-8', '1998-02-02'),
(39, 'Omer', 'Asad', 'Sheikhupura', 'Punjab', '39350', 'Traveler', '2023-06-09', '35102-9012345-9', '1991-08-21'),
(40, 'Zoya', 'Ali', 'Okara', 'Punjab', '56300', 'Operator', '2023-06-10', '33301-0123456-0', '1994-05-06'),
(41, 'Bilal', 'Naseer', 'Jhelum', 'Punjab', '49600', 'Admin', '2023-06-11', '37401-1234567-1', '1988-12-15'),
(42, 'Sana', 'Haroon', 'Tando Adam', 'Sindh', '68020', 'Traveler', '2023-06-12', '45103-2345678-2', '1993-09-07'),
(43, 'Rashid', 'Iqbal', 'Khairpur', 'Sindh', '66020', 'Traveler', '2023-06-13', '43201-3456789-3', '1990-01-18'),
(44, 'Maham', 'Zahid', 'Chakwal', 'Punjab', '48800', 'Operator', '2023-06-14', '37201-4567890-4', '1997-04-10'),
(45, 'Arsalan', 'Farooq', 'Sukkur', 'Sindh', '65200', 'Admin', '2023-06-15', '44102-5678901-5', '1989-03-03'),
(46, 'Iqra', 'Sultan', 'Gujrat', 'Punjab', '50700', 'Traveler', '2023-06-16', '34201-6789012-6', '1995-06-12'),
(47, 'Faizan', 'Ahmed', 'Khanewal', 'Punjab', '58150', 'Operator', '2023-06-17', '36102-7890123-7', '1991-10-28'),
(48, 'Aiman', 'Khalid', 'Muzaffargarh', 'Punjab', '34200', 'Traveler', '2023-06-18', '33104-8901234-8', '1996-02-22'),
(49, 'Rameez', 'Shahid', 'Layyah', 'Punjab', '31200', 'Traveler', '2023-06-19', '32101-9012345-9', '1987-11-11'),
(50, 'Hira', 'Jameel', 'Kasur', 'Punjab', '55050', 'Operator', '2023-06-20', '35103-0123456-0', '1994-07-25'),
(51, 'Talha', 'Rafiq', 'Mingora', 'KPK', '19200', 'Traveler', '2023-06-21', '16101-1234567-1', '1995-03-12'),
(52, 'Zara', 'Naveed', 'Kohat', 'KPK', '26000', 'Traveler', '2023-06-22', '15102-2345678-2', '1996-04-14'),
(53, 'Shahid', 'Mehmood', 'Nowshera', 'KPK', '24110', 'Traveler', '2023-06-23', '14103-3456789-3', '1988-06-09'),
(54, 'Amna', 'Latif', 'Okara', 'Punjab', '56300', 'Traveler', '2023-06-24', '33102-4567890-4', '1994-07-21'),
(55, 'Hamza', 'Shahbaz', 'Dera Ghazi Khan', 'Punjab', '32200', 'Traveler', '2023-06-25', '30101-5678901-5', '1992-08-13'),
(56, 'Kiran', 'Yousuf', 'Sahiwal', 'Punjab', '57000', 'Traveler', '2023-06-26', '34103-6789012-6', '1998-01-30'),
(57, 'Sameer', 'Iqbal', 'Chiniot', 'Punjab', '35400', 'Traveler', '2023-06-27', '33101-7890123-7', '1993-11-17'),
(58, 'Mehwish', 'Saleem', 'Narowal', 'Punjab', '51600', 'Traveler', '2023-06-28', '35101-8901234-8', '1999-02-25'),
(59, 'Asim', 'Rehman', 'Larkana', 'Sindh', '77150', 'Traveler', '2023-06-29', '43101-9012345-9', '1986-12-07'),
(60, 'Fatima', 'Mir', 'Turbat', 'Balochistan', '92600', 'Traveler', '2023-06-30', '71101-0123456-0', '1997-05-05'),

(61, 'Saif', 'Ali', 'Bannu', 'KPK', '28100', 'Traveler', '2023-07-01', '17102-1234567-1', '1991-09-11'),
(62, 'Hina', 'Manzoor', 'Attock', 'Punjab', '43600', 'Traveler', '2023-07-02', '37103-2345678-2', '1990-10-23'),
(63, 'Rizwan', 'Asghar', 'Bhakkar', 'Punjab', '30000', 'Traveler', '2023-07-03', '32103-3456789-3', '1993-03-15'),
(64, 'Neha', 'Tariq', 'Shikarpur', 'Sindh', '78100', 'Traveler', '2023-07-04', '43103-4567890-4', '1996-12-29'),
(65, 'Hassan', 'Rafiq', 'Zhob', 'Balochistan', '85200', 'Traveler', '2023-07-05', '72101-5678901-5', '1992-06-01'),
(66, 'Sumbal', 'Akram', 'Jhang', 'Punjab', '35200', 'Traveler', '2023-07-06', '34104-6789012-6', '1997-01-10'),
(67, 'Zeeshan', 'Rashid', 'Kambar', 'Sindh', '77200', 'Traveler', '2023-07-07', '43102-7890123-7', '1989-08-20'),
(68, 'Areeba', 'Junaid', 'Dadu', 'Sindh', '76200', 'Traveler', '2023-07-08', '42104-8901234-8', '1998-09-03'),
(69, 'Fahad', 'Khalil', 'Hafizabad', 'Punjab', '52110', 'Operator', '2023-07-09', '35104-9012345-9', '1990-05-06'),
(70, 'Laiba', 'Amin', 'Mardan', 'KPK', '23200', 'Operator', '2023-07-10', '16104-0123456-0', '1994-11-09');


select * from Person
--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------Admin-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////
INSERT INTO Admin (AdminID, ReviewID)
SELECT Registration, NULL
FROM Person
WHERE Role = 'Admin';
--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------User-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////
INSERT INTO [User] (UserID, UserName, Password, AdminID)
SELECT 
    p.Registration,
    'User' + CAST(p.Registration AS VARCHAR),
    'password' + CAST(p.Registration AS VARCHAR),
    (SELECT TOP 1 AdminID FROM Admin ORDER BY NEWID())  -- Random admin
FROM Person p
WHERE p.Role IN ('Operator', 'Traveler');
--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------Operator-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////


-- Company: BlueTech Pvt Ltd
INSERT INTO Operator (OperatorID, CompanyName) VALUES (2, 'BlueTech Pvt Ltd');
INSERT INTO Operator (OperatorID, CompanyName) VALUES (12, 'BlueTech Pvt Ltd');
INSERT INTO Operator (OperatorID, CompanyName) VALUES (44, 'BlueTech Pvt Ltd');

-- Company: Orbit Enterprises
INSERT INTO Operator (OperatorID, CompanyName) VALUES (6, 'Orbit Enterprises');
INSERT INTO Operator (OperatorID, CompanyName) VALUES (20, 'Orbit Enterprises');

-- Company: NextGen Solutions
INSERT INTO Operator (OperatorID, CompanyName) VALUES (10, 'NextGen Solutions');
INSERT INTO Operator (OperatorID, CompanyName) VALUES (22, 'NextGen Solutions');
INSERT INTO Operator (OperatorID, CompanyName) VALUES (47, 'NextGen Solutions');

-- Company: SkyBridge Tours
INSERT INTO Operator (OperatorID, CompanyName) VALUES (16, 'SkyBridge Tours');
INSERT INTO Operator (OperatorID, CompanyName) VALUES (30, 'SkyBridge Tours');

-- Company: WanderWorks
INSERT INTO Operator (OperatorID, CompanyName) VALUES (26, 'WanderWorks');
INSERT INTO Operator (OperatorID, CompanyName) VALUES (34, 'WanderWorks');

-- Company: PakVoyage Pvt Ltd
INSERT INTO Operator (OperatorID, CompanyName) VALUES (37, 'PakVoyage Pvt Ltd');
INSERT INTO Operator (OperatorID, CompanyName) VALUES (70, 'PakVoyage Pvt Ltd');

-- Company: GlobeTrek Partners
INSERT INTO Operator (OperatorID, CompanyName) VALUES (40, 'GlobeTrek Partners');
INSERT INTO Operator (OperatorID, CompanyName) VALUES (50, 'GlobeTrek Partners');
INSERT INTO Operator (OperatorID, CompanyName) VALUES (69, 'GlobeTrek Partners');


--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------Traveler-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////
INSERT INTO Traveler (TravelerID, Status) VALUES (3, 'Active');
INSERT INTO Traveler (TravelerID, Status) VALUES (4, 'Pending Verification');
INSERT INTO Traveler (TravelerID, Status) VALUES (7, 'Active');
INSERT INTO Traveler (TravelerID, Status) VALUES (9, 'Inactive');
INSERT INTO Traveler (TravelerID, Status) VALUES (13, 'Suspended');
INSERT INTO Traveler (TravelerID, Status) VALUES (14, 'Active');
INSERT INTO Traveler (TravelerID, Status) VALUES (17, 'Pending Verification');
INSERT INTO Traveler (TravelerID, Status) VALUES (19, 'Active');
INSERT INTO Traveler (TravelerID, Status) VALUES (21, 'Suspended');
INSERT INTO Traveler (TravelerID, Status) VALUES (24, 'Active');
INSERT INTO Traveler (TravelerID, Status) VALUES (25, 'Inactive');
INSERT INTO Traveler (TravelerID, Status) VALUES (27, 'Pending Verification');
INSERT INTO Traveler (TravelerID, Status) VALUES (29, 'Active');
INSERT INTO Traveler (TravelerID, Status) VALUES (32, 'Suspended');
INSERT INTO Traveler (TravelerID, Status) VALUES (33, 'Active');
INSERT INTO Traveler (TravelerID, Status) VALUES (36, 'Inactive');
INSERT INTO Traveler (TravelerID, Status) VALUES (38, 'Active');
INSERT INTO Traveler (TravelerID, Status) VALUES (39, 'Pending Verification');
INSERT INTO Traveler (TravelerID, Status) VALUES (42, 'Suspended');
INSERT INTO Traveler (TravelerID, Status) VALUES (43, 'Active');
INSERT INTO Traveler (TravelerID, Status) VALUES (46, 'Inactive');
INSERT INTO Traveler (TravelerID, Status) VALUES (48, 'Active');
INSERT INTO Traveler (TravelerID, Status) VALUES (49, 'Pending Verification');
INSERT INTO Traveler (TravelerID, Status) VALUES (51, 'Suspended');
INSERT INTO Traveler (TravelerID, Status) VALUES (52, 'Active');
INSERT INTO Traveler (TravelerID, Status) VALUES (53, 'Inactive');
INSERT INTO Traveler (TravelerID, Status) VALUES (54, 'Pending Verification');
INSERT INTO Traveler (TravelerID, Status) VALUES (55, 'Suspended');
INSERT INTO Traveler (TravelerID, Status) VALUES (56, 'Active');
INSERT INTO Traveler (TravelerID, Status) VALUES (57, 'Inactive');
INSERT INTO Traveler (TravelerID, Status) VALUES (58, 'Pending Verification');
INSERT INTO Traveler (TravelerID, Status) VALUES (59, 'Suspended');
INSERT INTO Traveler (TravelerID, Status) VALUES (60, 'Active');
INSERT INTO Traveler (TravelerID, Status) VALUES (61, 'Inactive');
INSERT INTO Traveler (TravelerID, Status) VALUES (62, 'Pending Verification');
INSERT INTO Traveler (TravelerID, Status) VALUES (63, 'Suspended');
INSERT INTO Traveler (TravelerID, Status) VALUES (64, 'Active');
INSERT INTO Traveler (TravelerID, Status) VALUES (65, 'Inactive');
INSERT INTO Traveler (TravelerID, Status) VALUES (66, 'Active');
INSERT INTO Traveler (TravelerID, Status) VALUES (67, 'Suspended');
INSERT INTO Traveler (TravelerID, Status) VALUES (68, 'Active');
--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------TourCategories-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////

INSERT INTO TourCategories (CategoryID, CategoryName, AdminID) 
VALUES 
(1, 'Adventure Tours', 1),
(2, 'Beach Holidays', 5),
(3, 'Cultural Tours', 8),
(4, 'Family Packages', 11),
(5, 'Luxury Cruises', 15),
(6, 'Historical Tours', 18),
(7, 'Nature Escapes', 23),
(8, 'Wildlife Safari', 28),
(9, 'Adventure Sports', 31),
(10, 'Eco-Friendly Tours', 35);
--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------TourCategoryActivities-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////
INSERT INTO TourCategoryActivities (ActivityID, CategoryID, Activity) 
VALUES 
(1, 1, 'Rock Climbing'),
(2, 1, 'Mountain Hiking'),
(3, 2, 'Scuba Diving'),
(4, 2, 'Snorkeling'),
(5, 3, 'Museum Tours'),
(6, 3, 'Art Exhibitions'),
(7, 4, 'Amusement Park Visits'),
(8, 4, 'Family Picnics'),
(9, 5, 'Private Yacht Cruises'),
(10, 5, 'Luxury Spa Treatments'),
(11, 6, 'Ancient Ruin Tours'),
(12, 6, 'Archaeological Excursions'),
(13, 7, 'Forest Walks'),
(14, 7, 'Camping Trips'),
(15, 8, 'Safari Game Drives'),
(16, 8, 'Bird Watching'),
(17, 9, 'Bungee Jumping'),
(18, 9, 'Paragliding'),
(19, 10, 'Eco Tours'),
(20, 10, 'Sustainable Travel Experiences'),
(21, 1, 'Alpine Skiing'),
(22, 1, 'Winter Snowshoeing'),
(23, 2, 'Shark Cage Diving'),
(24, 2, 'Underwater Photography'),
(25, 3, 'Cultural Immersion Tours'),
(26, 3, 'Historical City Walks'),
(27, 4, 'Zip Lining'),
(28, 4, 'Water Parks'),
(29, 5, 'Wine Tasting Tours'),
(30, 5, 'Gourmet Dining Experiences'),
(31, 6, 'Volcano Tours'),
(32, 6, 'Jungle Expeditions'),
(33, 7, 'Wildlife Safaris'),
(34, 7, 'Forest Zip Line'),
(35, 8, 'Night Safaris'),
(36, 8, 'Big Cat Tracking'),
(37, 9, 'Extreme Sports'),
(38, 9, 'Helicopter Tours'),
(39, 10, 'Wildlife Photography Workshops'),
(40, 10, 'Sustainable Hiking'),
(41, 1, 'Canoeing and Kayaking'),
(42, 1, 'Climbing Expeditions'),
(43, 2, 'Coral Reef Exploration'),
(44, 2, 'Deep Sea Fishing'),
(45, 3, 'Walking Tours of Historic Sites'),
(46, 3, 'Food and Wine Pairing Experiences'),
(47, 4, 'Theme Park Roller Coasters'),
(48, 4, 'Swimming with Dolphins'),
(49, 5, 'Hot Air Balloon Rides'),
(50, 5, 'Private Helicopter Tours');
--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------ServiceProvider-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////
INSERT INTO ServiceProvider (ProviderID, Name, PhoneNumber, Type, VehicleType, Language, Experience) 
VALUES
(1, 'Hotel Luxe', '0321-5551111', 'Hotel Provider', NULL, 'English', 15),
(2, 'Sky Tours', '0321-5552222', 'Guide', NULL, 'Spanish', 8),
(3, 'Royal Transport', '0321-5553333', 'Transport Provider', 'Luxury Sedan', NULL, NULL),
(4, 'Sunset Resorts', '0321-5554444', 'Hotel Provider', NULL, 'Italian', 20),
(5, 'TravelMate', '0321-5555555', 'Guide', NULL, 'German', 5),
(6, 'Elite Transport', '0321-5556666', 'Transport Provider', 'Mini Bus', NULL, NULL),
(7, 'Seaside Villas', '0321-5557777', 'Hotel Provider', NULL, 'Arabic', 10),
(8, 'Adventure Seekers', '0321-5558888', 'Guide', NULL, 'Portuguese', 12),
(9, 'Mountain Express', '0321-5559999', 'Transport Provider', '4x4 SUV', NULL, NULL),
(10, 'Grand Plaza', '0321-5560000', 'Hotel Provider', NULL, 'Russian', 25),
(11, 'Paradise Travels', '0321-5561111', 'Guide', NULL, 'Japanese', 6),
(12, 'Golden Miles', '0321-5562222', 'Transport Provider', 'Bus', NULL, NULL),
(13, 'Oceanic Stays', '0321-5563333', 'Hotel Provider', NULL, 'Chinese', 18),
(14, 'Voyage Masters', '0321-5564444', 'Guide', NULL, 'Italian', 3),
(15, 'Desert Adventures', '0321-5565555', 'Transport Provider', 'Camper Van', NULL, NULL),
(16, 'Beachfront Retreat', '0321-5566666', 'Hotel Provider', NULL, 'German', 10),
(17, 'Safari Team', '0321-5567777', 'Guide', NULL, 'Swahili', 7),
(18, 'City Shuttle', '0321-5568888', 'Transport Provider', 'Shuttle Bus', NULL, NULL),
(19, 'Mountain View Resort', '0321-5569999', 'Hotel Provider', NULL, 'French', 22),
(20, 'Expedition Leaders', '0321-5570000', 'Guide', NULL, 'Dutch', 15),
(21, 'Skyline Transport', '0321-5571111', 'Transport Provider', 'Private Car', NULL, NULL),
(22, 'Tranquil Lodgings', '0321-5572222', 'Hotel Provider', NULL, 'Arabic', 13),
(23, 'Guided Trails', '0321-5573333', 'Guide', NULL, 'Hindi', 8),
(24, 'Luxury Limo Service', '0321-5574444', 'Transport Provider', 'Limousine', NULL, NULL),
(25, 'Eagles Nest', '0321-5575555', 'Hotel Provider', NULL, 'French', 14),
(26, 'Oceanic Excursions', '0321-5576666', 'Guide', NULL, 'Italian', 10),
(27, 'Elite Chauffeurs', '0321-5577777', 'Transport Provider', 'Luxury Sedan', NULL, NULL),
(28, 'Safari Wonders', '0321-5578888', 'Guide', NULL, 'Zulu', 4),
(29, 'Tranquil Palms', '0321-5579999', 'Hotel Provider', NULL, 'Spanish', 11),
(30, 'Sunset Tours', '0321-5580000', 'Guide', NULL, 'Portuguese', 9),
(31, 'Green Travels', '0321-5581111', 'Transport Provider', 'Eco Bus', NULL, NULL),
(32, 'Blissful Retreat', '0321-5582222', 'Hotel Provider', NULL, 'Russian', 17),
(33, 'Voyage Adventures', '0321-5583333', 'Guide', NULL, 'French', 6),
(34, 'Royal Safari', '0321-5584444', 'Transport Provider', '4x4 SUV', NULL, NULL),
(35, 'Seaside Getaway', '0321-5585555', 'Hotel Provider', NULL, 'German', 14),
(36, 'Excursion Leaders', '0321-5586666', 'Guide', NULL, 'Dutch', 7),
(37, 'Alpine Tours', '0321-5587777', 'Transport Provider', 'Mountain Bus', NULL, NULL),
(38, 'Royal Estates', '0321-5588888', 'Hotel Provider', NULL, 'Arabic', 16),
(39, 'Desert Nomads', '0321-5589999', 'Guide', NULL, 'Swahili', 5),
(40, 'Coastal Adventures', '0321-5590000', 'Transport Provider', 'Yacht', NULL, NULL),
(41, 'Paradise Getaways', '0321-5591111', 'Hotel Provider', NULL, 'French', 23),
(42, 'Wilderness Guides', '0321-5592222', 'Guide', NULL, 'Hindi', 6),
(43, 'Jet Set Transport', '0321-5593333', 'Transport Provider', 'Private Jet', NULL, NULL),
(44, 'Natures Haven', '0321-5594444', 'Hotel Provider', NULL, 'Russian', 19),
(45, 'River Expeditions', '0321-5595555', 'Guide', NULL, 'German', 8),
(46, 'Tropical Hideaways', '0321-5596666', 'Hotel Provider', NULL, 'Spanish', 11),
(47, 'Swift Transits', '0321-5597777', 'Transport Provider', 'Motorbike', NULL, NULL),
(48, 'Luxury Resorts', '0321-5598888', 'Hotel Provider', NULL, 'Japanese', 18),
(49, 'Wilderness Adventures', '0321-5599999', 'Guide', NULL, 'Portuguese', 4),
(50, 'Alpine Getaways', '0321-5600000', 'Transport Provider', 'Snowmobile', NULL, NULL);

--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------Trip-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////
INSERT INTO Trip (TripID, TotalSlots, AvailableSlots, ReturnDate, Price, DepartureDate, CategoryID, ProviderID, OperatorID)
VALUES
(1, 20, 15, '2025-05-01', 150.00, '2025-04-30', 1, 1, 2),
(2, 30, 20, '2025-05-05', 200.00, '2025-04-30', 2, 2, 6),
(3, 25, 18, '2025-06-01', 180.00, '2025-05-28', 3, 3, 10),
(4, 40, 35, '2025-07-01', 250.00, '2025-06-25', 4, 4, 12),
(5, 50, 45, '2025-08-01', 300.00, '2025-07-28', 5, 5, 16),
(6, 60, 55, '2025-09-01', 350.00, '2025-08-28', 6, 6, 20),
(7, 35, 30, '2025-10-01', 280.00, '2025-09-28', 7, 7, 22),
(8, 25, 20, '2025-11-01', 220.00, '2025-10-30', 8, 8, 26),
(9, 15, 10, '2025-12-01', 150.00, '2025-11-30', 9, 9, 30),
(10, 40, 35, '2025-12-15', 270.00, '2025-12-10', 10, 10, 34),
(11, 50, 40, '2026-01-01', 300.00, '2025-12-28', 1, 11, 37),
(12, 30, 25, '2026-01-10', 220.00, '2026-01-05', 2, 12, 40),
(13, 45, 40, '2026-02-01', 250.00, '2026-01-25', 3, 13, 44),
(14, 55, 50, '2026-02-15', 320.00, '2026-02-10', 4, 14, 47),
(15, 25, 20, '2026-03-01', 190.00, '2026-02-20', 5, 15, 50),
(16, 35, 30, '2026-03-10', 230.00, '2026-03-05', 6, 16, 69),
(17, 40, 35, '2026-04-01', 270.00, '2026-03-28', 7, 17, 70),
(18, 45, 40, '2026-04-10', 310.00, '2026-04-05', 8, 18, 2),
(19, 50, 45, '2026-05-01', 350.00, '2026-04-25', 9, 19, 6),
(20, 30, 25, '2026-05-10', 230.00, '2026-05-05', 10, 20, 10),
(21, 40, 30, '2026-06-01', 260.00, '2026-05-28', 1, 21, 12),
(22, 25, 15, '2026-06-15', 180.00, '2026-06-10', 2, 22, 16),
(23, 35, 30, '2026-07-01', 220.00, '2026-06-25', 3, 23, 20),
(24, 50, 40, '2026-07-10', 290.00, '2026-07-05', 4, 24, 22),
(25, 30, 25, '2026-08-01', 250.00, '2026-07-28', 5, 25, 26),
(26, 45, 40, '2026-08-10', 310.00, '2026-08-05', 6, 26, 30),
(27, 35, 30, '2026-09-01', 270.00, '2026-08-28', 7, 27, 34),
(28, 25, 20, '2026-09-10', 200.00, '2026-09-05', 8, 28, 37),
(29, 40, 35, '2026-10-01', 280.00, '2026-09-25', 9, 29, 40),
(30, 50, 45, '2026-10-15', 330.00, '2026-10-10', 10, 30, 44),
(31, 60, 50, '2026-11-01', 360.00, '2026-10-25', 1, 31, 47),
(32, 35, 30, '2026-11-10', 230.00, '2026-11-05', 2, 32, 50),
(33, 45, 40, '2026-12-01', 290.00, '2026-11-28', 3, 33, 69),
(34, 50, 40, '2026-12-10', 320.00, '2026-12-05', 4, 34, 70),
(35, 30, 25, '2027-01-01', 240.00, '2026-12-25', 5, 35, 2),
(36, 40, 30, '2027-01-15', 270.00, '2027-01-10', 6, 36, 6),
(37, 45, 40, '2027-02-01', 310.00, '2027-01-25', 7, 37, 10),
(38, 35, 30, '2027-02-10', 260.00, '2027-02-05', 8, 38, 12),
(39, 50, 45, '2027-03-01', 350.00, '2027-02-25', 9, 39, 16),
(40, 60, 50, '2027-03-10', 380.00, '2027-03-05', 10, 40, 20),
(41, 25, 20, '2027-04-01', 190.00, '2027-03-25', 1, 41, 22),
(42, 35, 30, '2027-04-10', 220.00, '2027-04-05', 2, 42, 26),
(43, 45, 40, '2027-05-01', 270.00, '2027-04-25', 3, 43, 30),
(44, 50, 45, '2027-05-10', 320.00, '2027-05-05', 4, 44, 34),
(45, 25, 20, '2027-06-01', 210.00, '2027-05-25', 5, 45, 37),
(46, 35, 30, '2027-06-10', 230.00, '2027-06-05', 6, 46, 40),
(47, 50, 45, '2027-07-01', 300.00, '2027-06-25', 7, 47, 44),
(48, 30, 25, '2027-07-10', 250.00, '2027-07-05', 8, 48, 47),
(49, 40, 35, '2027-08-01', 280.00, '2027-07-28', 9, 49, 50),
(50, 60, 50, '2027-08-10', 350.00, '2027-08-05', 10, 50, 69);

--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------TripDestinations-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////
INSERT INTO TripDestinations (DestinationID, TripID, Destination)
VALUES
(1, 1, 'Paris'),
(2, 2, 'New York'),
(3, 3, 'Tokyo'),
(4, 4, 'London'),
(5, 5, 'Dubai'),
(6, 6, 'Rome'),
(7, 7, 'Sydney'),
(8, 8, 'Amsterdam'),
(9, 9, 'Singapore'),
(10, 10, 'Hong Kong'),
(11, 11, 'Barcelona'),
(12, 12, 'Istanbul'),
(13, 13, 'Cairo'),
(14, 14, 'Bangkok'),
(15, 15, 'Los Angeles'),
(16, 16, 'Berlin'),
(17, 17, 'Dubai'),
(18, 18, 'Paris'),
(19, 19, 'San Francisco'),
(20, 20, 'Rome');
--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------Payment-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////
INSERT INTO Payment (PaymentID, Date, PaymentMethod, Status, TravelerID)
VALUES
(1, '2025-04-01', 'Credit Card', 'Completed', 3),
(2, '2025-04-02', 'Debit Card', 'Pending', 4),
(3, '2025-04-03', 'PayPal', 'Completed', 7),
(4, '2025-04-04', 'Bank Transfer', 'Failed', 9),
(5, '2025-04-05', 'Credit Card', 'Completed', 13),
(6, '2025-04-06', 'PayPal', 'Completed', 14),
(7, '2025-04-07', 'Debit Card', 'Completed', 17),
(8, '2025-04-08', 'Credit Card', 'Pending', 19),
(9, '2025-04-09', 'PayPal', 'Completed', 21),
(10, '2025-04-10', 'Bank Transfer', 'Completed', 24),
(11, '2025-04-11', 'Debit Card', 'Completed', 25),
(12, '2025-04-12', 'Credit Card', 'Pending', 27),
(13, '2025-04-13', 'PayPal', 'Completed', 29),
(14, '2025-04-14', 'Credit Card', 'Completed', 32),
(15, '2025-04-15', 'Bank Transfer', 'Failed', 33),
(16, '2025-04-16', 'PayPal', 'Completed', 36),
(17, '2025-04-17', 'Debit Card', 'Completed', 38),
(18, '2025-04-18', 'Credit Card', 'Completed', 39),
(19, '2025-04-19', 'Bank Transfer', 'Pending', 42),
(20, '2025-04-20', 'PayPal', 'Completed', 43),
(21, '2025-04-21', 'Credit Card', 'Completed', 46),
(22, '2025-04-22', 'Debit Card', 'Pending', 48),
(23, '2025-04-23', 'PayPal', 'Completed', 49),
(24, '2025-04-24', 'Bank Transfer', 'Failed', 51),
(25, '2025-04-25', 'Credit Card', 'Completed', 52),
(26, '2025-04-26', 'PayPal', 'Completed', 53),
(27, '2025-04-27', 'Debit Card', 'Completed', 54),
(28, '2025-04-28', 'Bank Transfer', 'Pending', 55),
(29, '2025-04-29', 'Credit Card', 'Completed', 56),
(30, '2025-04-30', 'PayPal', 'Completed', 57),
(31, '2025-05-01', 'Debit Card', 'Pending', 58),
(32, '2025-05-02', 'Bank Transfer', 'Completed', 59),
(33, '2025-05-03', 'Credit Card', 'Completed', 60),
(34, '2025-05-04', 'PayPal', 'Failed', 61),
(35, '2025-05-05', 'Debit Card', 'Completed', 62),
(36, '2025-05-06', 'Bank Transfer', 'Completed', 63),
(37, '2025-05-07', 'Credit Card', 'Pending', 64),
(38, '2025-05-08', 'PayPal', 'Completed', 65),
(39, '2025-05-09', 'Debit Card', 'Completed', 66),
(40, '2025-05-10', 'Bank Transfer', 'Completed', 67),
(41, '2025-05-11', 'Credit Card', 'Completed', 68),
(42, '2025-05-12', 'PayPal', 'Pending', 3),
(43, '2025-05-13', 'Debit Card', 'Completed', 4),
(44, '2025-05-14', 'Bank Transfer', 'Failed', 7),
(45, '2025-05-15', 'Credit Card', 'Completed', 9),
(46, '2025-05-16', 'PayPal', 'Completed', 13),
(47, '2025-05-17', 'Debit Card', 'Completed', 14),
(48, '2025-05-18', 'Bank Transfer', 'Completed', 17),
(49, '2025-05-19', 'Credit Card', 'Pending', 19),
(50, '2025-05-20', 'PayPal', 'Completed', 21);

--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------BookingAttempt-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////
INSERT INTO BookingAttempt (AttemptID, AttemptDate, IsCompleted, TravelerID, TripID)
VALUES
(1, '2025-04-21', 1, 3, 1),
(2, '2025-04-22', 0, 4, 2),
(3, '2025-04-23', 1, 7, 3),
(4, '2025-04-24', 1, 9, 4),
(5, '2025-04-25', 0, 13, 5),
(6, '2025-04-26', 1, 14, 6),
(7, '2025-04-27', 1, 17, 7),
(8, '2025-04-28', 0, 19, 8),
(9, '2025-04-29', 1, 21, 9),
(10, '2025-04-30', 1, 24, 10),
(11, '2025-05-01', 0, 25, 11),
(12, '2025-05-02', 1, 27, 12),
(13, '2025-05-03', 0, 29, 13),
(14, '2025-05-04', 1, 32, 14),
(15, '2025-05-05', 1, 33, 15),
(16, '2025-05-06', 0, 36, 16),
(17, '2025-05-07', 1, 38, 17),
(18, '2025-05-08', 0, 39, 18),
(19, '2025-05-09', 1, 42, 19),
(20, '2025-05-10', 1, 43, 20),
(21, '2025-05-11', 0, 46, 21),
(22, '2025-05-12', 1, 48, 22),
(23, '2025-05-13', 1, 49, 23),
(24, '2025-05-14', 0, 51, 24),
(25, '2025-05-15', 1, 52, 25),
(26, '2025-05-16', 0, 53, 26),
(27, '2025-05-17', 1, 54, 27),
(28, '2025-05-18', 0, 55, 28),
(29, '2025-05-19', 1, 56, 29),
(30, '2025-05-20', 0, 57, 30),
(31, '2025-05-21', 1, 58, 31),
(32, '2025-05-22', 0, 59, 32),
(33, '2025-05-23', 1, 60, 33),
(34, '2025-05-24', 1, 61, 34),
(35, '2025-05-25', 0, 62, 35),
(36, '2025-05-26', 1, 63, 36),
(37, '2025-05-27', 1, 64, 37),
(38, '2025-05-28', 0, 65, 38),
(39, '2025-05-29', 1, 66, 39),
(40, '2025-05-30', 0, 67, 40),
(41, '2025-06-01', 1, 68, 41),
(42, '2025-06-02', 1, 3, 42),
(43, '2025-06-03', 0, 4, 43),
(44, '2025-06-04', 1, 7, 44),
(45, '2025-06-05', 0, 9, 45),
(46, '2025-06-06', 1, 13, 46),
(47, '2025-06-07', 1, 14, 47),
(48, '2025-06-08', 0, 17, 48),
(49, '2025-06-09', 1, 19, 49),
(50, '2025-06-10', 1, 21, 50);

--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------Booking-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////
-- Inserting 10 records with AttemptID where IsCompleted = 1, AdminID values from the provided list, and PaymentID from 1 to 50.

INSERT INTO Booking (BookingID, TotalAmount, NumberOfPeople, Date, AdminID, PaymentID, AttemptID)
VALUES
(1, 2500.00, 3, '2025-04-20', 5, 1, 1),
(2, 3500.00, 4, '2025-04-21', 8, 2, 3),
(3, 4500.00, 5, '2025-04-22', 11, 3, 4),
(4, 5000.00, 6, '2025-04-23', 15, 4, 6),
(5, 3700.00, 4, '2025-04-24', 18, 5, 7),
(6, 5500.00, 6, '2025-04-25', 23, 6, 9),
(7, 3200.00, 3, '2025-04-26', 28, 7, 10),
(8, 2800.00, 3, '2025-04-27', 31, 8, 12),
(9, 4200.00, 5, '2025-04-28', 35, 9, 14),
(10, 5000.00, 6, '2025-04-29', 41, 10, 15),
(11, 2700.00, 3, '2025-04-30', 45, 11, 17),
(12, 3200.00, 4, '2025-05-01', 5, 12, 19),
(13, 4200.00, 5, '2025-05-02', 8, 13, 20),
(14, 4700.00, 6, '2025-05-03', 11, 14, 22),
(15, 5600.00, 7, '2025-05-04', 15, 15, 23),
(16, 4300.00, 5, '2025-05-05', 18, 16, 25),
(17, 6000.00, 6, '2025-05-06', 23, 17, 27),
(18, 3800.00, 4, '2025-05-07', 28, 18, 29),
(19, 5200.00, 6, '2025-05-08', 31, 19, 31),
(20, 4500.00, 5, '2025-05-09', 35, 20, 33),
(21, 4900.00, 6, '2025-05-10', 41, 21, 34),
(22, 3700.00, 4, '2025-05-11', 45, 22, 36),
(23, 4100.00, 5, '2025-05-12', 5, 23, 37),
(24, 5600.00, 6, '2025-05-13', 8, 24, 39),
(25, 5300.00, 6, '2025-05-14', 11, 25, 41),
(26, 5900.00, 7, '2025-05-15', 15, 26, 42),
(27, 3200.00, 4, '2025-05-16', 18, 27, 44),
(28, 4800.00, 5, '2025-05-17', 23, 28, 46),
(29, 5500.00, 6, '2025-05-18', 28, 29, 47),
(30, 5000.00, 5, '2025-05-19', 31, 30, 49),
(31, 5200.00, 6, '2025-05-20', 35, 31, 50);
--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------Itinerary-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////


INSERT INTO Itinerary (ItineraryID, DayNumber, Title, Location, StartTime, EndTime, TripID)
VALUES
(1, 1, 'Morning Trek', 'Mountains', '08:00:00', '12:00:00', 1),
(2, 2, 'City Tour', 'Downtown', '09:00:00', '12:00:00', 1),
(3, 3, 'Beach Relaxation', 'Sunny Beach', '10:00:00', '15:00:00', 1),
(4, 1, 'Desert Safari', 'Sahara', '07:00:00', '12:00:00', 2),
(5, 2, 'Historical Monuments', 'Old Town', '09:00:00', '13:00:00', 2),
(6, 3, 'Sunset View', 'Desert Lookout', '16:00:00', '18:00:00', 2),
(7, 1, 'Morning Yoga', 'Beachfront', '06:00:00', '08:00:00', 3),
(8, 2, 'Market Visit', 'City Market', '10:00:00', '13:00:00', 3),
(9, 3, 'Dinner Cruise', 'Harbor', '18:00:00', '21:00:00', 3),
(10, 1, 'Cultural Show', 'Main Square', '19:00:00', '21:00:00', 4),
(11, 2, 'Hiking Adventure', 'Hillside', '07:00:00', '12:00:00', 4),
(12, 3, 'City Exploration', 'City Center', '09:00:00', '14:00:00', 4),
(13, 1, 'Safari Tour', 'National Park', '08:00:00', '11:00:00', 5),
(14, 2, 'Local Cuisine Tasting', 'Street Market', '12:00:00', '14:00:00', 5),
(15, 3, 'Evening Relaxation', 'Lakeside', '17:00:00', '20:00:00', 5),
(16, 1, 'Forest Trek', 'Woodland Trails', '08:00:00', '11:00:00', 6),
(17, 2, 'Waterfalls Visit', 'River Canyon', '10:00:00', '13:00:00', 6),
(18, 3, 'Night Sky Stargazing', 'Mountain Peak', '20:00:00', '22:00:00', 6),
(19, 1, 'Cave Exploration', 'Underground Caverns', '08:00:00', '11:00:00', 7),
(20, 2, 'Historical Site Visit', 'Ruins', '09:00:00', '12:00:00', 7),
(21, 3, 'Sunset at the Beach', 'Coastal View', '17:00:00', '20:00:00', 7),
(22, 1, 'Morning Hike', 'Mountain Trails', '07:00:00', '11:00:00', 8),
(23, 2, 'Cultural Dinner', 'City Restaurant', '18:00:00', '21:00:00', 8),
(24, 3, 'Shopping and Souvenir', 'Local Markets', '10:00:00', '14:00:00', 8),
(25, 1, 'Mountain Biking', 'Hillside Trails', '08:00:00', '11:00:00', 9),
(26, 2, 'Visit to Museum', 'City Museum', '09:00:00', '12:00:00', 9),
(27, 3, 'Relaxation at Spa', 'Luxury Resort', '14:00:00', '17:00:00', 9),
(28, 1, 'Rock Climbing', 'Cliffside', '08:00:00', '12:00:00', 10),
(29, 2, 'Botanical Gardens', 'City Park', '10:00:00', '13:00:00', 10),
(30, 3, 'Music Night', 'Beachside', '19:00:00', '22:00:00', 10),
(31, 1, 'Snorkeling Adventure', 'Coral Reef', '09:00:00', '12:00:00', 11),
(32, 2, 'Nature Walk', 'Forest Area', '08:00:00', '11:00:00', 11),
(33, 3, 'Dinner and Dance', 'City Club', '20:00:00', '23:00:00', 11),
(34, 1, 'Jet Skiing', 'Oceanfront', '08:00:00', '10:00:00', 12),
(35, 2, 'Gastronomy Tour', 'Food Street', '12:00:00', '15:00:00', 12),
(36, 3, 'Late Night Walk', 'City Beach', '21:00:00', '23:00:00', 12),
(37, 1, 'Safari Tour', 'Wildlife Reserve', '07:00:00', '10:00:00', 13),
(38, 2, 'River Rafting', 'River Valley', '09:00:00', '12:00:00', 13),
(39, 3, 'Cooking Class', 'Local Kitchen', '15:00:00', '18:00:00', 13),
(40, 1, 'Cultural Walk', 'Ancient Streets', '10:00:00', '12:00:00', 14),
(41, 2, 'Spa and Wellness', 'Mountain Resort', '11:00:00', '14:00:00', 14),
(42, 3, 'Visit to Vineyard', 'Wine Estate', '13:00:00', '16:00:00', 14),
(43, 1, 'Canoeing', 'Lake', '08:00:00', '10:00:00', 15),
(44, 2, 'Wine Tasting', 'Wine Cellar', '12:00:00', '15:00:00', 15),
(45, 3, 'Fishing Trip', 'River Banks', '07:00:00', '10:00:00', 15),
(46, 1, 'City Walking Tour', 'Old Town', '09:00:00', '12:00:00', 16),
(47, 2, 'Visit to Castle', 'Historic Castle', '11:00:00', '14:00:00', 16),
(48, 3, 'Live Performance', 'City Theater', '19:00:00', '21:00:00', 16),
(49, 1, 'Beach Volleyball', 'Coastal Resort', '08:00:00', '11:00:00', 17),
(50, 2, 'Island Tour', 'Tropical Island', '09:00:00', '12:00:00', 17),
(51, 3, 'Dinner on Yacht', 'Harbor', '18:00:00', '21:00:00', 17),
(52, 1, 'Caving', 'Underground Tunnels', '08:00:00', '12:00:00', 18),
(53, 2, 'Dune Bashing', 'Sand Dunes', '10:00:00', '13:00:00', 18),
(54, 3, 'Desert Stargazing', 'Desert Plateau', '20:00:00', '23:00:00', 18),
(55, 1, 'Horseback Riding', 'Countryside', '07:00:00', '11:00:00', 19),
(56, 2, 'Historical Walking Tour', 'Old Town', '10:00:00', '13:00:00', 25),
(57, 3, 'Beach Party', 'Beach Resort', '18:00:00', '22:00:00', 19),
(58, 1, 'Cultural Experience', 'Local Village', '08:00:00', '11:00:00', 20),
(59, 2, 'Botanical Garden Tour', 'Botanical Park', '10:00:00', '13:00:00', 20),
(60, 3, 'Cruise Dinner', 'Sea View', '19:00:00', '22:00:00', 20),
(61, 1, 'Mountain Climbing', 'High Peak', '06:00:00', '12:00:00', 21),
(62, 2, 'Cultural Dinner', 'Heritage Restaurant', '18:00:00', '21:00:00', 21),
(63, 3, 'Nature Photography', 'Wildlife Park', '08:00:00', '11:00:00', 21),
(64, 1, 'Scuba Diving', 'Coral Reefs', '09:00:00', '12:00:00', 22),
(65, 2, 'Island Hopping', 'Tropical Islands', '10:00:00', '13:00:00', 22),
(66, 3, 'Night Market', 'Night Bazaar', '18:00:00', '22:00:00', 22),
(67, 1, 'Hiking in Nature', 'Mountain Trails', '07:00:00', '11:00:00', 23),
(68, 2, 'Cooking Experience', 'Local Kitchen', '12:00:00', '14:00:00', 23),
(69, 3, 'Street Food Tasting', 'City Streets', '17:00:00', '20:00:00', 23),
(70, 1, 'Vineyard Tour', 'Wine Estate', '09:00:00', '12:00:00', 24);


--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------TravelPass-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////
INSERT INTO TravelPass (PassID, Type, GeneratedDate, BookingID) VALUES
(1, 'Standard', '2025-04-01', 1),
(2, 'Premium', '2025-04-02', 2),
(3, 'VIP', '2025-04-03', 3),
(4, 'Standard', '2025-04-04', 4),
(5, 'Premium', '2025-04-05', 5),
(6, 'VIP', '2025-04-06', 6),
(7, 'Standard', '2025-04-07', 7),
(8, 'Premium', '2025-04-08', 8),
(9, 'VIP', '2025-04-09', 9),
(10, 'Standard', '2025-04-10', 10),
(11, 'Premium', '2025-04-11', 11),
(12, 'VIP', '2025-04-12', 12),
(13, 'Standard', '2025-04-13', 13),
(14, 'Premium', '2025-04-14', 14),
(15, 'VIP', '2025-04-15', 15),
(16, 'Standard', '2025-04-16', 16),
(17, 'Premium', '2025-04-17', 17),
(18, 'VIP', '2025-04-18', 18),
(19, 'Standard', '2025-04-19', 19),
(20, 'Premium', '2025-04-20', 20),
(21, 'VIP', '2025-04-21', 21),
(22, 'Standard', '2025-04-22', 22),
(23, 'Premium', '2025-04-23', 23),
(24, 'VIP', '2025-04-24', 24),
(25, 'Standard', '2025-04-25', 25),
(26, 'Premium', '2025-04-26', 26),
(27, 'VIP', '2025-04-27', 27),
(28, 'Standard', '2025-04-28', 28),
(29, 'Premium', '2025-04-29', 29),
(30, 'VIP', '2025-04-30', 30);
--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------Preference-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////
INSERT INTO Preferences (PreferenceID, BudgetRange) VALUES
(1, 'Low'),
(2, 'Medium'),
(3, 'High'),
(4, 'Low'),
(5, 'Medium'),
(6, 'High'),
(7, 'Low'),
(8, 'Medium'),
(9, 'High'),
(10, 'Low'),
(11, 'Medium'),
(12, 'High'),
(13, 'Low'),
(14, 'Medium'),
(15, 'High'),
(16, 'Low'),
(17, 'Medium'),
(18, 'High'),
(19, 'Low'),
(20, 'Medium');

--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------Traveler_Preference-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////
INSERT INTO Traveler_Preference (PreferenceID, TravelerID) VALUES
(1, 3),
(2, 4),
(3, 7),
(4, 9),
(5, 13),
(6, 14),
(7, 17),
(8, 19),
(9, 21),
(10, 24),
(11, 25),
(12, 27),
(13, 29),
(14, 32),
(15, 33),
(16, 36),
(17, 38),
(18, 39),
(19, 42),
(20, 43),
(1, 46),
(2, 48),
(3, 49),
(4, 51),
(5, 52),
(6, 53),
(7, 54),
(8, 55),
(9, 56),
(10, 57);

--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------WishList-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////

INSERT INTO WishList (WishListID, TravelerID) VALUES
(1, 3),
(2, 4),
(3, 7),
(4, 9),
(5, 13),
(6, 14),
(7, 17),
(8, 19),
(9, 21),
(10, 24),
(11, 25),
(12, 27),
(13, 29),
(14, 32),
(15, 33),
(16, 36),
(17, 38),
(18, 39),
(19, 42),
(20, 43),
(21, 46),
(22, 48),
(23, 49),
(24, 51),
(25, 52),
(26, 53),
(27, 54),
(28, 55),
(29, 56),
(30, 57),
(31, 58),
(32, 59),
(33, 60),
(34, 61),
(35, 62),
(36, 63),
(37, 64),
(38, 65),
(39, 66),
(40, 67),
(41, 68),
(42, 3),
(43, 4),
(44, 7),
(45, 9),
(46, 13),
(47, 14),
(48, 17),
(49, 19),
(50, 21);

--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------WishList_Contains-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////


INSERT INTO WishList_Contains (WishListItemID, WishListID, TripID, DateAdded, IsNotified) VALUES
(1, 1, 1, '2025-04-01', 1),
(2, 2, 2, '2025-04-02', 0),
(3, 3, 3, '2025-04-03', 1),
(4, 4, 4, '2025-04-04', 0),
(5, 5, 5, '2025-04-05', 1),
(6, 6, 6, '2025-04-06', 1),
(7, 7, 7, '2025-04-07', 0),
(8, 8, 8, '2025-04-08', 1),
(9, 9, 9, '2025-04-09', 1),
(10, 10, 10, '2025-04-10', 0),
(11, 11, 11, '2025-04-11', 1),
(12, 12, 12, '2025-04-12', 0),
(13, 13, 13, '2025-04-13', 1),
(14, 14, 14, '2025-04-14', 0),
(15, 15, 15, '2025-04-15', 1),
(16, 16, 16, '2025-04-16', 1),
(17, 17, 17, '2025-04-17', 0),
(18, 18, 18, '2025-04-18', 1),
(19, 19, 19, '2025-04-19', 0),
(20, 20, 20, '2025-04-20', 1),
(21, 21, 21, '2025-04-21', 0),
(22, 22, 22, '2025-04-22', 1),
(23, 23, 23, '2025-04-23', 0),
(24, 24, 24, '2025-04-24', 1),
(25, 25, 25, '2025-04-25', 0),
(26, 26, 26, '2025-04-26', 1),
(27, 27, 27, '2025-04-27', 0),
(28, 28, 28, '2025-04-28', 1),
(29, 29, 29, '2025-04-29', 0),
(30, 30, 30, '2025-04-30', 1),
(31, 31, 31, '2025-05-01', 0),
(32, 32, 32, '2025-05-02', 1),
(33, 33, 33, '2025-05-03', 0),
(34, 34, 34, '2025-05-04', 1),
(35, 35, 35, '2025-05-05', 0),
(36, 36, 36, '2025-05-06', 1),
(37, 37, 37, '2025-05-07', 0),
(38, 38, 38, '2025-05-08', 1),
(39, 39, 39, '2025-05-09', 0),
(40, 40, 40, '2025-05-10', 1),
(41, 41, 41, '2025-05-11', 0),
(42, 42, 42, '2025-05-12', 1),
(43, 43, 43, '2025-05-13', 0),
(44, 44, 44, '2025-05-14', 1),
(45, 45, 45, '2025-05-15', 0),
(46, 46, 46, '2025-05-16', 1),
(47, 47, 47, '2025-05-17', 0),
(48, 48, 48, '2025-05-18', 1),
(49, 49, 49, '2025-05-19', 0),
(50, 50, 50, '2025-05-20', 1);
--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------Hotel-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////



INSERT INTO Hotel (HotelID, HotelName, Rooms, AvailabilityStatus, Location, Stars, ProviderID) VALUES
(1, 'Grand Plaza Hotel', 150, 'Available', 'Lahore', 5, 1),
(2, 'Ritz Carlton', 120, 'Available', 'Islamabad', 5, 4),
(3, 'Oceanview Resort', 200, 'Not Available', 'Karachi', 4, 7),
(4, 'Mountain Lodge', 80, 'Available', 'Murree', 3, 10),
(5, 'Cityscape Inn', 50, 'Available', 'Rawalpindi', 4, 13),
(6, 'Sunset Suites', 100, 'Available', 'Faisalabad', 5, 16),
(7, 'Golden Sands Resort', 200, 'Not Available', 'Karachi', 5, 19),
(8, 'Royal Palm Hotel', 300, 'Available', 'Lahore', 4, 22),
(9, 'The Grand Hyatt', 250, 'Not Available', 'Islamabad', 5, 25),
(10, 'Sapphire Heights', 60, 'Available', 'Multan', 3, 29),
(11, 'Shangri-La Resort', 180, 'Not Available', 'Hunza', 5, 32),
(12, 'The Royal Garden', 120, 'Available', 'Peshawar', 4, 35),
(13, 'Lakeview Hotel', 90, 'Available', 'Gilgit', 4, 38),
(14, 'Palm Breeze Resort', 110, 'Not Available', 'Karachi', 5, 41),
(15, 'Hilltop Suites', 75, 'Available', 'Abbottabad', 3, 44);
--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------ServiceAssignment-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////
INSERT INTO ServiceAssignment (AssignmentID, ProviderID, OperatorID) VALUES
(1, 1, 2),
(2, 4, 6),
(3, 7, 10),
(4, 10, 12),
(5, 13, 16),
(6, 16, 20),
(7, 19, 22),
(8, 22, 26),
(9, 25, 30),
(10, 29, 34),
(11, 32, 37),
(12, 35, 40),
(13, 38, 44),
(14, 41, 47),
(15, 44, 50),
(16, 1, 69),
(17, 4, 70),
(18, 7, 2),
(19, 10, 6),
(20, 13, 10),
(21, 16, 12),
(22, 19, 16),
(23, 22, 20),
(24, 25, 22),
(25, 29, 26),
(26, 32, 30),
(27, 35, 34),
(28, 38, 37),
(29, 41, 40),
(30, 44, 44),
(31, 1, 47),
(32, 4, 50),
(33, 7, 69),
(34, 10, 70),
(35, 13, 2),
(36, 16, 6),
(37, 19, 10),
(38, 22, 12),
(39, 25, 16),
(40, 29, 20),
(41, 32, 22),
(42, 35, 26),
(43, 38, 30),
(44, 41, 34),
(45, 44, 37),
(46, 1, 40),
(47, 4, 44),
(48, 7, 47),
(49, 10, 50),
(50, 13, 69);
--//////////////////////////////////////////////////////////////////////////////////////////////////////
------------------------------------------------Review-----------------------------------------------
--//////////////////////////////////////////////////////////////////////////////////////////////////////

INSERT INTO Review (ReviewID, Rating, ReviewDate, Comment, OperatorID, TravelerID, TripID, AdminID)
VALUES
(1, 5, '2025-04-01', 'Amazing experience!', 2, 3, 1, 1),
(2, 4, '2025-04-02', 'Great trip but could improve the accommodations.', 6, 4, 2, 5),
(3, 5, '2025-04-03', 'The best holiday ever!', 10, 7, 3, 8),
(4, 3, '2025-04-04', 'Good trip, but food could be better.', 12, 9, 4, 11),
(5, 4, '2025-04-05', 'Enjoyed the journey, would go again!', 16, 13, 5, 15),
(6, 5, '2025-04-06', 'Wonderful trip with a fantastic guide.', 20, 14, 6, 18),
(7, 4, '2025-04-07', 'Beautiful destination, but very crowded.', 22, 17, 7, 23),
(8, 3, '2025-04-08', 'Decent trip, but the transport was uncomfortable.', 26, 19, 8, 28),
(9, 5, '2025-04-09', 'Had a blast, everything was perfect!', 30, 21, 9, 31),
(10, 4, '2025-04-10', 'Great experience, but needs better planning.', 34, 24, 10, 35),
(11, 5, '2025-04-11', 'Fantastic, I would recommend this trip to everyone!', 37, 25, 11, 41),
(12, 4, '2025-04-12', 'Good overall, but the weather could have been better.', 40, 27, 12, 45),
(13, 3, '2025-04-13', 'Could have been better organized.', 44, 29, 13, 1),
(14, 5, '2025-04-14', 'Excellent trip with amazing views.', 47, 32, 14, 5),
(15, 4, '2025-04-15', 'The trip was great, but the accommodation was not up to expectations.', 50, 33, 15, 8),
(16, 3, '2025-04-16', 'Average experience, not what I expected.', 2, 36, 16, 11),
(17, 4, '2025-04-17', 'Nice, but too much time spent traveling.', 6, 38, 17, 15),
(18, 5, '2025-04-18', 'Amazing guide and itinerary!', 10, 39, 18, 18),
(19, 3, '2025-04-19', 'Not a bad trip, but it was very rushed.', 12, 42, 19, 23),
(20, 4, '2025-04-20', 'Good, but some activities were overpriced.', 16, 43, 20, 28),
(21, 5, '2025-04-21', 'Everything was perfect, will do again!', 20, 46, 21, 31),
(22, 4, '2025-04-22', 'Lovely trip, but the meals were not great.', 22, 48, 22, 35),
(23, 3, '2025-04-23', 'It was okay, but it didn�t meet my expectations.', 26, 49, 23, 41),
(24, 5, '2025-04-24', 'One of the best experiences of my life!', 30, 51, 24, 45),
(25, 4, '2025-04-25', 'Nice experience, could have been better organized.', 34, 52, 25, 1),
(26, 5, '2025-04-26', 'Amazing views and great guides!', 37, 53, 26, 5),
(27, 3, '2025-04-27', 'A decent trip but nothing extraordinary.', 40, 54, 27, 8),
(28, 4, '2025-04-28', 'Good trip but the schedule was a bit tight.', 44, 55, 28, 11),
(29, 5, '2025-04-29', 'A fantastic journey with beautiful experiences.', 47, 56, 29, 15),
(30, 3, '2025-04-30', 'Too crowded for my liking.', 50, 57, 30, 18)




-- Add TripStatus column to Trip table
ALTER TABLE Trip ADD TripStatus VARCHAR(20);

-- Update TripStatus for the first 50 rows (already inserted)
UPDATE Trip SET TripStatus = 'Upcoming' WHERE TripID IN (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25);
UPDATE Trip SET TripStatus = 'Completed' WHERE TripID IN (26, 27, 28, 29, 30, 31, 32, 33, 34, 35);
UPDATE Trip SET TripStatus = 'Upcoming' WHERE TripID IN (36, 37, 38, 39, 40, 41, 42, 43, 44, 45);
UPDATE Trip SET TripStatus = 'Completed' WHERE TripID IN (46, 47, 48, 49, 50);


INSERT INTO TripDestinations (DestinationID, TripID, Destination)
VALUES
(21, 21, 'Venice'),
(22, 22, 'Seoul'),
(23, 23, 'Prague'),
(24, 24, 'Lisbon'),
(25, 25, 'Vienna'),
(26, 26, 'Helsinki'),
(27, 27, 'Cape Town'),
(28, 28, 'Buenos Aires'),
(29, 29, 'Moscow'),
(30, 30, 'Reykjavik'),
(31, 31, 'Oslo'),
(32, 32, 'Zurich'),
(33, 33, 'Budapest'),
(34, 34, 'Athens'),
(35, 35, 'Warsaw'),
(36, 36, 'Edinburgh'),
(37, 37, 'Dublin'),
(38, 38, 'Manila'),
(39, 39, 'Doha'),
(40, 40, 'Kuala Lumpur'),
(41, 41, 'Mexico City'),
(42, 42, 'Montreal'),
(43, 43, 'Vancouver'),
(44, 44, 'Brussels'),
(45, 45, 'Lima'),
(46, 46, 'Casablanca'),
(47, 47, 'Hanoi'),
(48, 48, 'Phuket'),
(49, 49, 'Auckland'),
(50, 50, 'Beijing');



    ALTER TABLE Person ADD Email VARCHAR(100), PhoneNumber VARCHAR(20);
	    ALTER TABLE Booking ADD Status VARCHAR(50);
