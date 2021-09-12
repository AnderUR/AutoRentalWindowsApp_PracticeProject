--CREATE THE DATABASE
CREATE DATABASE EZRentalDB;

--SET DEFAULT DATABASE TO USE
use EZRentalDB;

--CREATE CREDITCARD TABLE
CREATE TABLE CreditCard
(
	CreditCardNumber	CHAR(16)		PRIMARY KEY,
	OwnerName			VARCHAR(80)		NOT NULL,
	MerchantName		VARCHAR(50)		NOT NULL,
	ExpDate				DATE			NOT NULL,
	AddressLine1		VARCHAR(50)		NOT NULL,
	AddressLine2		VARCHAR(50)		NOT NULL,
	City				VARCHAR(40)		NOT NULL,
	StateCode			CHAR(2)			NOT NULL,
	ZipCode				VARCHAR(10)		NOT NULL,
	Country				VARCHAR(60)		NOT NULL,
	CreditCardLimit		DECIMAL(9,2)	NOT NULL,
	CreditCardBalance	DECIMAL(9,2)	NOT NULL,
	ActivationStatus	BIT				NOT NULL
);

	
--CREATE EMPLOYEE USER ACCOUNT TABLE
CREATE TABLE EmployeeUserAccount
(
	EmployeeUserAccountID	CHAR(36)		PRIMARY KEY,
	Username				VARCHAR(50)		UNIQUE NOT NULL,
	Password				VARCHAR(75)		NOT NULL,
	Email					VARCHAR(100)	UNIQUE NOT NULL
);

