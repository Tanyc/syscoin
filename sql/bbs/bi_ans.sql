DROP TABLE IF EXISTS `bi_ans`;
CREATE TABLE `bi_ans` (
`id` smallint(4) unsigned NOT NULL AUTO_INCREMENT,
`blog_id` smallint(5) unsigned NOT NULL,
`UID` int(8) NOT NULL,
`content` BLOB(100) NOT NULL,
`imgs` varchar(70),
`CTIME` varchar(11) NOT NULL,
PRIMARY KEY (`id`)
)DEFAULT CHARSET =utf8;

-- ----------------------------
-- id:晒奖id
-- blog_id:blog的id
-- UID:用户id
-- content:内容，100字以下
-- imgs:评论中使用的图片，以“:”作为分隔符,最多6张,每张图片格式=“m_(大图)/s_(小图) + 用户id + 上传时间 + 单次上传图像编号 + 图片后缀”；
-- CTIME:创建时间
-- ----------------------------
INSERT INTO `bi_ans` VALUES ('1','3','1873372', '这是我的博客评论',null,'1400473645');
INSERT INTO `bi_ans` VALUES (NULL,'2','1873372', '这是我的博ssss1',null,'1400473645');
INSERT INTO `bi_ans` VALUES (NULL,'3','1873372', '这是我ssaaaaaaa2',null,'1400473645');