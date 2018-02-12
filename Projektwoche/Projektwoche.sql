CREATE DATABASE projektwoche2018;
USE projektwoche2018;

CREATE TABLE workshop (
	workshopID INT NOT NULL AUTO_INCREMENT,
	nr INT NOT NULL,
	titel VARCHAR(150) NOT NULL,
	kosten VARCHAR(100) NOT NULL,
	beschreibung text NOT NULL,
	voraussetzungen text NOT NULL,
	teilnehmerMin int NOT NULL,
	teilnehmerMax int NOT NULL,
	PRIMARY KEY (workshopID)
);

CREATE TABLE klasse (
	klasseID INT NOT NULL AUTO_INCREMENT,
	bezeichnung VARCHAR(50) NOT NULL,
	PRIMARY KEY(klasseID)
);

CREATE TABLE schueler (
	schuelerID INT NOT NULL AUTO_INCREMENT,
	vorname CHAR(30) NOT NULL,
	nachname CHAR(30) NOT NULL,
	email VARCHAR(50) NOT NULL,
	klasseID INT NOT NULL,
	PRIMARY KEY(schuelerID),
	FOREIGN KEY(klasseID) REFERENCES klasse(klasseID)
);

CREATE TABLE rel_workshop_schueler_wahl (
	wahlID INT NOT NULL AUTO_INCREMENT,
	workshopID INT NOT NULL,
	schuelerID INT NOT NULL,
	PRIMARY KEY(wahlID),
	FOREIGN KEY(workshopID) REFERENCES workshop(workshopID) ON DELETE CASCADE,
	FOREIGN KEY(schuelerID) REFERENCES schueler(schuelerID) ON DELETE CASCADE
);