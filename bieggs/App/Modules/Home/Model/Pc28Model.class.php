<?php
class Pc28Model extends Model {
	const CNT = 20;

    public function getResult($page = 1){
    	if ("" == $page) {
    		$page = 1;
    	}
    	$offset = ($page - 1) * $this::CNT;
        return $this->order('id DESC')->field(true)->limit($offset,$this::CNT)->select();
    }

    public function getLastRecord($filed){
        return $this->order('id DESC')->field($filed)->limit(5,1)->select();
    }

    public function getCount(){
        return $this->count();
    }
}