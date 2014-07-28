# DBTools 1.0.15 - MySQL Database Dump
#

# Dumping Table Structure for testtable

#
CREATE TABLE `testtable` (
  `ID` int(50) NOT NULL auto_increment,
  `Text` longblob,
  PRIMARY KEY  (`ID`)
) TYPE=InnoDB;
#
# Dumping Data for testtable
#
INSERT INTO testtable (ID, Text) VALUES(1, 'PK\n');
# Dumping Table Structure for testunicode

#
CREATE TABLE `testunicode` (
  `ID` int(50) NOT NULL auto_increment,
  `Text` varchar(50) default NULL,
  PRIMARY KEY  (`ID`)
) TYPE=ISAM;
#
# Dumping Data for testunicode
#
INSERT INTO testunicode (ID, Text) VALUES(1, 'ख');
# Dumping Table Structure for user

#
CREATE TABLE `user` (
  `UserID` int(50) NOT NULL auto_increment,
  `Alias` varchar(50) NOT NULL default '',
  `Name` varchar(50) default NULL,
  `LastLogin` timestamp(14) NOT NULL,
  `UserType` enum('Guest','User','Administrator') NOT NULL default 'Guest',
  `Rating` float(60,30) default NULL,
  `Birthday` date default NULL,
  PRIMARY KEY  (`UserID`),
  UNIQUE KEY `IDX_UniqueAlias` (`Alias`)
) TYPE=InnoDB;
#
# Dumping Data for user
#
INSERT INTO user (UserID, Alias, Name, LastLogin, UserType, Rating, Birthday) VALUES(1, 'chw', 'Christoph Wienands', '20021017223956', 'Administrator', 2.200000047683715800000000000000, '2003-02-08');
INSERT INTO user (UserID, Alias, Name, LastLogin, UserType, Rating, Birthday) VALUES(5, 'ag', 'Alex Granito', '20021017224001', 'User', 15.000000000000000000000000000000, '2001-12-10');
INSERT INTO user (UserID, Alias, Name, LastLogin, UserType, Rating, Birthday) VALUES(6, 'gs', 'Gerd Schneider', '20021017224008', 'User', 3.700000047683715800000000000000, '1950-04-01');
INSERT INTO user (UserID, Alias, Name, LastLogin, UserType, Rating, Birthday) VALUES(7, 'hta', 'Hans Testuser', '20021013030611', 'Guest', 9.000000000000000000000000000000, '1970-01-02');
INSERT INTO user (UserID, Alias, Name, LastLogin, UserType, Rating, Birthday) VALUES(8, 'hm', 'Heinz Mustermann', '20021010233211', 'User', 4.670000076293945300000000000000, '1963-08-17');
