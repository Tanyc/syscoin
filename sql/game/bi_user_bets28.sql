-- 该文件为所有用户的详细投注结果，某个用户在某一期投注了**
DROP TABLE IF EXISTS `bi_user_bets28`;
CREATE TABLE `bi_user_bets28` (
  `id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `UID` int(11) NOT NULL,
  `LID` varchar(10) NOT NULL,
  `ALLSMONEY` varchar(200) NOT NULL,
  `SMONEYSUM` int(9) NOT NULL,
  `GMONEYSUM` int(9) NOT NULL,
  `CTIME` int(11) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
INSERT INTO `bi_user_bets28` VALUES ('1','1873372','636520', '1,2,5,8,8,,28,,,,,,8,,,,,,4,,5,,,7,,,,', '25841',"25454", '1400473645');
INSERT INTO `bi_user_bets28` VALUES ('2','1873372','636521', '1,8,20,30,33,,128,,,,,,1,,,,,,4,,5,,,7,,,,', '12345',"555665", '1400473645');
INSERT INTO `bi_user_bets28` VALUES ('3','1873372','636522', '1,2,144,8,8,,855,,,447,,,8,,,,,,4,,5,,,7,,,,', '25481',"", '1400473645');
INSERT INTO `bi_user_bets28` VALUES ('4','1873372','636523', '1000,2,5,8,10,,28,,,2002,,,41,,,,,,4,,5,,,7,,,,', '25489544',"9857", '1400473645');
INSERT INTO `bi_user_bets28` VALUES ('5','1873372','636524', '1,745,5,4521,8,,125,,,,,,10,,,11,,,21,,241,,,7,,1254,,', '298754',"", '1400473645');
INSERT INTO `bi_user_bets28` VALUES ('6','1873372','636525', '1,2,5,1452,8,,4511,,44,,,,74,,,,44,,5788,,5,,,125,,2585,,', '259854',"", '1400473645');
INSERT INTO `bi_user_bets28` VALUES ('8','1873372','636527', '1,2,41,8,222,,441,,4,,,,88,,,,,,252,,124,,,341,,,,', '255891',"2542454", '1400473645');
INSERT INTO `bi_user_bets28` VALUES ('9','1873372','636528', '1,2,44,8,8,,525,,,,44,,8,,,,,,44,,5,,,231,,,,', '2999991',"", '1400473645');
INSERT INTO `bi_user_bets28` VALUES ('10','1873372','636529', '1,2,4774,8,22,,28,,,44,,,8,,,454,,,4,,5,,,7,,254,,', '2587541',"25845454", '1400473645');
INSERT INTO `bi_user_bets28` VALUES ('11','1873372','636530', '1,2,444,8,21541,,28,,,541144,,,5484,,,484,,,4,,2512,,,84541,,254,,', '2587741',"", '1400473645');
INSERT INTO `bi_user_bets28` VALUES ('12','1873372','636531', '1,2,4774,8,22,,28,,,48,,,8,,,454,,8,4,,5,,,7,,254,,', '25877541',"", '1400473645');
INSERT INTO `bi_user_bets28` VALUES ('13','1873372','636532', '1,2,444,8,22,,28,,,474,,,8,,,4144,,,4,,5,,,7,,254,,', '258741',"", '1400473645');
INSERT INTO `bi_user_bets28` VALUES ('14','1873372','636533', '1,2,444,8,47,,28,4,,44,,,8,,,454,,,4,,5,,,7,,254,,', '258758',"", '1400473645');
INSERT INTO `bi_user_bets28` VALUES ('15','1584584','636534', '1,2,444,8,22,,28,,,44,,,8,,,474,,,4,,5,,,7,,254,,', '25877',"", '1400473645');