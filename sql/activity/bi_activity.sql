DROP TABLE IF EXISTS `bi_activity`;
CREATE TABLE `bi_activity` (
  `id` smallint(4) unsigned NOT NULL AUTO_INCREMENT,
  `title` varchar(40) NOT NULL,
  `img_name` varchar(20) NOT NULL,
  `is_active` int(1) NOT NULL,
  `act_time_start` int(11) NOT NULL,
  `act_menber` int(1) NOT NULL,
  `url_file` varchar(10) NOT NULL,
  `CTIME` int(11) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
-- is_active:是否正在进行的活动1 = 正在进行  0 = 过期活动
-- act_time_start：活动开始时间
-- act_menber：活动参与对象 0 = 普通会员  1 = vip会员等 
-- url_file：活动url所表示的页面名称
INSERT INTO `bi_activity` VALUES ('1', '首冲送大礼', 'test.jpg','1', '1400473645', '0' , 'fi_char', '1400473645');
INSERT INTO `bi_activity` VALUES ('2', '第一届比特币大奖赛','test.jpg','1', '1400473645', '0' , 'fi_bit', '1400474056');
INSERT INTO `bi_activity` VALUES ('3', '这是测试用例', 'test.jpg','0', '1400473645', '0' , 'fi_char', '1400473645');
INSERT INTO `bi_activity` VALUES ('4', '这也是测试用例','test.jpg','0', '1400473645', '0' , 'fi_bit', '1400474056');