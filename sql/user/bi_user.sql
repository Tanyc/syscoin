DROP TABLE IF EXISTS `bi_user`;
CREATE TABLE `bi_user` (
  `id` int(8) unsigned NOT NULL AUTO_INCREMENT,
  `key` varchar(32) NOT NULL,
  `status` smallint(1),
  `s_key` varchar(32) NOT NULL,
  `nick` varchar(10),
  `selfdes` varchar(100),
  `headimg` int(2),
  `email` varchar(20) NOT NULL UNIQUE,
  `phone` varchar(12),
  `qq` varchar(12),
  `iplimit` int(1),
  `range` int(1) unsigned NOT NULL,
  `eggs` varchar(12) NOT NULL,
  `maxeggs` varchar(13) NOT NULL,
  `deposit` varchar(12) NOT NULL,
  `exp` int(4) unsigned NOT NULL,
  `jifen` int(5) unsigned NOT NULL,
  `grow` int(4) unsigned NOT NULL,
  `vip` int(1) unsigned NOT NULL DEFAULT 0,
  `ltime` int(11) unsigned,
  `lip` varchar(15),
  `s_name` varchar(8),
  `s_number` varchar(18),
  `s_message` int(1) NOT NULL,
  `s_bankkey` varchar(10),
  `sms_login` int(1),
  `s_addr` varchar(150),
  `reTIME` varchar(11),
  `bossID` varchar(10) UNIQUE,
  `tui_score` INT(4) NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- id:用户id
-- status:用户账号状态 1=正常，2=账号被封，3=账号注销等
-- key:登录密码 key和s_key均以“6284**”作为测试
-- s_key:取款密码
-- nick:用户昵称
-- selfdes:个人简介
-- headimg:用户头像编号
-- email:验证邮箱
-- phone:验证手机
-- qq:qq号码
-- iplimit:ip地区限制,1=华南，2=华北...
-- range：用户等级
-- eggs:财富金蛋值
-- maxeggs:账户历史最大财富
-- deposit:存款值
-- exp:经验值
-- jifen:积分值
-- grow:成长经验值
-- vip:vip等级，vip初步分成6个等级（第六个等级为龙）
-- ltime:最后登录时间
-- lip:最后登录ip
-- iscommit：账户是否认证：0=未认证  1=认证
-- s_name:身份证认证名称
-- s_number：身份证认证号码
-- s_message: 兑奖需要短信验证否 0=不需要，1=需要
-- s_bankkey:银行安全密码
-- sms_login：登录是否需要短信验证
-- addr:个人地址
-- reTIME:注册时间
-- bossID:自己上线id，每个用户有且仅有一个上线
-- tui_score:给邀请上线的提成分（推广分）

INSERT INTO `bi_user` VALUES ('1873372', 'fb31f5692a1ab9a09fe6b0193c4512c1', '1', 'fb31f5692a1ab9a09fe6b0193c4512c1', '天下第一', '我游戏，我快乐，我要赚钱养家！','1','dingyong4223@163.com','13267074323','394276418','1','5','255454124','5845845451254','10000000','120','80','100','0','1400473645','192.168.1.101','张三','510824198411153611','0',"pp6854","","","1400473645","1873371","121");
INSERT INTO `bi_user` VALUES ('1254845', 'fb31f5692a1ab9a09fe6b0193c4512c1', '1', 'fb31f5692a1ab9a09fe6b0193c4512c1', '天下第3', '我游戏，我快乐，我要赚钱养家！','1','dingyong4224@163.com','13267074354','394276418','1','5','255454124','5845845451254','10000000','120','80','100','0','1400473645','192.168.1.101','张三','510824198411153611','0',"pp6854","","","1400473658","1873372","254");