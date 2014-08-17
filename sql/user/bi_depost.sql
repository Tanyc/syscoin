DROP TABLE IF EXISTS `bi_deposit`;
CREATE TABLE `bi_deposit` (
  `id` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `UID` int(11) NOT NULL,
  `TYPE` smallint(1),
  `DMONEY` varchar(12) NOT NULL,
  `SMONEY` varchar(12) NOT NULL,
  `CTIME` int(11) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- 为了减小数据存储，本表不包含游戏金蛋投注明细
-- id:记录主键
-- UID:用户id
-- TYPE：0=存款，1=取款
-- DMONEY:存取款值
-- SMONEY：金库余额
-- CTIME：获取时间

INSERT INTO `bi_deposit` VALUES ("1","1873372","0","10000","3654211","1400473645");