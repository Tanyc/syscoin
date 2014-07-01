<?php
class ResultModel extends Model {
	const CNT = 10;

    public function getResult($game_id,$page = 1){
    	if ("" == $page) {
    		$page = 1;
    	}
    	$offset = ($page - 1) * $this::CNT;
        return $this->where('game_id='.$game_id)->order('user_get DESC')->field("user_id,user_down,user_get")->limit($offset,$this::CNT)->select();
    }

    public function getLastRecord($filed){
        return $this->order('id DESC')->field($filed)->limit(5,1)->select();
    }

    public function getCount(){
        return $this->count();
    }
}