DROP TABLE IF EXISTS `bi_gloryeva`;
CREATE TABLE `bi_gloryeva` (
`id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
`glory_id` int(5) NOT NULL,
`u_id` int(8) NOT NULL,
`content` varchar(200) NOT NULL,
`CTIME` int(11) unsigned NOT NULL,
PRIMARY KEY (`id`)
)DEFAULT CHARSET =utf8;

-- ----------------------------
-- glory_id:晒奖id,对应bi_glory中的id
-- u_id:评价用户的id
-- content:评价内容，最多一百字
-- CTIME:评价时间
-- ----------------------------
INSERT INTO `bi_gloryeva` VALUES ('1','1', '1873373', '加油，我也要像你学习', '1400473645');
INSERT INTO `bi_gloryeva` VALUES ('2','1', '1873374', '不错哦', '1400473655');
INSERT INTO `bi_gloryeva` VALUES ('3','1', '1873374', '加油，呵呵！', '1400473875');
INSERT INTO `bi_gloryeva` VALUES ('4','1', '1873375', '怎么我又归了啊', '1400474545');
INSERT INTO `bi_gloryeva` VALUES ('5','1', '1873376', '好难啊', '1400475245');
INSERT INTO `bi_gloryeva` VALUES ('6','2', '1873377', '我喜欢七彩网', '1400471455');
