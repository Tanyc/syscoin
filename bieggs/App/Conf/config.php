<?php
return array(
    'URL_MODEL'                 =>  2, // 如果你的环境不支持PATHINFO 请设置为3
    'DB_TYPE'                   =>  'mysql',
    'DB_HOST'                   =>  'localhost',
    'DB_NAME'                   =>  'bieggs',
    'DB_USER'                   =>  'root',
    'DB_PWD'                    =>  '',
    'DB_PORT'                   =>  '3306',
    'DB_PREFIX'                 =>  'bi_',
    'APP_AUTOLOAD_PATH'         =>  '@.TagLib',
    'APP_GROUP_LIST'            =>  'Home,Admin',
    'DEFAULT_GROUP'             =>  'Home',
    'APP_GROUP_MODE'            =>  1,
    'SHOW_PAGE_TRACE'           =>  1,//显示调试信息

    'TMPL_PARSE_STRING'         =>  array(
        '__IMAGES__'            =>  __ROOT__.'/Public/Images',// 站点公共图像目录
        '__UPIMAGES__'          =>  __ROOT__.'/Uploads/Images',// 站点公共图像目录
        '__JS__'                =>  __ROOT__.'/Public/Js',// 站点公共js目录
        '__CSS__'               =>  __ROOT__.'/Public/Css',// 站点公共css目录
        '__HOME__'              =>  __ROOT__.'/App/Modules/Home',// 站点公共home目录
        '__ADMIN__'             =>  __ROOT__.'/App/Modules/Admin',// 站点公共admin目录
    )
    
);
