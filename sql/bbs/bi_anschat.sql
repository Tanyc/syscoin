DROP TABLE IF EXISTS `bi_anschat`;
CREATE TABLE `bi_anschat` (
`id` smallint(4) unsigned NOT NULL AUTO_INCREMENT,
`ans_id` smallint(5) unsigned NOT NULL,
`UID` int(8) NOT NULL,
`content` BLOB(100) NOT NULL,
`CTIME` varchar(11) NOT NULL,
PRIMARY KEY (`id`)
)DEFAULT CHARSET =utf8;

-- ----------------------------
-- id:聊天id
-- ans_id:ans的id
-- UID:用户id
-- content:内容，100字以下
-- CTIME:创建时间
-- ----------------------------
INSERT INTO `bi_anschat` VALUES ('1','3','1873372', '这是我的博客评论','1400473645');
INSERT INTO `bi_anschat` VALUES (NULL,'2','1873372', '这是我的博ssss1','1400473645');
INSERT INTO `bi_anschat` VALUES (NULL,'3','1873372', '这是我ssaaaaaaa2','1400473645');