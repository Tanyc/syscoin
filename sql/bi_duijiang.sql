DROP TABLE IF EXISTS `bi_duijiang`;
CREATE TABLE `bi_duijiang` (
  `id` smallint(4) unsigned NOT NULL AUTO_INCREMENT,
  `user_id` int(12) unsigned NOT NULL,
  `p_id` int(8) unsigned NOT NULL,
  `p_name` varchar(50) NOT NULL,
  `time` int(11) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- product on show time
INSERT INTO `bi_duijiang` VALUES ('1', '1587424', '1241', '全国移动100元充值卡','1400474180');
INSERT INTO `bi_duijiang` VALUES ('2', '1587425', '1245', '全国移动10元充值卡','1400474190');
INSERT INTO `bi_duijiang` VALUES ('3', '1587426', '1246', '全国移动5元充值卡','1400474280');
INSERT INTO `bi_duijiang` VALUES ('4', '1587427', '1247', '全国移动2元充值卡','1400474380');