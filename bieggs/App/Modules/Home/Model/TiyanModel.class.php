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

    public function getSliderList($count=3){
        return $this->where('tab=4')->order('id DESC')->field(true)->limit($count)->select();
    }

    public function getListByTab($tab=1,$count=10){
        switch ($tab) {
            case 1:
                return $this->getTiyanList($count);
                break;
            case 2:
                return $this->getShiwanList($count);
                break;
            case 3:
                return $this->getDiaochaList($count);
                break;
            default:
                return $this->getTiyanList($count);
                break;
        }
    }
}