<?php
class Pc28Model extends Model {

    public function getResult($page = 1){
        return $this->order('id DESC')->field(true)->limit(20)->select();
    }

}