DROP TABLE IF EXISTS `bi_user_eggs`;
CREATE TABLE `bi_user_eggs` (
  `id` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `UID` int(11) NOT NULL,
  `TYPE` smallint(1),
  `NAME` varchar(20),
  `SMONEY` int(10) NOT NULL,
  `CTIME` int(11) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- 为了减小数据存储，本表不包含游戏金蛋投注明细
-- id:记录主键
-- UID:用户id
-- TYPE：金币来源,1=保留没有用，2=广告，3=团购领奖。4=其它：（登录奖励，领取，违规扣除等）
-- SMONEY：金币多少
-- CTIME：获取时间

INSERT INTO `bi_user_eggs` VALUES ("1","1873372","4","1","-52142","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("2","1873372","4","2","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("3","1873372","2","美肤宝问卷调查","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("4","1873372","2","我的问卷调查","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("5","1873372","3","0801团购","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("6","1873372","4","登录奖励","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("7","1873372","5","vip每日领取7","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("8","1873372","5","vip每日领取8","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("9","1873372","5","vip每日领取9","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("10","1873372","5","vip每日领取10","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("11","1873372","5","vip每日领取11","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("12","1873372","5","vip每日领取12","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("13","1873372","5","vip每日领取13","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("14","1873372","5","vip每日领取14","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("15","1873372","5","vip每日领取15","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("16","1873372","5","vip每16日领取","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("17","1873372","5","vip每日17领取","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("18","1873372","5","vip每日104领取","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("19","1873372","5","vip每日412领取","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("20","1873372","5","vip每日42领取","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("21","1873372","5","vip每日42领取","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("22","1873372","5","vip每日44领取","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("23","1873372","5","vip每日524领取","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("24","1873372","5","vip每424领取","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("25","1873372","5","vip每日42领取","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("26","1873372","5","vip每44日领取","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("27","1873372","5","vip每日77领取","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("28","1873372","5","vip每日78领取","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("29","1873372","5","vip每63日领取","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("30","1873372","5","vip每1日领取","254245","1400473645");
INSERT INTO `bi_user_eggs` VALUES ("31","1873372","5","vip每64日领取","254245","1400473645");