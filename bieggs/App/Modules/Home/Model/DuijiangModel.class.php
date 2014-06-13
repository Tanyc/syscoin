<?php
class DuijiangModel extends Model {
    public function getSliderList($count=4){
        return $this->order('id DESC')->field(true)->limit($count)->select();
    }

    public function getList($count=20){
        return $this->order('id DESC')->field(true)->limit($count)->select();
    }
}