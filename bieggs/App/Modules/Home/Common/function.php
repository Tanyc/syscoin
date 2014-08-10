<?php
function mytest(){
	return "this is a test";
}
function verifyName($name){
	if(isNil($name)){
		return false;
	}
	return true;
}

function verifyKey($key){
	if(isNil($key)){
		return false;
	}else if(strlen($key) < 6 || strlen($key) > 18){
		return false;
	}
	return true;
}

function verifyCode($code){
	if(isNil($code)){
		return false;
	}else if(strlen($code) != 4){
		return false;
	}
	return true;
}

function verifyPhone($phone){
	if(strlen($phone) != 11){
		return false;
	}else{
		if(!preg_match("/^(13[0-9]|15[0|3|6|7|8|9]|18[8|9])\d{8}$/",$phone)){
			return false;
		}
	}
	return true;
}

function verifyQQ($qq){ //此函数好像有问题
	if(strlen($qq) < 5){
		return false;
	}else{
		if(!preg_match("/^[1-9]\d$/",$qq)){
			return false;
		}
	}
	return true;
}

function isNil($str){
	if(empty($str) || "" == $str) return true;
	return false;
}

function setUserInfo($authInfo){
    $_SESSION['online']           = 1; //1表示在线，0表示离线，给客户端展示
    $_SESSION[C('USER_AUTH_KEY')] = $authInfo['id'];
    $_SESSION['id']               = $authInfo['id'];
    $_SESSION['headimg']          = $authInfo['headimg'];
    $_SESSION['email']            = $authInfo['email'];
    $_SESSION['nick']             = $authInfo['nick'];
    $_SESSION['vip']              = $authInfo['vip'];
    $_SESSION['ltime']            = $authInfo['ltime'];
    $_SESSION['lip']              = $authInfo['lip'];
}

function updateUserInfo(){
    $User   =   M('User');
    $data                   = array();
    $data['id']             = $_SESSION['id'];
    $data['ltime']          = time();
    $data['lip']            = get_client_ip();
    $User->save($data);
}

function isCodeRight($code){
    if(session('verify') != md5($code)){
        return false;
    }
    return true;
}

?>