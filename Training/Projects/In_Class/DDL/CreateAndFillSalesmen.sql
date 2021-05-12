create table Salesmen
(
	PhoneNumber varchar(12) primary key,
	FullName varchar(30) not null
)
create table SalesProducts
(
	PhoneNumber varchar(12) references Salesmen(PhoneNumber),
	Product varchar(30),
	Primary key (PhoneNumber, Product)
)
create table stops
(
	PhoneNumber varchar(12) references Salesmen(PhoneNumber),
	City varchar(3),
	Primary Key (PhoneNumber, City)
)

insert into Salesmen (PhoneNumber, FullName) values
('510-BUI-LDIT', 'Bob The Builder'), ('415-HEY-FRED', 'Fred Belotte'), ('888-GET-COFI', 'Nick Enscalada'), ('213-TRA-INER', 'Pushpinder Kaur'),
('635-SLI-DES!', 'Mark "Less is" Moore'), ('415-SEA-HAWK', 'Jacob Davis'), ('510-FLY-MARS', 'Marielle The Martian');
insert into SalesProducts (PhoneNumber, Product) values
('510-BUI-LDIT', 'hammer'), ('510-BUI-LDIT', 'nails'), ('510-BUI-LDIT', 'screws'), ('415-HEY-FRED', 'pizza'), ('888-GET-COFI', 'coffee'),
('888-GET-COFI', 'es[resso'), ('888-GET-COFI', 'latte'), ('213-TRA-INER', 'cookies'), ('213-TRA-INER', 'cakes'), ('635-SLI-DES!', 'books'),
('415-SEA-HAWK', 'coffee'), ('510-FLY-MARS', 'coffee'), ('510-FLY-MARS', 'tea'), ('510-FLY-MARS', 'hot chocolate');
insert into stops (PhoneNumber, City) values
('510-BUI-LDIT', 'SFO'), ('510-BUI-LDIT', 'LAX'), ('415-HEY-FRED', 'DFW'), ('415-HEY-FRED', 'IAH'), ('415-HEY-FRED', 'SAT'), ('888-GET-COFI', 'DAL'),
('888-GET-COFI', 'IAH'), ('888-GET-COFI', 'AUS'), ('213-TRA-INER', 'TPA'), ('213-TRA-INER', 'DFW'), ('213-TRA-INER', 'DAL'), ('635-SLI-DES!', 'DFW'),
('415-SEA-HAWK', 'SEA'), ('415-SEA-HAWK', 'STL'), ('415-SEA-HAWK', 'IAH'), ('510-FLY-MARS', 'OAK'), ('510-FLY-MARS', 'SFO'), ('510-FLY-MARS', 'MNL'),
('510-FLY-MARS', 'DAL');