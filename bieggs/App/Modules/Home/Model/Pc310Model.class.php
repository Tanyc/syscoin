<?php
class Pc310Model extends Model {
	const CNT = 20;

    public function getResult($page = 1){
    	if ("" == $page) {
    		$page = 1;
    	}
    	$offset = ($page - 1) * $this::CNT;
        return $this->field(true)->limit($offset,$this::CNT)->select();
    }

    public function getCount(){
        return $this->count();
    }
}