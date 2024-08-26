/*
 Navicat Premium Data Transfer

 Source Server         : Local
 Source Server Type    : MySQL
 Source Server Version : 80030 (8.0.30)
 Source Host           : localhost:3306
 Source Schema         : forecastdb

 Target Server Type    : MySQL
 Target Server Version : 80030 (8.0.30)
 File Encoding         : 65001

 Date: 26/08/2024 04:59:35
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for history
-- ----------------------------
DROP TABLE IF EXISTS `history`;
CREATE TABLE `history`  (
  `historyID` int NOT NULL AUTO_INCREMENT,
  `userID` int NOT NULL,
  `description` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `input` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `output` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `date` datetime NULL DEFAULT NULL,
  PRIMARY KEY (`historyID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 66 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of history
-- ----------------------------
INSERT INTO `history` VALUES (38, 1, 'user: manual forecasting', 'D:\\work\\vbprojects\\forecastWeatherDesktopApp\\bin\\Debug\\net8.0-windows\\Data\\DataGridViewData_20240825_175520.csv', '', '2024-08-25 17:55:28');
INSERT INTO `history` VALUES (39, 1, 'user: exported forecast chart', '', 'C:\\Users\\Mak Moinee\\Downloads\\ChartExport.pdf', '2024-08-25 17:55:37');
INSERT INTO `history` VALUES (40, 1, 'user: imported csv for auto forecasting', 'C:\\Users\\Mak Moinee\\Downloads\\input.csv', '', '2024-08-25 17:56:30');
INSERT INTO `history` VALUES (41, 1, 'user: imported csv for training', 'C:\\Users\\Mak Moinee\\Downloads\\train.csv', '', '2024-08-25 17:57:05');
INSERT INTO `history` VALUES (42, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 17:57:20');
INSERT INTO `history` VALUES (43, 1, 'user: imported csv for auto forecasting', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 18:15:39');
INSERT INTO `history` VALUES (44, 1, 'user: imported csv for auto forecasting', 'D:\\work\\forecastWeatherAI\\input.csv', '', '2024-08-25 18:16:06');
INSERT INTO `history` VALUES (45, 1, 'user: exported forecast results to csv', '', 'C:\\Users\\Mak Moinee\\Downloads\\predictions_20240825_181623.csv', '2024-08-25 18:16:23');
INSERT INTO `history` VALUES (46, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 18:17:45');
INSERT INTO `history` VALUES (47, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\mluzon.csv', '', '2024-08-25 18:18:25');
INSERT INTO `history` VALUES (48, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 18:19:20');
INSERT INTO `history` VALUES (49, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 23:20:42');
INSERT INTO `history` VALUES (50, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 23:23:27');
INSERT INTO `history` VALUES (51, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 23:23:56');
INSERT INTO `history` VALUES (52, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 23:31:06');
INSERT INTO `history` VALUES (53, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 23:31:39');
INSERT INTO `history` VALUES (54, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 23:34:44');
INSERT INTO `history` VALUES (55, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 23:35:16');
INSERT INTO `history` VALUES (56, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 23:38:37');
INSERT INTO `history` VALUES (57, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 23:39:19');
INSERT INTO `history` VALUES (58, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 23:41:16');
INSERT INTO `history` VALUES (59, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 23:42:20');
INSERT INTO `history` VALUES (60, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 23:42:42');
INSERT INTO `history` VALUES (61, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 23:44:39');
INSERT INTO `history` VALUES (62, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 23:45:01');
INSERT INTO `history` VALUES (63, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-25 23:47:46');
INSERT INTO `history` VALUES (64, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\mluzon.csv', '', '2024-08-25 23:49:50');
INSERT INTO `history` VALUES (65, 1, 'user: imported csv for training', 'D:\\work\\forecastWeatherAI\\train.csv', '', '2024-08-26 03:35:48');

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users`  (
  `userID` int NOT NULL AUTO_INCREMENT,
  `firstName` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `middleName` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `lastName` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `username` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `userType` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`userID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES (1, 'Kennen', 'Comaling', 'Borbon', 'user', 'ZKxggfpde83eAn3vUYvgBg==:/a+eWrDbc9+n4VhpQugZWG/whJ4=', 'Admin', '2024-08-09 12:39:17');
INSERT INTO `users` VALUES (2, 'User', 'User', 'User', 'sample', 'eIa9/3pyXDpptrlBZru8qQ==:qrwk7QzpcOvSKJnPe4PuRVSAIwU=', 'User', '2024-08-09 13:57:15');

-- ----------------------------
-- Table structure for weather_data
-- ----------------------------
DROP TABLE IF EXISTS `weather_data`;
CREATE TABLE `weather_data`  (
  `weatherID` int NOT NULL AUTO_INCREMENT,
  `dateLogs` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `date` int NOT NULL,
  `month` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `day` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `weekdayOrWeekend` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `typeOfDay` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `meanTemperature` float NOT NULL,
  `rainfall` float NOT NULL,
  `relativeHumidity` float NOT NULL,
  `windspeed` float NOT NULL,
  `demandLoad` decimal(10, 2) NOT NULL,
  PRIMARY KEY (`weatherID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 5311 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of weather_data
-- ----------------------------
INSERT INTO `weather_data` VALUES (5211, '1/1/2022', 1, 'January', 'Saturday', 'Weekend', 'Regular Holiday', 25.6111, 4.1, 69.0917, 3.15556, 134903.00);
INSERT INTO `weather_data` VALUES (5212, '1/2/2022', 2, 'January', 'Sunday', 'Weekend', 'Normal Day', 25.0667, 9.37, 72.5944, 2.41905, 141162.00);
INSERT INTO `weather_data` VALUES (5213, '1/3/2022', 3, 'January', 'Monday', 'Weekday', 'Normal Day', 25.8778, 0.09, 69.3722, 2.64444, 169898.00);
INSERT INTO `weather_data` VALUES (5214, '1/4/2022', 4, 'January', 'Tuesday', 'Weekday', 'Normal Day', 25.8911, 12.89, 71.0417, 2.32381, 181105.00);
INSERT INTO `weather_data` VALUES (5215, '1/5/2022', 5, 'January', 'Wednesday', 'Weekday', 'Normal Day', 26.0667, 35.59, 74.5667, 2.12381, 185404.00);
INSERT INTO `weather_data` VALUES (5216, '1/6/2022', 6, 'January', 'Thursday', 'Weekday', 'Normal Day', 25.4289, 11.9, 76.6833, 1.97143, 186201.00);
INSERT INTO `weather_data` VALUES (5217, '1/7/2022', 7, 'January', 'Friday', 'Weekday', 'Normal Day', 26.2578, 7.2, 73.5861, 2.21587, 186436.00);
INSERT INTO `weather_data` VALUES (5218, '1/8/2022', 8, 'January', 'Saturday', 'Weekend', 'Normal Day', 26.23, 18.79, 78.3556, 1.69841, 182213.00);
INSERT INTO `weather_data` VALUES (5219, '1/9/2022', 9, 'January', 'Sunday', 'Weekend', 'Normal Day', 26.2611, 1.19, 79.1361, 1.82222, 173635.00);
INSERT INTO `weather_data` VALUES (5220, '1/10/2022', 10, 'January', 'Monday', 'Weekday', 'Normal Day', 26.3356, 12.6, 79.4306, 1.88571, 193234.00);
INSERT INTO `weather_data` VALUES (5221, '1/11/2022', 11, 'January', 'Tuesday', 'Weekday', 'Normal Day', 25.6767, 23.59, 76.4667, 2.60952, 191733.00);
INSERT INTO `weather_data` VALUES (5222, '1/12/2022', 12, 'January', 'Wednesday', 'Weekday', 'Normal Day', 25.5133, 61.46, 75.8333, 2.33016, 187103.00);
INSERT INTO `weather_data` VALUES (5223, '1/13/2022', 13, 'January', 'Thursday', 'Weekday', 'Normal Day', 24.5933, 31.49, 76.9222, 2.42857, 183784.00);
INSERT INTO `weather_data` VALUES (5224, '1/14/2022', 14, 'January', 'Friday', 'Weekday', 'Normal Day', 24.3911, 6.28, 77.2083, 2.17143, 179016.00);
INSERT INTO `weather_data` VALUES (5225, '1/15/2022', 15, 'January', 'Saturday', 'Weekend', 'Normal Day', 24.7533, 4.88, 73.9861, 2.2381, 168476.00);
INSERT INTO `weather_data` VALUES (5226, '1/16/2022', 16, 'January', 'Sunday', 'Weekend', 'Normal Day', 24.9078, 11.79, 73.1278, 2.59683, 158030.00);
INSERT INTO `weather_data` VALUES (5227, '1/17/2022', 17, 'January', 'Monday', 'Weekday', 'Normal Day', 25.02, 0.09, 70.7806, 2.12698, 174251.00);
INSERT INTO `weather_data` VALUES (5228, '1/18/2022', 18, 'January', 'Tuesday', 'Weekday', 'Normal Day', 25.4689, 0.09, 70.9556, 2.14603, 177402.00);
INSERT INTO `weather_data` VALUES (5229, '1/19/2022', 19, 'January', 'Wednesday', 'Weekday', 'Normal Day', 25.79, 25.36, 75.9111, 1.85079, 182450.00);
INSERT INTO `weather_data` VALUES (5230, '1/20/2022', 20, 'January', 'Thursday', 'Weekday', 'Normal Day', 25.79, 16.26, 78.5139, 2.26032, 184536.00);
INSERT INTO `weather_data` VALUES (5231, '1/21/2022', 21, 'January', 'Friday', 'Weekday', 'Normal Day', 25.9944, 134.39, 81.6111, 2.04127, 188202.00);
INSERT INTO `weather_data` VALUES (5232, '1/22/2022', 22, 'January', 'Saturday', 'Weekend', 'Normal Day', 26.6994, 70.49, 79.3194, 1.92381, 184225.00);
INSERT INTO `weather_data` VALUES (5233, '1/23/2022', 23, 'January', 'Sunday', 'Weekend', 'Normal Day', 26.9254, 4.09, 80.0833, 2.00952, 175349.00);
INSERT INTO `weather_data` VALUES (5234, '1/24/2022', 24, 'January', 'Monday', 'Weekday', 'Normal Day', 26.6724, 6.38, 80.0611, 2.11746, 194303.00);
INSERT INTO `weather_data` VALUES (5235, '1/25/2022', 25, 'January', 'Tuesday', 'Weekday', 'Normal Day', 26.9756, 61.6, 73.2861, 2.37143, 197470.00);
INSERT INTO `weather_data` VALUES (5236, '1/26/2022', 26, 'January', 'Wednesday', 'Weekday', 'Normal Day', 26.3489, 209.2, 83.8972, 2.34921, 196751.00);
INSERT INTO `weather_data` VALUES (5237, '1/27/2022', 27, 'January', 'Thursday', 'Weekday', 'Normal Day', 27.4744, 65.68, 81.9361, 2.29206, 204097.00);
INSERT INTO `weather_data` VALUES (5238, '1/28/2022', 28, 'January', 'Friday', 'Weekday', 'Normal Day', 27.4303, 26.89, 78.6306, 1.85714, 206814.00);
INSERT INTO `weather_data` VALUES (5239, '1/29/2022', 29, 'January', 'Saturday', 'Weekend', 'Normal Day', 27.8383, 166.69, 80.4278, 2.13968, 198110.00);
INSERT INTO `weather_data` VALUES (5240, '1/30/2022', 30, 'January', 'Sunday', 'Weekend', 'Normal Day', 26.4875, 108.88, 83.2222, 2.75556, 183689.00);
INSERT INTO `weather_data` VALUES (5241, '1/31/2022', 31, 'January', 'Monday', 'Weekday', 'Normal Day', 26.4461, 21.2, 75.8472, 2.54286, 193709.00);
INSERT INTO `weather_data` VALUES (5242, '2/1/2022', 1, 'February', 'Tuesday', 'Weekday', 'Special Non-working Holiday', 25.7961, 2.8, 75.4056, 2.45714, 182795.00);
INSERT INTO `weather_data` VALUES (5243, '2/2/2022', 2, 'February', 'Wednesday', 'Weekday', 'Normal Day', 26.3531, 11.6, 74.3167, 2.39048, 192343.00);
INSERT INTO `weather_data` VALUES (5244, '2/3/2022', 3, 'February', 'Thursday', 'Weekday', 'Normal Day', 25.8517, 74.18, 79.2278, 1.8127, 194217.00);
INSERT INTO `weather_data` VALUES (5245, '2/4/2022', 4, 'February', 'Friday', 'Weekday', 'Normal Day', 26.8375, 0.09, 72.5556, 2.3619, 196002.00);
INSERT INTO `weather_data` VALUES (5246, '2/5/2022', 5, 'February', 'Saturday', 'Weekend', 'Normal Day', 26.5603, 7.5, 71.9028, 3.08889, 186715.00);
INSERT INTO `weather_data` VALUES (5247, '2/6/2022', 6, 'February', 'Sunday', 'Weekend', 'Normal Day', 26.5636, 74.29, 73.3028, 3.32381, 173809.00);
INSERT INTO `weather_data` VALUES (5248, '2/7/2022', 7, 'February', 'Monday', 'Weekday', 'Normal Day', 25.9653, 69.98, 81.4583, 2.14603, 195186.00);
INSERT INTO `weather_data` VALUES (5249, '2/8/2022', 8, 'February', 'Tuesday', 'Weekday', 'Normal Day', 26.8667, 10.78, 77.9667, 2.30476, 204141.00);
INSERT INTO `weather_data` VALUES (5250, '2/9/2022', 9, 'February', 'Wednesday', 'Weekday', 'Normal Day', 26.9597, 0.7, 73.9333, 2.32063, 203760.00);
INSERT INTO `weather_data` VALUES (5251, '2/10/2022', 10, 'February', 'Thursday', 'Weekday', 'Normal Day', 26.7581, 8.79, 74.1556, 2.51111, 202781.00);
INSERT INTO `weather_data` VALUES (5252, '2/11/2022', 11, 'February', 'Friday', 'Weekday', 'Normal Day', 26.4275, 12.18, 74.8556, 2.47619, 202425.00);
INSERT INTO `weather_data` VALUES (5253, '2/12/2022', 12, 'February', 'Saturday', 'Weekend', 'Normal Day', 26.9006, 27.27, 76.2806, 2.16825, 191465.00);
INSERT INTO `weather_data` VALUES (5254, '2/13/2022', 13, 'February', 'Sunday', 'Weekend', 'Normal Day', 26.9733, 118.58, 80.2778, 2.33016, 182109.00);
INSERT INTO `weather_data` VALUES (5255, '2/14/2022', 14, 'February', 'Monday', 'Weekday', 'Normal Day', 26.6108, 36.18, 82.2333, 2.06032, 202789.00);
INSERT INTO `weather_data` VALUES (5256, '2/15/2022', 15, 'February', 'Tuesday', 'Weekday', 'Normal Day', 26.8497, 28.99, 77.4306, 2.47302, 207314.00);
INSERT INTO `weather_data` VALUES (5257, '2/16/2022', 16, 'February', 'Wednesday', 'Weekday', 'Normal Day', 26.5872, 21.29, 76.0389, 2.55873, 205383.00);
INSERT INTO `weather_data` VALUES (5258, '2/17/2022', 17, 'February', 'Thursday', 'Weekday', 'Normal Day', 26.0781, 48.68, 80.0083, 2.07619, 205082.00);
INSERT INTO `weather_data` VALUES (5259, '2/18/2022', 18, 'February', 'Friday', 'Weekday', 'Normal Day', 26.8331, 0.27, 76.9472, 1.71746, 207170.00);
INSERT INTO `weather_data` VALUES (5260, '2/19/2022', 19, 'February', 'Saturday', 'Weekend', 'Normal Day', 27.7828, 4.9, 76.3194, 2.37778, 198960.00);
INSERT INTO `weather_data` VALUES (5261, '2/20/2022', 20, 'February', 'Sunday', 'Weekend', 'Normal Day', 27.1222, 54.59, 74.125, 2.55238, 186416.00);
INSERT INTO `weather_data` VALUES (5262, '2/21/2022', 21, 'February', 'Monday', 'Weekday', 'Normal Day', 26.7217, 62.49, 76.975, 2.64444, 205368.00);
INSERT INTO `weather_data` VALUES (5263, '2/22/2022', 22, 'February', 'Tuesday', 'Weekday', 'Normal Day', 26.0242, 307.7, 86.4028, 2.1746, 205241.00);
INSERT INTO `weather_data` VALUES (5264, '2/23/2022', 23, 'February', 'Wednesday', 'Weekday', 'Normal Day', 26.3778, 9.49, 77.95, 2.33651, 202570.00);
INSERT INTO `weather_data` VALUES (5265, '2/24/2022', 24, 'February', 'Thursday', 'Weekday', 'Normal Day', 27.215, 8.57, 73.3639, 2.82857, 204854.00);
INSERT INTO `weather_data` VALUES (5266, '2/25/2022', 25, 'February', 'Friday', 'Weekday', 'Special Non-working Holiday', 26.9528, 40.29, 73.2, 2.76825, 193706.00);
INSERT INTO `weather_data` VALUES (5267, '2/26/2022', 26, 'February', 'Saturday', 'Weekend', 'Normal Day', 26.4231, 35.58, 75.7417, 2.4254, 190173.00);
INSERT INTO `weather_data` VALUES (5268, '2/27/2022', 27, 'February', 'Sunday', 'Weekend', 'Normal Day', 26.6344, 14.2, 74.5694, 2.36825, 179352.00);
INSERT INTO `weather_data` VALUES (5269, '2/28/2022', 28, 'February', 'Monday', 'Weekday', 'Normal Day', 27.2733, 2.2, 72.3111, 2.7746, 203074.00);
INSERT INTO `weather_data` VALUES (5270, '3/1/2022', 1, 'March', 'Tuesday', 'Weekday', 'Normal Day', 27.0797, 0.5, 69.5833, 2.46667, 207029.00);
INSERT INTO `weather_data` VALUES (5271, '3/2/2022', 2, 'March', 'Wednesday', 'Weekday', 'Normal Day', 27.3983, 12.9, 73.2694, 2.6, 210772.00);
INSERT INTO `weather_data` VALUES (5272, '3/3/2022', 3, 'March', 'Thursday', 'Weekday', 'Normal Day', 27.0906, 5.19, 74.7667, 2.72698, 214535.00);
INSERT INTO `weather_data` VALUES (5273, '3/4/2022', 4, 'March', 'Friday', 'Weekday', 'Normal Day', 27.2436, 1.09, 75.4778, 2.36825, 215144.00);
INSERT INTO `weather_data` VALUES (5274, '3/5/2022', 5, 'March', 'Saturday', 'Weekend', 'Normal Day', 27.5172, 0, 73.6167, 1.99048, 204868.00);
INSERT INTO `weather_data` VALUES (5275, '3/6/2022', 6, 'March', 'Sunday', 'Weekend', 'Normal Day', 27.6689, 0.09, 70.8278, 2.54921, 191457.00);
INSERT INTO `weather_data` VALUES (5276, '3/7/2022', 7, 'March', 'Monday', 'Weekday', 'Normal Day', 27.3839, 1.2, 71.5667, 2.28571, 210301.00);
INSERT INTO `weather_data` VALUES (5277, '3/8/2022', 8, 'March', 'Tuesday', 'Weekday', 'Normal Day', 27.0781, 10.09, 72.3194, 2.99683, 215639.00);
INSERT INTO `weather_data` VALUES (5278, '3/9/2022', 9, 'March', 'Wednesday', 'Weekday', 'Normal Day', 26.7814, 0.19, 71.2111, 2.95556, 211066.00);
INSERT INTO `weather_data` VALUES (5279, '3/10/2022', 10, 'March', 'Thursday', 'Weekday', 'Normal Day', 27.4411, 29.68, 70.4972, 2.55873, 212159.00);
INSERT INTO `weather_data` VALUES (5280, '3/11/2022', 11, 'March', 'Friday', 'Weekday', 'Normal Day', 27.9647, 28.59, 77.2139, 1.88889, 217689.00);
INSERT INTO `weather_data` VALUES (5281, '3/12/2022', 12, 'March', 'Saturday', 'Weekend', 'Normal Day', 28.1308, 211.3, 78.2611, 2.1619, 212633.00);
INSERT INTO `weather_data` VALUES (5282, '3/13/2022', 13, 'March', 'Sunday', 'Weekend', 'Normal Day', 27.4875, 113.8, 80.5917, 1.97143, 194003.00);
INSERT INTO `weather_data` VALUES (5283, '3/14/2022', 14, 'March', 'Monday', 'Weekday', 'Normal Day', 27.9836, 135.38, 81.7056, 2.06984, 218059.00);
INSERT INTO `weather_data` VALUES (5284, '3/15/2022', 15, 'March', 'Tuesday', 'Weekday', 'Normal Day', 28.4272, 65.09, 80.0611, 2.18095, 225423.00);
INSERT INTO `weather_data` VALUES (5285, '3/16/2022', 16, 'March', 'Wednesday', 'Weekday', 'Normal Day', 28.5178, 76.09, 78.5083, 2.13333, 227216.00);
INSERT INTO `weather_data` VALUES (5286, '3/17/2022', 17, 'March', 'Thursday', 'Weekday', 'Normal Day', 28.6739, 11, 77.1472, 2.30794, 230863.00);
INSERT INTO `weather_data` VALUES (5287, '3/18/2022', 18, 'March', 'Friday', 'Weekday', 'Normal Day', 28.7056, 49.98, 78.6056, 1.97778, 230741.00);
INSERT INTO `weather_data` VALUES (5288, '3/19/2022', 19, 'March', 'Saturday', 'Weekend', 'Normal Day', 28.6989, 16.08, 77.1667, 1.97143, 216383.00);
INSERT INTO `weather_data` VALUES (5289, '3/20/2022', 20, 'March', 'Sunday', 'Weekend', 'Normal Day', 28.9067, 28.1, 72.3556, 2.30476, 203100.00);
INSERT INTO `weather_data` VALUES (5290, '3/21/2022', 21, 'March', 'Monday', 'Weekday', 'Normal Day', 28.7383, 25.08, 73.0222, 2.21587, 227294.00);
INSERT INTO `weather_data` VALUES (5291, '3/22/2022', 22, 'March', 'Tuesday', 'Weekday', 'Normal Day', 29.1425, 0, 72.9389, 2.15238, 234840.00);
INSERT INTO `weather_data` VALUES (5292, '3/23/2022', 23, 'March', 'Wednesday', 'Weekday', 'Normal Day', 28.9406, 95.4, 75.2361, 2.29206, 238420.00);
INSERT INTO `weather_data` VALUES (5293, '3/24/2022', 24, 'March', 'Thursday', 'Weekday', 'Normal Day', 28.9753, 26.8, 73.6222, 2.6381, 236145.00);
INSERT INTO `weather_data` VALUES (5294, '3/25/2022', 25, 'March', 'Friday', 'Weekday', 'Normal Day', 29.1333, 5.88, 71.325, 2.28571, 233260.00);
INSERT INTO `weather_data` VALUES (5295, '3/26/2022', 26, 'March', 'Saturday', 'Weekend', 'Normal Day', 29.2617, 9.2, 72.7361, 1.92381, 223916.00);
INSERT INTO `weather_data` VALUES (5296, '3/27/2022', 27, 'March', 'Sunday', 'Weekend', 'Normal Day', 29.0153, 4.18, 72.1917, 2.24444, 208860.00);
INSERT INTO `weather_data` VALUES (5297, '3/28/2022', 28, 'March', 'Monday', 'Weekday', 'Normal Day', 29.2458, 18.58, 70.6056, 2.51111, 229605.00);
INSERT INTO `weather_data` VALUES (5298, '3/29/2022', 29, 'March', 'Tuesday', 'Weekday', 'Normal Day', 28.9547, 68.19, 73.5806, 2.73333, 234717.00);
INSERT INTO `weather_data` VALUES (5299, '3/30/2022', 30, 'March', 'Wednesday', 'Weekday', 'Normal Day', 29.1353, 39.19, 70.7389, 2.59683, 234866.00);
INSERT INTO `weather_data` VALUES (5300, '3/31/2022', 31, 'March', 'Thursday', 'Weekday', 'Normal Day', 29.2708, 12.5, 71.8833, 2.59365, 236416.00);
INSERT INTO `weather_data` VALUES (5301, '4/1/2022', 1, 'April', 'Friday', 'Weekday', 'Normal Day', 28.2656, 197.08, 76.9694, 2.61587, 231773.00);
INSERT INTO `weather_data` VALUES (5302, '4/2/2022', 2, 'April', 'Saturday', 'Weekend', 'Normal Day', 27.6786, 15.38, 70.9194, 2.69524, 212717.00);
INSERT INTO `weather_data` VALUES (5303, '4/3/2022', 3, 'April', 'Sunday', 'Weekend', 'Normal Day', 27.6906, 14.99, 70.9889, 3.00635, 195566.00);
INSERT INTO `weather_data` VALUES (5304, '4/4/2022', 4, 'April', 'Monday', 'Weekday', 'Normal Day', 27.9531, 269.4, 70.8611, 2.84444, 217067.00);
INSERT INTO `weather_data` VALUES (5305, '4/5/2022', 5, 'April', 'Tuesday', 'Weekday', 'Normal Day', 25.8472, 471.49, 88.0667, 2.25397, 208043.00);
INSERT INTO `weather_data` VALUES (5306, '4/6/2022', 6, 'April', 'Wednesday', 'Weekday', 'Normal Day', 27.2517, 123.38, 79.95, 2.52698, 212434.00);
INSERT INTO `weather_data` VALUES (5307, '4/7/2022', 7, 'April', 'Thursday', 'Weekday', 'Normal Day', 27.8175, 68.16, 77.0806, 2.58095, 217753.00);
INSERT INTO `weather_data` VALUES (5308, '4/8/2022', 8, 'April', 'Friday', 'Weekday', 'Normal Day', 26.7347, 238.2, 81.7083, 2.06032, 215046.00);
INSERT INTO `weather_data` VALUES (5309, '4/9/2022', 9, 'April', 'Saturday', 'Weekend', 'Regular Holiday', 27.8033, 26.19, 76.1972, 1.90794, 197970.00);
INSERT INTO `weather_data` VALUES (5310, '4/10/2022', 10, 'April', 'Sunday', 'Weekend', 'Normal Day', 27.3872, 74.29, 79.2361, 1.7746, 189633.00);

SET FOREIGN_KEY_CHECKS = 1;
