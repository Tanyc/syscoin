DROP TABLE IF EXISTS `bi_tiyanlast`;
CREATE TABLE `bi_tiyanlast` (
  `id` smallint(4) unsigned NOT NULL AUTO_INCREMENT,
  `user_id` varchar(12) NOT NULL,
  `act_name` varchar(50) NOT NULL,
  `act_time` int(11) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
INSERT INTO `bi_tiyanlast` VALUES ('1','1873372', '棋牌试玩江湖游', '1400473645');
INSERT INTO `bi_tiyanlast` VALUES ('2','1873373', '呱呱歌舞厅', '1400473655');
INSERT INTO `bi_tiyanlast` VALUES ('3','1873374', '博雅斗地主', '1400473645');
INSERT INTO `bi_tiyanlast` VALUES ('4','1873375', '博雅德州扑克', '140047445');
INSERT INTO `bi_tiyanlast` VALUES ('5','1873376', '博雅四川麻将', '14004445');
INSERT INTO `bi_tiyanlast` VALUES ('6','1873377', '博雅蛋蛋', '1400473545');
INSERT INTO `bi_tiyanlast` VALUES ('7','1873378', '博雅测试', '140047645');
INSERT INTO `bi_tiyanlast` VALUES ('8','1873379', '博雅侧四十四', '140047545');
INSERT INTO `bi_tiyanlast` VALUES ('9','1873380', '博雅事实上实施', '1400773645');
INSERT INTO `bi_tiyanlast` VALUES ('10','1873381', '博雅vv阿三', '1400473445');