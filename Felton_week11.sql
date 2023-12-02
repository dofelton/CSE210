-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema University
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema University
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `University` DEFAULT CHARACTER SET utf8 ;
USE `University` ;

-- -----------------------------------------------------
-- Table `University`.`faculty`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`faculty` (
  `faculty_id` INT NOT NULL,
  `faculty_fname` VARCHAR(45) NULL,
  `faculty_lname` VARCHAR(45) NULL,
  `section_id` INT NULL,
  PRIMARY KEY (`faculty_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`term`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`term` (
  `term_id` INT NOT NULL,
  `year` INT NULL,
  `term` VARCHAR(45) NULL,
  `course_id` INT NULL,
  PRIMARY KEY (`term_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`section`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`section` (
  `section_id` INT NOT NULL,
  `section_number` INT NULL,
  `capacity` INT NULL,
  `term_id` INT NULL,
  `faculty_id` INT NULL,
  `course_id` INT NULL,
  PRIMARY KEY (`section_id`),
  INDEX `faculty_id_idx` (`faculty_id` ASC) VISIBLE,
  INDEX `term_id_idx` (`term_id` ASC) VISIBLE,
  CONSTRAINT `faculty_id`
    FOREIGN KEY (`faculty_id`)
    REFERENCES `University`.`faculty` (`faculty_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `term_id`
    FOREIGN KEY (`term_id`)
    REFERENCES `University`.`term` (`term_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`department`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`department` (
  `dept_id` INT NOT NULL,
  `dept_name` VARCHAR(45) NULL,
  `dept_code` VARCHAR(45) NULL,
  PRIMARY KEY (`dept_id`),
  INDEX `dept_id` (`dept_id` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`college`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`college` (
  `college_id` INT NOT NULL,
  `college_name` VARCHAR(45) NULL,
  `dept_id` INT NULL,
  PRIMARY KEY (`college_id`),
  INDEX `dept_id_idx` (`dept_id` ASC) VISIBLE,
  CONSTRAINT `dept_id`
    FOREIGN KEY (`dept_id`)
    REFERENCES `University`.`department` (`dept_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`course`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`course` (
  `course_id` INT NOT NULL,
  `course_title` VARCHAR(45) NULL,
  `course_num` INT NULL,
  `credits` INT NULL,
  `dept_id` INT NOT NULL,
  PRIMARY KEY (`course_id`),
  INDEX `dept_id` (`dept_id` ASC) VISIBLE,
  CONSTRAINT `course_id`
    FOREIGN KEY (`course_id`)
    REFERENCES `University`.`section` (`course_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `dept_id`
    FOREIGN KEY (`dept_id`)
    REFERENCES `University`.`department` (`dept_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`student`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`student` (
  `student_id` INT NULL,
  `first_name` VARCHAR(45) NULL,
  `last_name` VARCHAR(45) NULL,
  `gender` ENUM('M', 'F') NULL,
  `city` VARCHAR(45) NULL,
  `state` VARCHAR(45) NULL,
  `birthdate` DATE NULL,
  PRIMARY KEY (`student_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `University`.`enrollment`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `University`.`enrollment` (
  `section_id` INT NOT NULL,
  `student_id` INT NOT NULL,
  INDEX `section_id_idx` (`section_id` ASC) VISIBLE,
  INDEX `student_id_idx` (`student_id` ASC) VISIBLE,
  CONSTRAINT `section_id`
    FOREIGN KEY (`section_id`)
    REFERENCES `University`.`section` (`section_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `student_id`
    FOREIGN KEY (`student_id`)
    REFERENCES `University`.`student` (`student_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

USE university;

INSERT INTO college VALUES
	(1, "College of Physical Engineering", 1),
    (2, "College of Business and Communication", 2),
    (3, "College of Language and Letters", 3);
    
INSERT INTO department VALUES
	(1, "Computer Information Technology", "CIT"),
    (2, "Economics", "ECON"),
    (3, "Humanities and Philosophy", "HUM");
    
INSERT INTO course VALUES
	(1, "Intro to Databases", 111, 3),
    (2, "Econometrics", 388, 4),
    (3, "Micro Economics", 150, 3),
    (4, "Classical Heritage", 376, 2);

INSERT INTO term VALUES
	(1, 2019, "Fall", 1),
	(2, 2019, "Fall", 3),
	(3, 2019, "Fall", 1),
    (4, 2019, "Fall", 2),
    (5, 2019, "Fall", 4),
    (6, 2018, "Winter", 1),
    (7, 2018, "Winter", 1),
    (8, 2018, "Winter", 3),
    (9, 2018, "Winter", 3),
    (10, 2018, "Winter", 4);

INSERT INTO faculty VALUES
	(1, "Marty", "Morning", 1),
    (2, "Nate", "Nathan", 1),
    (3, "Ben", "Barus", 1),
    (4, "John", "Jensen", 1),
    (5, "Bill", "Barney", 3);
    
INSERT INTO student VALUES
	(1, "Paul", "Miller", "M", "Dallas", "TX", "1996-02-22"),
    (2, "Katie", "Smith", "F", "Provo", "UT", "1995-07-22"),
    (3, "Kelly", "Jones", "F", "Provo", "UT", "1998-06-22"),
    (4, "Devon", "Merrill", "M", "Mesa", "AZ", "2000-07-22"),
    (5, "Mandy", "Murdock", "F", "Topeka", "KS", "1996-11-22"),
    (6, "Alece", "Adams", "F", "Rigby", "ID", "1997-05-22"),
    (7, "Bryce", "Carlson", "M", "Bozeman", "MT", "1997-11-22"),
    (8, "Preston", "Larson", "M", "Decatur", "TN", "1996-09-22"),
    (9, "Julia", "Madsen", "F", "Rexburg", "ID", "1998-09-22"),
    (10, "Susan", "Sorensen", "F", "Mesa", "AZ", "1998-08-09");
    
INSERT INTO section VALUES
	(1, 1, 30, 1, 1, 1),
    (2, 1, 50, 1, 4, 2),
    (3, 2, 50, 1, 4, 2),
    (4, 1, 35, 1, 3, 4),
    (5, 1, 30, 1, 5, 3),
    (6, 2, 30, 2, 1, 1),
    (7, 3, 35, 2, 2, 1),
    (8, 1, 50, 2, 4, 2),
    (9, 2, 50, 2, 4, 2),
    (10, 1, 30, 2, 5, 3);
    
INSERT INTO enrollment VALUES
	(7, 6),
    (6, 7),
    (8, 7),
    (10, 7),
    (5, 4),
    (9, 9),
    (4, 2),
    (4, 3),
    (4, 5),
    (5, 5),
    (1, 1),
    (3, 1),
    (9, 8),
    (6, 10);
    