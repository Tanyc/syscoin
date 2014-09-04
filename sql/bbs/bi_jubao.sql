DROP TABLE IF EXISTS `bi_jubao`;
CREATE TABLE `bi_jubao` (
`id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
`s_type` smallint(1) unsigned NOT NULL,
`type` smallint(1) unsigned NOT NULL,
`BUID` varchar(8) NOT NULL,
`UID` varchar(8) NOT NULL,
`content` varchar(20) NOT NULL,
`CTIME` varchar(11) NOT NULL,
PRIMARY KEY (`id`)
)DEFAULT CHARSET =utf8;

-- ----------------------------
-- id:晒奖id
-- s_type:0=举报blog，1=举报评论
-- type:1=发广告，2=含负面信息（黄、赌，毒），3=刷屏，4=其它
-- BUID:被举报用户id
-- UID:举报用户id
-- content:举报内容
-- CTIME:创建时间
-- ----------------------------