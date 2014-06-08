DROP TABLE IF EXISTS `bi_activity`;
CREATE TABLE `bi_activity` (
  `id` smallint(4) unsigned NOT NULL AUTO_INCREMENT,
  `title` varchar(50) NOT NULL,
  `create_time` int(11) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
INSERT INTO `bi_activity` VALUES ('1', '首冲送大礼', '1400473645');
INSERT INTO `bi_activity` VALUES ('2', '第一届比特币大奖赛', '1400474056');