<?php
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

function convSeMsg($str,$pL){
	$re = substr ( $str, 0,$pL);
	return $re . "******";
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

function dever($str){ 
	return str_replace(",","",$str);
}

function verifyQQ($qq){ //此函数好像有问题
	if(strlen($qq) < 5){
		return false;
	}else{
		if(!preg_match("/^[1-9]\d*$/",$qq)){
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
    $_SESSION[C('USER_AUTH_KEY')] = $authInfo['id'];
    // $_SESSION['nick']             = $authInfo['nick'];
}

function updateUserInfo(){
    $User                = M('User');
    $data                = array();
    $data['id']          = $_SESSION[C('USER_AUTH_KEY')];
    $data['ltime']       = time();
    $data['lip']         = get_client_ip();
    $User->save($data);
}

function isCodeRight($code){
    if(session('verify') != md5($code)){
        return false;
    }
    return true;
}

function checkName($name){
	if (isNil($name)) {
		return false;
	};
	$reg="/[\w\d]/";
	if(preg_match($reg,$name)){
		return false;
	}
	return true;
}

function checkSCard($num){
	if (isNil($num) || (strlen($num) != 15 && strlen($num) != 18)) {
		return false;
	};
	return true;
}

function checkIfPlusNum($str){
	if(preg_match("/^[1-9]\d*$/",$str)){
		return true;
	}
	return false;
}

function checkKey($key){
	if (isNil($key) || strlen($key) < 6) {
		return false;
	};
	return true;
}

?>