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

function isNil($str){
	if(empty($str) || "" == $str) return true;
	return false;
}

?>