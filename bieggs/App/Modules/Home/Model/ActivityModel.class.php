<?php
class ActivityModel extends Model {
    public function getList($count=10){
        return $this->field(true)->limit($count)->select();
    }

    public function getActiveList($count=10){
        return $this->where("is_active=1")->field(true)->limit($count)->select();
    }

    public function getInActiveList($count=10){
        return $this->where("is_active=0")->field(true)->limit($count)->select();
    }
}