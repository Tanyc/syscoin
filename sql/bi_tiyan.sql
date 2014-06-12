DROP TABLE IF EXISTS `bi_tiyan`;
CREATE TABLE `bi_tiyan` (
  `id` smallint(4) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `give_eggs` int(5) unsigned NOT NULL,
  `pic` varchar(30),
  `tab` smallint(1) unsigned,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
INSERT INTO `bi_tiyan` VALUES ('1', '棋牌试玩-江湖游', '160', 'tiyan.jpg','1');
INSERT INTO `bi_tiyan` VALUES ('2', '呱呱歌舞厅', '180', 'tiyan.jpg','1');
INSERT INTO `bi_tiyan` VALUES ('3', '博雅斗地主', '210', 'tiyan.jpg','1');
INSERT INTO `bi_tiyan` VALUES ('4', '博雅德州扑克', '360', 'tiyan.jpg','1');
INSERT INTO `bi_tiyan` VALUES ('5', '博雅四川麻将', '190', 'tiyan.jpg','1');
INSERT INTO `bi_tiyan` VALUES ('6', '博雅蛋蛋', '180', 'tiyan.jpg','2');
INSERT INTO `bi_tiyan` VALUES ('7', '博雅测试', '280', 'tiyan.jpg','2');
INSERT INTO `bi_tiyan` VALUES ('8', '博雅侧四十四', '230', 'tiyan.jpg','3');
INSERT INTO `bi_tiyan` VALUES ('9', '博雅事实上实施', '245', 'tiyan.jpg','3');
INSERT INTO `bi_tiyan` VALUES ('10', '博雅vv阿三', '265', 'tiyan.jpg','3');

INSERT INTO `bi_tiyan` VALUES ('11', '赠品试用赚蛋', '7000', 'slider1.png','4');
INSERT INTO `bi_tiyan` VALUES ('12', '竞猜游戏竞猜赚蛋', '1000', 'slider2.png','4');
INSERT INTO `bi_tiyan` VALUES ('13', '新人任务赚蛋', '2000', 'slider3.png','4');