--CREATE EMPLOYEE TABLE
CREATE TABLE Employee
(
	EmployeeID				INT IDENTITY(1111111,1)	PRIMARY KEY	NOT NULL,
	FirstName				VARCHAR(50)				NOT NULL,
	LastName				VARCHAR(50)				NOT NULL,
	SSNumber				CHAR(11)				UNIQUE NOT NULL,
	BirthDate				DATE					NOT NULL,
	AddressLine1			VARCHAR(50)				NOT NULL,
	AddressLine2			VARCHAR(50)				NOT NULL,
	City					VARCHAR(60)				NOT NULL,
	StateCode				CHAR(2)					NOT NULL,
	ZipCode					VARCHAR(10)				NOT NULL,
	Country					VARCHAR(60)				NOT NULL,
	EmployeePhone			VARCHAR(20)				NOT NULL,
	EmployeeJobTitle		VARCHAR(90)				NOT NULL,
	EmployeeEmail			VARCHAR(100)			UNIQUE NOT NULL,
	EmployeeUserAccountID	CHAR(36)				NOT NULL,

	CONSTRAINT fk_EmployeeUserAccountID_Employee
	FOREIGN KEY (EmployeeUserAccountID)
	REFERENCES EmployeeUserAccount(EmployeeUserAccountID)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--CREATE CUSTOMER USER ACCOUNT TABLE
CREATE TABLE CustomerUserAccount
(
	CustomerUserAccountID	UNIQUEIDENTIFIER	PRIMARY KEY DEFAULT NEWID(),
	Username				VARCHAR(50)			UNIQUE NOT NULL,
	Password				VARCHAR(75)			NOT NULL,
	Email					VARCHAR(100)		UNIQUE NOT NULL
);

--CREATE CUSTOMER TABLE
CREATE TABLE Customer
(
	CustomerID				INT IDENTITY(11111111,1)	PRIMARY KEY NOT NULL,
	FirstName				VARCHAR(50)					NOT NULL, 
	LastName				VARCHAR(50)					NOT NULL,
	BirthDate				DATE						NOT NULL,
	AddressLine1			VARCHAR(50)					NOT NULL,
	AddressLine2			VARCHAR(50)					NOT NULL,
	City					VARCHAR(60)					NOT NULL,
	StateCode				CHAR(2)						NOT NULL,
	ZipCode					VARCHAR(10)					NOT NULL,
	Country					VARCHAR(60)					NOT NULL,
	Phone					VARCHAR(20)					NOT NULL,
	Email					VARCHAR(100)				UNIQUE NOT NULL,
	DriverLicenseNumber		VARCHAR(25)					UNIQUE NOT NULL,
	DriverLicenseExpDate	DATE						NOT NULL,
	CustomerUserAccountID	UNIQUEIDENTIFIER					NULL,
	CustomerType			CHAR(1)						NOT NULL,

	CONSTRAINT fk_CustomerUserAccountID_Customer
	FOREIGN KEY (CustomerUserAccountID)
	REFERENCES CustomerUserAccount(CustomerUserAccountID)
);

--CREATE CUSTOMER_CREDITCARD TABLE
CREATE TABLE Customer_CreditCard
(
	CreditCardNumber	CHAR(16)	NOT NULL,
	CustomerID			INT			NOT NULL,

	CONSTRAINT pk_Customer_CreditCard
	PRIMARY KEY (CreditCardNumber, CustomerID),

	CONSTRAINT fk_CCNumber_CustomerCC
	FOREIGN KEY (CreditCardNumber)
	REFERENCES CreditCard(CreditCardNumber)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_CustomerID_CustomerCC
	FOREIGN KEY (CustomerID)
	REFERENCES Customer(CustomerID)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--CREATE DISCOUNT TABLE
CREATE TABLE Discount
(
	DiscountID			INT IDENTITY	PRIMARY KEY,
	DiscountCode		CHAR(8)			UNIQUE NOT NULL,
	DiscountCodeDesc	VARCHAR(148)	NOT NULL
);

--CREATE EZPLUS TABLE
CREATE TABLE EZPlus
(
	EZPlusID			INT IDENTITY	PRIMARY KEY,
	EZPlusRewardsCode	CHAR(8)			UNIQUE NOT NULL,
	EZPlusEarnedPoints	INT				NULL
);

--CREATE RETAIL CUSTOMER TABLE
CREATE TABLE RetailCustomer
(
	CustomerID	INT		PRIMARY KEY,
	DiscountID	INT 	NULL,
	EZPlusID	INT		NULL,

	CONSTRAINT fk_CustomerID_RetailCustomer
	FOREIGN KEY (CustomerID)
	REFERENCES Customer(CustomerID)
	ON DELETE CASCADE ON UPDATE CASCADE,


	CONSTRAINT fk_DiscountID_RetailCustomer
	FOREIGN KEY (DiscountID)
	REFERENCES Discount(DiscountID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_EZPlusID_RetailCustomer
	FOREIGN KEY (EZPlusID)
	REFERENCES EZPlus(EZPlusID)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--CREATE COMPANY TABLE
CREATE TABLE Company
(
	CompanyID				INT				PRIMARY KEY CHECK(CompanyID BETWEEN 1 AND 9999999),
	CompanyName				VARCHAR(50)		UNIQUE NOT NULL,
	AddressLine1			VARCHAR(50)		NOT NULL,
	AddressLine2			VARCHAR(50)		NOT NULL,
	City					VARCHAR(60)		NOT NULL,
	StateCode				CHAR(2)			NOT NULL,
	ZipCode					VARCHAR(10)		NOT NULL,
	Country					VARCHAR(60)		NOT NULL,
	ContactName				VARCHAR(100)	NOT NULL,
	ContactPhone			VARCHAR(20)		NOT NULL,
	ContactEmail			VARCHAR(100)	UNIQUE NOT NULL,	
	CompanyDailyRentalRate	DECIMAL(6,2)	NOT NULL,
);


--CREATE CORPORATE CUSTOMER TABLE
CREATE TABLE CorporateCustomer
(
	CustomerID		INT		PRIMARY KEY,
	CompanyID		INT		NOT NULL,

	CONSTRAINT	fk_CustomerID_CorporateCustomer
	FOREIGN KEY	(CustomerID)
	REFERENCES Customer(CustomerID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT	fk_CompanyID_CorporateCustomer
	FOREIGN KEY (CompanyID)
	REFERENCES Company(CompanyID)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--CREATE VEHICLE STATUS TABLE
CREATE TABLE VehicleStatus
(
	VehicleStatusID		TINYINT		PRIMARY KEY CHECK(VehicleStatusID BETWEEN 1 AND 9),
	VehicleStatusDesc	VARCHAR(40)	NOT NULL
);

--CREATE VEHICLE RENTAL CATEGORY 
CREATE TABLE VehicleRentalCategory
(
	VehicleRentalCategoryID		TINYINT			PRIMARY KEY	CHECK(VehicleRentalCategoryID BETWEEN 1 AND 25),
	CategoryName				VARCHAR(40)		UNIQUE NOT NULL,
	CategoryDailyRentalRate		DECIMAL(5,2)	NOT NULL
);

--CREATE RENTAL AGENCY TABLE
CREATE TABLE RentalAgency
(
	RentalAgencyID		INT				PRIMARY KEY,
	RentalAgencyName	VARCHAR(100)	NOT NULL,
	AddressLine1		VARCHAR(50)		NOT NULL,
	AddressLine2		VARCHAR(50)		NOT NULL,
	City				VARCHAR(60)		NOT NULL,
	StateCode			CHAR(2)			NOT NULL,
	Country				VARCHAR(60)		NOT NULL,
	ZipCode				VARCHAR(10)		NOT NULL,
	Phone				VARCHAR(20)		NOT NULL,
	Email				VARCHAR(100)	UNIQUE NOT NULL
);

--CREATE RENTAL INSURANCE OPTION TABLE
CREATE TABLE RentalInsuranceOption
(
	InsuranceOptionID				TINYINT			PRIMARY KEY	CHECK(InsuranceOptionID BETWEEN 1 AND 8),
	InsuranceOptionDesc				VARCHAR(MAX)	NOT NULL,
	InsuranceOptionAdditionalCost	DECIMAL(5,2)	NOT NULL
);

--CREATE RENTAL STATUS TABLE
CREATE TABLE RentalStatus
(
	RentalStatusID	 	TINYINT			PRIMARY KEY	CHECK(RentalStatusID BETWEEN 1 AND 10),
	RentalStatusDesc	VARCHAR(40)		NOT NULL
);

--CREATE FUEL OPTION TABLE
CREATE TABLE FuelOption
(
	RentalFuelOptionID				TINYINT			PRIMARY KEY	CHECK(RentalFuelOptionID BETWEEN 1 AND 5),
	FuelOptionDesc					VARCHAR(95)		NOT NULL,
	RentalFuelOptionAdditionalCost	VARCHAR(105)	NOT NULL
);

--CREATE RESERVATION STATUS TABLE
CREATE TABLE ReservationStatus
(
	ReservationStatusID		TINYINT			PRIMARY KEY CHECK(ReservationStatusID BETWEEN 1 AND 9),
	ReservationStatusDesc	VARCHAR(30)		NOT NULL

);

--CREATE VEHICLE TABLE
CREATE TABLE Vehicle
(
	VehicleID						INT IDENTITY(111111,1)	PRIMARY KEY,
	VINNumber						CHAR(17)				UNIQUE NOT NULL,
	Make							VARCHAR(40)				NOT NULL,
	Model							VARCHAR(40)				NOT NULL,
	Year							SMALLINT				NOT NULL,
	Color							VARCHAR(27)				NOT NULL,
	LicensePlateNumber				VARCHAR(15)				NOT NULL,
	LicensePlateState				CHAR(2)					NOT NULL,
	Mileage							INT						CHECK(Mileage BETWEEN 1 AND 300000)	NOT NULL,
	TransmissionType				VARCHAR(50)				NOT NULL,
	SeatCapacity					TINYINT					NOT NULL,
	VehicleRentalCategoryID			TINYINT					CHECK(VehicleRentalCategoryID BETWEEN 1 AND 25) NOT NULL,
	VehicleStatusID					TINYINT					CHECK(VehicleStatusID BETWEEN 1 AND 9) NOT NULL,
	VehicleOwningAgencyID			INT						NOT NULL,
	VehicleCurrentLocationAgencyID	INT						NOT NULL,	
	VehicleType						CHAR(1)					NOT NULL,

	CONSTRAINT fk_VehicleRentalCategoryID_Vehicle
	FOREIGN KEY (VehicleRentalCategoryID)
	REFERENCES VehicleRentalCategory(VehicleRentalCategoryID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_VehicleStatusID_Vehicle
	FOREIGN KEY (VehicleStatusID)
	REFERENCES VehicleStatus(VehicleStatusID)
	ON DELETE CASCADE ON UPDATE CASCADE,


	CONSTRAINT fk_VehicleOwningAgencyID_Vehicle
	FOREIGN KEY (VehicleOwningAgencyID)
	REFERENCES RentalAgency(RentalAgencyID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_VehicleCurrentLocationAgencyID_Vehicle
	FOREIGN KEY (VehicleCurrentLocationAgencyID)
	REFERENCES RentalAgency(RentalAgencyID)
);

--CREATE CAR TABLE
CREATE TABLE Car
(
	VehicleID		INT				PRIMARY KEY,
	TrunkCapacity	Decimal(4,1)	NOT NULL,

	CONSTRAINT fk_VehicleID_Car
	FOREIGN KEY (VehicleId)
	REFERENCES Vehicle(VehicleID)
	ON DELETE CASCADE ON UPDATE CASCADE

);

--CREATE SUV TABLE
CREATE TABLE Suv
(
	VehicleID		INT			PRIMARY KEY,
	TowingCapacity	SMALLINT	NOT NULL,
	IsAWD			BIT			NOT NULL,

	CONSTRAINT fk_VehicleID_Suv
	FOREIGN KEY (VehicleId)
	REFERENCES Vehicle(VehicleID)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--CREATE MINIVAN TABLE
CREATE TABLE Minivan
(
	VehicleID			INT		PRIMARY KEY,
	HasDiabilityOption	BIT		NOT NULL,

	CONSTRAINT fk_VehicleID_Minivan
	FOREIGN KEY (VehicleId)
	REFERENCES Vehicle(VehicleID)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--CREATE CARGOVAN TABLE
CREATE TABLE Cargovan
(
	VehicleID		INT				PRIMARY KEY,
	CargoCapacity	DECIMAL(4,1)	NOT NULL,
	MaximumPayload	SMALLINT		NOT NULL,

	CONSTRAINT fk_VehicleID_Cargovan
	FOREIGN KEY (VehicleId)
	REFERENCES Vehicle(VehicleID)
	ON DELETE CASCADE ON UPDATE CASCADE		
);

--CREATE RESERVATION TABLE
CREATE TABLE Reservation
(
	ReservationID				INT			PRIMARY KEY,
	CustomerID					INT			NOT NULL,
	RentalAgencyID				INT			NOT NULL,
	VehicleRentalCategoryID		TINYINT		CHECK(VehicleRentalCategoryID BETWEEN 1 AND 25) NOT NULL,
	ReservationDropOffAgencyID	INT			NOT NULL,
	ReservationPickUpDate		DATE		NOT NULL,
	ReservationPickUpTime		INT			CHECK(ReservationPickUpTime BETWEEN 0000 AND 2400) NOT NULL,
	ReservationDropOffDate		DATE		NOT NULL,
	ReservationDropOffTime		INT			CHECK(ReservationDropOffTime BETWEEN 0000 AND 2400) NOT NULL,
	ReservationStatusID			TINYINT		CHECK(ReservationStatusID BETWEEN 1 AND 9) NOT NULL,

	CONSTRAINT fk_CustomerID_Reservation
	FOREIGN KEY (CustomerID)
	REFERENCES Customer(CustomerID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_ReservationAgencyID_Reservation
	FOREIGN KEY (RentalAgencyID)
	REFERENCES RentalAgency(RentalAgencyID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_VehicleRentalCategoryID_Reservation
	FOREIGN KEY (VehicleRentalCategoryID)
	REFERENCES VehicleRentalCategory(VehicleRentalCategoryID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_ReservationDropOffAgencyID_Reservation
	FOREIGN KEY (ReservationDropOffAgencyID)
	REFERENCES RentalAgency(RentalAgencyID),

	CONSTRAINT fk_ReservationStatusID_Reservation
	FOREIGN KEY	(ReservationStatusID)
	REFERENCES ReservationStatus(ReservationStatusID)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--CREATE RENTAL TABLE
CREATE TABLE Rental
(
	RentalAgreementID			INT				PRIMARY KEY,
	CustomerID					INT				NOT NULL,
	VehicleID					INT				NOT NULL,
	RentalAgencyID				INT				NOT NULL,
	RentalDropOffAgencyID		INT				NOT NULL,
	ReservationID				INT				NULL,
	RentalPickUpDate			DATE			NOT NULL,
	RentalPickUpTime			INT				CHECK(RentalPickUpTime BETWEEN 0000 AND 2400) NOT NULL,
	RentalDropOffDate			DATE			NOT NULL,
	RentalDropOffTime			INT				CHECK(RentalDropOffTime BETWEEN 0000 AND 2400) NOT NULL,
	RentalPickUpOdometerValue	INT				CHECK(RentalPickUpOdometerValue BETWEEN 0 AND 300000) NOT NULL,
	RentalDropOffOdometerValue	INT				CHECK(RentalDropOffOdometerValue BETWEEN 0 AND 300000) NOT NULL,
	RentalFuelOptionID			TINYINT			CHECK(RentalFuelOptionID BETWEEN 1 AND 5) NOT NULL,
	InsuranceOptionID			TINYINT			CHECK(InsuranceOptionID BETWEEN 1 AND 8) NOT NULL,
	RentalStatusID				TINYINT			CHECK(RentalStatusID BETWEEN 1 AND 10) NOT NULL,
	RentalDeposit				DECIMAL(7,2)	NOT NULL,

	CONSTRAINT fk_CustomerID_Rental
	FOREIGN KEY (CustomerID)
	REFERENCES Customer(CustomerID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_VehicleID_Rental
	FOREIGN KEY (VehicleID)
	REFERENCES Vehicle(VehicleID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_RentalAgencyID_Rental
	FOREIGN KEY (RentalAgencyID)
	REFERENCES RentalAgency(RentalAgencyID),
	
	CONSTRAINT fk_RentalDropOffAgencyID_Rental
	FOREIGN KEY (RentalDropOffAgencyID)
	REFERENCES RentalAgency(RentalAgencyID),

	CONSTRAINT fk_ReservationID_Rental
	FOREIGN KEY (ReservationID)
	REFERENCES Reservation(ReservationID),

	CONSTRAINT fk_RentalFuelOptionID_Rental
	FOREIGN KEY (RentalFuelOptionID)
	REFERENCES FuelOption(RentalFuelOptionID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_InsuranceOptionID_Rental
	FOREIGN KEY (InsuranceOptionID)
	REFERENCES RentalInsuranceOption(InsuranceOptionID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_RentalStatusID_Rental
	FOREIGN KEY	(RentalStatusID)
	REFERENCES RentalStatus(RentalStatusID)
	ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE TransportStatus(
	TransportStatusID		TINYINT			PRIMARY KEY CHECK(TransportStatusID BETWEEN 1 AND 9),
	TransportStatusDesc		VARCHAR(80)		NOT NULL
);

CREATE TABLE TransportReason(
	TransportReasonID		TINYINT			PRIMARY KEY CHECK(TransportReasonID BETWEEN 1 AND 9),
	TransportReasonDesc		VARCHAR(80)		NOT NULL
);

CREATE TABLE Transport(
	EmployeeID				INT			NOT NULL,
	VehicleID				INT			NOT NULL,
	PickUpRentalAgencyID	INT			NOT NULL,
	DropOffRentalAgencyID	INT			NOT NULL,
	DriverDepartureDate		DATE		NOT NULL,
	DriverDepartureTime		SMALLINT	CHECK(DriverDepartureTime BETWEEN 0 AND 2400) NOT NULL,
	VehiclePickUpDate		DATE		NOT NULL,	
	VehiclePickUpTime		SMALLINT	CHECK(VehiclePickUpTime BETWEEN 0 AND 2400) NOT NULL,
	VehicleDropOffDate		DATE		NOT NULL,
	VehicleDropOffTime		SMALLINT	CHECK(VehicleDropOffTime BETWEEN 0 AND 2400) NOT NULL,
	TransportStatusID		TINYINT		CHECK(TransportStatusID BETWEEN 1 AND 9) NOT NULL,
	TransportReasonID		TINYINT		CHECK(TransportReasonID BETWEEN 1 AND 9) NOT NULL,

	CONSTRAINT pk_Transport
	PRIMARY KEY (EmployeeID, VehicleID, PickUpRentalAgencyID),

	CONSTRAINT fk_EmployeeID_Transport
	FOREIGN KEY (EmployeeID)
	REFERENCES Employee(EmployeeID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_VehicleID_Transport
	FOREIGN KEY (VehicleID)
	REFERENCES Vehicle(VehicleID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_PickUpRentalAgencyID_Transport
	FOREIGN KEY (PickUpRentalAgencyID)
	REFERENCES RentalAgency(RentalAgencyID),

	CONSTRAINT fk_DropOffRentalAgencyID_Transport
	FOREIGN KEY (DropOffRentalAgencyID)
	REFERENCES RentalAgency(RentalAgencyID),

	CONSTRAINT fk_TransportStatusID_Transport
	FOREIGN KEY (TransportStatusID)
	REFERENCES TransportStatus(TransportStatusID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_TransportReasonID_Transport
	FOREIGN KEY (TransportReasonID)
	REFERENCES TransportReason(TransportReasonID)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--CREATE COUNTRY TABLE
CREATE TABLE Country
(
	CountryID		TINYINT			PRIMARY KEY,
	CountryCode2	CHAR(2)			UNIQUE NOT NULL,
	CountryCode3	CHAR(3)			UNIQUE NOT NULL,
	CountryName		VARCHAR(60)		NOT NULL,
	NumericCode		SMALLINT		CHECK(NumericCode BETWEEN 1 AND 999) NOT NULL
);

--CREATE USSTATE TABLE
CREATE TABLE USState
(
	StateID		TINYINT			PRIMARY KEY	CHECK(StateID BETWEEN 1 AND 51),
	StateCode	CHAR(2)			UNIQUE NOT NULL,
	StateName	VARCHAR(20)		NOT NULL
);