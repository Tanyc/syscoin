DROP TABLE IF EXISTS `bi_prize`;
CREATE TABLE `bi_prize` (
`id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
`prize_num` varchar(10) not null,
`name` varchar(80) NOT NULL,
`cost_eggs` varchar(15) NOT NULL,
`swap_num` int(5) unsigned NOT NULL,
`des` varchar(100),
PRIMARY KEY (`id`)
)DEFAULT CHARSET =utf8;

-- ----------------------------
-- Records of bi_notice
-- ----------------------------
INSERT INTO `bi_prize` VALUES ('1', 'eg-1','prize1', '560,000','0','');
INSERT INTO `bi_prize` VALUES ('2', 'eg-2','prize2', '1,560,000','0','');
INSERT INTO `bi_prize` VALUES ('3', 'eg-3','prize3', '2,560,000','0','');
INSERT INTO `bi_prize` VALUES ('4', 'eg-4','prize4', '3,560,000','0','');
INSERT INTO `bi_prize` VALUES ('5', 'eg-5','prize5', '55,560,000','0','');
INSERT INTO `bi_prize` VALUES ('6', 'eg-6','prize6', '33,560,000','1','');