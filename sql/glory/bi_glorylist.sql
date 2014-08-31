DROP TABLE IF EXISTS `bi_glorylist`;
CREATE TABLE `bi_glorylist` (
`id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
`UID` int(8) NOT NULL,
`is_im` smallint(1) NOT NULL,
`title` varchar(40) NOT NULL,
`content` BLOB(600) NOT NULL,
`imgs` varchar(150),
`yes` smallint(1) NOT NULL DEFAULT 0,
`bbs_num` smallint(1) NOT NULL DEFAULT 0,
`CTIME` int(11) unsigned NOT NULL,
PRIMARY KEY (`id`)
)DEFAULT CHARSET =utf8;

-- ----------------------------
-- id:晒奖id
-- UID:用户id
-- is_im:是否置精
-- title：标题
-- content:内容，1000字以下
-- imgs:评论中使用的图片，以“:”作为分隔符,最多6张,每张图片格式=“m_(大图)/s_(小图) + 用户id + 上传时间 + 单次上传图像编号 + 图片后缀”；后期考虑优化
-- yes:点赞数量
-- bbs_num:评论数目, 预留
-- CTIME:创建时间
-- ----------------------------
INSERT INTO `bi_glorylist` VALUES ('1', '1873372', '1', '等候多时的iPad Air （16GB 银色）终于到手咯', '这么多年的坚持没有白费啊！注册PC还是5年前当时还在读小学，现在读职高，不知不觉支持PC蛋蛋这么多年了~(≧▽≦)/~', '18733721400473645.jpg:18733721400473665.jpg:18733721400473689.jpg:18733721400473710.jpg:18733721400473730.jpg:18733721400473755.jpg','2','5','1400473645');
INSERT INTO `bi_glorylist` VALUES ('2', '1873542','0', '我的充电宝到手了', '玩pc蛋蛋也有六年了，第一次兑换实物奖品好激动，感谢pc蛋蛋提供了这个平台。我会一直支持下去！经过我努力终于得到了回报。', '18733721400473645.jpg:18733721400473730.jpg:18733721400473755.jpg','2','5','1400473854');
INSERT INTO `bi_glorylist` VALUES ('3', '1254845','0', '哈哈，我终于换到大奖了', '测试测试测试测试测试测试的发生了打法和搜到发生的', '18733721400473645.jpg:18733721400473665.jpg:18733721400473689.jpg:18733721400473710.jpg','2','5','1400485475');