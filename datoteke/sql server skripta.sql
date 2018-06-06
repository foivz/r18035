-- MySQL Workbench Forward Engineering

/* SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0; */
/* SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0; */
/* SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES'; */

-- -----------------------------------------------------
-- Schema 18035_DB
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema 18035_DB
-- -----------------------------------------------------
IF (SCHEMA_ID('18035_DB') IS NULL) 
BEGIN
    EXEC ('CREATE SCHEMA [18035_DB] AUTHORIZATION [dbo]')
END

USE [18035_DB] ;
-- -----------------------------------------------------
-- Table `18035_DB`.`vrsta_sadnog_materijala`
-- -----------------------------------------------------
CREATE TABLE "18035_DB".vrsta_sadnog_materijala (
  [id] INT NOT NULL IDENTITY,
  [naziv] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [naziv_UNIQUE] UNIQUE  ([naziv] ASC))
;


-- -----------------------------------------------------
-- Table `18035_DB`.`sadni_materijal`
-- -----------------------------------------------------
CREATE TABLE "18035_DB".sadni_materijal (
  [id] INT NOT NULL IDENTITY,
  [naziv] VARCHAR(45) NULL,
  [jedinicna_mjera] VARCHAR(45) NULL,
  [id_vrste_materijala] INT NOT NULL,
  PRIMARY KEY ([id])
 ,
  CONSTRAINT [fk_proizvodi_vrste_proizvoda1]
    FOREIGN KEY ([id_vrste_materijala])
    REFERENCES "18035_DB".vrsta_sadnog_materijala ([id])
    ON DELETE NO ACTION
    ON UPDATE CASCADE)
;

CREATE INDEX [fk_proizvodi_vrste_proizvoda1_idx] ON "18035_DB".sadni_materijal ([id_vrste_materijala] ASC);


-- -----------------------------------------------------
-- Table `18035_DB`.`djelatnik`
-- -----------------------------------------------------
CREATE TABLE "18035_DB".djelatnik (
  [id] INT NOT NULL IDENTITY,
  [ime] VARCHAR(45) NOT NULL,
  [prezime] VARCHAR(45) NOT NULL,
  [email] VARCHAR(100) NOT NULL,
  [lozinka] VARCHAR(100) NOT NULL,
  [broj_telefona] VARCHAR(45) NULL,
  PRIMARY KEY ([id]))
;


-- -----------------------------------------------------
-- Table `18035_DB`.`namjena_povrsine`
-- -----------------------------------------------------
CREATE TABLE "18035_DB".namjena_povrsine (
  [id] INT NOT NULL IDENTITY,
  [namjena] VARCHAR(100) NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [namjena_UNIQUE] UNIQUE  ([namjena] ASC))
;


-- -----------------------------------------------------
-- Table `18035_DB`.`polj_povrsina`
-- -----------------------------------------------------
CREATE TABLE "18035_DB".polj_povrsina (
  [id] INT NOT NULL IDENTITY,
  [naziv] VARCHAR(45) NOT NULL,
  [povrsina_m2] DECIMAL(10,2) NOT NULL,
  [koordinate] [GEOMETRY] NOT NULL,
  [id_namjene] INT NOT NULL,
  PRIMARY KEY ([id])
 ,
  CONSTRAINT [fk_polj_povrsina_namjena_povrsine1]
    FOREIGN KEY ([id_namjene])
    REFERENCES "18035_DB".namjena_povrsine ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_polj_povrsina_namjena_povrsine1_idx] ON "18035_DB".polj_povrsina ([id_namjene] ASC);


-- -----------------------------------------------------
-- Table `18035_DB`.`sadnja`
-- -----------------------------------------------------
CREATE TABLE "18035_DB".sadnja (
  [id_povrsina] INT NOT NULL,
  [id_materijal] INT NOT NULL,
  [datum_sadnje] DATE NOT NULL,
  [kolicina] VARCHAR(70) NULL,
  PRIMARY KEY ([id_povrsina], [id_materijal], [datum_sadnje])
 ,
  CONSTRAINT [fk_sadnja_polj_povrsine1]
    FOREIGN KEY ([id_povrsina])
    REFERENCES "18035_DB".polj_povrsina ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_sadnja_proizvodi1]
    FOREIGN KEY ([id_materijal])
    REFERENCES "18035_DB".sadni_materijal ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_sadnja_proizvodi1_idx] ON "18035_DB".sadnja ([id_materijal] ASC);


