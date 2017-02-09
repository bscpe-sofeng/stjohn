-- phpMyAdmin SQL Dump
-- version 4.5.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 08, 2017 at 09:04 AM
-- Server version: 5.7.11
-- PHP Version: 5.6.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `enrollmentsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `adminsaccount`
--

CREATE TABLE `adminsaccount` (
  `IDNumber` int(20) NOT NULL,
  `FirstName` text NOT NULL,
  `LastName` text NOT NULL,
  `UserName` varchar(20) NOT NULL,
  `Password` varchar(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `adminsaccount`
--

INSERT INTO `adminsaccount` (`IDNumber`, `FirstName`, `LastName`, `UserName`, `Password`) VALUES
(15, 'Andrew', 'Belen', 'drew', 'drew'),
(14, 'asd', 'drewasdasd', 'asd', 'asd'),
(13, 'sdfghjk', 'asdfghjk', 'sdfghj', 'sdfgh');

-- --------------------------------------------------------

--
-- Table structure for table `billing`
--

CREATE TABLE `billing` (
  `StudentNumber` int(50) NOT NULL,
  `Name` text NOT NULL,
  `Section` varchar(10) DEFAULT NULL,
  `Total` int(10) NOT NULL,
  `RemainingBalance` int(10) NOT NULL,
  `Monthly` int(10) NOT NULL,
  `TypeofPayment` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `billing`
--

INSERT INTO `billing` (`StudentNumber`, `Name`, `Section`, `Total`, `RemainingBalance`, `Monthly`, `TypeofPayment`) VALUES
(0, 'xxxx', NULL, 0, 0, 0, 'Cash'),
(0, 'xxxx', NULL, 0, 0, 0, 'Cash'),
(0, 'xxxx', NULL, 0, 0, 0, 'Cash'),
(0, 'xxxx', NULL, 0, 0, 0, 'Cash');

-- --------------------------------------------------------

--
-- Table structure for table `listofstudents`
--

CREATE TABLE `listofstudents` (
  `StudentNumber` int(20) NOT NULL,
  `LastName` text NOT NULL,
  `FirstName` text NOT NULL,
  `MiddleName` text NOT NULL,
  `Address` varchar(10) NOT NULL,
  `Age` int(3) NOT NULL,
  `AverageGrade` int(5) NOT NULL,
  `Birthday` varchar(15) NOT NULL,
  `Gender` text NOT NULL,
  `PlaceofBirth` varchar(50) NOT NULL,
  `Nationality` text NOT NULL,
  `Citizenship` text NOT NULL,
  `Religion` text NOT NULL,
  `FatherName` text NOT NULL,
  `Occupation1` text NOT NULL,
  `MotherName` text NOT NULL,
  `Occupation2` text NOT NULL,
  `GuardianName` text NOT NULL,
  `ContactNumber` int(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `listofstudents`
--

INSERT INTO `listofstudents` (`StudentNumber`, `LastName`, `FirstName`, `MiddleName`, `Address`, `Age`, `AverageGrade`, `Birthday`, `Gender`, `PlaceofBirth`, `Nationality`, `Citizenship`, `Religion`, `FatherName`, `Occupation1`, `MotherName`, `Occupation2`, `GuardianName`, `ContactNumber`) VALUES
(16, 'titular', 'ti', 'qw', 'qw', 12, 12, 'May 12, 121', 'Female', 'qw12', 'as', 'as', 'as', 'as', 'qw', 'qw', 'as', 'dfghj', 123456),
(15, 'Belen', 'Andrew', 'Itoralba', 'asdfg', 20, 12, 'August 21, 1996', 'Male', 'asdfgh', 'asdf', 'as', 'asd', 'asdfghj', 'asdfghjk', 'asdfghjkl', 'zxcvbn', 'zxcvbn', 123456),
(14, 'Agno', 'qw', 'qw', 'qw', 12, 12, 'May 12, 121', 'Female', 'qw12', 'as', 'as', 'as', 'as', 'qw', 'qw', 'as', 'dfghj', 123456),
(13, 'Belen', 'qw', 'qw', 'qw', 12, 12, 'May 12, 121', 'Female', 'qw12', 'as', 'as', 'as', 'as', 'qw', 'qw', 'as', 'dfghj', 123456),
(12, 'qw', 'qw', 'qw', 'qw', 12, 12, 'May 12, 121', 'Female', 'qw12', 'as', 'as', 'as', 'as', 'qw', 'qw', 'as', 'dfghj', 123456),
(11, 'as', 'as', 'as', 'as', 12, 12, 'August 21, 1996', 'Male', 'qw12', 'qw', 'qw', 'wq', 'qw', 'qw', 'qw', 'as', 'qw', 12345),
(10, 'drew', 'deqw', 'as', 'as', 12, 12, 'August 21, 1996', 'Male', 'qw12', 'qw', 'qw', 'wq', 'qw', 'qw', 'qw', 'qw', 'qw', 12);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `adminsaccount`
--
ALTER TABLE `adminsaccount`
  ADD PRIMARY KEY (`IDNumber`);

--
-- Indexes for table `listofstudents`
--
ALTER TABLE `listofstudents`
  ADD PRIMARY KEY (`StudentNumber`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `adminsaccount`
--
ALTER TABLE `adminsaccount`
  MODIFY `IDNumber` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT for table `listofstudents`
--
ALTER TABLE `listofstudents`
  MODIFY `StudentNumber` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
