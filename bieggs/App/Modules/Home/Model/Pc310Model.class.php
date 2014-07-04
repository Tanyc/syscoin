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

    public function getRecordByLID($LID){
        return $this->where("id=".$LID)->field(true)->select();
    }

    public function getResultByLID($LID){
        return $this->where("id=".$LID)->field('game_result')->select();
    }

    public function getCount(){
        return $this->count();
    }
}