-- -----------------------------------------------------
-- Table `18035_DB`.`stanje_navodnjavanja`
-- -----------------------------------------------------
CREATE TABLE "18035_DB".stanje_navodnjavanja (
  [id] INT NOT NULL IDENTITY,
  [naziv] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [stnav_naziv_UNIQUE] UNIQUE  ([naziv] ASC))
;


-- -----------------------------------------------------
-- Table `18035_DB`.`navodnjavanje`
-- -----------------------------------------------------
CREATE TABLE "18035_DB".navodnjavanje (
  [id_povrsina] INT NOT NULL,
  [datum] DATE NOT NULL,
  [kolicina_vode_litri] DECIMAL(10,2) NULL DEFAULT NULL,
  [id_stanja] INT NOT NULL,
  PRIMARY KEY ([id_povrsina], [datum])
 ,
  CONSTRAINT [fk_navodnjavanje_polj_povrsine1]
    FOREIGN KEY ([id_povrsina])
    REFERENCES "18035_DB".polj_povrsina ([id])
    ON DELETE CASCADE
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_navodnjavanje_vrsta_navodnjavanja1]
    FOREIGN KEY ([id_stanja])
    REFERENCES "18035_DB".stanje_navodnjavanja ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_navodnjavanje_vrsta_navodnjavanja1_idx] ON "18035_DB".navodnjavanje ([id_stanja] ASC);


-- -----------------------------------------------------
-- Table `18035_DB`.`vrsta_zastite`
-- -----------------------------------------------------
CREATE TABLE "18035_DB".vrsta_zastite (
  [id] INT NOT NULL IDENTITY,
  [naziv] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [naziv_zastite_UNIQUE] UNIQUE  ([naziv] ASC))
;


-- -----------------------------------------------------
-- Table `18035_DB`.`zastita`
-- -----------------------------------------------------
CREATE TABLE "18035_DB".zastita (
  [id] INT NOT NULL IDENTITY,
  [naziv] VARCHAR(45) NULL,
  [koncentracija] VARCHAR(20) NULL,
  [id_vrste_zastite] INT NOT NULL,
  PRIMARY KEY ([id])
 ,
  CONSTRAINT [fk_zastita_vrste_zastite1]
    FOREIGN KEY ([id_vrste_zastite])
    REFERENCES "18035_DB".vrsta_zastite ([id])
    ON DELETE NO ACTION
    ON UPDATE CASCADE)
;

CREATE INDEX [fk_zastita_vrste_zastite1_idx] ON "18035_DB".zastita ([id_vrste_zastite] ASC);


-- -----------------------------------------------------
-- Table `18035_DB`.`prskanje`
-- -----------------------------------------------------
CREATE TABLE "18035_DB".prskanje (
  [id_povrsina] INT NOT NULL,
  [id_zastita] INT NOT NULL,
  [datum] DATE NOT NULL,
  [opis] VARCHAR(45) NULL,
  [id_djelatnik] INT NOT NULL,
  PRIMARY KEY ([id_povrsina], [id_zastita], [datum])
 ,
  CONSTRAINT [fk_prskanje_zastita1]
    FOREIGN KEY ([id_zastita])
    REFERENCES "18035_DB".zastita ([id])
    ON DELETE CASCADE
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_prskanje_polj_povrsine1]
    FOREIGN KEY ([id_povrsina])
    REFERENCES "18035_DB".polj_povrsina ([id])
    ON DELETE CASCADE
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_prskanje_korisnik1]
    FOREIGN KEY ([id_djelatnik])
    REFERENCES "18035_DB".djelatnik ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_prskanje_zastita1_idx] ON "18035_DB".prskanje ([id_zastita] ASC);
