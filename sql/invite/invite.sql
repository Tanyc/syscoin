DROP TABLE IF EXISTS `bi_invite`;
CREATE TABLE `bi_invite` (
`id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
`UID` int(8) NOT NULL UNIQUE,
`BUIDS` varchar(160),
`b_num` int(2) NOT NULL DEFAULT 0,
`score` int(5) NOT NULL DEFAULT 0,
`p_score` int(5) NOT NULL DEFAULT 0,
`p_money` int(3) NOT NULL DEFAULT 0,
`last_score` int(3) NOT NULL DEFAULT 0,
`CTIME` varchar(11),
PRIMARY KEY (`id`)
)DEFAULT CHARSET =utf8;

-- ----------------------------
-- id:晒奖id
-- UID:推广用户id
-- BUIDS:被推广用户的id，以";"间隔，当前最多保存20位
-- b_num：被推广人数
-- score:推广分数
-- p_score:已兑换的分数
-- p_money:已兑换的现金
-- last_score:最后获得奖励分数
-- CTIME：最后获得奖励时间
-- ----------------------------
INSERT INTO `bi_invite` VALUES ('1','1873372', '1873373,1985454,5248541,548751', '4','2654','215','10','100','1400473645');
INSERT INTO `bi_invite` VALUES (null,'1873373', '1873373', '1','2654854','2152','1','105','1400473655');
INSERT INTO `bi_invite` VALUES (null,'1873374', '1873373,1985454', '2','2654454','2125','0','1580','1400473665');
INSERT INTO `bi_invite` VALUES (null,'1873375', '1873373,1985454,5248541,5458751', '4','26548','215','0','205','1400473685');
INSERT INTO `bi_invite` VALUES (null,'1873376', '1873373,54584584,5458751', '3','2654854','21524','1','1320','1400473745');
INSERT INTO `bi_invite` VALUES (null,'1873377', '1873373,1985454,5248541,5458751', '4','8454','2155','5','111','1400473545');
INSERT INTO `bi_invite` VALUES (null,'1873378', '1873373,2545454,5248541,584542', '4','545454','25','6','108','1400473335');
INSERT INTO `bi_invite` VALUES (null,'1873379', '1873373,2545415,5248541,5252522', '4','5254','2152','3','109','1400473225');
INSERT INTO `bi_invite` VALUES (null,'1873310', '1873373,5555545,5248541,54542545', '4','55554','2152','2','112','1400473945');
INSERT INTO `bi_invite` VALUES (null,'1873311', '1873373,1985454,5248541,5458751', '4','554','2185','0','10','1400473642');
INSERT INTO `bi_invite` VALUES (null,'1873312', '1873373,5454544,54584584,554545,5458751', '5','54554','21555','1000','100','1400475645');