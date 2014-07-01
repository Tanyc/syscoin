DROP TABLE IF EXISTS `bi_niu`;
CREATE TABLE `bi_niu` (
  `id` smallint(4) unsigned NOT NULL AUTO_INCREMENT,
  `data_id` int(1) unsigned NOT NULL,
  `user_id` int(11) unsigned NOT NULL,
  `egg_win_all` int(11) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
INSERT INTO `bi_niu` VALUES ('1', '1', '17883275','2300474');
INSERT INTO `bi_niu` VALUES ('2', '2', '17436179','5400474');
INSERT INTO `bi_niu` VALUES ('3', '3', '12670827','5200474');
INSERT INTO `bi_niu` VALUES ('4', '4', '12670837','25400180');
INSERT INTO `bi_niu` VALUES ('5', '5', '12670154','452474180');
INSERT INTO `bi_niu` VALUES ('6', '6', '12447777','4444474180');
INSERT INTO `bi_niu` VALUES ('7', '1', '17883278','2304180');
INSERT INTO `bi_niu` VALUES ('8', '2', '17436178','5404180');
INSERT INTO `bi_niu` VALUES ('9', '3', '12670855','5204180');
INSERT INTO `bi_niu` VALUES ('10', '4', '12670855','20474180');
INSERT INTO `bi_niu` VALUES ('11', '5', '1267014','450474180');
INSERT INTO `bi_niu` VALUES ('12', '6', '1244777','4440474180');