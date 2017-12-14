-- phpMyAdmin SQL Dump
-- version 4.7.3
-- https://www.phpmyadmin.net/
--
-- Anamakine: localhost:3306
-- Üretim Zamanı: 11 Ara 2017, 23:36:32
-- Sunucu sürümü: 10.1.29-MariaDB
-- PHP Sürümü: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `alibabas_1773`
--

-- --------------------------------------------------------

--
-- Görünüm yapısı durumu `manageUser`
-- (Asıl görünüm için aşağıya bakın)
--
CREATE TABLE `manageUser` (
`id` int(10)
,`full_name` varchar(50)
,`user_name` varchar(50)
,`password` varchar(100)
,`address` varchar(250)
,`email` varchar(100)
,`user_type` varchar(20)
);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `MAP`
--

CREATE TABLE `MAP` (
  `id` int(10) NOT NULL,
  `road_id` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ORDERS`
--

CREATE TABLE `ORDERS` (
  `id` int(10) NOT NULL,
  `distributor_id` int(10) NOT NULL,
  `create_date` date NOT NULL,
  `status` varchar(20) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `ORDERS`
--

INSERT INTO `ORDERS` (`id`, `distributor_id`, `create_date`, `status`) VALUES
(1, 1, '2017-12-01', 'pending'),
(2, 1, '2017-12-04', 'confirmed'),
(3, 5, '2017-12-04', 'pending'),
(4, 5, '2017-12-05', 'pending'),
(71, 14, '2017-12-08', 'pending'),
(68, 11, '2017-12-08', 'pending'),
(69, 12, '2017-12-08', 'pending'),
(70, 13, '2017-12-08', 'pending'),
(66, 9, '2017-12-08', 'pending'),
(67, 10, '2017-12-08', 'pending'),
(65, 8, '2017-12-08', 'pending'),
(64, 7, '2017-12-08', 'pending');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ORDER_DETAIL`
--

CREATE TABLE `ORDER_DETAIL` (
  `id` int(10) NOT NULL,
  `order_id` int(10) NOT NULL,
  `product_id` int(10) NOT NULL,
  `amount` int(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `ORDER_DETAIL`
--

INSERT INTO `ORDER_DETAIL` (`id`, `order_id`, `product_id`, `amount`) VALUES
(124, 68, 1, 112),
(123, 67, 3, 111),
(122, 67, 2, 110),
(121, 67, 1, 109),
(120, 66, 3, 108),
(119, 66, 2, 107),
(118, 66, 1, 106),
(117, 65, 3, 105),
(116, 65, 2, 104),
(128, 69, 1, 114),
(115, 65, 1, 103),
(114, 64, 3, 102),
(113, 64, 2, 101),
(136, 71, 3, 121),
(135, 71, 2, 119),
(134, 71, 1, 120),
(133, 70, 3, 118),
(112, 64, 1, 100),
(111, 2, 3, 350),
(110, 2, 2, 250),
(109, 2, 1, 150),
(108, 1, 3, 300),
(107, 1, 2, 200),
(106, 1, 1, 100),
(132, 70, 2, 117),
(131, 70, 1, 116),
(130, 69, 3, 116),
(129, 69, 2, 115),
(126, 68, 3, 114),
(125, 68, 2, 113);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `POOLPOINT`
--

CREATE TABLE `POOLPOINT` (
  `id` int(10) NOT NULL,
  `name` varchar(100) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `address` varchar(250) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `POOLPOINT`
--

INSERT INTO `POOLPOINT` (`id`, `name`, `address`) VALUES
(1, 'A', 'A'),
(2, 'B', 'B'),
(3, 'C', 'C'),
(4, 'D', 'D'),
(5, 'E', 'E'),
(6, 'F', 'F'),
(7, 'G', 'G'),
(8, 'H', 'H');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `PRODUCT`
--

CREATE TABLE `PRODUCT` (
  `id` int(11) NOT NULL,
  `name` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `PRODUCT`
--

INSERT INTO `PRODUCT` (`id`, `name`) VALUES
(1, 'yoghurt'),
(2, 'cheese'),
(3, 'milk');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ROAD`
--

CREATE TABLE `ROAD` (
  `id` int(11) NOT NULL,
  `point1` varchar(100) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `point2` varchar(100) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `distance` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `ROAD`
--

INSERT INTO `ROAD` (`id`, `point1`, `point2`, `distance`) VALUES
(1, 'A', 'B', 15),
(19, 'E', 'C', 16),
(18, 'C', 'D', 5),
(17, 'B', 'C', 10),
(16, 'B', 'E', 13),
(15, 'F', 'E', 12),
(14, 'F', 'B', 8),
(13, 'A', 'F', 14),
(12, 'A', 'D', 20),
(11, 'A', 'C', 18),
(20, 'E', 'G', 14),
(21, 'C', 'G', 9),
(22, 'C', 'H', 20),
(23, 'D', 'H', 16),
(24, 'G', 'H', 15),
(25, 'E', 'H', 25);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `SHIPPING`
--

CREATE TABLE `SHIPPING` (
  `id` int(10) NOT NULL,
  `create_date` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `SHIPPING_DETAIL`
--

CREATE TABLE `SHIPPING_DETAIL` (
  `id` int(10) NOT NULL,
  `shipping_id` int(10) NOT NULL,
  `order_id` int(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Görünüm yapısı durumu `showManageOrder`
-- (Asıl görünüm için aşağıya bakın)
--
CREATE TABLE `showManageOrder` (
`id` int(10)
,`full_name` varchar(50)
,`name` varchar(50)
,`amount` int(10)
,`status` varchar(20)
,`create_date` date
);

-- --------------------------------------------------------

--
-- Görünüm yapısı durumu `showOrderHistory`
-- (Asıl görünüm için aşağıya bakın)
--
CREATE TABLE `showOrderHistory` (
`id` int(10)
,`full_name` varchar(50)
,`name` varchar(50)
,`amount` int(10)
,`status` varchar(20)
,`create_date` date
);

-- --------------------------------------------------------

--
-- Görünüm yapısı durumu `showRouteDraw`
-- (Asıl görünüm için aşağıya bakın)
--
CREATE TABLE `showRouteDraw` (
`id` int(10)
,`full_name` varchar(50)
,`name` varchar(50)
,`amount` int(10)
,`status` varchar(20)
,`create_date` date
);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `siparis`
--

CREATE TABLE `siparis` (
  `id` int(50) NOT NULL,
  `milk` int(10) NOT NULL,
  `cheese` int(10) NOT NULL,
  `yoghurt` int(10) NOT NULL,
  `status` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `siparis`
--

INSERT INTO `siparis` (`id`, `milk`, `cheese`, `yoghurt`, `status`) VALUES
(33, 2, 3, 2, NULL),
(34, 3, 3, 5, NULL),
(30, 3, 3, 3, NULL),
(31, 0, 0, 0, NULL),
(32, 3, 2, 1, NULL),
(25, 1, 2, 1, 'waiting');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `USER`
--

CREATE TABLE `USER` (
  `id` int(10) NOT NULL,
  `user_name` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `full_name` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `address` varchar(250) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `email` varchar(100) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `user_type` varchar(20) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `authority` int(10) NOT NULL,
  `password` varchar(100) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `USER`
--

INSERT INTO `USER` (`id`, `user_name`, `full_name`, `address`, `email`, `user_type`, `authority`, `password`) VALUES
(1, 'hasanemre', 'Hasan Emre ARI', 'Luleburgaz-KIRKLARELI', 'hasanemreari@gmail.com', 'distributor', 2, '123'),
(2, 'okan', 'Okan YILDIRIM', 'Eryaman-ANKARA', 'okanyildirim@gmail.com', 'companyofficial', 1, '123'),
(3, 'ozgur', 'Ozgur AKTAS', 'Kozan-ADANA', 'ozguraktas@gmail.com', 'companyofficial', 1, '123'),
(4, 'fatih', 'Fatih YILMAZ', 'Gaziosmanpaşa-İSTANBUL', 'fatihyilmaz@gmail.com', 'admin', 0, '123'),
(5, 'ali', 'Ali Uçar', 'Kartepe-Kocaeli', 'aliucar@gmail.com', 'distributor', 2, '120'),
(7, 'A', 'A', 'A', 'A@A', 'distributor', 2, '123'),
(8, 'B', 'B', 'B', 'B@B', 'distributor', 2, '123'),
(9, 'C', 'C', 'C', 'C@C', 'distributor', 2, '123'),
(10, 'D', 'D', 'D', 'D@D', 'distributor', 2, '123'),
(11, 'E', 'E', 'E', 'E@E', 'distributor', 2, '123'),
(12, 'F', 'F', 'F', 'F@F', 'distributor', 2, '123'),
(13, 'G', 'G', 'G', 'G@G', 'distributor', 2, '123'),
(14, 'H', 'H', 'H', 'H@H', 'distributor', 2, '123');

-- --------------------------------------------------------

--
-- Görünüm yapısı `manageUser`
--
DROP TABLE IF EXISTS `manageUser`;

CREATE ALGORITHM=UNDEFINED DEFINER=`cpses_al2wm6xkf5`@`localhost` SQL SECURITY DEFINER VIEW `manageUser`  AS  select `USER`.`id` AS `id`,`USER`.`full_name` AS `full_name`,`USER`.`user_name` AS `user_name`,`USER`.`password` AS `password`,`USER`.`address` AS `address`,`USER`.`email` AS `email`,`USER`.`user_type` AS `user_type` from `USER` ;

-- --------------------------------------------------------

--
-- Görünüm yapısı `showManageOrder`
--
DROP TABLE IF EXISTS `showManageOrder`;

CREATE ALGORITHM=UNDEFINED DEFINER=`cpses_al2wm6xkf5`@`localhost` SQL SECURITY DEFINER VIEW `showManageOrder`  AS  select `ORDER_DETAIL`.`id` AS `id`,`USER`.`full_name` AS `full_name`,`PRODUCT`.`name` AS `name`,`ORDER_DETAIL`.`amount` AS `amount`,`ORDERS`.`status` AS `status`,`ORDERS`.`create_date` AS `create_date` from (((`ORDER_DETAIL` join `ORDERS` on((`ORDER_DETAIL`.`order_id` = `ORDERS`.`id`))) join `PRODUCT` on((`ORDER_DETAIL`.`product_id` = `PRODUCT`.`id`))) join `USER` on((`ORDERS`.`distributor_id` = `USER`.`id`))) where (`ORDERS`.`create_date` >= (curdate() - interval 7 day)) ;

-- --------------------------------------------------------

--
-- Görünüm yapısı `showOrderHistory`
--
DROP TABLE IF EXISTS `showOrderHistory`;

CREATE ALGORITHM=UNDEFINED DEFINER=`cpses_al2wm6xkf5`@`localhost` SQL SECURITY DEFINER VIEW `showOrderHistory`  AS  select `ORDER_DETAIL`.`id` AS `id`,`USER`.`full_name` AS `full_name`,`PRODUCT`.`name` AS `name`,`ORDER_DETAIL`.`amount` AS `amount`,`ORDERS`.`status` AS `status`,`ORDERS`.`create_date` AS `create_date` from (((`ORDER_DETAIL` join `ORDERS` on((`ORDER_DETAIL`.`order_id` = `ORDERS`.`id`))) join `PRODUCT` on((`ORDER_DETAIL`.`product_id` = `PRODUCT`.`id`))) join `USER` on((`ORDERS`.`distributor_id` = `USER`.`id`))) where (`ORDERS`.`create_date` < (curdate() - interval 7 day)) ;

-- --------------------------------------------------------

--
-- Görünüm yapısı `showRouteDraw`
--
DROP TABLE IF EXISTS `showRouteDraw`;

CREATE ALGORITHM=UNDEFINED DEFINER=`cpses_al2wm6xkf5`@`localhost` SQL SECURITY DEFINER VIEW `showRouteDraw`  AS  select `ORDER_DETAIL`.`id` AS `id`,`USER`.`full_name` AS `full_name`,`PRODUCT`.`name` AS `name`,`ORDER_DETAIL`.`amount` AS `amount`,`ORDERS`.`status` AS `status`,`ORDERS`.`create_date` AS `create_date` from (((`ORDER_DETAIL` join `ORDERS` on((`ORDER_DETAIL`.`order_id` = `ORDERS`.`id`))) join `PRODUCT` on((`ORDER_DETAIL`.`product_id` = `PRODUCT`.`id`))) join `USER` on((`ORDERS`.`distributor_id` = `USER`.`id`))) where (`ORDERS`.`create_date` >= (curdate() - interval 7 day)) ;

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `MAP`
--
ALTER TABLE `MAP`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `ORDERS`
--
ALTER TABLE `ORDERS`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `ORDER_DETAIL`
--
ALTER TABLE `ORDER_DETAIL`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `POOLPOINT`
--
ALTER TABLE `POOLPOINT`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `PRODUCT`
--
ALTER TABLE `PRODUCT`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `ROAD`
--
ALTER TABLE `ROAD`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `SHIPPING`
--
ALTER TABLE `SHIPPING`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `SHIPPING_DETAIL`
--
ALTER TABLE `SHIPPING_DETAIL`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `siparis`
--
ALTER TABLE `siparis`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `USER`
--
ALTER TABLE `USER`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `MAP`
--
ALTER TABLE `MAP`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT;
--
-- Tablo için AUTO_INCREMENT değeri `ORDERS`
--
ALTER TABLE `ORDERS`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=72;
--
-- Tablo için AUTO_INCREMENT değeri `ORDER_DETAIL`
--
ALTER TABLE `ORDER_DETAIL`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=137;
--
-- Tablo için AUTO_INCREMENT değeri `POOLPOINT`
--
ALTER TABLE `POOLPOINT`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- Tablo için AUTO_INCREMENT değeri `PRODUCT`
--
ALTER TABLE `PRODUCT`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- Tablo için AUTO_INCREMENT değeri `ROAD`
--
ALTER TABLE `ROAD`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
--
-- Tablo için AUTO_INCREMENT değeri `SHIPPING`
--
ALTER TABLE `SHIPPING`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT;
--
-- Tablo için AUTO_INCREMENT değeri `SHIPPING_DETAIL`
--
ALTER TABLE `SHIPPING_DETAIL`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT;
--
-- Tablo için AUTO_INCREMENT değeri `siparis`
--
ALTER TABLE `siparis`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;
--
-- Tablo için AUTO_INCREMENT değeri `USER`
--
ALTER TABLE `USER`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
