/*
Navicat MySQL Data Transfer

Source Server         : mysql
Source Server Version : 50610
Source Host           : localhost:3306
Source Database       : examples

Target Server Type    : MYSQL
Target Server Version : 50610
File Encoding         : 65001

Date: 2014-05-21 12:26:36
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `think_form`
-- ----------------------------
DROP TABLE IF EXISTS `think_form`;
CREATE TABLE `think_form` (
  `id` smallint(4) unsigned NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `content` varchar(255) NOT NULL,
  `create_time` int(11) unsigned NOT NULL,
  `status` tinyint(1) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of think_form
-- ----------------------------
INSERT INTO `think_form` VALUES ('1', 'test', 'test1', '1400473645', '1');
INSERT INTO `think_form` VALUES ('2', 'rear', 'rasera', '1400474056', '1');
INSERT INTO `think_form` VALUES ('3', 'rears', 'rasera', '1400474066', '1');
INSERT INTO `think_form` VALUES ('4', 'rearsd', '<p>this is a test haha a</p>\r\n<p>asdasdfafsd</p>\r\n<p><b><i>this is atsteswe</i></b></p>\r\n<p><span style=\"font-size:24px;\">ssaaaaaaaaaaaaaaaasa</span></p>', '1400474086', '1');
INSERT INTO `think_form` VALUES ('5', 'dingyong', 'this is my second test', '1400587673', '1');
INSERT INTO `think_form` VALUES ('6', 'english', '<p style=\"font-family:宋体, arial;font-size:14px;line-height:23px;\">Occasionally, life can be undeniably, impossibly difficult. We are faced with challenges and events that can seem overwhelming, life-destroying to the point where it may be hard to decide w', '1400587766', '1');
INSERT INTO `think_form` VALUES ('7', 'sssssssssssssssssssssssssssssssssssssss', 'sssssssssssssssssssssssssssssssssssssss', '1400589701', '1');
INSERT INTO `think_form` VALUES ('8', '这是一个测试', '这是测试内容', '1400642296', '1');
