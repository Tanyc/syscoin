DROP TABLE IF EXISTS `bi_prize`;
CREATE TABLE `bi_prize` (
`id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
`type_id` smallint(1),
`subtype_id` smallint(1),
`name` varchar(30) NOT NULL,
`cost_eggs` int(6) NOT NULL,
`swap_num` smallint(4) unsigned NOT NULL,
`des_img` varchar(10) not null,
`des_img_num` smallint(4) not null,
`is_limit` smallint(1),
`des` varchar(100),
PRIMARY KEY (`id`)
)DEFAULT CHARSET =utf8;

-- ----------------------------
-- type_id:商品类别id
-- subtype_id:子类别商品id
-- name:商品名
-- cost_eggs:价值
-- swap_num：被兑换次数
-- des_img:描述图片
-- des_img_num:描述图片张数
-- is_limit:当前是否缺货,等于1时表示缺货
-- des:商品自身描述
-- ----------------------------
INSERT INTO `bi_prize` VALUES ('1', '1', '1', '移动话费100元直冲','11400000', '0', 'yid','1','', '兑换时请填写好要充值的手机卡号');
INSERT INTO `bi_prize` VALUES ('2', '1', '1', '移动话费50元直冲', '6000000', '0', 'yid','1','','');
INSERT INTO `bi_prize` VALUES ('3', '1', '1', '移动话费10元直冲', '1600000', '0', 'yid','1','','');
INSERT INTO `bi_prize` VALUES ('4', '1', '1', '联通话费100元直冲','11400000', '0', 'liant','1','','');
INSERT INTO `bi_prize` VALUES ('5', '1', '1', '联通话费50元直冲', '6000000', '0', 'liant','1','','');
INSERT INTO `bi_prize` VALUES ('6', '1', '1', '联通话费10元直冲', '1600000', '0', 'liant','1','','');
INSERT INTO `bi_prize` VALUES ('7', '1', '1', '联通话费100元直冲','11400000', '0', 'dianx','1','','');
INSERT INTO `bi_prize` VALUES ('8', '1', '1', '联通话费50元直冲', '6000000', '0', 'dianx','1','','');
INSERT INTO `bi_prize` VALUES ('9', '1', '1', '联通话费10元直冲', '1600000', '0', 'dianx','1','','');
INSERT INTO `bi_prize` VALUES ('10', '1', '1', '移动话费100卡密','11500000', '0', 'yidz','1','', '兑换成功后直接发送到用户邮箱，请尽快充值');
INSERT INTO `bi_prize` VALUES ('11', '1', '1', '移动话费50卡密', '6100000', '0', 'yidz','1','','');
INSERT INTO `bi_prize` VALUES ('12', '1', '1', '移动话费10卡密', '1650000', '0', 'yidz','1','','');
INSERT INTO `bi_prize` VALUES ('13', '1', '1', '联通话费100卡密','11500000', '0', 'liantz','1','','');
INSERT INTO `bi_prize` VALUES ('14', '1', '1', '联通话费50卡密', '6100000', '0', 'liantz','1','','');
INSERT INTO `bi_prize` VALUES ('15', '1', '1', '联通话费10卡密', '1650000', '0', 'liantz','1','','');
INSERT INTO `bi_prize` VALUES ('16', '1', '1', '联通话费100卡密','11500000', '0', 'dianxz','1','','');
INSERT INTO `bi_prize` VALUES ('17', '1', '1', '联通话费50卡密', '6100000', '0', 'dianxz','1','','');
INSERT INTO `bi_prize` VALUES ('18', '1', '1', '联通话费10卡密', '1650000', '0', 'dianxz','1','','');
INSERT INTO `bi_prize` VALUES ('19', '1', '1', '兑换券','180000', '0', 'quan','0','','一个兑换券等于一元话费，可积攒够10多张后兑换话费');
INSERT INTO `bi_prize` VALUES ('20', '1', '2', '京东购物券50元卡密', '6000000', '0', 'jingd','1','1','只能用于京东商城充值使用');
