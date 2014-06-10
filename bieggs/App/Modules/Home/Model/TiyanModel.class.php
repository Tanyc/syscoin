<?php
class TiyanModel extends Model {
    public function getList($count=10){
        return $this->order('id DESC')->field(true)->limit($count)->select();
    }
}