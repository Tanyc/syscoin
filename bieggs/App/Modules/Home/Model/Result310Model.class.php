<?php
class Result310Model extends Model {
	const CNT = 10;

    public function getResult($game_id,$page = 1){
    	if ("" == $page) {
    		$page = 1;
    	}
    	$offset = ($page - 1) * $this::CNT;
        return $this->where('game_id='.$game_id)->order('user_get DESC')->field("user_id,user_down,user_get")->limit($offset,$this::CNT)->select();
    }

    public function getCount($game_id){
        return $this->where('game_id='.$game_id)->count();
    }
}