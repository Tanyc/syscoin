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
INSERT INTO `bi_notice` VALUES ('1', '关于用户首次兑奖的相关问题', 'notice1.html','1400474180');
INSERT INTO `bi_notice` VALUES ('2', '端午狂欢，登录有奖', 'notice2.html','1400474199');
INSERT INTO `bi_notice` VALUES ('3', '关于团购返利的相关公告', 'notice3.html','1400474280');
