DROP TABLE IF EXISTS `bi_prize`;
CREATE TABLE `bi_prize` (
`id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
`name` varchar(30) NOT NULL,
`cost_eggs` int(6) NOT NULL,
`swap_num` smallint(4) unsigned NOT NULL,
`des_img` varchar(10) not null,
`des_img_num` smallint(4) not null,
`des` varchar(100),
PRIMARY KEY (`id`)
)DEFAULT CHARSET =utf8;

-- ----------------------------
-- name:商品名
-- cost_eggs:价值
-- swap_num：被兑换次数
-- des_img:描述图片
-- des_img_num:描述图片张数
-- des:商品自身描述
-- ----------------------------
INSERT INTO `bi_prize` VALUES ('1', '移动话费100元直冲','12400000 ', '560,000','0','');