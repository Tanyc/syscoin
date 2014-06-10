DROP TABLE IF EXISTS `bi_tiyan`;
CREATE TABLE `bi_tiyan` (
  `id` smallint(4) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `give_eggs` int(5) unsigned NOT NULL,
  `pic` varchar(30),
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
INSERT INTO `bi_tiyan` VALUES ('1', '棋牌试玩-江湖游', '160', 'tiyan.jpg');
INSERT INTO `bi_tiyan` VALUES ('2', '呱呱歌舞厅', '180', 'tiyan.jpg');
INSERT INTO `bi_tiyan` VALUES ('3', '博雅斗地主', '210', 'tiyan.jpg');
INSERT INTO `bi_tiyan` VALUES ('4', '博雅德州扑克', '360', 'tiyan.jpg');
INSERT INTO `bi_tiyan` VALUES ('5', '博雅四川麻将', '190', 'tiyan.jpg');
INSERT INTO `bi_tiyan` VALUES ('6', '博雅广东麻将', '180', 'tiyan.jpg');