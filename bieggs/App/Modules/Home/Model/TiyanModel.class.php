<?php
class TiyanModel extends Model {
    public function getTiyanList($count=10){
        return $this->where('tab=1')->order('id DESC')->field(true)->limit($count)->select();
    }

    public function getShiwanList($count=10){
        return $this->where('tab=2')->order('id DESC')->field(true)->limit($count)->select();
    }

    public function getDiaochaList($count=10){
        return $this->where('tab=3')->order('id DESC')->field(true)->limit($count)->select();
    }
}