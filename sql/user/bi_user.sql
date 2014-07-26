DROP TABLE IF EXISTS `bi_user`;
CREATE TABLE `bi_user` (
  `user_id` int(12) unsigned NOT NULL AUTO_INCREMENT,
  `key` varchar(20) NOT NULL,
  `s_key` varchar(20) NOT NULL,
  `nick` varchar(10),
  `email` varchar(20),
  `phone` varchar(12),
  `qq` varchar(12),
  `range` int(8) unsigned NOT NULL,
  `eggs` int(12) unsigned NOT NULL,
  `maxeggs` int(12) unsigned NOT NULL,
  `deposit` int(12) unsigned NOT NULL,
  `exp` int(4) unsigned NOT NULL,
  `jifen` int(5) unsigned NOT NULL,
  `grow` int(4) unsigned NOT NULL,
  `vip` int(4) unsigned NOT NULL,
  `ltime` int(11) unsigned,
  `s_name` varchar(8),
  `s_number` varchar(18),
  PRIMARY KEY (`user_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- user_id:用户id
-- key:登录密码
-- s_key:取款密码
-- nick:用户昵称
-- email:验证邮箱
-- phone:验证手机
-- qq:qq号码
-- range：用户等级
-- eggs:财富金蛋值
-- maxeggs:账户最大财富
-- deposit:存款值
-- exp:经验值
-- jifen:积分值
-- grow:成长经验值
-- vip:vip经验值
-- ltime:最后登录时间
-- iscommit：账户是否认证：0=未认证  1=认证
-- s_name:身份证认证名称
-- s_number：身份证认证号码

INSERT INTO `bi_user` VALUES ('1873372', '628411', 'love660303', '天下第一','dingyong4223@163.com','13267074323','394276418','5','255454124','5845845451','10000000','120','80','100','100','1400473645','张三','510824198411153611');