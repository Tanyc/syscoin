<?php
class TiyanlastModel extends Model {
    public function getTylastList($count=10){
        return $this->order('id DESC')->field(true)->limit($count)->select();
    }
}