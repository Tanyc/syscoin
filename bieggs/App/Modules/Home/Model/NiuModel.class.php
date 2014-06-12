<?php
class NiuModel extends Model {
    const COUNT = 20;
    
    public function getSpecList($count=COUNT,$condition){
        if ($condition){
            return $this->where($condition)->order('id DESC')->field(true)->limit($count)->select();
        }
        return $this->order('id DESC')->field(true)->limit($count)->select();
    }

    public function getAllList($count=120){
        return $this->order('id DESC')->field(true)->limit($count)->select();
    }

    public function getToDayList($count=COUNT){
        return $this->where("data_id=1")->order('id DESC')->field(true)->limit($count)->select();
    }

    public function getYestoDayList($count=COUNT){
        return $this->order('id DESC')->field(true)->limit($count)->select();
    }

    public function getThisWeekList($count=COUNT){
        return $this->order('id DESC')->field(true)->limit($count)->select();
    }

    public function getLastWeekList($count=COUNT){
        return $this->order('id DESC')->field(true)->limit($count)->select();
    }

    public function getLastMouthList($count=COUNT){
        return $this->order('id DESC')->field(true)->limit($count)->select();
    }

    public function getThisYearList($count=COUNT){
        return $this->order('id DESC')->field(true)->limit($count)->select();
    }
}