CREATE INDEX [fk_prskanje_korisnik1_idx] ON "18035_DB".prskanje ([id_djelatnik] ASC);


/* SET SQL_MODE=@OLD_SQL_MODE; */
/* SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS; */
/* SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS; */

BEGIN TRANSACTION;
USE "18035_DB";
INSERT INTO "18035_DB".vrsta_sadnog_materijala (naziv) VALUES ('voce');
INSERT INTO "18035_DB".vrsta_sadnog_materijala (naziv) VALUES ('povrce');
INSERT INTO "18035_DB".vrsta_sadnog_materijala (naziv) VALUES ('žitarice');
INSERT INTO "18035_DB".vrsta_sadnog_materijala (naziv) VALUES ('cvijece');

COMMIT;


-- \--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\---
-- Data for table 18035_DB.sadni_materijal
-- \--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\---
BEGIN TRANSACTION;
USE "18035_DB";
INSERT INTO "18035_DB".sadni_materijal (naziv, jedinicna_mjera, id_vrste_materijala) VALUES ('Paprika babura', 'komad', 2);
INSERT INTO "18035_DB".sadni_materijal (naziv, jedinicna_mjera, id_vrste_materijala) VALUES ('Varaždinsko zelje', 'komad', 2);

COMMIT;


-- \--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\---
-- Data for table 18035_DB.djelatnik
-- \--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\---
BEGIN TRANSACTION;
USE "18035_DB";
INSERT INTO "18035_DB".djelatnik (ime, prezime, email, lozinka, broj_telefona) VALUES ('Pero', 'Peric', 'pero.peric@gmail.com', 'pero1', '123456');
INSERT INTO "18035_DB".djelatnik (ime, prezime, email, lozinka, broj_telefona) VALUES ('Ana', 'Anic', 'ana.anic@gmail.com', 'ana1a', '012234');

COMMIT;


-- \--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\---
-- Data for table 18035_DB.namjena_povrsine
-- \--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\---
BEGIN TRANSACTION;
USE "18035_DB";
INSERT INTO "18035_DB".namjena_povrsine (namjena) VALUES ('oranica');
INSERT INTO "18035_DB".namjena_povrsine (namjena) VALUES ('vocnjak');
INSERT INTO "18035_DB".namjena_povrsine (namjena) VALUES ('plastenik');

COMMIT;


-- \--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\---
-- Data for table 18035_DB.polj_povrsina
-- \--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\---
BEGIN TRANSACTION;
USE "18035_DB";
INSERT INTO "18035_DB".polj_povrsina (naziv, povrsina_m2, koordinate, id_namjene) VALUES ('Špica velika', 6400, DEFAULT, 1);
INSERT INTO "18035_DB".polj_povrsina (naziv, povrsina_m2, koordinate, id_namjene) VALUES ('Špica mala', 5800, DEFAULT, 1);

COMMIT;


-- \--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\---
-- Data for table 18035_DB.vrsta_zastite
-- \--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\---
BEGIN TRANSACTION;
USE "18035_DB";
INSERT INTO "18035_DB".vrsta_zastite (naziv) VALUES ('fungicid');
INSERT INTO "18035_DB".vrsta_zastite (naziv) VALUES ('pesticid');
INSERT INTO "18035_DB".vrsta_zastite (naziv) VALUES ('herbicid');
INSERT INTO "18035_DB".vrsta_zastite (naziv) VALUES ('insekticid');
INSERT INTO "18035_DB".vrsta_zastite (naziv) VALUES ('gnojivo');

COMMIT;


-- \--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\---
-- Data for table 18035_DB.zastita
-- \--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\--\---
BEGIN TRANSACTION;
USE "18035_DB";
INSERT INTO "18035_DB".zastita (naziv, koncentracija, id_vrste_zastite) VALUES ('Butisan', NULL, 3);
INSERT INTO "18035_DB".zastita (naziv, koncentracija, id_vrste_zastite) VALUES ('Kan', NULL, 5);

COMMIT;
