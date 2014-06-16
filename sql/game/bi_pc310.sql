DROP TABLE IF EXISTS `bi_pc310`;
CREATE TABLE `bi_pc310` (
  `id` int(8) unsigned NOT NULL AUTO_INCREMENT,
  `game_name` varchar(20) NOT NULL,
  `game_desc` varchar(30),
  `game_time` varchar(12) NOT NULL,
  `game_result` varchar(1),
  `all_down` int(6) unsigned NOT NULL,
  `all_eggs` int(15) unsigned not null,
  `open_people` int(5) unsigned not null,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

INSERT INTO `bi_pc310` VALUES ('12260', '巴西世界杯小组赛', '巴西 VS 墨西哥','06-18 04:00','','652','1022323734','0');
INSERT INTO `bi_pc310` VALUES ('12261', '巴西世界杯小组赛', '巴西 VS 墨西哥','06-18 06:00','','542','2222322415','0');
INSERT INTO `bi_pc310` VALUES ('12262', '巴西世界杯小组赛', '巴西 VS 墨西哥','06-18 07:00','','254','3222323720','0');
INSERT INTO `bi_pc310` VALUES ('12263', '巴西世界杯小组赛', '巴西 VS 墨西哥','06-17 09:00','','452','1252323300','0');
INSERT INTO `bi_pc310` VALUES ('12264', '巴西世界杯小组赛', '巴西 VS 墨西哥','06-18 02:00','','254','2102323724','0');
INSERT INTO `bi_pc310` VALUES ('12265', '巴西世界杯小组赛', '俄罗斯 VS 韩国','06-18 05:00','','238','554555320','0');
INSERT INTO `bi_pc310` VALUES ('12308', '13/14赛季NBA季后赛', '巴西 VS 墨西哥','06-18 05:00','1','5241','252355424','5622');
INSERT INTO `bi_pc310` VALUES ('12251', '巴西世界杯小组赛', '马刺 vs 热火','06-18 05:00','1','542','2525452724','452');
INSERT INTO `bi_pc310` VALUES ('12309', '13/14赛季NBA季后赛', '巴西 VS 克罗地亚','06-19 02:00','1','5421','252322424','254');
INSERT INTO `bi_pc310` VALUES ('12252', '巴西世界杯小组赛', '马刺 vs 热火','06-18 02:30','0','2415','25232724','542');
INSERT INTO `bi_pc310` VALUES ('12253', '巴西世界杯小组赛', '墨西哥 VS 喀麦隆','06-15 02:00','0','2102','365323724','854');
INSERT INTO `bi_pc310` VALUES ('12254', '巴西世界杯小组赛', '西班牙 VS 荷兰','06-15 02:50','1','1201','654323724','487');
INSERT INTO `bi_pc310` VALUES ('12255', '巴西世界杯小组赛', '智利 VS 澳大利亚','06-17 03:00','1','954','25232541','688');
INSERT INTO `bi_pc310` VALUES ('12256', '巴西世界杯小组赛', '哥伦比亚 VS 希腊','06-17 05:00','1','458','252323651','355');
INSERT INTO `bi_pc310` VALUES ('12257', '巴西世界杯小组赛', '乌拉圭 VS 哥斯达黎加','06-16 09:00','0','245','152323722','154');
INSERT INTO `bi_pc310` VALUES ('12297', '巴西世界杯小组赛', '英格兰 VS 意大利','06-16 05:00','0','854','262323733','325');
INSERT INTO `bi_pc310` VALUES ('12298', '巴西世界杯小组赛', '科特迪瓦 VS 日本','06-18 04:00','1','542','252323322','1121');
INSERT INTO `bi_pc310` VALUES ('12258', '巴西世界杯小组赛', '法国 VS 洪都拉斯','06-18 04:00','1','874','252322233','2415');
INSERT INTO `bi_pc310` VALUES ('12259', '巴西世界杯小组赛', '瑞士 VS 厄瓜多尔','06-18 01:00','3','452','262323344','1254');
INSERT INTO `bi_pc310` VALUES ('12310', '13/14赛季NBA季后赛', '热火 vs 马刺','06-16 07:00','0','880','1016400973','368');
