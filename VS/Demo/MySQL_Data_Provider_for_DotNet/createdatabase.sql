#
# DBTools 1.0.15 - MySQL Database Dump
#        

#
# CREATE test database
#
CREATE DATABASE MySQLClientTest;  
USE MySQLClientTest;

#
# Dumping TABLE Structure FOR testtable
#
CREATE TABLE `testtable` (
  `ID` INT(50) NOT NULL auto_increment,
  `Text` longblob,
  PRIMARY KEY  (`ID`)
) TYPE=MyISAM;

INSERT INTO testtable SET Text=NULL;

#
# Dumping TABLE Structure FOR testunicode
#
CREATE TABLE `testunicode` (
  `ID` INT(50) NOT NULL auto_increment,
  `Text` varchar(50) DEFAULT NULL,
  PRIMARY KEY  (`ID`)
) TYPE=MyISAM;

INSERT INTO testunicode SET Text=NULL;

#
# Dumping TABLE Structure FOR USER
#
CREATE TABLE `user` (
  `UserID` INT(50) NOT NULL auto_increment,
  `Alias` varchar(50) NOT NULL DEFAULT '',
  `Name` varchar(50) DEFAULT NULL,
  `LastLogin` TIMESTAMP(14) NOT NULL,
  `Rating` FLOAT(60,30) DEFAULT NULL,
  `Birthday` DATE DEFAULT NULL,
  PRIMARY KEY  (`UserID`),
  UNIQUE KEY `IDX_UniqueAlias` (`Alias`)
) TYPE=InnoDB;

INSERT INTO user SET Alias='testuser', Name='Hans Mustermann', Rating=2.5, Birthday='1962-10-15';