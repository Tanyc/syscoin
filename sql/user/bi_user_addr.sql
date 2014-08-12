DROP TABLE IF EXISTS `bi_user_addr`;
CREATE TABLE `bi_user_addr` (
  `id` int(4) unsigned NOT NULL AUTO_INCREMENT,
  `UID` int(11) NOT NULL,
  `NAME` varchar(8),
  `PROVINCE` varchar(10) NOT NULL,
  `CITY` varchar(10) NOT NULL,
  `ADDRESS` varchar(80) NOT NULL,
  `PCODE` INT(6),
  `TEL` varchar(12) NOT NULL,
  `DEFAULT` smallint(1) unsigned DEFAULT 0,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- `id` id值
-- `UID` 用户id
-- `NAME` 姓名
-- `PROVINCE` 省
-- `CITY` 市
-- `ADDRESS` 详细地址
-- `PCODE` 邮编
-- `TEL` 电话
-- `DEFAULT` 是否默认地址

INSERT INTO `bi_user_addr` VALUES ("1","1873372","丁雍","广东","深圳","南山区西丽镇茶光村雨欣娄301","625411","13267074323","1");
INSERT INTO `bi_user_addr` VALUES ("2","1873372","丁霞","广东","深圳","南山区测试地址1号码","654214","13267025451","");
INSERT INTO `bi_user_addr` VALUES ("3","1873372","想语音","广东","深圳","南山测试地址545是谁的号","548541","13268545454","");