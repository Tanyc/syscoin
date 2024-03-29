<?php
return array(
    'SESSION_AUTO_START'        =>  true,
    'USER_AUTH_KEY'             =>  'authId',	// 用户认证SESSION标记
    'ADMIN_AUTH_KEY'			=>  'administrator',
    'AUTH_PWD_ENCODER'          =>  'md5',	// 用户认证密码加密方式
    'DB_LIKE_FIELDS'            =>  'title|remark',
    'COOKIE_ID'                 =>  'cookie_id',
    'COOKIE_AUTH'               =>  'cookie_auth', //用于cookie保存时的验证
);