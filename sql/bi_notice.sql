DROP TABLE IF EXISTS `bi_notice`;
CREATE TABLE `bi_notice` (
  `id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `title` varchar(64) NOT NULL,
  `con_link` varchar(100) NOT NULL,
  `create_time` int(11) unsigned NOT NULL,
  PRIMARY KEY (`id`)
)DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of bi_notice
-- ----------------------------
INSERT INTO `bi_notice` VALUES ('1', 'notice1', 'notice1.html','1400474180');
INSERT INTO `bi_notice` VALUES ('2', 'notice2', 'notice2.html','1400474199');
INSERT INTO `bi_notice` VALUES ('3', 'notice3', 'notice3.html','1400474280');
INSERT INTO `bi_notice` VALUES ('4', 'notice4', 'notice4.html','1400474380');
INSERT INTO `bi_notice` VALUES ('5', 'notice5', 'notice5.html','1400474480');
INSERT INTO `bi_notice` VALUES ('6', 'notice6', 'notice6.html','1400474580');
