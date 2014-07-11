DROP TABLE IF EXISTS `bi_prize`;
CREATE TABLE `bi_prize` (
`id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
`p_id` varchar(6) UNIQUE NOT NULL,
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
-- p_id:商品编号,虚拟商品以XN开头，实物商品以SW开头
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
INSERT INTO `bi_prize` VALUES ('1', 'XN1000', '1', '1', '移动话费100元直冲','11400000', '0', 'yid','1','', '兑换时请填写好要充值的手机卡号');
INSERT INTO `bi_prize` VALUES ('2', 'XN1001', '1', '1', '移动话费50元直冲', '6000000', '0', 'yid','1','','');
INSERT INTO `bi_prize` VALUES ('3', 'XN1002', '1', '1', '移动话费10元直冲', '1600000', '0', 'yid','1','','');
INSERT INTO `bi_prize` VALUES ('4', 'XN1003', '1', '1', '联通话费100元直冲','11400000', '0', 'liant','1','','');
INSERT INTO `bi_prize` VALUES ('5', 'XN1004', '1', '1', '联通话费50元直冲', '6000000', '0', 'liant','1','','');
INSERT INTO `bi_prize` VALUES ('6', 'XN1005', '1', '1', '联通话费10元直冲', '1600000', '0', 'liant','1','','');
INSERT INTO `bi_prize` VALUES ('7', 'XN1006', '1', '1', '联通话费100元直冲','11400000', '0', 'dianx','1','','');
INSERT INTO `bi_prize` VALUES ('8', 'XN1007', '1', '1', '联通话费50元直冲', '6000000', '0', 'dianx','1','','');
INSERT INTO `bi_prize` VALUES ('9', 'XN1008', '1', '1', '联通话费10元直冲', '1600000', '0', 'dianx','1','','');
INSERT INTO `bi_prize` VALUES ('10', 'XN1009', '1', '1', '移动话费100元卡密','11500000', '0', 'yidz','1','', '兑换成功后直接发送到用户邮箱，请尽快充值');
INSERT INTO `bi_prize` VALUES ('11', 'XN1010', '1', '1', '移动话费50元卡密', '6100000', '0', 'yidz','1','','');
INSERT INTO `bi_prize` VALUES ('12', 'XN1011', '1', '1', '移动话费10元卡密', '1650000', '0', 'yidz','1','','');
INSERT INTO `bi_prize` VALUES ('13', 'XN1012', '1', '1', '联通话费100元卡密','11500000', '0', 'liantz','1','','');
INSERT INTO `bi_prize` VALUES ('14', 'XN1013', '1', '1', '联通话费50元卡密', '6100000', '0', 'liantz','1','','');
INSERT INTO `bi_prize` VALUES ('15', 'XN1014', '1', '1', '联通话费10元卡密', '1650000', '0', 'liantz','1','','');
INSERT INTO `bi_prize` VALUES ('16', 'XN1015', '1', '1', '联通话费100元卡密','11500000', '0', 'dianxz','1','','');
INSERT INTO `bi_prize` VALUES ('17', 'XN1016', '1', '1', '联通话费50元卡密', '6100000', '0', 'dianxz','1','','');
INSERT INTO `bi_prize` VALUES ('18', 'XN1017', '1', '1', '联通话费10元卡密', '1650000', '0', 'dianxz','1','','');
INSERT INTO `bi_prize` VALUES ('19', 'XN1018', '1', '1', '兑换券','180000', '0', 'quan','0','','一个兑换券等于一元话费，可积攒够10多张后兑换话费');
INSERT INTO `bi_prize` VALUES ('20', 'XN1019', '1', '2', '京东购物券50元卡密', '6000000', '0', 'jingd','1','1','只能用于京东商城充值使用');
