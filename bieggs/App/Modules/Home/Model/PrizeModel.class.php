<?php
class PrizeModel extends Model {
    public function getList($count=6,$field){
    	if ($field) {
    		return $this->order('id DESC')->field($field)->limit($count)->select();
    	}
    	return $this->order('id DESC')->field(true)->limit($count)->select();
    }
}