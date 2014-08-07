<?php

class loginAction extends comAction{
    
    function _initialize() {
    	parent::_initialize();
        Log::record("loginAction _initialize..." . strtolower(MODULE_NAME));
        if(!isset($_SESSION[C('USER_AUTH_KEY')])) {
        	if(isset($_COOKIE[C('COOKIE_ID')])){
        		$id = $_COOKIE[C('COOKIE_ID')];
        		$md5email = $_COOKIE[C('COOKIE_AUTH')];

        		$map = array();
		        $map['id'] = $id;
		        $authInfo = M('User')->where($map)->find();
		        if (md5($authInfo['email']) == $md5email) {
		        	setUserInfo($authInfo);
            		// updateUserInfo();       //此次用户并未登陆，故不用更新
		        }else{
		        	redirect(__ROOT__.'/pubtpl/nologin');
		        }
        	}else{
        		redirect(__ROOT__.'/pubtpl/nologin');
        	}
        }
    }

}