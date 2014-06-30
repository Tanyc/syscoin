DROP TABLE IF EXISTS `bi_umode`;
CREATE TABLE `bi_umode` (
  `id` smallint(4) unsigned NOT NULL AUTO_INCREMENT,
  `user_id` int(12) unsigned NOT NULL,
  `name` varchar(10) NOT NULL,
  `U_ALLSMONEY` varchar(200) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
INSERT INTO `bi_umode` VALUES ('1', '1873372', '随机投注', '1,2,5,55,85,,444,,,,,,4444,,444,,,,4444,,444,,,7,,24,,');
INSERT INTO `bi_umode` VALUES ('2', '1873372', '稳定法', '1,2,41,8,222,,441,,4,,,,88,,,,,,252,,124,,,341,,,,');
INSERT INTO `bi_umode` VALUES ('3', '1873372', '张三法', '1,2,4774,8,22,,28,,,48,,,8,,,454,,8,4,,5,,,7,,254,,');
INSERT INTO `bi_umode` VALUES ('4', '1873372', '李四法', '1,745,5,4521,8,,125,,,,,,10,,,11,,,21,,241,,,7,,1254,,');
INSERT INTO `bi_umode` VALUES ('5', '1854545', '王五法', '1,2,444,8,21541,,28,,,541144,,,5484,,,484,,,4,,2512,,,84541,,254,,');