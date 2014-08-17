DROP TABLE IF EXISTS `bi_user_eggs`;
CREATE TABLE `bi_user_eggs` (
  `id` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `UID` int(11) NOT NULL,
  `TYPE` smallint(1),
  `NAME` varchar(20),
  `SMONEY` varchar(10) NOT NULL,
  `ALLMONEY` varchar(12) NOT NULL,
  `CTIME` int(11) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- 为了减小数据存储，本表不包含游戏金蛋投注明细
-- id:记录主键
-- UID:用户id
-- TYPE：金币来源,1=保留没有用，2=广告，3=团购领奖。4=其它：（登录奖励，领取，违规扣除等）
-- SMONEY：金币多少
-- CTIME：获取时间

INSERT INTO `bi_user_eggs` VALUES ("1","1873372","4","1","-52142","2548545425","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("2","1873372","4","2","254245","2548545425","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("3","1873372","2","美肤宝问卷调查","254245","2548545425","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("4","1873372","2","我的问卷调查","254245","2548545425","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("5","1873372","3","0801团购","254245","2548545425","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("6","1873372","4","登录奖励","254245","2548545425","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("7","1873372","5","vip每日领取7","254245","2548545425","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("8","1873372","5","vip每日领取8","254245","2548545425","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("9","1873372","5","vip每日领取9","254245","2548545425","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("10","1873372","5","vip每日领取10","254245","2548545425","1400473645");